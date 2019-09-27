using System;

namespace uppgift2_addtwonum_falhantering_method
{

    class Program
    {   
        static void Main(string[] args)
        {
            
            int firstnumber = HämtaTal("Vilken är din första talet?"); 
            int secondnumber = HämtaTal("Vilken är din andra talet?"); 

            int summa = add(firstnumber, secondnumber);
            Console.WriteLine("Summan blir: " + summa);
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

    }

}



