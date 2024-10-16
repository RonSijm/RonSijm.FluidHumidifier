// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerConfiguredTableAnalysisRuleAggregationFactory(Action<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRuleAggregation> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRuleAggregation>
{

    protected override Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRuleAggregation Create()
    {
        var analysisRuleAggregationResult = CreateAnalysisRuleAggregation();
        factoryAction?.Invoke(analysisRuleAggregationResult);

        return analysisRuleAggregationResult;
    }

    private Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRuleAggregation CreateAnalysisRuleAggregation()
    {
        var analysisRuleAggregationResult = new Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRuleAggregation();

        return analysisRuleAggregationResult;
    }

} // End Of Class

public static class InnerConfiguredTableAnalysisRuleAggregationFactoryExtensions
{
}
