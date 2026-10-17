// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.APS;

public class InnerScraperRoleConfigurationFactory(Action<Humidifier.APS.ScraperTypes.RoleConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.APS.ScraperTypes.RoleConfiguration>
{

    protected override Humidifier.APS.ScraperTypes.RoleConfiguration Create()
    {
        var roleConfigurationResult = CreateRoleConfiguration();
        factoryAction?.Invoke(roleConfigurationResult);

        return roleConfigurationResult;
    }

    private Humidifier.APS.ScraperTypes.RoleConfiguration CreateRoleConfiguration()
    {
        var roleConfigurationResult = new Humidifier.APS.ScraperTypes.RoleConfiguration();

        return roleConfigurationResult;
    }

} // End Of Class

public static class InnerScraperRoleConfigurationFactoryExtensions
{
}
