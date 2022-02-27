using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm genereerib juhuslikku numbri 1 kuni 10;
            //Kasutaja peab seda nubmrit ära arvama;
            //Kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //*programm genereerib juhusliku numbrit ühte korda. 

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool loopactive = true;
            int i = 0;

            while (loopactive)
            {

                Console.WriteLine("Paku arv:"); 
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                 Console.WriteLine("Oled mängu võtinud, palju õnne!");
                    loopactive = false;
                }
                else
                {
                 i++;
                 Console.WriteLine($"Vale arv! Oled valesti pakkunud {i} korda. Proovi  uuesti!");

                }
                
            }
            Console.WriteLine("Kena päeva!");


        }
    }
}
