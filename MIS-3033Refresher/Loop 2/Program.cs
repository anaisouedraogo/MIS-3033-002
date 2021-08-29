using System;

namespace Loop_2
{
    class Program
    {
        static void Main(string[] args)
        {

            double sum = 0;
                int examCount = 0;
            do
            {
                examCount++;
                Console.WriteLine($"Enter your score as a percent for exam{examCount.ToString("NO")}");
                sum += Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Do you have another exam?yes or no >>");
            } while (Console.ReadLine().ToLower()[0]=='y');
        }
    }
}
