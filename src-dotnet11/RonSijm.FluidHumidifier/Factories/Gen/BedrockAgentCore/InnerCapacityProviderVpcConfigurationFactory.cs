// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerCapacityProviderVpcConfigurationFactory(Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.VpcConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.CapacityProviderTypes.VpcConfiguration>
{

    protected override Humidifier.BedrockAgentCore.CapacityProviderTypes.VpcConfiguration Create()
    {
        var vpcConfigurationResult = CreateVpcConfiguration();
        factoryAction?.Invoke(vpcConfigurationResult);

        return vpcConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.CapacityProviderTypes.VpcConfiguration CreateVpcConfiguration()
    {
        var vpcConfigurationResult = new Humidifier.BedrockAgentCore.CapacityProviderTypes.VpcConfiguration();

        return vpcConfigurationResult;
    }

} // End Of Class

public static class InnerCapacityProviderVpcConfigurationFactoryExtensions
{
}
