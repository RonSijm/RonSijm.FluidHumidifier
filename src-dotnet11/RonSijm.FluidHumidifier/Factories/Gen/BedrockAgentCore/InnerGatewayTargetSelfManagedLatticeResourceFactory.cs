// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetSelfManagedLatticeResourceFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.SelfManagedLatticeResource> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.SelfManagedLatticeResource>
{

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.SelfManagedLatticeResource Create()
    {
        var selfManagedLatticeResourceResult = CreateSelfManagedLatticeResource();
        factoryAction?.Invoke(selfManagedLatticeResourceResult);

        return selfManagedLatticeResourceResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.SelfManagedLatticeResource CreateSelfManagedLatticeResource()
    {
        var selfManagedLatticeResourceResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.SelfManagedLatticeResource();

        return selfManagedLatticeResourceResult;
    }

} // End Of Class

public static class InnerGatewayTargetSelfManagedLatticeResourceFactoryExtensions
{
}
