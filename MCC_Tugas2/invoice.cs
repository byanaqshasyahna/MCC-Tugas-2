using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCC_Tugas2
{
        class Invoice
    {
        static void Main(string[] args)
        {
            int data ;
            Console.Write("Input data : ");
            data = Convert.ToInt32(Console.ReadLine());

            //Get date and time in next three days
            DateTime today = DateTime.Today.AddDays(3);
            

            //Get name of day
            String nameDay = today.ToString("dddd");

            //Get date and year in numeric
            String dateYear = today.ToString("yyyy");
            String dateMonth = today.ToString("MM");

            //To change a numeric to roman 
            String romawiDay = ToRoman(today.Day);
            String romawiMonth = ToRoman(today.Month);
            String romawiYear = ToRoman(today.Year);

            Console.Write( "Output data: ");

            //Using String Interpolasi
            Console.WriteLine($"INV/{dateYear}{dateMonth}/{Day(nameDay)}/{romawiDay}/{romawiYear}/{(data += 1)}" );
        }


        //Methode change a numeric to roman
        public static string ToRoman(int number)
        {
            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M" + ToRoman(number - 1000);
            if (number >= 900) return "CM" + ToRoman(number - 900);
            if (number >= 500) return "D" + ToRoman(number - 500);
            if (number >= 400) return "CD" + ToRoman(number - 400);
            if (number >= 100) return "C" + ToRoman(number - 100);
            if (number >= 90) return "XC" + ToRoman(number - 90);
            if (number >= 50) return "L" + ToRoman(number - 50);
            if (number >= 40) return "XL" + ToRoman(number - 40);
            if (number >= 10) return "X" + ToRoman(number - 10);
            if (number >= 9) return "IX" + ToRoman(number - 9);
            if (number >= 5) return "V" + ToRoman(number - 5);
            if (number >= 4) return "IV" + ToRoman(number - 4);
            if (number >= 1) return "I" + ToRoman(number - 1);
            throw new ArgumentOutOfRangeException("something bad happened");
        }

        static string Day(string nameDay) {

            if (nameDay.Equals("Sunday"))
            {
                return "SU";
            }
            if (nameDay.Equals("Monday"))
            {
                return "MO";
            }
            if (nameDay.Equals("Tuesday"))
            {
                return "TU";
            }
            if (nameDay.Equals("Wednesday"))
            {
                return "WE";
            }
            if (nameDay.Equals("Thursday"))
            {
                return "TH";
            }
            if (nameDay.Equals("Friday"))
            {
                return "FR";
            }
            if (nameDay.Equals("Saturday"))
            {
                return "ST";
            }

            throw new ArgumentOutOfRangeException("something bad happened");
        }
    }
}
