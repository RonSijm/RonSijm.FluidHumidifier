// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory(Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector>
{

    protected override Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector Create()
    {
        var oTelEnrichmentMetricSelectorResult = CreateOTelEnrichmentMetricSelector();
        factoryAction?.Invoke(oTelEnrichmentMetricSelectorResult);

        return oTelEnrichmentMetricSelectorResult;
    }

    private Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector CreateOTelEnrichmentMetricSelector()
    {
        var oTelEnrichmentMetricSelectorResult = new Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector();

        return oTelEnrichmentMetricSelectorResult;
    }

} // End Of Class

public static class InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactoryExtensions
{
}
