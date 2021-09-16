using System;

namespace WeatherReportSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mitu kraadi on õues:");
            int tempt = Convert.ToInt32(Console.ReadLine());

            switch (temp)
            {
                case var _ when temp < 0:
                    Console.WriteLine("Freezing cold"):
                    break;
                case var _ when temp >= 0 && temp < 10:
                    Console.WriteLine("Cold.");
                    break;
                case var _ when tempt >= 10 && tempt < 20:
                    Console.WriteLine("Chilly.");
                    break;
                case var _ when tempt >= 20 && temp < 30:
                    Console.WriteLine("Nice."):
                    break;
                case var _ when tempt >= 30 && tempt < 35:
                    Console.WriteLine("Hot."):
                        break;
                default;
                    Console.WriteLine("Boiling hot."):
                        break;
                
                
                

            }
        }
    }
}
