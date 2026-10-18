// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Billing;

public class InnerBillingViewTimeRangeFactory(Action<Humidifier.Billing.BillingViewTypes.TimeRange> factoryAction = null) : SubResourceFactory<Humidifier.Billing.BillingViewTypes.TimeRange>
{

    protected override Humidifier.Billing.BillingViewTypes.TimeRange Create()
    {
        var timeRangeResult = CreateTimeRange();
        factoryAction?.Invoke(timeRangeResult);

        return timeRangeResult;
    }

    private Humidifier.Billing.BillingViewTypes.TimeRange CreateTimeRange()
    {
        var timeRangeResult = new Humidifier.Billing.BillingViewTypes.TimeRange();

        return timeRangeResult;
    }

} // End Of Class

public static class InnerBillingViewTimeRangeFactoryExtensions
{
}
