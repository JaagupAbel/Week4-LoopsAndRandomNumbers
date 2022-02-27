using System;

namespace GuessingGameTheeTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm genereerib juhuslikku numbri 1 kuni 10;
            //Kasutaja peab seda nubmrit ära arvama;
            //Kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata, 
            //siis võidab mängu arvuti;
            //*programm genereerib juhusliku numbrit ühte korda. 


            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;

            while (i < 9)
            {

                Console.WriteLine("Paku arv:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Oled mängu võtinud, palju õnne!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale arv! Sul on veel {9 - i} võimalust. Proovi  uuesti!");

                }

            }
            Console.WriteLine("Kena päeva!");



        }
    }
}
