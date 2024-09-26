// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDataQualityJobDefinitionVpcConfigFactory(Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DataQualityJobDefinitionTypes.VpcConfig>
{

    protected override Humidifier.SageMaker.DataQualityJobDefinitionTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.SageMaker.DataQualityJobDefinitionTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.SageMaker.DataQualityJobDefinitionTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerDataQualityJobDefinitionVpcConfigFactoryExtensions
{
}
