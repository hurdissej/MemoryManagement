using System;
using AvoidingAllocations;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BoxingAndUnboxing;

[MemoryDiagnoser]
public class StackAllocationBenchmarks 
{

    private const int limit = 1000;

    [Benchmark]
    public void Heap()
    {
        
        AllocationMethods.AllocateSomeStuff(limit);
        
    }

    [Benchmark]
    public void Stack()
    {
        AllocationMethods.AllocateSomeStuffOnStack(limit);
    }

    [Benchmark]
    public void StackSpan()
    {
        AllocationMethods.AllocateSomeStuffOnStackWithSpan(limit);
    }
    

}