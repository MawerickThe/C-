using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tömbök_használata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tomb1, tomb2;
            Console.WriteLine("Kérem az első tömb méretét!");
            tomb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem a második tömb méretét!");
            tomb2 = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int[] tombegy =new int[tomb1];
            int[] tombketto = new int[tomb2];
            for (int i = 0; i < tomb1; i++)
            {
                tombegy[i] = rnd.Next(1, 200);
            }
            for (int i = 0; i < tomb2; i++)
            {
                tombketto[i] = rnd.Next(1, 200);
            }
            Console.WriteLine("Az első tömb elemei: ");
            foreach (var item in tombegy)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine("\nA második tömb elemei: ");
            foreach(var item in tombketto)
            {
                Console.Write(item+" ");
            }
            int[] tombharom = new int[tomb1+tomb2];
            for (int i = 0; i < (tomb1>tomb2?tomb1-1:tomb2-1); i+=2)
            {
                tombharom[i] = tombegy[i];
                tombharom[i + 1] = tombketto[i];
            }
            Console.WriteLine("Az összefésült tömb elemei: ");
            foreach (var item in tombharom)
            {
                Console.Write(tombharom[item]);
            }
        }
    }
}
