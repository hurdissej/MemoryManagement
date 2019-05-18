using System;
using BenchmarkDotNet.Attributes;
using MemoryManagement;

public class SequentialAccessBenchmarks 
    {
        private readonly SequentialAccess target = new SequentialAccess();
        
        [Benchmark]
        public void Sequential()
        {
            target.Sequential(5000,5000);
        }

        [Benchmark]
        public void NonSequential()
        {
            target.NonSequential(5000,5000);
        }


    }