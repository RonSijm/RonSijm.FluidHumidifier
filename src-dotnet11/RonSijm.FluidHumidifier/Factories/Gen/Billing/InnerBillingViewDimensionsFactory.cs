// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Billing;

public class InnerBillingViewDimensionsFactory(Action<Humidifier.Billing.BillingViewTypes.Dimensions> factoryAction = null) : SubResourceFactory<Humidifier.Billing.BillingViewTypes.Dimensions>
{

    protected override Humidifier.Billing.BillingViewTypes.Dimensions Create()
    {
        var dimensionsResult = CreateDimensions();
        factoryAction?.Invoke(dimensionsResult);

        return dimensionsResult;
    }

    private Humidifier.Billing.BillingViewTypes.Dimensions CreateDimensions()
    {
        var dimensionsResult = new Humidifier.Billing.BillingViewTypes.Dimensions();

        return dimensionsResult;
    }

} // End Of Class

public static class InnerBillingViewDimensionsFactoryExtensions
{
}
