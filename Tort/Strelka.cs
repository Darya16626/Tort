using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tort
{
    internal class Strelka
    {
        private int minStrelochka;
        private int maxStrelochka;

        public Strelka(int min, int max)
        {
            minStrelochka = min;
            maxStrelochka = max;
        }
        
        public int Show()
        {
            int posit = 1;
            Console.SetCursorPosition(0, posit);
            Console.Write("->");
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow && posit != minStrelochka)
                {
                    Console.SetCursorPosition(0, posit);
                    Console.Write("  ");
                    posit--;
                }
                else if (key.Key == ConsoleKey.DownArrow && posit != maxStrelochka)
                {
                    Console.SetCursorPosition(0, posit);
                    Console.Write("  ");
                    posit++;
                }
                
                Console.SetCursorPosition(0, posit);
                Console.Write("->");
            }
            while (key.Key != ConsoleKey.Enter);
            return posit;
        }
    }
}
