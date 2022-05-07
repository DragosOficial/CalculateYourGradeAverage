using System;

namespace CalculateYourGradeAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            float sum = 0;
            int i = 0;
            int user = 0;
            bool valid = false;

            Console.WriteLine("Aby zakończyć działania wpisz do wartości 0.");

            do
            {
                Console.WriteLine("\nPodaj liczbę:");
                a = float.Parse(Console.ReadLine());
                if(a == 0)
                {
                    break;
                }
                if(a <= 0)
                {
                    Console.WriteLine("Podaj prawidłową liczbę!");
                }
                sum += a;
                i++;
            } while(a != 0);

            Console.WriteLine("Średnia to: {0}", Math.Round(sum / i, 2));
        }
    }
}