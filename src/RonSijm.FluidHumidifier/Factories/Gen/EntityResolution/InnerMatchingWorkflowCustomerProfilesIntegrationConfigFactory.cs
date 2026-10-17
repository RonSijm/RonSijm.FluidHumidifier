// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EntityResolution;

public class InnerMatchingWorkflowCustomerProfilesIntegrationConfigFactory(Action<Humidifier.EntityResolution.MatchingWorkflowTypes.CustomerProfilesIntegrationConfig> factoryAction = null) : SubResourceFactory<Humidifier.EntityResolution.MatchingWorkflowTypes.CustomerProfilesIntegrationConfig>
{

    protected override Humidifier.EntityResolution.MatchingWorkflowTypes.CustomerProfilesIntegrationConfig Create()
    {
        var customerProfilesIntegrationConfigResult = CreateCustomerProfilesIntegrationConfig();
        factoryAction?.Invoke(customerProfilesIntegrationConfigResult);

        return customerProfilesIntegrationConfigResult;
    }

    private Humidifier.EntityResolution.MatchingWorkflowTypes.CustomerProfilesIntegrationConfig CreateCustomerProfilesIntegrationConfig()
    {
        var customerProfilesIntegrationConfigResult = new Humidifier.EntityResolution.MatchingWorkflowTypes.CustomerProfilesIntegrationConfig();

        return customerProfilesIntegrationConfigResult;
    }

} // End Of Class

public static class InnerMatchingWorkflowCustomerProfilesIntegrationConfigFactoryExtensions
{
}
