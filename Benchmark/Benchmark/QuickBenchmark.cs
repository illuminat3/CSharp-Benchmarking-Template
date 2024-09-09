using BenchmarkDotNet.Attributes;

namespace Benchmark;

[ShortRunJob]
public class QuickBenchmark
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
