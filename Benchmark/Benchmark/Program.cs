using BenchmarkDotNet.Running;

namespace Benchmark;

public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<Benchmark>(); //Change <Benchmark> to the class containing your benchmarks
        Console.WriteLine("Benchmarks Completed, press Enter to exit.");
        Console.ReadLine();
    }
}
