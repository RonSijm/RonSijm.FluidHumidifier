// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelExplainabilityJobDefinitionVpcConfigFactory(Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.VpcConfig>
{

    protected override Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerModelExplainabilityJobDefinitionVpcConfigFactoryExtensions
{
}
