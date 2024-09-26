// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceAccessControlListConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.AccessControlListConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.AccessControlListConfiguration>
{

    protected override Humidifier.Kendra.DataSourceTypes.AccessControlListConfiguration Create()
    {
        var accessControlListConfigurationResult = CreateAccessControlListConfiguration();
        factoryAction?.Invoke(accessControlListConfigurationResult);

        return accessControlListConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.AccessControlListConfiguration CreateAccessControlListConfiguration()
    {
        var accessControlListConfigurationResult = new Humidifier.Kendra.DataSourceTypes.AccessControlListConfiguration();

        return accessControlListConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceAccessControlListConfigurationFactoryExtensions
{
}
