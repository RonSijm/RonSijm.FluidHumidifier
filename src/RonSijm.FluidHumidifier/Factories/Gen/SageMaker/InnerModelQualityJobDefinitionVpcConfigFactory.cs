// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelQualityJobDefinitionVpcConfigFactory(Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.VpcConfig>
{

    protected override Humidifier.SageMaker.ModelQualityJobDefinitionTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.SageMaker.ModelQualityJobDefinitionTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.SageMaker.ModelQualityJobDefinitionTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerModelQualityJobDefinitionVpcConfigFactoryExtensions
{
}
