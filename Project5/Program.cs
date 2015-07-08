using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = readFile();
            string word = giveWord();
            string rez=verifyWord(word,lines);
            printFunction(rez,word,lines);
        }


        static string giveWord()
        {
            Console.Write("Give a word: ");
            string word = Console.ReadLine();
            return word;
        }


        static string[] readFile()
        {
            string fileName = @"C:\Users\valentin.brad\Documents\Visual Studio 2013\Projects\Project5\Project5\Words.txt";
            string[] lines = System.IO.File.ReadAllLines(fileName);
            return lines;
        }


        static void printWordIfOk(string rez)
        {
            
            Console.WriteLine("Your word is composed of:" + rez);
            
        }
        static void printWordIfNotOk()
        {
            
            Console.WriteLine("Word can not be composed!");
            
        }

        static void printFunction(string rez,string word,string[] lines)
        {
            Console.WriteLine();
            if (rez == "")
                printWordIfNotOk();
            else
                printWordIfOk(verifyWord(word, lines));
            Console.ReadKey();
        }


        static string verifyWord(string word,string[] lines)
        {
            string rez = "";
            string copy = word;
            for (int i = 0; i < lines.Length; i++)
            {
                if (word.Contains(lines[i]))
                {
                    int index = word.IndexOf(lines[i]);
                    rez = rez + word.Substring(index, lines[i].Length);
                    rez = rez + " ";
                    if (index>0 && index + lines[i].Length==word.Length)
                    {
                        word = word.Substring(0,index);
                    }
                    else
                        if(index > 0 && index + lines[i].Length < word.Length)
                            word = word = word.Substring(0, index)+word.Substring(index + lines[i].Length);
                        else
                        {
                            word =word.Substring(index + lines[i].Length);
                        }
                    i = 0;
                }
            }
            
            if (rez.Length-1 <= copy.Length)
            {
                rez = "";
            }
            
            return rez;

        }
    }
}

