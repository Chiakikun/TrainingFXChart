/******************************************************************************************
 *  Copyright (c) 2016 Chiaki Yamada https://yamada153@bitbucket.org/yamada153/cylibcs.git
 *  Released under the MIT license
 *  http://opensource.org/licenses/mit-license.php
 ******************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

/// <summary>
/// 検索と並び替えのためのクラス。
/// 結果をインデックスの配列で返す。
/// </summary>
class SSIndex<Type>
{
    private Dictionary<Type, List<int>> _IndexRecord;

    /// <summary>
    /// 空のSSIndexを作成する
    /// </summary>
    public SSIndex(int caption = 100) //100は適当
    {
        _IndexRecord = new Dictionary<Type, List<int>>(caption);
    }

    /// <summary>
    /// doubleやstring等の配列を登録する
    /// </summary>
    public SSIndex(Type[] datas)
    {
        if (datas == null) throw new ArgumentNullException("SSIndexの初期化に失敗しました。引数「datas」にnullが渡されました");

        _IndexRecord = new Dictionary<Type, List<int>>(datas.Length);

        for (int i = 0; i < datas.Count(); i++)
            Add(datas[i], i);
    }

    /// <summary>
    /// 独自クラスの配列を登録する
    /// </summary>
    public SSIndex(Type[] datas, IEqualityComparer<Type> eq)
    {
        if (datas == null) throw new ArgumentNullException("SSIndexの初期化に失敗しました。引数「datas」にnullが渡されました");

        _IndexRecord = new Dictionary<Type, List<int>>(datas.Length, eq);

        for (int i = 0; i < datas.Count(); i++)
            Add(datas[i], i);
    }

    /// <summary>
    /// 登録済みのキー数を返す
    /// </summary>
    public int Count()
    {
        return _IndexRecord.Count;
    }

    /// <summary>
    /// 登録済みのキーの配列を返す
    /// </summary>
    public Type[] Keys()
    {
        return _IndexRecord.Keys.ToArray();
    }

    /// <summary>
    /// 指定したキーに紐付いたインデックスを返す。検索できなかった場合はnullを返す
    /// </summary>
    public int[] Search(Type key)
    {
        if (key == null) throw new ArgumentNullException("SSIndex.Searchに失敗しました。引数「key」にnullが渡されました");

        if (!_IndexRecord.ContainsKey(key)) return null;
        return _IndexRecord[key].ToArray();
    }

    /// <summary>
    /// キーを並び替えて、各キーに紐付いたインデックスを順に返す
    /// </summary>
    public int[] Sort()
    {
        Type[] tmp = _IndexRecord.Keys.ToArray();
        Array.Sort<Type>(tmp);

        List<int> resultlist = new List<int>();
        foreach(Type t in tmp)
            foreach (int i in Search(t)) resultlist.Add(i);

        return resultlist.ToArray();
    }

    /// <summary>
    /// キーを並び替えて、各キーに紐付いたインデックスを順に返す
    /// </summary>
    public int[] Sort(IComparer<Type> cmp)
    {
        Type[] tmp = _IndexRecord.Keys.ToArray();
        Array.Sort<Type>(tmp, cmp);

        List<int> resultlist = new List<int>();
        foreach (Type t in tmp)
            foreach (int i in Search(t)) resultlist.Add(i);
        return resultlist.ToArray();
    }

    /// <summary>
    /// 未登録のキーを登録する。登録済みならインデックスを追加する
    /// </summary>
    public void Add(Type key, int index)
    {
        if (!_IndexRecord.ContainsKey(key))
        {
            List<int> tmp = new List<int>();
            tmp.Add(index);
            _IndexRecord.Add(key, tmp);
        }
        else
        {
            _IndexRecord[key].Add(index);
        }
    }
}

/***********************************************************************************************************************/
/// <summary>
/// テスト用クラス
/// </summary>
/***********************************************************************************************************************/
static class TestSSIndex
{
    static private Person[] persons = new Person[] {
        new Person("佐藤", 7),
        new Person("山田", 18),
        new Person("鈴木", 4),
        new Person("斉藤", 0),
        new Person("石田", 18),
        new Person("田中", 35),
        new Person("渡辺", 0),
        new Person("伊藤", 9),
        new Person("鈴木", 4),
        new Person("石川", 18),
        new Person("安部", 59)
    };

