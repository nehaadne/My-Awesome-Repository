using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    //    class p
    //    {


    //        int id = 101;
    //        string nm = "neha";
    //        public int Id { get => id; set => id = value; }
    //        public string Nm { get => nm; set => nm = value; }
    //        public void m1()
    //        {
    //            Console.WriteLine("in parent m1");
    //        }

    //        }
    //    class child : p
    //    {
    //        public void m2()
    //        {
    //            Console.WriteLine("in child m2");
    //        }
    //    }
    //    class Inherit
    //    {
    //        static void Main(string[] args)
    //        {
    //            child c = new child();
    //            c.m1();
    //            c.m2();
    //            Console.WriteLine(c.Id);
    //            Console.WriteLine(c.Nm);
    //        }
    //    }
    //    }



    //public class Animal
    //{
    //    public void eat() 
    //    {
    //        Console.WriteLine("Eating..."); 
    //    }
    //}
    //public class Dog : Animal
    //{
    //    public void bark()
    //    {
    //        Console.WriteLine("Barking...");
    //    }
    //}
    //public class BabyDog : Dog
    //{
    //    public void weep()
    //    {
    //        Console.WriteLine("Weeping..."); 
    //    }
    //}
    //class TestInheritance2
    //{
    //    public static void Main(string[] args)
    //    {
    //        BabyDog d1 = new BabyDog();
    //        d1.eat();
    //        d1.bark();
    //        d1.weep();
    //    }
    //}
    //class Order
    //{
    //    int id;
    //    int date;
    //    Customer customer;
    //    Item item;
    //    public Order(int id, int date)
    //    {
    //        this.id = id;
    //        this.date = date;

    //    }
    //    public Order()
    //    {

    //    }
    //    public int Id
    //    {
    //        set { id = value; }
    //        get { return id; }
    //    }
    //    public int Date
    //    {
    //        set { date = value; }
    //        get { return date; }
    //    }
    //    public Customer Customer1
    //    {
    //        set { customer = value; }
    //        get { return customer; }
    //    }
    //    public Item Item1
    //    {
    //        set { item = value; }
    //        get { return item; }
    //    }
    //}
    //class Customer
    //{
    //    string custname;
    //    string cust_add;
    //    long mob_no;

    //    public Customer(string custname, string cust_add, long mob_no)
    //    {
    //        this.Custname = custname;
    //        this.Cust_add = cust_add;
    //        this.Mob_no = mob_no;
    //    }

    //    public string Custname { get => custname; set => custname = value; }
    //    public string Cust_add { get => cust_add; set => cust_add = value; }
    //    public long Mob_no { get => mob_no; set => mob_no = value; }
    //}
    //class Item
    //{
    //    string item_name;
    //    int price;

    //    public Item(string item_name, int price)
    //    {
    //        this.Item_name = item_name;
    //        this.Price = price;
    //    }

    //    public string Item_name { get => item_name; set => item_name = value; }
    //    public int Price { get => price; set => price = value; }
    //}
    //class TestOrder
    //{
    //    static void Main(string[] args)
    //    {
    //        Order o = new Order();
    //        o.Id = 1;
    //        o.Date = 15;
    //        o.Customer1 = new Customer("Neha", "abad", 9158749682);
    //        o.Item1 = new Item("mob", 589);
    //    }
    //}

    class Parent
    {
        string name;
        public void play()
        {
            Console.WriteLine("play on ground");
        }
        public virtual void study()
        {
            Console.WriteLine("Read books");
        }
        public static void m1()
        {
            Console.WriteLine("in parent");
        }
    }
    class Child:Parent
    {
        public static void m1()
        {
            Console.WriteLine("in child m1");
        }
        public new void play()
        {
            Console.WriteLine("play videos games");
        }
        public override void study()
        {
            Console.WriteLine("Learn watching online videos");
        }
    }
    class TTest
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.study();
            Child c1 = new Child();
            c1.study();
            Parent p2 = new Child();
            p2.study();
        }
    }
}