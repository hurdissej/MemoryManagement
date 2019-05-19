using System;
using BenchmarkDotNet.Attributes;
using MemoryManagement;

public class CacheLevelBenchmarks 
{  
    [Params(1, 3, 5, 10, 30, 50, 100)] 
    public int CacheSize { get; set; }

    [Benchmark]
    public void Read()
    {
        //TODO need to play with this a bit more
        var array = new OneLineStruct[CacheSize];
        var result = CacheLevels.ReadStruct(array);
    }
}