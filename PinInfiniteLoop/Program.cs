using System;

namespace PinInfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt siestada PIN-koodi;
            //programm võrdleb siestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!";
            //kui siestatud PIN-kood on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti!";
            //katsete arv on piiramatu

            bool loopActive = true; //boolean --> true/false
            int i = 0;

            while (loopActive)
            {
                Console.WriteLine("Sisesta PIN:"); //cw+double TAB ehk saab kiiremini kirjutada
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }
                else
                {
                    i++; // i = i + 1
                    Console.WriteLine("Vale PIN. Proovi uuesti!");
                    Console.WriteLine($"Oled vale PIN-kood {i} korda sisestanud.");
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
