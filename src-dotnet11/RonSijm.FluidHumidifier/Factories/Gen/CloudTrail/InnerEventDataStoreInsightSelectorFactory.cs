// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudTrail;

public class InnerEventDataStoreInsightSelectorFactory(Action<Humidifier.CloudTrail.EventDataStoreTypes.InsightSelector> factoryAction = null) : SubResourceFactory<Humidifier.CloudTrail.EventDataStoreTypes.InsightSelector>
{

    protected override Humidifier.CloudTrail.EventDataStoreTypes.InsightSelector Create()
    {
        var insightSelectorResult = CreateInsightSelector();
        factoryAction?.Invoke(insightSelectorResult);

        return insightSelectorResult;
    }

    private Humidifier.CloudTrail.EventDataStoreTypes.InsightSelector CreateInsightSelector()
    {
        var insightSelectorResult = new Humidifier.CloudTrail.EventDataStoreTypes.InsightSelector();

        return insightSelectorResult;
    }

} // End Of Class

public static class InnerEventDataStoreInsightSelectorFactoryExtensions
{
}
