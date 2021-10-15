using System;

namespace L6._4_CummulativeAnnualBirths
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Cumulative Annual Births.");
            Console.WriteLine("");

            int[] annualBirths = {1851, 1669, 1480, 1565, 1675, 1637, 1809, 2004, 1976, 1903, 
            1737, 1636, 1957, 2248, 2479, 2596, 2503, 2917, 2883, 2996};

            int[] cumulativeAnnualBirths = new int[annualBirths.Length];

            cumulativeAnnualBirths[0] = annualBirths[0];

            int index = 1;

            while (index <= annualBirths.Length-1)
            {
                cumulativeAnnualBirths[index] = cumulativeAnnualBirths[index - 1] + annualBirths[index];
                index = index + 1;
            } 
            
            //Codes here

            
        }
    }
}
