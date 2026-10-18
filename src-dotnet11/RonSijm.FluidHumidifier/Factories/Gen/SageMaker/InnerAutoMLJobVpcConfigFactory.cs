// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAutoMLJobVpcConfigFactory(Action<Humidifier.SageMaker.AutoMLJobTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AutoMLJobTypes.VpcConfig>
{

    protected override Humidifier.SageMaker.AutoMLJobTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.SageMaker.AutoMLJobTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.SageMaker.AutoMLJobTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerAutoMLJobVpcConfigFactoryExtensions
{
}
