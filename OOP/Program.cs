using MyLib;
using System;

namespace OOP
{
    class Program
    {
        /// <summary>
        /// Entry Point
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Console.WriteLine(p1.ToString());

            Point p2 = new Point(10, 20);
            Console.WriteLine(p2.ToString());

            Point p3 = new Point(p2);
            Console.WriteLine(p3.ToString());
            
            Point p4 = p2;
            
            
            
            p3.x = 30;
            p4.x = 20;
            p2.y = 50;
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p4.ToString());
            var compare13 = p3.Equals(p1);
            var compare23 = p3.Equals(p2);
            var compare24 = p2.Equals(p4);

            var d23 = p2.Distance(p3);

            string rs = "Khoang cach p2 --> p3 la" + d23.ToString();
            string rs2 = string.Format("Khoang cach p2 --> p3 la {0}", d23);

            Console.WriteLine($"Khoang cach p2 --> p3 la {d23:N2}");

            Console.WriteLine(
                $"Compare p1vsp3 = {compare13}\n" +
                $"and compare p2p3 = {compare23}\n" +
                $"and compare p2p4 = {compare24}");


            Console.ReadKey();
        }
    }
}
