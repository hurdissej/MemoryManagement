using System;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using MemoryManagement;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = RunBoxingBenchmarks();
        }

        private static BenchmarkDotNet.Reports.Summary RunBoxingBenchmarks()
        {
            return BenchmarkRunner.Run<BoxingAndUnboxingBenchmarks>();
        }

        private static BenchmarkDotNet.Reports.Summary RunStructVsClassAccessTests()
        {
            return BenchmarkRunner.Run<ClassVsStructBenchmarks>();
        }

        private static BenchmarkDotNet.Reports.Summary RunSequentialAccessTests()
        {
            return BenchmarkRunner.Run<SequentialAccessBenchmarks>();
        }

        private static BenchmarkDotNet.Reports.Summary RunCacheLevelAccessTests()
        {
            return BenchmarkRunner.Run<CacheLevelBenchmarks>();
        }
    }
}
