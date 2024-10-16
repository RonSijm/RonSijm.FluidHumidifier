// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleAggregationFactory(Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRuleAggregation> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRuleAggregation>
{

    protected override Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRuleAggregation Create()
    {
        var configuredTableAssociationAnalysisRuleAggregationResult = CreateConfiguredTableAssociationAnalysisRuleAggregation();
        factoryAction?.Invoke(configuredTableAssociationAnalysisRuleAggregationResult);

        return configuredTableAssociationAnalysisRuleAggregationResult;
    }

    private Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRuleAggregation CreateConfiguredTableAssociationAnalysisRuleAggregation()
    {
        var configuredTableAssociationAnalysisRuleAggregationResult = new Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRuleAggregation();

        return configuredTableAssociationAnalysisRuleAggregationResult;
    }

} // End Of Class

public static class InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleAggregationFactoryExtensions
{
}
