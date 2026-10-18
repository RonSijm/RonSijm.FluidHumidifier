// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudTrail;

public class InnerTrailAggregationConfigurationFactory(Action<Humidifier.CloudTrail.TrailTypes.AggregationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CloudTrail.TrailTypes.AggregationConfiguration>
{

    protected override Humidifier.CloudTrail.TrailTypes.AggregationConfiguration Create()
    {
        var aggregationConfigurationResult = CreateAggregationConfiguration();
        factoryAction?.Invoke(aggregationConfigurationResult);

        return aggregationConfigurationResult;
    }

    private Humidifier.CloudTrail.TrailTypes.AggregationConfiguration CreateAggregationConfiguration()
    {
        var aggregationConfigurationResult = new Humidifier.CloudTrail.TrailTypes.AggregationConfiguration();

        return aggregationConfigurationResult;
    }

} // End Of Class

public static class InnerTrailAggregationConfigurationFactoryExtensions
{
}
