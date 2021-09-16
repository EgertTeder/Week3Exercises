using System;

namespace AndExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // tingimused sisseastumisks;
            //miinimum matemaatikas 85 punkti;
            //miinimum keemias 90 punkti;
            //miinimum bioloogias 95 punkti;
            //programm küsib kasutajal sisestada tema
            //eksami punktid ja otsustab, kas kasutaja
            //saab arstiks õppida

            Console.WriteLine("Sisesta matemaatika eksami tulemused:");
            int math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sisesta keemia eksami tulemused:");
            int chemistry = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sisesta bioloogia eksmi tulemused:");
            int biology = Convert.ToInt32(Console.ReadLine());

            if (math = && chemistry = 90 && biology = 95)
            {
                Console.WriteLine("tubli töö! Õpi arstiks!");
            }
            else
            {
                Console.WriteLine("Ei ole piisavalt punkte.");
            }


           

        }
    }
}
