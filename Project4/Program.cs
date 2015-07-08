using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            Image i = Image.FromFile(@"C:\Users\valentin.brad\Documents\Visual Studio 2013\Projects\Project4\Project4\Ducky.png");
            Bitmap bmp = new Bitmap(i);
            
            string str = "@#$%*+=-. ";
            for (int y = 0; y < bmp.Height; y+=10)
            {
                for (int x = 0; x < bmp.Width; x+=10)
                { 
                    Color pixelColor = bmp.GetPixel(x, y);
                    decimal bright = Brightness(pixelColor);
                   
                    decimal n = bright / 256 * 10;
                   
                    int nr = Convert.ToInt32(Math.Round(n));
                    
                    Console.Write(str.Substring(nr-1,1));
                  
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static int Brightness(Color c)
        {
            return (int)Math.Sqrt(
               c.R * c.R * .241 +
               c.G * c.G * .691 +
               c.B * c.B * .068);
        }
    }



}