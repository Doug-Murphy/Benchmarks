# Introduction

This repo contains benchmarks for various problems you may face when working with C# and .NET. 
The goal of this repo is to educate the community through clear examples of code in order to demonstrate the performance implications of different approaches to the same problem as well as to highlight performance differences between the different version of .NET.

# Running The Project
## Prerequisites
Since this project benchmarks .NET Framework and .NET code, it requires the latest .NET Framework and .NET SDKs and runtimes. If you choose to ignore .NET Framework benchmarks, you can just install the latest .NET SDK.

- You can install the latest .NET Framework from [here](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48).
- You can install the latest .NET SDK [here](https://dotnet.microsoft.com/en-us/download).
    - If you have [winget](https://learn.microsoft.com/en-us/windows/package-manager/winget/) installed then you can do `winget search dotnet.sdk` and install the versions you'd like to benchmark in with `winget install <Id>`.

## Running Benchmarks
Running the benchmarks is best done from the command-line. Running from the IDE is possible, but isn't as simple.

1. In your terminal, navigate to the folder containing the `Benchmarks.csproj` file.
2. Execute `dotnet run -c Release --framework net48 --runtimes net48 netcoreapp3.1 net6.0`
   - You can list any and all runtimes that the `Benchmarks.csproj` file targets and that you currently have installed.
   - We use `--framework net48` here for .NET Framework benchmarks to be runnable. If you don't care about .NET Framework, you can use `--framework net6.0` or whatever version of the .NET runtime.
3. A list of benchmarks implemented will be listed for you to choose. Enter the number of your choice and hit Enter to begin the benchmarks.
4. The benchmarks will now run and, after some time, give you the results. You can view [the official documentation](https://benchmarkdotnet.org/articles/overview.html#benchmark-results) to learn how to interpret the results.