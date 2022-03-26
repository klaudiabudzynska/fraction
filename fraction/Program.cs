using System;
using System.Collections.Generic;

namespace fraction
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Fraction fraction1 = new Fraction(1, 2);
                Console.WriteLine(fraction1);
                
                Fraction fraction2 = new Fraction(2, 5);
                Console.WriteLine(fraction2);

                Console.WriteLine(fraction1.add(fraction2));

                Console.WriteLine(fraction1 + fraction2);
                Console.WriteLine(fraction1 - fraction2);
                Console.WriteLine(fraction1 / fraction2);

                List<Fraction> list = new List<Fraction>();
                list.Add(fraction1);
                list.Add(fraction2);
                list.Add(new Fraction(7, 3));
                list.Add(new Fraction(4, 5));
                Console.WriteLine("-------");
                list.ForEach(Console.WriteLine);
                list.Sort();
                Console.WriteLine("-------");
                list.ForEach(Console.WriteLine);

                Console.WriteLine(fraction1.Equals(fraction2));

            } catch (ArgumentException error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
