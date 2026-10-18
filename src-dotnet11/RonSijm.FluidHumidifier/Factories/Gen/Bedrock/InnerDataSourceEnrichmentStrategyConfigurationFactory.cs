// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceEnrichmentStrategyConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.EnrichmentStrategyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.EnrichmentStrategyConfiguration>
{

    protected override Humidifier.Bedrock.DataSourceTypes.EnrichmentStrategyConfiguration Create()
    {
        var enrichmentStrategyConfigurationResult = CreateEnrichmentStrategyConfiguration();
        factoryAction?.Invoke(enrichmentStrategyConfigurationResult);

        return enrichmentStrategyConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.EnrichmentStrategyConfiguration CreateEnrichmentStrategyConfiguration()
    {
        var enrichmentStrategyConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.EnrichmentStrategyConfiguration();

        return enrichmentStrategyConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceEnrichmentStrategyConfigurationFactoryExtensions
{
}
