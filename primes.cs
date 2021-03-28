using System;
using System.Collections.Generic;
using System.Timers;

namespace primesC
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();                            //gets the numbers
            List<int> primes = new List<int>();                             //final list
            bool startit = true;
            bool isPrime = true;

            //int test = 0;

            Console.Write("Get primes smaller & equal to: ");
            int num = Convert.ToInt32(Console.ReadLine());

            string startTime = DateTime.Now.ToString("hh:mm:ss:ffff");      //gets starting time

            if (num == 1)                                                   //if not possible
            {
                Console.WriteLine("There is no prime smaller or equal to 1");
                startit = false;
            }

            if (startit == true)
            {
                for (int i = 2; i <= num; i++)                              //creates the "number" List
                {
                    numbers.Add(i);
                }
                #region tests
                ////////////////////////

                //foreach (int _number in numbers)                //should go through the fist and second list to get the primes
                //{
                //    Console.WriteLine("first foreach! {0}", test);
                //    test++;

                //    foreach (int _prime in primes)
                //    {
                //        Console.WriteLine("second foreach!");
                //        Console.WriteLine("comparing {0} & {1}", _number, _prime);

                //        if (_number % _prime == 0)
                //        {
                //            break;
                //        }
                //        else
                //        {
                //            primes.Add(_number);
                //        }
                //    }
                //    Console.WriteLine("end");
                //}

                //////////////////////////
                #endregion

                for (int i = 0; i < numbers.Count; i++)                     //takes every number to compare with the primes to see if he is or sint prime
                {                                                           //if he is prime then he is added to "primes"
                    //Console.WriteLine("number: {0}", numbers[i]);

                    for (int j = 0; j < primes.Count; j++)                  //taking numbers from primes
                    {
                        if (numbers[i] % primes[j] == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime == true)                                    //number is prime and is added to "primes"
                    {
                        primes.Add(numbers[i]);

                        //Console.WriteLine("number {0} is prime!", numbers[i]);
                    }
                    isPrime = true;
                }
            }

            string endTime = DateTime.Now.ToString("hh:mm:ss:ffff");        //takes ending time

            Console.WriteLine("List of primes: ");

            foreach (int item in primes)                                    //prints list of primes
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
            Console.WriteLine("There are {0} primes", primes.Count);
            Console.WriteLine("Times are:");
            Console.WriteLine("{0} - started", startTime);
            Console.WriteLine("{0} - ended", endTime);
            
            Console.ReadKey();
        }
    }
}
