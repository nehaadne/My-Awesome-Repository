using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShauryaCSharpTraining
{
    class Studd
    {
        int sid;
        string name;
        int percent;

        public Studd (int Sid, string name, int percent)
        {
            this.Sid = sid;
            this.Name = name;
            this.Percent = percent;
        }
        public override string ToString()
        {
            return $"Sid :{sid} Name:{name} Percent:{percent}";
        }
        public int Sid { get => sid; set => sid = value; }
        public string Name { get => name; set => name = value; }
        public int Percent { get => percent; set => percent = value; }


    }
    //class myStudsort : IComparer<Studd>
    //    {
    //    public int Compare(Studd x, Studd y)
    //    {
    //        return x.Name.CompareTo(y.Name);
    //    }
    //    }
    class DemoListCustom
    {
        static void Main2(string[] args)
        {
            List<Studd> ht = new List<Studd>(/*new myStudsort()*/);
            ht.Add(new Studd(101,"neha",89));
            ht.Add(new Studd(102,"swati", 79));
            ht.Add(new Studd(103,"mansi", 99));

            foreach(Studd d in ht)
            {
                if(d.Percent>80)
                Console.WriteLine(d);

            }

        }
    }
}
