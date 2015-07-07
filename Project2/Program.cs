using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNr = 0;
            
            Console.Write("Give a number: ");
            inputNr=Convert.ToInt32(Console.ReadLine());
            string rez=ConvertToRoman(inputNr);
            Console.WriteLine("Roman number is "+rez);
            Console.ReadKey();
        }
        static string ConvertToRoman(int number) 
        {
            string romanNumber="";
            int nr = number;
            int M = 1000;
            int D = 500;
            int C = 100;
            int L = 50;
            int X = 10;
            int V = 5;
            int I = 1;
            int contor=0;
            int length=0;

            while (nr >= M)
            {
                
                nr = nr - 1000;
                romanNumber = romanNumber + "M";
                length++;
            }

            

            while (nr >= D)
            {
                contor++;
                nr = nr - 500;
                romanNumber = romanNumber + "D";
                length++;
            }


            contor = 0;
            while (nr >= C)
            {
                contor++;
                nr = nr - 100;
               if (nr < C)
                    if (contor == 4 && romanNumber[length - 1] == 'D')
                    {
                        romanNumber = romanNumber.Remove(length - 1);
                        romanNumber = romanNumber + "CM";
                        length = length + 2;
                    }

                    else if (contor == 4)
                    {
                        length = length + 2;
                        romanNumber = romanNumber + "CD";
                    }
                    else
                        for (int i = 0; i < contor; i++)
                        {
                            romanNumber = romanNumber + "C";
                            length++;
                        }
            }


            contor = 0;
            while (nr >= L)
            {
                contor++;
                nr = nr - 50;
                romanNumber = romanNumber + "L";
                length++;
            }


            contor = 0;
            while (nr >= X)
            {
                contor++;
                nr = nr - 10;
                if (nr < X)
                    if (contor == 4 && romanNumber[length - 1] == 'L')
                    {
                        romanNumber = romanNumber.Remove(length - 1);
                        romanNumber = romanNumber + "XC";
                        length = length + 2;
                    }

                    else if (contor == 4)
                    {
                        length = length + 2;
                        romanNumber = romanNumber + "XL";
                    }
                    else
                        for (int i = 0; i < contor; i++)
                        {
                            romanNumber = romanNumber + "X";
                            length++;
                        }
                
            }


            contor = 0;
            while (nr >= V)
            {
                contor++;
                nr = nr - 5;
                romanNumber = romanNumber + "V";
                length++;
            }


            contor = 0;
            while (nr >= I)
            {
                contor++;
                nr = nr - 1;
                
                if(nr<I)
                    if (contor == 4 && romanNumber[length-1] == 'V')
                    {
                        romanNumber = romanNumber.Remove(length - 1);
                        romanNumber = romanNumber + "IX";
                        length = length + 2;
                    }
                    else if (contor == 4)
                    {
                        romanNumber = romanNumber + "IV";
                        length = length + 2;
                    }

                    else
                        for (int i = 0; i < contor; i++)
                        {
                            romanNumber = romanNumber + "I";
                            length++;
                        }

            }

                return romanNumber;
        }

        

    }
}
