// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class InnerConfigurationAggregatorOrganizationAggregationSourceFactory(Action<Humidifier.Config.ConfigurationAggregatorTypes.OrganizationAggregationSource> factoryAction = null) : SubResourceFactory<Humidifier.Config.ConfigurationAggregatorTypes.OrganizationAggregationSource>
{

    protected override Humidifier.Config.ConfigurationAggregatorTypes.OrganizationAggregationSource Create()
    {
        var organizationAggregationSourceResult = CreateOrganizationAggregationSource();
        factoryAction?.Invoke(organizationAggregationSourceResult);

        return organizationAggregationSourceResult;
    }

    private Humidifier.Config.ConfigurationAggregatorTypes.OrganizationAggregationSource CreateOrganizationAggregationSource()
    {
        var organizationAggregationSourceResult = new Humidifier.Config.ConfigurationAggregatorTypes.OrganizationAggregationSource();

        return organizationAggregationSourceResult;
    }

} // End Of Class

public static class InnerConfigurationAggregatorOrganizationAggregationSourceFactoryExtensions
{
}
