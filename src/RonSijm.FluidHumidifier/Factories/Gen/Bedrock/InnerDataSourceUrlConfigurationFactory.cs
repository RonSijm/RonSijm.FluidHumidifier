// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceUrlConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.UrlConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.UrlConfiguration>
{

    protected override Humidifier.Bedrock.DataSourceTypes.UrlConfiguration Create()
    {
        var urlConfigurationResult = CreateUrlConfiguration();
        factoryAction?.Invoke(urlConfigurationResult);

        return urlConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.UrlConfiguration CreateUrlConfiguration()
    {
        var urlConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.UrlConfiguration();

        return urlConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceUrlConfigurationFactoryExtensions
{
}
