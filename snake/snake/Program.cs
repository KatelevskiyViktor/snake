using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args){

            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p4 = new Point(7, 8, '#');

            List<string> numList = new List<string>();
            numList.Add("SH");
            numList.Add("_");
            numList.Add("^");

            foreach (string i in numList)
            {
                Console.WriteLine(i);
            }


            Console.ReadLine();
        }

        
    }
}
