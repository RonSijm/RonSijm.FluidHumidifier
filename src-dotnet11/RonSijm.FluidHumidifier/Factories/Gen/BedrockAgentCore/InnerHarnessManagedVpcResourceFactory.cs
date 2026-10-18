// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessManagedVpcResourceFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.ManagedVpcResource> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.ManagedVpcResource>
{

    protected override Humidifier.BedrockAgentCore.HarnessTypes.ManagedVpcResource Create()
    {
        var managedVpcResourceResult = CreateManagedVpcResource();
        factoryAction?.Invoke(managedVpcResourceResult);

        return managedVpcResourceResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.ManagedVpcResource CreateManagedVpcResource()
    {
        var managedVpcResourceResult = new Humidifier.BedrockAgentCore.HarnessTypes.ManagedVpcResource();

        return managedVpcResourceResult;
    }

} // End Of Class

public static class InnerHarnessManagedVpcResourceFactoryExtensions
{
}
