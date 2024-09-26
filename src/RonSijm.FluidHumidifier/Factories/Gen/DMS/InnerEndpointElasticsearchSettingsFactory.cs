// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerEndpointElasticsearchSettingsFactory(Action<Humidifier.DMS.EndpointTypes.ElasticsearchSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.EndpointTypes.ElasticsearchSettings>
{

    protected override Humidifier.DMS.EndpointTypes.ElasticsearchSettings Create()
    {
        var elasticsearchSettingsResult = CreateElasticsearchSettings();
        factoryAction?.Invoke(elasticsearchSettingsResult);

        return elasticsearchSettingsResult;
    }

    private Humidifier.DMS.EndpointTypes.ElasticsearchSettings CreateElasticsearchSettings()
    {
        var elasticsearchSettingsResult = new Humidifier.DMS.EndpointTypes.ElasticsearchSettings();

        return elasticsearchSettingsResult;
    }

} // End Of Class

public static class InnerEndpointElasticsearchSettingsFactoryExtensions
{
}
