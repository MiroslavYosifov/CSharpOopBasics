using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Fibonacci_Numbers
{
    class Fibonacci
    {
        public List<int> allnumber;
        public int startPosition;
        public int endPosition;

        public Fibonacci(int startPosition,int endPosition)
        {
            this.startPosition = startPosition;
            this.endPosition = endPosition;
        }
       
        public List<int> GetNumbersInRange(int startPosition, int endPosition)
        {
            this.allnumber = new List<int>();
            this.allnumber.Add(0);
            this.allnumber.Add(1);

            for (int i = 0; i < this.endPosition; i++)
            {
                var num = this.allnumber[i] + this.allnumber[i + 1];
                this.allnumber.Add(num);
            }

            this.allnumber = this.allnumber.Skip(startPosition).Take(this.endPosition-this.startPosition).ToList();
            return this.allnumber;            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var lastNum = int.Parse(Console.ReadLine());

            var fibonacci = new Fibonacci(firstNum,lastNum);

            Console.WriteLine(string.Join(", ", fibonacci.GetNumbersInRange(firstNum, lastNum)));
                      
        }
    }
}
