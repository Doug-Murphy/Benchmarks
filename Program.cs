using BenchmarkDotNet.Running;

namespace Benchmarks {
    public class Program {
        public static void Main(string[] args) {
            //Run with the following command on CLI to run a chosen benchmark on all runtimes after the --runtimes flag
            //dotnet run -c Release --framework net48 --runtimes net48 netcoreapp3.1 net5.0 net6.0
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
}
