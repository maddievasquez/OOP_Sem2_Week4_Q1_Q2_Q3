using System;
using System.Collections.Generic;
using System.Text;

namespace exercises_class4.Exercises
{
    class Q_1
    {
        public void Multiplication()
        {
            Console.Write("Enter an integer : ");
            string input = Console.ReadLine();
            int num;
            int.TryParse(input, out num); // returns num = 0 if input invalid
            Console.WriteLine();
            multiplicationTable(num);
            Console.ReadKey();
        }

        static void multiplicationTable(int num)
        {
            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1, -2} = {2}", num, i, num * i);
            }
        }
    }
}