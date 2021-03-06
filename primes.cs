using System;
using System.Collections.Generic;
using System.Timers;

namespace primesC
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primes = new List<int>();                             //final list
            bool startit = true;
            bool isPrime = true;

            Console.Write("Get primes smaller & equal to: ");
            int num = Convert.ToInt32(Console.ReadLine());

            string startTime = DateTime.Now.ToString("hh:mm:ss:ffff");      //gets starting time

            if (num <= 1)                                                   //if not possible
            {
                Console.WriteLine("There is no prime smaller or even to {0}", num);
                Console.WriteLine("The number must be greater than 1!");
                startit = false;
            }

            if (startit == true)
            {
                for (int i = 2; i <= num; i++)                              //takes every number to compare with the primes to see if he is or sint prime
                {                                                           //if he is prime then he is added to "primes"
                    //Console.WriteLine("number: {0}", numbers[i]);

                    foreach (int j in primes)                               //taking numbers from primes
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime == true)                                    //number is prime and is added to "primes"
                    {
                        primes.Add(i);

                        //Console.WriteLine("number {0} is prime!", numbers[i]);
                    }
                    isPrime = true;
                }
            }

            string endTime = DateTime.Now.ToString("hh:mm:ss:ffff");        //takes ending time

            Console.WriteLine("List of primes that are smaller or even to {0}: ", num);

            Console.WriteLine(String.Join(" ", primes.ToArray()));          //print the list of primes
            
            Console.WriteLine("There are {0} primes that are smaller or even to {1}", primes.Count, num);
            Console.WriteLine("Times are:");
            Console.WriteLine("{0} - started", startTime);
            Console.WriteLine("{0} - ended", endTime);

            Console.ReadKey();
        }
    }
}
