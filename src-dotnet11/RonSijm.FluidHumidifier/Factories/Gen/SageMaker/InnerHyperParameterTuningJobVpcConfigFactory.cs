// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerHyperParameterTuningJobVpcConfigFactory(Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.HyperParameterTuningJobTypes.VpcConfig>
{

    protected override Humidifier.SageMaker.HyperParameterTuningJobTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.SageMaker.HyperParameterTuningJobTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.SageMaker.HyperParameterTuningJobTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerHyperParameterTuningJobVpcConfigFactoryExtensions
{
}
