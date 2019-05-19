``` ini

BenchmarkDotNet=v0.11.5, OS=macOS Mojave 10.14.4 (18E226) [Darwin 18.5.0]
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.2.105
  [Host]     : .NET Core 2.2.3 (CoreCLR 4.6.27414.05, CoreFX 4.6.27414.05), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.3 (CoreCLR 4.6.27414.05, CoreFX 4.6.27414.05), 64bit RyuJIT


```
|              Method |     Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|----------:|----------:|-------:|------:|------:|----------:|
|  GetStringInterface | 8.688 ns | 0.1557 ns | 0.1380 ns | 0.0152 |     - |     - |      24 B |
|    GetStringGeneric | 1.985 ns | 0.0932 ns | 0.0827 ns |      - |     - |     - |         - |
| GetStringGenericRef | 1.189 ns | 0.0917 ns | 0.0813 ns |      - |     - |     - |         - |
