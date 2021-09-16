using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal siestada kasutajatunnus ja parool
            //programm kontrollib siestatuid andmeid
            //kui sisestatud kasutajatunnus on "admin" ja
            //sisestatud parool on "admin1234
            //siis programm kuvab "Tere tulemast!"
            //muul juhul programm kuvab "Vale kasutajatunnus või parool. Proovi uuesti!";

            Console.WriteLine("Sisesta kasutajatunnus:");
            string userNme = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string password = Console.ReadLine();

            if (userName == "admin" && pasword == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale kasutajatunnus või parool. Proovi uuesti");
            } */

            if (userName != "admin" || password != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või parool. Proovi uuesti!");
            }
            else
            }
                Console.WriteLine("Tere tulemast!");
            }

            
            

        }
    }
}
