using System;
using System.Collections.Generic;
using System.Threading;

namespace PrototypeDesignPattern.EvenNumberGen
{
    class EvenNumbersGenerator : IEvenNumberGen, ICloneable
    {
        private int Numbers;
        private List<int> EvenNumbers;
        public EvenNumbersGenerator(int _numbers)
        {
            Numbers = _numbers;
            DetermineEvenNumbers();
        }

        public void PrintEvenNumbers()
        {
            Console.WriteLine("\nEven Numbers");
            foreach (int number in EvenNumbers)
            {
                Console.Write(String.Format("{0} ", number));
            }
        }

        private void DetermineEvenNumbers()
        {
            EvenNumbers = new List<int>();
            Console.Write("Processing:");
            for (var Counter = 1; Counter < Numbers; Counter++)
            {
                Console.Write(".");
                Thread.Sleep(50);
                if ((Counter % 2) == 0)
                {
                    EvenNumbers.Add(Counter);
                }
            }
        }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
