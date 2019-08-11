``` ini

BenchmarkDotNet=v0.11.5, OS=macOS Mojave 10.14.4 (18E226) [Darwin 18.5.0]
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.2.301
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
|              Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |----------:|----------:|----------:|----------:|-------:|------:|------:|----------:|
|  GetStringInterface | 8.9827 ns | 0.1750 ns | 0.1637 ns | 8.9001 ns | 0.0152 |     - |     - |      24 B |
|    GetStringGeneric | 0.0636 ns | 0.0562 ns | 0.0498 ns | 0.0450 ns |      - |     - |     - |         - |
| GetStringGenericRef | 0.0015 ns | 0.0061 ns | 0.0051 ns | 0.0000 ns |      - |     - |     - |         - |
