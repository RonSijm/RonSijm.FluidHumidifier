// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class InnerAutomationRuleV2ExternalIntegrationConfigurationFactory(Action<Humidifier.SecurityHub.AutomationRuleV2Types.ExternalIntegrationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SecurityHub.AutomationRuleV2Types.ExternalIntegrationConfiguration>
{

    protected override Humidifier.SecurityHub.AutomationRuleV2Types.ExternalIntegrationConfiguration Create()
    {
        var externalIntegrationConfigurationResult = CreateExternalIntegrationConfiguration();
        factoryAction?.Invoke(externalIntegrationConfigurationResult);

        return externalIntegrationConfigurationResult;
    }

    private Humidifier.SecurityHub.AutomationRuleV2Types.ExternalIntegrationConfiguration CreateExternalIntegrationConfiguration()
    {
        var externalIntegrationConfigurationResult = new Humidifier.SecurityHub.AutomationRuleV2Types.ExternalIntegrationConfiguration();

        return externalIntegrationConfigurationResult;
    }

} // End Of Class

public static class InnerAutomationRuleV2ExternalIntegrationConfigurationFactoryExtensions
{
}
