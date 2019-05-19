``` ini

BenchmarkDotNet=v0.11.5, OS=macOS Mojave 10.14.4 (18E226) [Darwin 18.5.0]
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.2.105
  [Host]     : .NET Core 2.2.3 (CoreCLR 4.6.27414.05, CoreFX 4.6.27414.05), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.3 (CoreCLR 4.6.27414.05, CoreFX 4.6.27414.05), 64bit RyuJIT


```
|            Method |       Mean |    Error |   StdDev | Ratio | RatioSD |
|------------------ |-----------:|---------:|---------:|------:|--------:|
|  ClassArrayAccess | 2,199.0 us | 50.78 us | 71.18 us |  1.00 |    0.00 |
| StructArrayAccess |   943.3 us | 17.95 us | 17.63 us |  0.43 |    0.02 |
