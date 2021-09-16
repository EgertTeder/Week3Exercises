using System;

namespace Week3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN koodi
            //programm võrdleb siestatud PIN-koodi arvuga 1234
            //kui siestatud PIN-kood on 1234
            //programm kuvab konsoolis "Tere tulemast!"
            //kui sisestatud PIN on vale, programm kuvab konsoolis
            //"Vale PIN. Proovi uuesti."

            Console.WriteLine("Sisesta PIN-kood:");
            int userPIN = Convert.ToInt32(Console.ReadLine());

            if (userPIN == 1234)
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("´Vale PIN.Proovi uuesti.");
            }

            if(userPIN != 1234){
                Console.WriteLine("Vale PIN.Proovi uuesti!");
        

        }
    }
}
