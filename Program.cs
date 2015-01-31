using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int longestChain = 0;
            int bestStartingNumber = 1;

            for (int i = bestStartingNumber; i < 1000000; i++)
            {
                int chainLength = GetChainLength(i);
                if (chainLength > longestChain)
                {
                    longestChain = chainLength;
                    Console.WriteLine("chain length " + longestChain + " starting number " + i);
                    bestStartingNumber = i;
                }
            }

            Console.WriteLine(longestChain);
            Console.WriteLine(bestStartingNumber);
            Console.ReadLine();
        }


        static int GetChainLength(int i)
        {
            // Note this MUST be bigger than int.
            long startingNumber = i;
            int chainLength = 1;

            while (startingNumber > 1)
            {
                if (startingNumber%2==0)
                {
                    startingNumber = startingNumber/2;
                }
                else
                {
                    startingNumber = (startingNumber * 3) + 1;
                }
                chainLength++;
            }            

            return chainLength;
        }

    }
}
