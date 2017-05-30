using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Last_Digit_Name
{
    class Number
    {
        public int num;

        public Number(int num)
        {
            this.num = num;
        }

        public void PrintEnglishNameOfTheLastDigit()
        {
           if(this.num % 10 == 1)
            {
                Console.WriteLine("one");
            }
           else if(this.num % 10 == 2)
            {
                Console.WriteLine("two");
            }
            else if (this.num % 10 == 3)
            {
                Console.WriteLine("three");
            }
            else if (this.num % 10 == 4)
            {
                Console.WriteLine("four");
            }
            else if (this.num % 10 == 5)
            {
                Console.WriteLine("five");
            }
            else if (this.num % 10 == 6)
            {
                Console.WriteLine("six");
            }
            else if (this.num % 10 == 7)
            {
                Console.WriteLine("seven");
            }
            else if (this.num % 10 == 8)
            {
                Console.WriteLine("eight");
            }
            else if (this.num % 10 == 9)
            {
                Console.WriteLine("nine");
            }
           else
            {
                Console.WriteLine("zero");
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var number = new Number(num);

            number.PrintEnglishNameOfTheLastDigit();
        }
    }
}
