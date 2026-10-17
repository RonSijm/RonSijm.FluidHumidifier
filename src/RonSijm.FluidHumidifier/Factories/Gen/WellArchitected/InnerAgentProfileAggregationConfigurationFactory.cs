// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WellArchitected;

public class InnerAgentProfileAggregationConfigurationFactory(Action<Humidifier.WellArchitected.AgentProfileTypes.AggregationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.WellArchitected.AgentProfileTypes.AggregationConfiguration>
{

    protected override Humidifier.WellArchitected.AgentProfileTypes.AggregationConfiguration Create()
    {
        var aggregationConfigurationResult = CreateAggregationConfiguration();
        factoryAction?.Invoke(aggregationConfigurationResult);

        return aggregationConfigurationResult;
    }

    private Humidifier.WellArchitected.AgentProfileTypes.AggregationConfiguration CreateAggregationConfiguration()
    {
        var aggregationConfigurationResult = new Humidifier.WellArchitected.AgentProfileTypes.AggregationConfiguration();

        return aggregationConfigurationResult;
    }

} // End Of Class

public static class InnerAgentProfileAggregationConfigurationFactoryExtensions
{
}
