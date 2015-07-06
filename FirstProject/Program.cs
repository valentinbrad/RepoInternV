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
           
            float number = 0.0f;
            Console.Write("Give a number: " );
            string stringNr=Console.ReadLine();
            Console.WriteLine("String number is "+stringNr);
            number=functionConvert(stringNr);
            Console.WriteLine("Integer number is " + number);
            Console.ReadKey();
        }
        static public float functionConvert(string stringNr)
        {
            bool pas = false;
            bool negative=false;
            string stringNumber = stringNr;
            char minus = '-';
            float integerNumber = 0.0f;
            
            for (int i = 0; i < stringNumber.Length; i++)
            {
                if (pas == false && i==0)
                    if (stringNumber[0].CompareTo(minus) == 0)
                    {
                        negative = true;
                        pas = true;
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

