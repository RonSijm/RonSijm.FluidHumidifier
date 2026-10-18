// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BillingConductor;

public class InnerCustomLineItemPresentationDetailsFactory(Action<Humidifier.BillingConductor.CustomLineItemTypes.PresentationDetails> factoryAction = null) : SubResourceFactory<Humidifier.BillingConductor.CustomLineItemTypes.PresentationDetails>
{

    protected override Humidifier.BillingConductor.CustomLineItemTypes.PresentationDetails Create()
    {
        var presentationDetailsResult = CreatePresentationDetails();
        factoryAction?.Invoke(presentationDetailsResult);

        return presentationDetailsResult;
    }

    private Humidifier.BillingConductor.CustomLineItemTypes.PresentationDetails CreatePresentationDetails()
    {
        var presentationDetailsResult = new Humidifier.BillingConductor.CustomLineItemTypes.PresentationDetails();

        return presentationDetailsResult;
    }

} // End Of Class

public static class InnerCustomLineItemPresentationDetailsFactoryExtensions
{
}
