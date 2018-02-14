﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace number_of_primes
{
    class Program
    {
        static int NumberOfPrimes(long number, int i = 0, int numPrimes = 1)
        {
            long[] primes = new long[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691, 701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911, 919, 929, 937, 941, 947, 953, 967, 971, 977, 983, 991, 997 };
            // base condition
            if (primes.Contains(number))
            {
                return numPrimes;
            }

            if (number % primes[i] == 0)
            {
                number = number / primes[i];
                numPrimes++;
                return NumberOfPrimes(number, i, numPrimes);
            }
            else
            {
                i++; // move on to the next prime number
                return NumberOfPrimes(number, i, numPrimes);
            }
        }

        static void Main(string[] args)
        {
            int a = NumberOfPrimes(10098);
            Console.WriteLine("10098 has " + a.ToString() + " prime factors.");
            Console.WriteLine("Expected value is 6.");

            int b = NumberOfPrimes(2);
            Console.WriteLine("2 has {0} prime factors.", b.ToString());
            Console.WriteLine("Expected value is 1.");

            int c = NumberOfPrimes(10005);
            Console.WriteLine("10005 has {0} prime factors.", c.ToString());
            Console.WriteLine("Expected value is 4.");

            int d = NumberOfPrimes(10030);
            Console.WriteLine("10030 has {0} prime factors.", d.ToString());
            Console.WriteLine("Expected value is 4.");
        }
    }
}
