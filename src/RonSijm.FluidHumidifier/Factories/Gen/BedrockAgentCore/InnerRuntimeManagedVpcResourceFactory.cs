// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerRuntimeManagedVpcResourceFactory(Action<Humidifier.BedrockAgentCore.RuntimeTypes.ManagedVpcResource> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.RuntimeTypes.ManagedVpcResource>
{

    protected override Humidifier.BedrockAgentCore.RuntimeTypes.ManagedVpcResource Create()
    {
        var managedVpcResourceResult = CreateManagedVpcResource();
        factoryAction?.Invoke(managedVpcResourceResult);

        return managedVpcResourceResult;
    }

    private Humidifier.BedrockAgentCore.RuntimeTypes.ManagedVpcResource CreateManagedVpcResource()
    {
        var managedVpcResourceResult = new Humidifier.BedrockAgentCore.RuntimeTypes.ManagedVpcResource();

        return managedVpcResourceResult;
    }

} // End Of Class

public static class InnerRuntimeManagedVpcResourceFactoryExtensions
{
}
