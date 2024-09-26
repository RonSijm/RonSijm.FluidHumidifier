// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerGraphQLApiEnhancedMetricsConfigFactory(Action<Humidifier.AppSync.GraphQLApiTypes.EnhancedMetricsConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.GraphQLApiTypes.EnhancedMetricsConfig>
{

    protected override Humidifier.AppSync.GraphQLApiTypes.EnhancedMetricsConfig Create()
    {
        var enhancedMetricsConfigResult = CreateEnhancedMetricsConfig();
        factoryAction?.Invoke(enhancedMetricsConfigResult);

        return enhancedMetricsConfigResult;
    }

    private Humidifier.AppSync.GraphQLApiTypes.EnhancedMetricsConfig CreateEnhancedMetricsConfig()
    {
        var enhancedMetricsConfigResult = new Humidifier.AppSync.GraphQLApiTypes.EnhancedMetricsConfig();

        return enhancedMetricsConfigResult;
    }

} // End Of Class

public static class InnerGraphQLApiEnhancedMetricsConfigFactoryExtensions
{
}
