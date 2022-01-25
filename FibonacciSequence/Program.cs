﻿using System;
using System.Linq;

namespace FibonacciSequence
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var sequence = Sequence.GetFibonacci().Take(30).ToList();
            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}
