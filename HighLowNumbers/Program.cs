using System;

namespace HighLowNumbers
{
    class Program
    {
        static void Main(string[] args)
        {   
            int[] nbrs = {
               754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
               187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
               460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
               690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
               435, 643, 809, 874, 906, 620, 328, 369, 426, 561
            };

            var high = nbrs[0];
            var low = nbrs[0];
            var count = 0;
            var sum = 0.0;
            var avg = 0.0;
            foreach(var nbr in nbrs)
            {
                count++;
                sum += nbr;
                if (high < nbr)
                {
                    high = nbr;
                }

                if (low > nbr)
                {
                    low = nbr;
                }
            }
            avg = sum / count;
            Console.WriteLine($"High value is {high}.");
            Console.WriteLine($"Low value is {low}.");
            Console.WriteLine($"The average of the {count} values is {avg}.");
        }
    }
}
