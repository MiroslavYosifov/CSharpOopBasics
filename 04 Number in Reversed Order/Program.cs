using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Number_in_Reversed_Order
{
    class DecimalNumber
    {
        public double number;

        public DecimalNumber(double number)
        {
            this.number = number;
        }

        public double ReverseNumber(double number)
        {
            var reversed = this.number.ToString().Reverse();
            this.number = double.Parse(string.Join("", reversed));
            return this.number;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumber = double.Parse(Console.ReadLine());
            var decimalNumber = new DecimalNumber(inputNumber);

            Console.WriteLine(decimalNumber.ReverseNumber(decimalNumber.number));
        }
    }
}
