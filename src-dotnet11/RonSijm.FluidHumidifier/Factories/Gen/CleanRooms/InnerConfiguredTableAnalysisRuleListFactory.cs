// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerConfiguredTableAnalysisRuleListFactory(Action<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRuleList> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRuleList>
{

    protected override Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRuleList Create()
    {
        var analysisRuleListResult = CreateAnalysisRuleList();
        factoryAction?.Invoke(analysisRuleListResult);

        return analysisRuleListResult;
    }

    private Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRuleList CreateAnalysisRuleList()
    {
        var analysisRuleListResult = new Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRuleList();

        return analysisRuleListResult;
    }

} // End Of Class

public static class InnerConfiguredTableAnalysisRuleListFactoryExtensions
{
}
