// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceConfluenceBlogConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.ConfluenceBlogConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.ConfluenceBlogConfiguration>
{

    protected override Humidifier.Kendra.DataSourceTypes.ConfluenceBlogConfiguration Create()
    {
        var confluenceBlogConfigurationResult = CreateConfluenceBlogConfiguration();
        factoryAction?.Invoke(confluenceBlogConfigurationResult);

        return confluenceBlogConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.ConfluenceBlogConfiguration CreateConfluenceBlogConfiguration()
    {
        var confluenceBlogConfigurationResult = new Humidifier.Kendra.DataSourceTypes.ConfluenceBlogConfiguration();

        return confluenceBlogConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceConfluenceBlogConfigurationFactoryExtensions
{
}
