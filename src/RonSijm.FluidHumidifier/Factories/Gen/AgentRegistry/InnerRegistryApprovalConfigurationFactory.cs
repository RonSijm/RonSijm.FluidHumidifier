// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AgentRegistry;

public class InnerRegistryApprovalConfigurationFactory(Action<Humidifier.AgentRegistry.RegistryTypes.ApprovalConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AgentRegistry.RegistryTypes.ApprovalConfiguration>
{

    protected override Humidifier.AgentRegistry.RegistryTypes.ApprovalConfiguration Create()
    {
        var approvalConfigurationResult = CreateApprovalConfiguration();
        factoryAction?.Invoke(approvalConfigurationResult);

        return approvalConfigurationResult;
    }

    private Humidifier.AgentRegistry.RegistryTypes.ApprovalConfiguration CreateApprovalConfiguration()
    {
        var approvalConfigurationResult = new Humidifier.AgentRegistry.RegistryTypes.ApprovalConfiguration();

        return approvalConfigurationResult;
    }

} // End Of Class

public static class InnerRegistryApprovalConfigurationFactoryExtensions
{
}
