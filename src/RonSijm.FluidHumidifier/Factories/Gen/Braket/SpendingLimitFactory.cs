// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Braket;

public class SpendingLimitFactory(string resourceName = null, Action<Humidifier.Braket.SpendingLimit> factoryAction = null) : ResourceFactory<Humidifier.Braket.SpendingLimit>(resourceName)
{

    internal InnerSpendingLimitTimePeriodFactory TimePeriodFactory { get; set; }

    protected override Humidifier.Braket.SpendingLimit Create()
    {
        var spendingLimitResult = CreateSpendingLimit();
        factoryAction?.Invoke(spendingLimitResult);

        return spendingLimitResult;
    }

    private Humidifier.Braket.SpendingLimit CreateSpendingLimit()
    {
        var spendingLimitResult = new Humidifier.Braket.SpendingLimit
        {
            GivenName = InputResourceName,
        };

        return spendingLimitResult;
    }
    public override void CreateChildren(Humidifier.Braket.SpendingLimit result)
    {
        base.CreateChildren(result);

        result.TimePeriod ??= TimePeriodFactory?.Build();
    }

} // End Of Class

public static class SpendingLimitFactoryExtensions
{
    public static CombinedResult<SpendingLimitFactory, InnerSpendingLimitTimePeriodFactory> WithTimePeriod(this SpendingLimitFactory parentFactory, Action<Humidifier.Braket.SpendingLimitTypes.TimePeriod> subFactoryAction = null)
    {
        parentFactory.TimePeriodFactory = new InnerSpendingLimitTimePeriodFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TimePeriodFactory);
    }

    public static CombinedResult<SpendingLimitFactory, T1, InnerSpendingLimitTimePeriodFactory> WithTimePeriod<T1>(this CombinedResult<SpendingLimitFactory, T1> combinedResult, Action<Humidifier.Braket.SpendingLimitTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimePeriod(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SpendingLimitFactory, InnerSpendingLimitTimePeriodFactory> WithTimePeriod<T1>(this CombinedResult<T1, SpendingLimitFactory> combinedResult, Action<Humidifier.Braket.SpendingLimitTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimePeriod(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SpendingLimitFactory, T1, T2, InnerSpendingLimitTimePeriodFactory> WithTimePeriod<T1, T2>(this CombinedResult<SpendingLimitFactory, T1, T2> combinedResult, Action<Humidifier.Braket.SpendingLimitTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimePeriod(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SpendingLimitFactory, T2, InnerSpendingLimitTimePeriodFactory> WithTimePeriod<T1, T2>(this CombinedResult<T1, SpendingLimitFactory, T2> combinedResult, Action<Humidifier.Braket.SpendingLimitTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimePeriod(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SpendingLimitFactory, InnerSpendingLimitTimePeriodFactory> WithTimePeriod<T1, T2>(this CombinedResult<T1, T2, SpendingLimitFactory> combinedResult, Action<Humidifier.Braket.SpendingLimitTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimePeriod(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SpendingLimitFactory, T1, T2, T3, InnerSpendingLimitTimePeriodFactory> WithTimePeriod<T1, T2, T3>(this CombinedResult<SpendingLimitFactory, T1, T2, T3> combinedResult, Action<Humidifier.Braket.SpendingLimitTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimePeriod(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SpendingLimitFactory, T2, T3, InnerSpendingLimitTimePeriodFactory> WithTimePeriod<T1, T2, T3>(this CombinedResult<T1, SpendingLimitFactory, T2, T3> combinedResult, Action<Humidifier.Braket.SpendingLimitTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimePeriod(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SpendingLimitFactory, T3, InnerSpendingLimitTimePeriodFactory> WithTimePeriod<T1, T2, T3>(this CombinedResult<T1, T2, SpendingLimitFactory, T3> combinedResult, Action<Humidifier.Braket.SpendingLimitTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimePeriod(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SpendingLimitFactory, InnerSpendingLimitTimePeriodFactory> WithTimePeriod<T1, T2, T3>(this CombinedResult<T1, T2, T3, SpendingLimitFactory> combinedResult, Action<Humidifier.Braket.SpendingLimitTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimePeriod(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SpendingLimitFactory, T1, T2, T3, T4, InnerSpendingLimitTimePeriodFactory> WithTimePeriod<T1, T2, T3, T4>(this CombinedResult<SpendingLimitFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Braket.SpendingLimitTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimePeriod(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SpendingLimitFactory, T2, T3, T4, InnerSpendingLimitTimePeriodFactory> WithTimePeriod<T1, T2, T3, T4>(this CombinedResult<T1, SpendingLimitFactory, T2, T3, T4> combinedResult, Action<Humidifier.Braket.SpendingLimitTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimePeriod(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SpendingLimitFactory, T3, T4, InnerSpendingLimitTimePeriodFactory> WithTimePeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, SpendingLimitFactory, T3, T4> combinedResult, Action<Humidifier.Braket.SpendingLimitTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimePeriod(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SpendingLimitFactory, T4, InnerSpendingLimitTimePeriodFactory> WithTimePeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SpendingLimitFactory, T4> combinedResult, Action<Humidifier.Braket.SpendingLimitTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimePeriod(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SpendingLimitFactory, InnerSpendingLimitTimePeriodFactory> WithTimePeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SpendingLimitFactory> combinedResult, Action<Humidifier.Braket.SpendingLimitTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimePeriod(combinedResult.T5, subFactoryAction).T2);
}
