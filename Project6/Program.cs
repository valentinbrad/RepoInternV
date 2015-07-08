using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> letters = new List<string>();
            List<string> goodWords = new List<string>();
            string[] lines = readFile();
            
            Console.Write("Give first word: ");
            string firstWord = giveWord();
            Console.Write("Give second word: ");
            string secondWord = giveWord();
            

            for(int i=0;i<secondWord.Length;i++)
                letters.Add(secondWord.Substring(i,1));

            foreach (string line in lines)
                if (line.Length == firstWord.Length)
                    for (int i = 0; i < letters.Count; i++)
                        if (line.Contains(letters[i]))
                            goodWords.Add(line);
            Console.Write(firstWord);
           
            int index = 0;
            bool semafor = false;
            while(!firstWord.Equals(secondWord))
            {
                semafor = false;
                string copy = firstWord;
                copy = copy.Replace(copy.Substring(index,1), letters[index]);
                foreach (string word in goodWords)
                {
                    if (word.Equals(copy))
                    {
                        firstWord = word;
                        semafor = true;
                        Console.Write("->");
                        Console.Write(firstWord);                        
                    }
                    if (semafor)
                        break;
                    else                   
                        continue;                 

                }
                if (semafor)
                       index++;                   
                else                                      
                        index++;
                if (index == letters.Count && (!firstWord.Equals(secondWord)))
                {
                    index = 0;
                }
                
            }            
            Console.ReadKey();
        }


        static string giveWord()
        {           
            string word = Console.ReadLine();      
            return word;
        }


        static string[] readFile()
        {
            string fileName = @"C:\Users\valentin.brad\Documents\Visual Studio 2013\Projects\Project6\Project6\Words.txt";
            string[] lines = System.IO.File.ReadAllLines(fileName);
            return lines;
        }


    }
}
