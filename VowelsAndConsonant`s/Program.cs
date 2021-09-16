using System;

namespace VowelsAndConsonant_s
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tähte
            //programm kontrollib, kas sisestatud täht on
            //täishäälik või kaashäälik

            //kui sisestada täht on täishäälik
            //"täishäälik"
            //kui siestatud täishäälik on kaashäälik
            //programm kuvab "kaashäälik"
            //kasutame switch'i

            //"mingi sõna" - string
            // 'a'  - character ehk char

            Console.WriteLine("Sisesta täht:");
            char userCharacters = Convert.ToChar(Console.ReadLine().ToLower());

            switch (userCharacter)
            {
                Console.WriteLine("Täishäälik");
            }
             
            
                
        
        }
    }
}
