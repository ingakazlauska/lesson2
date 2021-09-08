using System;

namespace lesson2practical
{
    class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine("Kā Tevi sauc?");

            //string userName = Console.ReadLine();

            //Console.WriteLine("Sveiks, " + userName + "!");


            // --------------------------------------



            Console.WriteLine("Kāds ir Tavs vecums?");

            string ageText = Console.ReadLine();


            int age = int.Parse(ageText);
            int previosusYearAge = age + 1;

            Console.WriteLine("Sveiks, Tev nākošgad būs" + previosusYearAge); 


        
            bool isAdult = false;
            Console.WriteLine("Tavs vecums ir " + "Tu esi pilngadīgs " + isAdult);











            Console.WriteLine("Hello World!");
        }
    }
}
