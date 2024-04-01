using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeNetProject
{
    class Program
    {


        static void Main(string[] args)
        {
            BasicCalculator basicCalculator = new BasicCalculator();
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            int[] numbers2 = new int[] { 10, 20, 30, 40, 50, 60 };

            basicCalculator.Sum(numbers);
            basicCalculator.Sum(numbers2);


            

        }


    }
}