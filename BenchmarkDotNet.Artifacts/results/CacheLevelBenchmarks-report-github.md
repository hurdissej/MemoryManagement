``` ini

BenchmarkDotNet=v0.11.5, OS=macOS Mojave 10.14.4 (18E226) [Darwin 18.5.0]
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.2.105
  [Host]     : .NET Core 2.2.3 (CoreCLR 4.6.27414.05, CoreFX 4.6.27414.05), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.3 (CoreCLR 4.6.27414.05, CoreFX 4.6.27414.05), 64bit RyuJIT


```
| Method | CacheSize |      Mean |      Error |     StdDev |
|------- |---------- |----------:|-----------:|-----------:|
|   **Read** |         **1** |  **14.88 ns** |  **0.4132 ns** |  **0.5373 ns** |
|   **Read** |         **3** |  **27.08 ns** |  **0.4044 ns** |  **0.3585 ns** |
|   **Read** |         **5** |  **39.16 ns** |  **0.9140 ns** |  **0.8550 ns** |
|   **Read** |        **10** |  **66.78 ns** |  **1.2849 ns** |  **1.2019 ns** |
|   **Read** |        **30** | **181.05 ns** |  **6.2740 ns** |  **6.4430 ns** |
|   **Read** |        **50** | **287.26 ns** |  **6.9157 ns** |  **6.4690 ns** |
|   **Read** |       **100** | **566.64 ns** | **11.0531 ns** | **10.3391 ns** |
