// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class OrganizationConfigurationFactory(string resourceName = null, Action<Humidifier.SecurityHub.OrganizationConfiguration> factoryAction = null) : ResourceFactory<Humidifier.SecurityHub.OrganizationConfiguration>(resourceName)
{

    protected override Humidifier.SecurityHub.OrganizationConfiguration Create()
    {
        var organizationConfigurationResult = CreateOrganizationConfiguration();
        factoryAction?.Invoke(organizationConfigurationResult);

        return organizationConfigurationResult;
    }

    private Humidifier.SecurityHub.OrganizationConfiguration CreateOrganizationConfiguration()
    {
        var organizationConfigurationResult = new Humidifier.SecurityHub.OrganizationConfiguration
        {
            GivenName = InputResourceName,
        };

        return organizationConfigurationResult;
    }

} // End Of Class

public static class OrganizationConfigurationFactoryExtensions
{
}
