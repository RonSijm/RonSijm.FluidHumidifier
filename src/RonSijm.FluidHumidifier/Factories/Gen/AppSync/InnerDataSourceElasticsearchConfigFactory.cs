// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerDataSourceElasticsearchConfigFactory(Action<Humidifier.AppSync.DataSourceTypes.ElasticsearchConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.DataSourceTypes.ElasticsearchConfig>
{

    protected override Humidifier.AppSync.DataSourceTypes.ElasticsearchConfig Create()
    {
        var elasticsearchConfigResult = CreateElasticsearchConfig();
        factoryAction?.Invoke(elasticsearchConfigResult);

        return elasticsearchConfigResult;
    }

    private Humidifier.AppSync.DataSourceTypes.ElasticsearchConfig CreateElasticsearchConfig()
    {
        var elasticsearchConfigResult = new Humidifier.AppSync.DataSourceTypes.ElasticsearchConfig();

        return elasticsearchConfigResult;
    }

} // End Of Class

public static class InnerDataSourceElasticsearchConfigFactoryExtensions
{
}
