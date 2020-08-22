using System;

namespace AoCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int value = int.Parse(Console.ReadLine());
            int[] numbers = new int[11]
            {
                1,2,3,4,5,6,7,8,9,10,11
            };
            Console.WriteLine("OUR ARRAY");
            Print(numbers);
            Space(Search(numbers, value) + 1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Search(numbers, value) + 1);
            Console.ForegroundColor = ConsoleColor.White;
            Celebrate(Search(numbers, value));
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();

        }
        private static void Celebrate(int value)
        {
            string[] article1 = new string[]
            {
                "\\            /  _____   |",
                " \\          /  |        |",
                "  \\   /\\   /   |____    |",
                "   \\ /  \\ /    |        |",
                "    \\    \\     |_____   |______"
            };
            string[] article2 = new string[]
            {
                "|>        ^       |\\    |  _____",
                "| >     <   >     | \\   | |",
                "|  >  <       >   |  \\  | |____",
                "| >     <   >     |   \\ | |",
                "|>        *       |    \\| |_____",
                "you found it."
            };
            if (value != -1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < article1.Length; i++)
                {
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine(article1[i]);
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int i = 0; i < article2.Length; i++)
                {
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine(article2[i]);
                }
            }
            else
                Console.WriteLine("You didn't find");
        }
        private static void Space(int vs)
        {
            Console.WriteLine();
            for (int i = 0; i < vs + vs - 2; i++)
            {
                Console.Write(" ");
            }

        }
        private static void Print(int[] vs)
        {
            foreach (var item in vs)
            {
                Console.Write(item + " ");
                System.Threading.Thread.Sleep(250);
            }
        }
        private static void Print(string[] vs)
        {
            foreach (var item in vs)
            {
                Console.Write(item + " ");
                System.Threading.Thread.Sleep(250);
            }
        }
        private static int Search(int[] array, int value)
        {
            int low = 0, high = array.Length - 1;

            while (low <= high)
            {

                int new_value = low + (high - low) / 2;



                if (value == array[new_value])
                {

                    return new_value;

                }
                else
                {
                    if (array[new_value] < value)
                    {

                        low = new_value + 1;
                    }
                    else
                    {

                        high = new_value - 1;
                    }
                }
            }
            return -1;
        }
    }

}
