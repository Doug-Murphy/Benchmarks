``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
AMD Ryzen 7 5800X, 1 CPU, 16 logical and 8 physical cores
  [Host]     : .NET Framework 4.8.1 (4.8.9167.0), X64 RyuJIT VectorSize=256
  Job-BQVMTG : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  Job-FYOECP : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT AVX2
  Job-XTPWQX : .NET Framework 4.8.1 (4.8.9167.0), X64 RyuJIT VectorSize=256


```
|             Method |            Runtime |        Mean |      Error |     StdDev |      Median | Ratio | RatioSD |      Gen0 |  Allocated | Alloc Ratio |
|------------------- |------------------- |------------:|-----------:|-----------:|------------:|------:|--------:|----------:|-----------:|------------:|
| EnumerableContains |           .NET 7.0 |    49.30 μs |   0.149 μs |   0.117 μs |    49.27 μs |  0.03 |    0.00 |         - |          - |          NA |
| EnumerableContains |           .NET 6.0 |   150.19 μs |   0.423 μs |   0.375 μs |   150.16 μs |  0.10 |    0.00 |         - |          - |          NA |
| EnumerableContains | .NET Framework 4.8 | 1,438.29 μs |   4.357 μs |   3.638 μs | 1,436.51 μs |  1.00 |    0.00 |         - |          - |          NA |
|                    |                    |             |            |            |             |       |         |           |            |             |
|       ListContains |           .NET 7.0 |    49.44 μs |   0.279 μs |   0.233 μs |    49.45 μs |  0.03 |    0.00 |         - |          - |          NA |
|       ListContains |           .NET 6.0 |   135.53 μs |   0.425 μs |   0.377 μs |   135.46 μs |  0.09 |    0.00 |         - |          - |          NA |
|       ListContains | .NET Framework 4.8 | 1,439.85 μs |   4.664 μs |   3.895 μs | 1,439.57 μs |  1.00 |    0.00 |         - |          - |          NA |
|                    |                    |             |            |            |             |       |         |           |            |             |
|         ListExists | .NET Framework 4.8 | 1,438.90 μs |   2.204 μs |   1.840 μs | 1,438.31 μs |  1.00 |    0.00 |         - |          - |          NA |
|         ListExists |           .NET 7.0 | 1,684.39 μs |   8.652 μs |   8.093 μs | 1,683.16 μs |  1.17 |    0.01 |         - |        1 B |          NA |
|         ListExists |           .NET 6.0 | 1,689.31 μs |  19.915 μs |  15.548 μs | 1,683.29 μs |  1.17 |    0.01 |         - |        1 B |          NA |
|                    |                    |             |            |            |             |       |         |           |            |             |
|            LinqAny | .NET Framework 4.8 | 5,271.86 μs |  11.233 μs |   9.958 μs | 5,269.81 μs |  1.00 |    0.00 |         - |          - |          NA |
|            LinqAny |           .NET 7.0 | 5,718.83 μs |   4.996 μs |   3.901 μs | 5,719.67 μs |  1.08 |    0.00 |         - |       45 B |          NA |
|            LinqAny |           .NET 6.0 | 6,005.91 μs |  51.472 μs |  42.982 μs | 5,985.59 μs |  1.14 |    0.01 |         - |       45 B |          NA |
|                    |                    |             |            |            |             |       |         |           |            |             |
|      ForeachEquals |           .NET 6.0 | 5,979.26 μs | 117.025 μs | 241.677 μs | 5,856.94 μs |  0.74 |    0.04 | 2867.1875 | 47999957 B |        1.00 |
|      ForeachEquals |           .NET 7.0 | 6,212.56 μs |  88.840 μs |  78.754 μs | 6,191.65 μs |  0.75 |    0.03 | 2867.1875 | 47999957 B |        1.00 |
|      ForeachEquals | .NET Framework 4.8 | 8,163.97 μs | 162.839 μs | 285.200 μs | 8,004.73 μs |  1.00 |    0.00 | 7640.6250 | 48141295 B |        1.00 |
