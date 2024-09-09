using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows;
using BenchmarkDotNet.Diagnostics.Windows.Configs;

namespace Benchmark;

[EtwProfiler]
[MemoryDiagnoser]
public class EventTracingBenchmark
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

