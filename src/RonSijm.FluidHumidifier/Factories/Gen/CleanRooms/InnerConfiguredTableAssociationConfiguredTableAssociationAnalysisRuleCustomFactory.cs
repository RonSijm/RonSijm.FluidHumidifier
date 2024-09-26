// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleCustomFactory(Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRuleCustom> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRuleCustom>
{

    protected override Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRuleCustom Create()
    {
        var configuredTableAssociationAnalysisRuleCustomResult = CreateConfiguredTableAssociationAnalysisRuleCustom();
        factoryAction?.Invoke(configuredTableAssociationAnalysisRuleCustomResult);

        return configuredTableAssociationAnalysisRuleCustomResult;
    }

    private Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRuleCustom CreateConfiguredTableAssociationAnalysisRuleCustom()
    {
        var configuredTableAssociationAnalysisRuleCustomResult = new Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRuleCustom();

        return configuredTableAssociationAnalysisRuleCustomResult;
    }

} // End Of Class

public static class InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleCustomFactoryExtensions
{
}
