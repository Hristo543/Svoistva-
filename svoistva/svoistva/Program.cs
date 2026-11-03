using System;

namespace svoistva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pravougulnic p = new Pravougulnic();
            p.pravougulnic();
           
            Console.Write($"Svoistvo area p= {p.Area}");
            
            Pravougulnic p2 = new Pravougulnic(2,3);
            p2.pravougulnic();
            Console.WriteLine($"vtoro svoistvo p ={p2.Area}");
           
            Pravougulnic p3 = new Pravougulnic(10, 5);
           // p3.pravougulnic();
            Console.WriteLine($"treto svoistvo p={p3.Area}");
        }
    }
    class Pravougulnic
    {
        private int a;
        private int b;
        public Pravougulnic()
        {
            this.a = 0;
            this.b = 0;
        }
        public Pravougulnic(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Area
        {
            get {  return (2*a) +(2*b);}
            
            
        }
        
        
        public void pravougulnic()
        {
            a =int.Parse(Console.ReadLine());
            b =int.Parse(Console.ReadLine());
        }


    }
}