// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudTrail;

public class InnerTrailInsightSelectorFactory(Action<Humidifier.CloudTrail.TrailTypes.InsightSelector> factoryAction = null) : SubResourceFactory<Humidifier.CloudTrail.TrailTypes.InsightSelector>
{

    protected override Humidifier.CloudTrail.TrailTypes.InsightSelector Create()
    {
        var insightSelectorResult = CreateInsightSelector();
        factoryAction?.Invoke(insightSelectorResult);

        return insightSelectorResult;
    }

    private Humidifier.CloudTrail.TrailTypes.InsightSelector CreateInsightSelector()
    {
        var insightSelectorResult = new Humidifier.CloudTrail.TrailTypes.InsightSelector();

        return insightSelectorResult;
    }

} // End Of Class

public static class InnerTrailInsightSelectorFactoryExtensions
{
}
