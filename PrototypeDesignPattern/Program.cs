using PrototypeDesignPattern.EvenNumberGen;
using System;

namespace PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEven Numbers Generator from the Original:\n");
            IEvenNumberGen EvenNumberGen = new EvenNumbersGenerator(100);
            EvenNumberGen.PrintEvenNumbers();

            Console.WriteLine("\n\nEven Numbers from the Clone:\n");

            IEvenNumberGen EvenNumberGenClone = EvenNumberGen.Clone() as EvenNumbersGenerator;
            EvenNumberGenClone.PrintEvenNumbers();
            Console.ReadKey();
        }
    }
}
