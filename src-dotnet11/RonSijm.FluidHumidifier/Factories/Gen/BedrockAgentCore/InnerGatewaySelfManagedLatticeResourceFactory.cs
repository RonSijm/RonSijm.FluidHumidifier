// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewaySelfManagedLatticeResourceFactory(Action<Humidifier.BedrockAgentCore.GatewayTypes.SelfManagedLatticeResource> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTypes.SelfManagedLatticeResource>
{

    protected override Humidifier.BedrockAgentCore.GatewayTypes.SelfManagedLatticeResource Create()
    {
        var selfManagedLatticeResourceResult = CreateSelfManagedLatticeResource();
        factoryAction?.Invoke(selfManagedLatticeResourceResult);

        return selfManagedLatticeResourceResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTypes.SelfManagedLatticeResource CreateSelfManagedLatticeResource()
    {
        var selfManagedLatticeResourceResult = new Humidifier.BedrockAgentCore.GatewayTypes.SelfManagedLatticeResource();

        return selfManagedLatticeResourceResult;
    }

} // End Of Class

public static class InnerGatewaySelfManagedLatticeResourceFactoryExtensions
{
}
