using System;

namespace OddorEven
{
    class Program
    {
        static void Main(string[] args)
        {
            //var comma = "";
            //for (var nbr = 1; nbr <= 25; nbr++)
            //  if (nbr < 25)
            //{
            //        Console.Write($"{comma} {nbr}");
            //        comma = ",";
            //}
            //  else
            //      Console.WriteLine($"{nbr}");

            //for (var idx = 0; idx < 5; idx++)
            //{ 
            //    Console.Write("Enter an integer: ");
            //    var answer = Console.ReadLine();
            //    var value = Convert.ToInt32(answer);

            //    if (value % 2 == 0)
            //    {
            //        Console.WriteLine("The number is even.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The number is odd.");
            //    }
            //    Console.WriteLine("");
            //}

            //var total = 0;
            //for (var nbr = 1; nbr <= 50; nbr++)
            //{
            //    if (nbr % 5 == 0)
            //    {
            //        total = total + nbr;
            //        continue;
            //    }
            //    if (nbr % 7 == 0)
            //    {
            //        total = total + nbr;
            //    }

            //}
            //Console.WriteLine($"Total is {total}.");

            int[] nbrs2 = { 3023, 8760, 1112, 8232, 8107 };

            var highest = nbrs2[0];
            var lowest = nbrs2[0];

            for (var idx = 1; idx <= 4; idx++) {
                foreach (var nbr in nbrs2)
                {
                    if (highest < nbr) {
                        highest = nbr + highest;
                    }
                    if (lowest > nbr) {
                        lowest = nbr + lowest;
                    }

                }
            }

            Console.WriteLine($"The largest number is {highest} and the lowest is {lowest}.");
            //int[] nbrs = {
            //      754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
            //      187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
            //      460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
            //      690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
            //      435, 643, 809, 874, 906, 620, 328, 369, 426, 561
            //};

            //var highnbr = nbrs[0];
            //var lownbr = nbrs[0];
            
            //foreach (var nbr in nbrs)
            //{
            //    if (highnbr < nbr)
            //        highnbr = nbr;
            //    if (lownbr > nbr)
            //        lownbr = nbr;
            //}
            //Console.WriteLine($"The high number is {highnbr} and the low number is {lownbr}.");
        }
    }
}

