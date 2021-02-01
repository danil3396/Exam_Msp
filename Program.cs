using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Msp
{
    class Program
    {
       static public void RandomNumber()
        {
            Random random = new Random();
            int number=random.Next(1000);
            Console.WriteLine("рандомное число: "+number);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RandomNumber();
            Console.ReadLine();
        }
    }
}
