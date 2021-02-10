using System;
using System.Collections.Generic;
using System.Linq;

namespace MyClass.Collection
{
    /// <summary>
    /// 検索と並び替えの結果をインデックスの配列で返す
    /// </summary>
    class SSIndex<Type>
    {
        private Dictionary<Type, List<int>> _IndexRecord;


        public SSIndex(int caption = 100) //100は適当
        {
            _IndexRecord = new Dictionary<Type, List<int>>(caption);
        }


        public int Count
        {
            get
            {
                return _IndexRecord.Count;
            }
        }


        public Type[] Keys
        {
            get
            {
                return _IndexRecord.Keys.ToArray();
            }
        }


        /// <summary>
        /// 指定したキーに紐付いたインデックスを返す。検索できなかった場合はnullを返す
        /// </summary>
        public int[] Search(Type key)
        {
            if (!_IndexRecord.ContainsKey(key))
                return null;

            return _IndexRecord[key].ToArray();
        }

        
        /// <summary>
        /// キーを並び替えて、各キーに紐付いたインデックスを順に返す
        /// </summary>
        public int[] Sort()
        {
            Type[] tmp = Keys;
            Array.Sort<Type>(tmp);

            List<int> resultlist = new List<int>();
            foreach (Type t in tmp)
                foreach (int i in Search(t)) resultlist.Add(i);

            return resultlist.ToArray();
        }
       
        
        /// <summary>
        /// キーを並び替えて、各キーに紐付いたインデックスを順に返す
        /// </summary>
        public int[] Sort(Comparison<Type> cmp)
        {
            Type[] tmp = _IndexRecord.Keys.ToArray();
            Array.Sort(tmp, cmp);

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
}


#region SSIndexの使用例
static class UsageSSIndex
{
    #region テスト用クラス
    class Person : IComparable
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


        public override bool Equals(object obj)
        {
            Person other = obj as Person;
            if (other == null)
                return false;

            return name == other.name && age == other.age;
        }


        public override int GetHashCode() // Dictionaryクラスのキーで使用されるメソッド
        {
            if (name == null)
                return age;

            return age ^ name.GetHashCode();
        }


        public int CompareTo(object obj)
        {
            Person other = obj as Person;
            return age - other.age;
        }
    }
    #endregion

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


    static public void Sort()
    {
        MyClass.Collection.SSIndex<Person> ss = new MyClass.Collection.SSIndex<Person>();
        for (int i = 0; i < persons.Length; i++)
            ss.Add(persons[i], i);

        int[] indexs = ss.Sort();
        for (int i = 0; i < indexs.Length; i++)
            Console.WriteLine(persons[indexs[i]].ToString());

        // 降順にしたいとき
        Console.WriteLine("");
        indexs = ss.Sort((a, b) => b.age - a.age);
        for (int i = 0; i < indexs.Length; i++)
            Console.WriteLine(persons[indexs[i]].ToString());
    }

    static public void Search()
    {
        MyClass.Collection.SSIndex<Person> ss = new MyClass.Collection.SSIndex<Person>();
        for (int i = 0; i < persons.Length; i++)
            ss.Add(persons[i], i);

        int[] indexs = ss.Search(new Person("鈴木", 4));
        for (int i = 0; i < indexs.Length; i++)
            Console.WriteLine(indexs[i].ToString());
    }
}
#endregion