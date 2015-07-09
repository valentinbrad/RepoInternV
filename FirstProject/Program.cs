using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int number = 0;
            Console.Write("Give a number: " );
            string stringNr=Console.ReadLine();
            Console.WriteLine("String number is "+stringNr);
            number=functionConvert(stringNr);
            Console.WriteLine("Integer number is " + number);
            Console.ReadKey();
        }
        static public int functionConvert(string stringNr)
        {
            
            bool negative=false;
            string stringNumber = stringNr;
            char minus = '-';
            int integerNumber = 0;
            
            for (int i = 0; i < stringNumber.Length; i++)
            {
                if (i==0)
                    if (stringNumber[0].CompareTo(minus) == 0)
                    {
                        negative = true;                     
                        i++;
                    }
                integerNumber = integerNumber * 10;
                integerNumber = integerNumber + stringNumber[i] - 48;
            }
            if (negative)
                integerNumber = integerNumber * -1;
            return integerNumber;
        }

    }
}

