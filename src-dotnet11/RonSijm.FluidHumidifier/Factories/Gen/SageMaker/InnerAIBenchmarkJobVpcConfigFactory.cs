// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAIBenchmarkJobVpcConfigFactory(Action<Humidifier.SageMaker.AIBenchmarkJobTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AIBenchmarkJobTypes.VpcConfig>
{

    protected override Humidifier.SageMaker.AIBenchmarkJobTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.SageMaker.AIBenchmarkJobTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.SageMaker.AIBenchmarkJobTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerAIBenchmarkJobVpcConfigFactoryExtensions
{
}
