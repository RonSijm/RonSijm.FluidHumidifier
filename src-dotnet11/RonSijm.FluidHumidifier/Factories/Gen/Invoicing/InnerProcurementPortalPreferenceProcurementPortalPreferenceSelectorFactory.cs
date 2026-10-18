// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Invoicing;

public class InnerProcurementPortalPreferenceProcurementPortalPreferenceSelectorFactory(Action<Humidifier.Invoicing.ProcurementPortalPreferenceTypes.ProcurementPortalPreferenceSelector> factoryAction = null) : SubResourceFactory<Humidifier.Invoicing.ProcurementPortalPreferenceTypes.ProcurementPortalPreferenceSelector>
{

    protected override Humidifier.Invoicing.ProcurementPortalPreferenceTypes.ProcurementPortalPreferenceSelector Create()
    {
        var procurementPortalPreferenceSelectorResult = CreateProcurementPortalPreferenceSelector();
        factoryAction?.Invoke(procurementPortalPreferenceSelectorResult);

        return procurementPortalPreferenceSelectorResult;
    }

    private Humidifier.Invoicing.ProcurementPortalPreferenceTypes.ProcurementPortalPreferenceSelector CreateProcurementPortalPreferenceSelector()
    {
        var procurementPortalPreferenceSelectorResult = new Humidifier.Invoicing.ProcurementPortalPreferenceTypes.ProcurementPortalPreferenceSelector();

        return procurementPortalPreferenceSelectorResult;
    }

} // End Of Class

public static class InnerProcurementPortalPreferenceProcurementPortalPreferenceSelectorFactoryExtensions
{
}
