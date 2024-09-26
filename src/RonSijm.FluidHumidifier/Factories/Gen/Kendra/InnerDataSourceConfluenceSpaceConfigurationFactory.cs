// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceConfluenceSpaceConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.ConfluenceSpaceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.ConfluenceSpaceConfiguration>
{

    protected override Humidifier.Kendra.DataSourceTypes.ConfluenceSpaceConfiguration Create()
    {
        var confluenceSpaceConfigurationResult = CreateConfluenceSpaceConfiguration();
        factoryAction?.Invoke(confluenceSpaceConfigurationResult);

        return confluenceSpaceConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.ConfluenceSpaceConfiguration CreateConfluenceSpaceConfiguration()
    {
        var confluenceSpaceConfigurationResult = new Humidifier.Kendra.DataSourceTypes.ConfluenceSpaceConfiguration();

        return confluenceSpaceConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceConfluenceSpaceConfigurationFactoryExtensions
{
}
