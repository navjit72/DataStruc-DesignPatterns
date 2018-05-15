using System;

namespace DesignWeek1
{
    class Program
    {
        static void Main(string[] args)
        {
            Week1 w1 = new Week1();
            Console.WriteLine(w1.Radius);

            SingeltonEg s = SingeltonEg.GetInstance();
            SingeltonEg s1 = SingeltonEg.GetObject;

        }
    }
}
