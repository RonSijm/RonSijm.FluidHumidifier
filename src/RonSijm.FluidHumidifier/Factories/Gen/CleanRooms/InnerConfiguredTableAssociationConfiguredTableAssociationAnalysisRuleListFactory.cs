// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleListFactory(Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRuleList> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRuleList>
{

    protected override Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRuleList Create()
    {
        var configuredTableAssociationAnalysisRuleListResult = CreateConfiguredTableAssociationAnalysisRuleList();
        factoryAction?.Invoke(configuredTableAssociationAnalysisRuleListResult);

        return configuredTableAssociationAnalysisRuleListResult;
    }

    private Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRuleList CreateConfiguredTableAssociationAnalysisRuleList()
    {
        var configuredTableAssociationAnalysisRuleListResult = new Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRuleList();

        return configuredTableAssociationAnalysisRuleListResult;
    }

} // End Of Class

public static class InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleListFactoryExtensions
{
}
