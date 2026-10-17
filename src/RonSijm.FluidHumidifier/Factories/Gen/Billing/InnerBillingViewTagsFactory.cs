// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Billing;

public class InnerBillingViewTagsFactory(Action<Humidifier.Billing.BillingViewTypes.Tags> factoryAction = null) : SubResourceFactory<Humidifier.Billing.BillingViewTypes.Tags>
{

    protected override Humidifier.Billing.BillingViewTypes.Tags Create()
    {
        var tagsResult = CreateTags();
        factoryAction?.Invoke(tagsResult);

        return tagsResult;
    }

    private Humidifier.Billing.BillingViewTypes.Tags CreateTags()
    {
        var tagsResult = new Humidifier.Billing.BillingViewTypes.Tags();

        return tagsResult;
    }

} // End Of Class

public static class InnerBillingViewTagsFactoryExtensions
{
}
