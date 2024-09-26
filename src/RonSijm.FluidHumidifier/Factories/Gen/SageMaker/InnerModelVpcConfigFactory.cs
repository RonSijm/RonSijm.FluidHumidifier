// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelVpcConfigFactory(Action<Humidifier.SageMaker.ModelTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelTypes.VpcConfig>
{

    protected override Humidifier.SageMaker.ModelTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.SageMaker.ModelTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.SageMaker.ModelTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerModelVpcConfigFactoryExtensions
{
}
