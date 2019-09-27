using System;

namespace bonusuppgift_1234_method
{
    class Program
    {
        static void Main(string[] args)

        {
            int number = 0;
            
            while (number != 4)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Vad du vill gjöra?\n1.Summra två tal\n2.Skriv ut en talföljd\n3.Kasta träning\n4.Avsluta");
                val("?");
            }
            
        }

        public static void val(string fråga)
        {
            int number =0;
            string ett = "summera";
            string två = "talföljd";
            string tre = "kasta tärning";

            Console.WriteLine(fråga);
            String str01 = Console.ReadLine();
            number = Convert.ToInt32(str01);
            
            if (number == 1) 
            {
                addtvånummer(ett);
            }
            if (number == 2)
            {
                SkrivaUtTalföljd(två);
            }
            if (number == 3)
            {
                GissamellanEttOchSex(tre);
            }
            else if(number == 4)
            {
                Environment.Exit(0);
            }
        }

        public static void addtvånummer(string ett)
        {
            Console.WriteLine("Hej nu ska vi " + ett + " två tal som du matar in");
            int firstnumber = HämtaTal("Vilken är din första talet?");
            int secondnumber = HämtaTal("Vilken är din andra talet?");

            int summa = add(firstnumber, secondnumber);
            Console.WriteLine("Summan blir: " + summa);
        }

        public static void SkrivaUtTalföljd(string två)
        {
            int usernumber;
            int count = 0;
            Console.WriteLine("Hej nu ska vi skriv ut en " + två);
            Console.WriteLine("vad är ditt nummer?");
            String str01 = Console.ReadLine();
            usernumber = Convert.ToInt32(str01);

            while (count <= usernumber)
            {
                Console.WriteLine(count);
                count = count + 1;
            }
        }

        public static void GissamellanEttOchSex(string tre)
        {

            Console.WriteLine("Hej nu ska vi " + tre );
            string choice = " ";
            guessing(choice);
            Console.WriteLine(" ");
        }

        public static int HämtaTal(string ask)
        {
            bool isNumeric = false;
            int n;
            int number = 0;

            while (isNumeric == false)
            {
                try
                {
                    Console.WriteLine(ask);
                    String str01 = Console.ReadLine();
                    isNumeric = int.TryParse(str01, out n);
                    number = Convert.ToInt32(str01);
                }

                catch (Exception e)
                {
                    Console.WriteLine("Nu skrev du inte ett tal. Gör rätt nästa gång. annars funkar inte programmet.");
                }
            }
            return number;
        }

        public static int add(int firstnumber, int secondnumber)
        {
            int addresult = 0;
            addresult = firstnumber + secondnumber;
            return addresult;

        }

        public static void guessing(string functiontwo)
        {
            int usernumber;
            int guess, i;
            int count = 0;
            Console.WriteLine("Hur många tärningar vill du kasta?");
            String str01 = Console.ReadLine();
            usernumber = Convert.ToInt32(str01);

            Console.Write("Resultat blev: ");

            for (i = 0; i < usernumber; i++)
            {
             guess = new Random().Next(1, 6);
             Console.Write(guess + " ");
            }      
        }
    }
}
