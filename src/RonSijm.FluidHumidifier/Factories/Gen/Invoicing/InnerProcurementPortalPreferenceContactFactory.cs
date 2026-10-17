// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Invoicing;

public class InnerProcurementPortalPreferenceContactFactory(Action<Humidifier.Invoicing.ProcurementPortalPreferenceTypes.Contact> factoryAction = null) : SubResourceFactory<Humidifier.Invoicing.ProcurementPortalPreferenceTypes.Contact>
{

    protected override Humidifier.Invoicing.ProcurementPortalPreferenceTypes.Contact Create()
    {
        var contactResult = CreateContact();
        factoryAction?.Invoke(contactResult);

        return contactResult;
    }

    private Humidifier.Invoicing.ProcurementPortalPreferenceTypes.Contact CreateContact()
    {
        var contactResult = new Humidifier.Invoicing.ProcurementPortalPreferenceTypes.Contact();

        return contactResult;
    }

} // End Of Class

public static class InnerProcurementPortalPreferenceContactFactoryExtensions
{
}
