// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerQuotaShareQuotaShareCapacityLimitFactory(Action<Humidifier.Batch.QuotaShareTypes.QuotaShareCapacityLimit> factoryAction = null) : SubResourceFactory<Humidifier.Batch.QuotaShareTypes.QuotaShareCapacityLimit>
{

    protected override Humidifier.Batch.QuotaShareTypes.QuotaShareCapacityLimit Create()
    {
        var quotaShareCapacityLimitResult = CreateQuotaShareCapacityLimit();
        factoryAction?.Invoke(quotaShareCapacityLimitResult);

        return quotaShareCapacityLimitResult;
    }

    private Humidifier.Batch.QuotaShareTypes.QuotaShareCapacityLimit CreateQuotaShareCapacityLimit()
    {
        var quotaShareCapacityLimitResult = new Humidifier.Batch.QuotaShareTypes.QuotaShareCapacityLimit();

        return quotaShareCapacityLimitResult;
    }

} // End Of Class

public static class InnerQuotaShareQuotaShareCapacityLimitFactoryExtensions
{
}
