using System;

namespace degelate
{

    public delegate void addDelegate(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Program prg = new Program();   /// class obj
            addDelegate add2No = new addDelegate(prg.Mul);// default method will print 1st   
                                                          // delegate obj with default printing method prg.Mul as 1st

            add2No += prg.sub;// add this next to Previous to Next & print
            add2No += prg.Div;// add this next to Previous to Next & print
            add2No += prg.Mul;//skip/ignore(subtraction operation) from print
            add2No.Invoke(70, 10);
            add2No.Invoke(20, 80);
            Console.ReadKey();
        }
        public void Div(int a, int b)
        {
            int c = a / b;
            Console.WriteLine($"Div is : {c}");
        }
        public void Mul(int a, int b)
        {
            int c = a * b;
            Console.WriteLine($"Mul is : {c}");
        }
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Additon is : " + c);
        }

        public void sub(int c, int d)
        {
            int x = c - d;
            Console.WriteLine("Substration is : " + x);
        }

    }
}



