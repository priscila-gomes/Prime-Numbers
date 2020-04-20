using System;

namespace Prime_Numbers
{
    class Program
    {
        public static void SieveOfEratosthenes(long n) // sieve-of-eratosthenes algorithm
        {
            // Create a boolean array "prime[0..n]" and initialize 
            // all entries it as true. A value in prime[i] will 
            // finally be false if i is Not a prime, else true. 

            long totPrime = 0; // 2
            bool[] prime = new bool[n + 1];

            for (long i = 0; i < n; i++)
                prime[i] = true;

            for (long p = 2; p * p <= n; p++)
            {
                // If prime[p] is not changed, 
                // then it is a prime 
                if (prime[p] == true)
                {
                    // Update all multiples of p 
                    for (long i = p * p; i <= n; i += p)
                        prime[i] = false;
                }
            }

            // Print all prime numbers 
            for (long i = 2; i <= n; i++)
            {
                if (prime[i] == true)
                {
                    ++totPrime;
                    //Console.Write(i + " ");
                }
            }

            Console.WriteLine("Total Prime Numbers below 1 Billion are: {0}", totPrime);

        }
        static void Main(string[] args)
        {
            long number = 1000000000; // 1 billion
            SieveOfEratosthenes(number);
        }
    }
}
