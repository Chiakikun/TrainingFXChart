using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

using System.Windows.Forms;

namespace TrainingFXChart
{
    /// <summary>
    /// 通貨
    /// </summary>
    public class Currency
    {
        double[,] _data;    // 時系列データ
        uint _div;          // 足の種類 100=1分足、500=5分足
        private CancellationTokenSource _CancellationTokenSource; // 読み込みキャンセル用


        public double[,] Data
        {
            get { return _data; }
        }


        public uint Div
        {
            get { return _div; }
        }


        public Currency(string filename, uint div = Const.ONEMINUTE)
        {
            ProgressDialog pd = new ProgressDialog();
            pd.Title = "ファイル読み込み中";

            LoadCSV(filename, pd);
            pd.ShowDialog();

            if (pd.Ret == DialogResult.Cancel)
                throw new Exception("ファイル読み込みがキャンセルされました。");

            _div = div;
        }


        public Currency(Currency src, uint div, int startindex = 0, int endindex = 0)
        {
            _data = _Convert(src.Data, div, startindex, endindex);
            _div = div;
        }


        public async void LoadCSV(string filename, ProgressDialog pd)
        {
            using (_CancellationTokenSource = new CancellationTokenSource())
            {
                try
                {
                    // 子スレッドで実行
                    await Task.Run(() =>
                    {
                        // テキストを全部読み込む
                        string[] contents = File.ReadAllLines(filename);

                        pd.SetProgressMaxValue(contents.Length);
                        IProgress<int> p = new Progress<int>((x) => { pd.SetValue(x); });

                        // データを格納するテーブルを用意する。
                        _data = new double[contents.Length - 1, 5]; // 5 = {日時,始値,高値,安値,終値} -1しているのは、ヘッダー分要らないから

                        for (int i = 1; i < contents.Length; i++)
                        {
                            // プログレスダイアログのキャンセルボタンが押下されたら...
                            if (pd.Ret == System.Windows.Forms.DialogResult.Cancel)
                                _CancellationTokenSource.Cancel();
                            _CancellationTokenSource.Token.ThrowIfCancellationRequested(); // 例外を投げる

                            //プログレスバー進捗状況更新
                            if (i % 10000 == 0)
                                p.Report(i);

                            // データ格納
                            string[] splited = contents[i].Split(',');
                            _data[i - 1, Const.IDXDATE] = double.Parse(splited[Const.IDXDATE].Replace(":", "").Replace(" ", "").Replace("/", "")); // 日時 2017/01/01 07:00:00 を20170101070000にしたい
                            _data[i - 1, Const.IDXOP] = double.Parse(splited[Const.IDXOP]);
                            _data[i - 1, Const.IDXHI] = double.Parse(splited[Const.IDXHI]);
                            _data[i - 1, Const.IDXLW] = double.Parse(splited[Const.IDXLW]);
                            _data[i - 1, Const.IDXCL] = double.Parse(splited[Const.IDXCL]);
                        }

                        pd.Ret = System.Windows.Forms.DialogResult.OK;
                        // ダイアログが表示される前にここにきてしまうと、「CreateHandle() の実行中は値Close()を呼び出せません」というエラーが出力されてしまうので。
                        while (true)
                        {
                            if (pd.FormVisible)
                            {
                                pd.FormClose();
                                break;
                            }
                        }
                    }, _CancellationTokenSource.Token);
                }
                catch (OperationCanceledException)
                {
                    pd.FormClose();
                }
            }
        }


        private double[,] _Convert(double[,] table, uint divide, int startindex = 0, int endindex = 0)
        {
            int tablelength = table.GetLength(0);
            if (endindex != 0)
                tablelength = endindex;

            SSIndex<long> hist = new SSIndex<long>(tablelength);

            // n分毎にまとめる (集計はまだ)
            long prefix = 0;
            for (int i = startindex; i < tablelength; i++)
            {
                if (divide < 10000)
                    prefix = (long)Math.Floor(table[i, Const.IDXDATE] / 10000) * 10000;
                hist.Add(prefix + (long)Math.Floor((table[i, Const.IDXDATE] - prefix) / divide), i);
            }
            long[] keys = hist.Keys();

            // まとめた要素を集計する
            double[,] newtable = new double[keys.Length, 5];
            for (int i = 0; i < keys.Length; i++)
            {
                int[] idxs = hist.Search(keys[i]);

                newtable[i, Const.IDXDATE] = table[idxs[0], Const.IDXDATE];
                newtable[i, Const.IDXOP] = table[idxs[0], Const.IDXOP];
                newtable[i, Const.IDXCL] = table[idxs.Last(), Const.IDXCL];
                newtable[i, Const.IDXHI] = double.MinValue;
                newtable[i, Const.IDXLW] = double.MaxValue;
                for (int j = 0; j < idxs.Length; j++)
                {
                    newtable[i, Const.IDXHI] = Math.Max(newtable[i, Const.IDXHI], table[idxs[j], Const.IDXHI]);
                    newtable[i, Const.IDXLW] = Math.Min(newtable[i, Const.IDXLW], table[idxs[j], Const.IDXLW]);
                }
            }

            return newtable;
        }

        public int GetYear(int idx) { return (int)(_data[idx, Const.IDXDATE] / 10000000000); }
        public int GetMonth(int idx) { return (int)(_data[idx, Const.IDXDATE] / 100000000 % 100); }
        public int GetDay(int idx) { return (int)(_data[idx, Const.IDXDATE] / 1000000 % 100); }
        public int GetHour(int idx) { return (int)(_data[idx, Const.IDXDATE] / 10000 % 100); }
        public int GetMinute(int idx) { return (int)(_data[idx, Const.IDXDATE] / 100 % 100); }
        public string GetYoubi(int idx)
        {
            int year = GetYear(idx);
            int month = GetMonth(idx);
            int day = GetDay(idx);

            if (month < 3)
            {
                year--;
                month += 12;
            }
            int i = (year + year / 4 - year / 100 + year / 400 + (13 * month + 8) / 5 + day) % 7;
            switch (i)
            {
                case 0: return "日";
                case 1: return "月";
                case 2: return "火";
                case 3: return "水";
                case 4: return "木";
                case 5: return "金";
                default: return "土";
            }
        }
    }
}
