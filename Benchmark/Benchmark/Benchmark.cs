using BenchmarkDotNet.Attributes;

namespace Benchmark;

public class Benchmark
{
    [GlobalSetup]
    public void Setup()
    {
    }

    [Benchmark]
    public void BenchmarkFunction() 
    {
        CodeToBenchmark();
    }

    private void CodeToBenchmark() 
    {
    }
}
