// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayManagedVpcResourceFactory(Action<Humidifier.BedrockAgentCore.GatewayTypes.ManagedVpcResource> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTypes.ManagedVpcResource>
{

    protected override Humidifier.BedrockAgentCore.GatewayTypes.ManagedVpcResource Create()
    {
        var managedVpcResourceResult = CreateManagedVpcResource();
        factoryAction?.Invoke(managedVpcResourceResult);

        return managedVpcResourceResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTypes.ManagedVpcResource CreateManagedVpcResource()
    {
        var managedVpcResourceResult = new Humidifier.BedrockAgentCore.GatewayTypes.ManagedVpcResource();

        return managedVpcResourceResult;
    }

} // End Of Class

public static class InnerGatewayManagedVpcResourceFactoryExtensions
{
}
