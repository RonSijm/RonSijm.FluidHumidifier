// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetManagedVpcResourceFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ManagedVpcResource> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.ManagedVpcResource>
{

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.ManagedVpcResource Create()
    {
        var managedVpcResourceResult = CreateManagedVpcResource();
        factoryAction?.Invoke(managedVpcResourceResult);

        return managedVpcResourceResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.ManagedVpcResource CreateManagedVpcResource()
    {
        var managedVpcResourceResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.ManagedVpcResource();

        return managedVpcResourceResult;
    }

} // End Of Class

public static class InnerGatewayTargetManagedVpcResourceFactoryExtensions
{
}
