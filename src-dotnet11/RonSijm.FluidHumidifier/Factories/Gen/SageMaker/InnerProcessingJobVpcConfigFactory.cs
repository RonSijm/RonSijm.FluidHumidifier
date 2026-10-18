// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerProcessingJobVpcConfigFactory(Action<Humidifier.SageMaker.ProcessingJobTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ProcessingJobTypes.VpcConfig>
{

    protected override Humidifier.SageMaker.ProcessingJobTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.SageMaker.ProcessingJobTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.SageMaker.ProcessingJobTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerProcessingJobVpcConfigFactoryExtensions
{
}
