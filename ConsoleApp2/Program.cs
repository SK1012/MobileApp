using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringLibrary.Class1;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Percentage of Men:");
            float PercentageMen = float.Parse(Console.ReadLine());
            float PercentageWomen = 100 - PercentageMen;
            Console.WriteLine("Percentage of Men that answer No:");
            float PercentageMenNo = float.Parse(Console.ReadLine());
            Console.WriteLine("Percentage of Women that answer No:");
            float PercentageWomenNo = float.Parse(Console.ReadLine());
            Compute(PercentageMen, PercentageMenNo, PercentageWomen, PercentageWomenNo);

        }
    }
}
