// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Invoicing;

public class InnerInvoiceUnitResourceTagFactory(Action<Humidifier.Invoicing.InvoiceUnitTypes.ResourceTag> factoryAction = null) : SubResourceFactory<Humidifier.Invoicing.InvoiceUnitTypes.ResourceTag>
{

    protected override Humidifier.Invoicing.InvoiceUnitTypes.ResourceTag Create()
    {
        var resourceTagResult = CreateResourceTag();
        factoryAction?.Invoke(resourceTagResult);

        return resourceTagResult;
    }

    private Humidifier.Invoicing.InvoiceUnitTypes.ResourceTag CreateResourceTag()
    {
        var resourceTagResult = new Humidifier.Invoicing.InvoiceUnitTypes.ResourceTag();

        return resourceTagResult;
    }

} // End Of Class

public static class InnerInvoiceUnitResourceTagFactoryExtensions
{
}
