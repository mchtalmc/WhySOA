using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public class BasicCalculator // Componet Base Programing icin .dll ile farkli platformlara paylasmamda kullanabilirim.
        
    {
        public void Sum(int[] arr)
        {
            int sum = 0;
            foreach (var result in arr)
            {
                sum += result;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
