using System;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BoxingAndUnboxing;

[MemoryDiagnoser]
public class BoxingAndUnboxingBenchmarks 
{
    private MessageProvider _messageProvider;

    [GlobalSetup]
    public void Setup()
    {
        _messageProvider = new MessageProvider();
    }

    [Benchmark]
    public string GetStringInterface()
    {
        return BoxingMethods.UnpackMessage(_messageProvider);
    }

    [Benchmark]
    public string GetStringGeneric()
    {
        return BoxingMethods.UnpackMessageGeneric(_messageProvider);
    }

    [Benchmark]
    public string GetStringGenericRef()
    {
        return BoxingMethods.UnpackMessageGenericRef(ref _messageProvider);
    }
}