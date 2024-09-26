// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceConfluencePageConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.ConfluencePageConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.ConfluencePageConfiguration>
{

    protected override Humidifier.Kendra.DataSourceTypes.ConfluencePageConfiguration Create()
    {
        var confluencePageConfigurationResult = CreateConfluencePageConfiguration();
        factoryAction?.Invoke(confluencePageConfigurationResult);

        return confluencePageConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.ConfluencePageConfiguration CreateConfluencePageConfiguration()
    {
        var confluencePageConfigurationResult = new Humidifier.Kendra.DataSourceTypes.ConfluencePageConfiguration();

        return confluencePageConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceConfluencePageConfigurationFactoryExtensions
{
}