    static public void Sort(RichTextBox memo)
    {
        SSIndex<Person> ss = new SSIndex<Person>(persons, new IPersonEquality());
        int[] indexs = ss.Sort(new IPersonComparer());
        for(int i = 0; i < indexs.Length; i++)
            memo.AppendText(indexs[i].ToString() + ": " + persons[indexs[i]].ToString() + "\n");

        try
        {
            ss = new SSIndex<Person>(null, new IPersonEquality());
            indexs = ss.Sort(new IPersonComparer());
            for (int i = 0; i < indexs.Length; i++)
                memo.AppendText(indexs[i].ToString() + ": " + persons[indexs[i]].ToString() + "\n");
        }
        catch(Exception e)
        {
            memo.AppendText(e.Message + "\n");
        }

        try
        {
            ss = new SSIndex<Person>(persons, null);
            indexs = ss.Sort(new IPersonComparer());
            for (int i = 0; i < indexs.Length; i++)
                memo.AppendText(indexs[i].ToString() + ": " + persons[indexs[i]].ToString() + "\n");
        }
        catch (Exception e)
        {
            memo.AppendText(e.Message + "\n");
        }

        memo.AppendText("------------------変更前------------------------\n");
        ss = new SSIndex<Person>(persons, new IPersonEquality());
        indexs = ss.Sort(new IPersonComparer());
        for (int i = 0; i < indexs.Length; i++)
            memo.AppendText(indexs[i].ToString() + ": " + persons[indexs[i]].ToString() + "\n");
        memo.AppendText("------------------変更後------------------------\n");
        persons[4].age = 100; //5番目の年齢を変更してみる
        indexs = ss.Sort(new IPersonComparer());
        for (int i = 0; i < indexs.Length; i++)
            memo.AppendText(indexs[i].ToString() + ": " + persons[indexs[i]].ToString() + "\n");
    }

    static public void Search(RichTextBox memo)
    {
        SSIndex<Person> ss = null;
        Person target = new Person("鈴木", 4);

        ss = new SSIndex<Person>(persons, new IPersonEquality());
        memo.AppendText("--------------------------------\n");
        int[] indexs = ss.Search(target);
        for (int i = 0; i < indexs.Length; i++)
            memo.AppendText(indexs[i].ToString() + ": " + persons[indexs[i]].ToString() + "\n");

        try
        {
            ss = new SSIndex<Person>(persons, new IPersonEquality());
            memo.AppendText("--------------------------------\n");
            indexs = ss.Search(null);
            for (int i = 0; i < indexs.Length; i++)
                memo.AppendText(indexs[i].ToString() + ": " + persons[indexs[i]].ToString() + "\n");
        }
        catch (Exception e)
        {
            memo.AppendText(e.Message + "\n");
        }

        ss = new SSIndex<Person>(persons);
        memo.AppendText("--------------------------------\n");
        indexs = ss.Search(target);
        for (int i = 0; i < indexs.Length; i++)
            memo.AppendText(indexs[i].ToString() + ": " + persons[indexs[i]].ToString() + "\n");

        ss = new SSIndex<Person>(persons, null);
        memo.AppendText("--------------------------------\n");
        indexs = ss.Search(target);
        for (int i = 0; i < indexs.Length; i++)
            memo.AppendText(indexs[i].ToString() + ": " + persons[indexs[i]].ToString() + "\n");
    }

    class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        override public string ToString()
        {
            return name + ", " + age.ToString();
        }
    }

    class IPersonEquality : IEqualityComparer<Person>
    {
        public int GetHashCode(Person p)
        {
            return p.name.GetHashCode() ^ p.age.GetHashCode();
        }

        public bool Equals(Person x, Person y)
        {
            return (x.age == y.age) && (x.name == y.name);
        }
    }

    class IPersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.age > y.age) return 1;
            else if (x.age < y.age) return -1;
            else return 0;
        }
    }
}