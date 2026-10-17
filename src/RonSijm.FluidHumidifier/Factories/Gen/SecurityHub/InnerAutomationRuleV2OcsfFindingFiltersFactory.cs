// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class InnerAutomationRuleV2OcsfFindingFiltersFactory(Action<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfFindingFilters> factoryAction = null) : SubResourceFactory<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfFindingFilters>
{

    protected override Humidifier.SecurityHub.AutomationRuleV2Types.OcsfFindingFilters Create()
    {
        var ocsfFindingFiltersResult = CreateOcsfFindingFilters();
        factoryAction?.Invoke(ocsfFindingFiltersResult);

        return ocsfFindingFiltersResult;
    }

    private Humidifier.SecurityHub.AutomationRuleV2Types.OcsfFindingFilters CreateOcsfFindingFilters()
    {
        var ocsfFindingFiltersResult = new Humidifier.SecurityHub.AutomationRuleV2Types.OcsfFindingFilters();

        return ocsfFindingFiltersResult;
    }

} // End Of Class

public static class InnerAutomationRuleV2OcsfFindingFiltersFactoryExtensions
{
}
