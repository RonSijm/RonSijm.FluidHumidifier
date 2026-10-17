// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Invoicing;

public class InnerProcurementPortalPreferenceEinvoiceDeliveryPreferenceFactory(Action<Humidifier.Invoicing.ProcurementPortalPreferenceTypes.EinvoiceDeliveryPreference> factoryAction = null) : SubResourceFactory<Humidifier.Invoicing.ProcurementPortalPreferenceTypes.EinvoiceDeliveryPreference>
{

    protected override Humidifier.Invoicing.ProcurementPortalPreferenceTypes.EinvoiceDeliveryPreference Create()
    {
        var einvoiceDeliveryPreferenceResult = CreateEinvoiceDeliveryPreference();
        factoryAction?.Invoke(einvoiceDeliveryPreferenceResult);

        return einvoiceDeliveryPreferenceResult;
    }

    private Humidifier.Invoicing.ProcurementPortalPreferenceTypes.EinvoiceDeliveryPreference CreateEinvoiceDeliveryPreference()
    {
        var einvoiceDeliveryPreferenceResult = new Humidifier.Invoicing.ProcurementPortalPreferenceTypes.EinvoiceDeliveryPreference();

        return einvoiceDeliveryPreferenceResult;
    }

} // End Of Class

public static class InnerProcurementPortalPreferenceEinvoiceDeliveryPreferenceFactoryExtensions
{
}
