using System;
using BenchmarkDotNet.Attributes;
using ClassVsStructAccess;

public class ClassVsStructBenchmarks 
{
    private SomeClass[] classes;
    private SomeStruct[] structs;

    private static int limit = 1000000;

    [GlobalSetup]
    public void Setup()
    {
        classes = new SomeClass[limit];
        structs = new SomeStruct[limit];

        for (int i = 0; i < limit; i++)
        {
            classes[i] = new SomeClass(i);
            structs[i] = new SomeStruct(i);    
        }
    }

    [Benchmark(Baseline = true)]
    public int ClassArrayAccess()
    {
        var result = 0;
        for (int i = 0; i < limit; i++)
        {
            result += AccessorMethods.ClassAccessor(classes, i);
        }
        return result;
    }

    [Benchmark]
    public int StructArrayAccess()
    {
        var result = 0;
        for (int i = 0; i < limit; i++)
        {
            result += AccessorMethods.StructAccessor(structs, i);
        }
        return result;
    }

}