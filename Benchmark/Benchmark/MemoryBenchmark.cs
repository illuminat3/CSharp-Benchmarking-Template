using BenchmarkDotNet.Attributes;

namespace Benchmark;

[MemoryDiagnoser]
public class MemoryBenchmark
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
