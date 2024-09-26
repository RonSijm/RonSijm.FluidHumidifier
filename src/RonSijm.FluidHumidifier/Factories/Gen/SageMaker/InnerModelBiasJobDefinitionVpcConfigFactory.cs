// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelBiasJobDefinitionVpcConfigFactory(Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.VpcConfig>
{

    protected override Humidifier.SageMaker.ModelBiasJobDefinitionTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.SageMaker.ModelBiasJobDefinitionTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.SageMaker.ModelBiasJobDefinitionTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerModelBiasJobDefinitionVpcConfigFactoryExtensions
{
}
