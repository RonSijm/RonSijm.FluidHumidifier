// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerDataSourceRecommendationConfigurationFactory(Action<Humidifier.DataZone.DataSourceTypes.RecommendationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.DataSourceTypes.RecommendationConfiguration>
{

    protected override Humidifier.DataZone.DataSourceTypes.RecommendationConfiguration Create()
    {
        var recommendationConfigurationResult = CreateRecommendationConfiguration();
        factoryAction?.Invoke(recommendationConfigurationResult);

        return recommendationConfigurationResult;
    }

    private Humidifier.DataZone.DataSourceTypes.RecommendationConfiguration CreateRecommendationConfiguration()
    {
        var recommendationConfigurationResult = new Humidifier.DataZone.DataSourceTypes.RecommendationConfiguration();

        return recommendationConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceRecommendationConfigurationFactoryExtensions
{
}
