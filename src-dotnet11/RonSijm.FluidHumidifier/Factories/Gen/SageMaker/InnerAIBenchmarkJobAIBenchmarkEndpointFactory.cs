// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAIBenchmarkJobAIBenchmarkEndpointFactory(Action<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkEndpoint> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkEndpoint>
{

    protected override Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkEndpoint Create()
    {
        var aIBenchmarkEndpointResult = CreateAIBenchmarkEndpoint();
        factoryAction?.Invoke(aIBenchmarkEndpointResult);

        return aIBenchmarkEndpointResult;
    }

    private Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkEndpoint CreateAIBenchmarkEndpoint()
    {
        var aIBenchmarkEndpointResult = new Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkEndpoint();

        return aIBenchmarkEndpointResult;
    }

} // End Of Class

public static class InnerAIBenchmarkJobAIBenchmarkEndpointFactoryExtensions
{
}
