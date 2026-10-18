// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAIBenchmarkJobAIBenchmarkOutputConfigFactory(Action<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkOutputConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkOutputConfig>
{

    protected override Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkOutputConfig Create()
    {
        var aIBenchmarkOutputConfigResult = CreateAIBenchmarkOutputConfig();
        factoryAction?.Invoke(aIBenchmarkOutputConfigResult);

        return aIBenchmarkOutputConfigResult;
    }

    private Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkOutputConfig CreateAIBenchmarkOutputConfig()
    {
        var aIBenchmarkOutputConfigResult = new Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkOutputConfig();

        return aIBenchmarkOutputConfigResult;
    }

} // End Of Class

public static class InnerAIBenchmarkJobAIBenchmarkOutputConfigFactoryExtensions
{
}
