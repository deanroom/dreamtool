﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //generic list
            List<int> ListGeneric = new List<int> { 5, 9, 1, 4,2,3,213,6,456,567,56,867,678,678,67,6878,678,678,9457,456,4567,4567,894675,84356,3457,74567,5486};
            //non-generic list
            ArrayList ListNonGeneric = new ArrayList(){ 5, 9, 1, 4,2,3,213,6,456,567,56,867,678,678,67,6878,678,678,9457,456,4567,4567,894675,84356,3457,74567,5486};
            // timer for generic list sort
            Stopwatch s = Stopwatch.StartNew();
            ListGeneric.Sort();
            s.Stop();
            Console.WriteLine($"Generic Sort: {ListGeneric}  \n Time taken: {s.Elapsed.TotalMilliseconds}ms");

            //timer for non-generic list sort
            Stopwatch s2 = Stopwatch.StartNew();
            ListNonGeneric.Sort();
            s2.Stop();
            Console.WriteLine($"Non-Generic Sort: {ListNonGeneric}  \n Time taken: {s2.Elapsed.TotalMilliseconds}ms");
            Console.ReadLine();
        }
    }
}