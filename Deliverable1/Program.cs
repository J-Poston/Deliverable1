using System;

namespace Deliverable1
{
    internal class Program
    {

        public static int totalLoavesNeeded { get; set; }
        public static int totalSlicesNeeded { get; set; }
        public static int numPeople { get; set; }
        public static int tbspPeanutButter { get; set; }
        public static int tspJelly { get; set; }
        public static int numSandwiches { get; set; }
        public static int totalJarsPeanutButter { get; set; }
        public static int totalJarsJelly { get; set; }

        const int TBSP_JAR_PB = 32;
        const int TSP_JAR_JELLY = 48;
        const int TBSP_PB_PER_SANDWICH = 2;
        const int TSP_JELLY_PER_SANDWICH = 4;
        const int SANDWICHES_PER_PERSON = 1;
        const int SLICES_PER_LOAF = 28;
        const int SLICES_PER_SANDWICH = 2;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            Console.Write("How many people?   ");

            numPeople = int.Parse(Console.ReadLine());
            numSandwiches = numPeople * SANDWICHES_PER_PERSON;            
            totalSlicesNeeded = numSandwiches * SLICES_PER_SANDWICH;
            totalLoavesNeeded = totalSlicesNeeded / SLICES_PER_LOAF;
            tbspPeanutButter = numSandwiches * TBSP_PB_PER_SANDWICH;
            tspJelly = numSandwiches * TSP_JELLY_PER_SANDWICH;
            totalJarsPeanutButter = tbspPeanutButter / TBSP_JAR_PB;
            totalJarsJelly = tspJelly / TSP_JAR_JELLY;

            Console.WriteLine("We need {0} slices of bread, which means we need {1} loaves of bread.", totalSlicesNeeded, totalLoavesNeeded);
            Console.WriteLine("We need {0} tbsp of peanut butter, which means we'll need {1} jars of peanut butter.", tbspPeanutButter, totalJarsPeanutButter);
            Console.WriteLine("We need {0} tsp of jelly, which means we'll need {1} jars of jelly.", tspJelly, totalJarsJelly);

        }
    }
}