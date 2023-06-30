using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int card = rnd.Next(100);     // creates a number between 0 and 99

            int t=0;
            while (true)// qora oynada suz topish uyini
            {
                t=t+1;

                Console.Write("Son kiriting: ");
                int n=Convert.ToInt32(Console.ReadLine());
                
                if(n==card)
                {
                    Console.WriteLine($"Tabriklaymiz siz {(t)} Urinishda o\'ylangan sonni topdingiz!! ");
                        break;
                }
                else if (n > card)
                {
                    Console.WriteLine("Kichikroq son kiriting !!");
                }
                else if (n < card)
                {
                    Console.WriteLine("Kattaroq son kiriting !!");
                }
               
            }
            Console.ReadKey();
        }
    }
}
