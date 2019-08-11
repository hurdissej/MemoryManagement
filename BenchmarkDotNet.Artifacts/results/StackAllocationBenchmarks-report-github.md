``` ini

BenchmarkDotNet=v0.11.5, OS=macOS Mojave 10.14.4 (18E226) [Darwin 18.5.0]
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.2.301
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
|    Method |     Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |---------:|----------:|----------:|-------:|------:|------:|----------:|
|      Heap | 993.1 ns |  4.013 ns |  3.133 ns | 2.5558 |     - |     - |    4024 B |
|     Stack | 842.5 ns |  2.248 ns |  1.877 ns |      - |     - |     - |         - |
| StackSpan | 784.5 ns | 13.928 ns | 13.028 ns |      - |     - |     - |         - |
