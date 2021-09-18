using System;

namespace L6._4_CummulativeAnnualDeaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cumulative Annual Deaths From Drug Usage.");
            Console.WriteLine("");

            int[] annualDrugDeaths = {1851, 1669, 1480, 1565, 1675, 1637, 1809, 2004, 1976, 1903, 
            1737, 1636, 1957, 2248, 2479, 2596, 2503, 2917, 2883, 2996};

            int[] cumulativeAnnualDrugUsage = new int[annualDrugDeaths.Length];

            cumulativeAnnualDrugUsage[0] = annualDrugDeaths[0];

            int index = 1;

            while (index <= 19)
            {
                cumulativeAnnualDrugUsage[index] = cumulativeAnnualDrugUsage[index - 1] + annualDrugDeaths[index];
                index = index + 1;
            }

            //Codes here

            
            
        }
    }
}
