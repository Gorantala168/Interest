using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interest
{
    internal class SimpleInterest
    {
        int p;
        int t;
        int r;
        int i;
        public void AcceptValue()
        {
            Console.WriteLine("Enter the Principle amount: ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the time period: ");
            t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rate of intrest: ");
            r = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            AcceptValue();
            i = (p * t * r) / 100;
            Console.WriteLine("Simple-Intrest is : " + i);
        }
    }
}

