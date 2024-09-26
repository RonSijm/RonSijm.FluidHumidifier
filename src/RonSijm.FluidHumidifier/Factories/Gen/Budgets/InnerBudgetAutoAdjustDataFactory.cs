// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Budgets;

public class InnerBudgetAutoAdjustDataFactory(Action<Humidifier.Budgets.BudgetTypes.AutoAdjustData> factoryAction = null) : SubResourceFactory<Humidifier.Budgets.BudgetTypes.AutoAdjustData>
{

    internal InnerBudgetHistoricalOptionsFactory HistoricalOptionsFactory { get; set; }

    protected override Humidifier.Budgets.BudgetTypes.AutoAdjustData Create()
    {
        var autoAdjustDataResult = CreateAutoAdjustData();
        factoryAction?.Invoke(autoAdjustDataResult);

        return autoAdjustDataResult;
    }

    private Humidifier.Budgets.BudgetTypes.AutoAdjustData CreateAutoAdjustData()
    {
        var autoAdjustDataResult = new Humidifier.Budgets.BudgetTypes.AutoAdjustData();

        return autoAdjustDataResult;
    }
    public override void CreateChildren(Humidifier.Budgets.BudgetTypes.AutoAdjustData result)
    {
        base.CreateChildren(result);

        result.HistoricalOptions ??= HistoricalOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerBudgetAutoAdjustDataFactoryExtensions
{
    public static CombinedResult<InnerBudgetAutoAdjustDataFactory, InnerBudgetHistoricalOptionsFactory> WithHistoricalOptions(this InnerBudgetAutoAdjustDataFactory parentFactory, Action<Humidifier.Budgets.BudgetTypes.HistoricalOptions> subFactoryAction = null)
    {
        parentFactory.HistoricalOptionsFactory = new InnerBudgetHistoricalOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HistoricalOptionsFactory);
    }

    public static CombinedResult<InnerBudgetAutoAdjustDataFactory, T1, InnerBudgetHistoricalOptionsFactory> WithHistoricalOptions<T1>(this CombinedResult<InnerBudgetAutoAdjustDataFactory, T1> combinedResult, Action<Humidifier.Budgets.BudgetTypes.HistoricalOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithHistoricalOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBudgetAutoAdjustDataFactory, InnerBudgetHistoricalOptionsFactory> WithHistoricalOptions<T1>(this CombinedResult<T1, InnerBudgetAutoAdjustDataFactory> combinedResult, Action<Humidifier.Budgets.BudgetTypes.HistoricalOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithHistoricalOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBudgetAutoAdjustDataFactory, T1, T2, InnerBudgetHistoricalOptionsFactory> WithHistoricalOptions<T1, T2>(this CombinedResult<InnerBudgetAutoAdjustDataFactory, T1, T2> combinedResult, Action<Humidifier.Budgets.BudgetTypes.HistoricalOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHistoricalOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBudgetAutoAdjustDataFactory, T2, InnerBudgetHistoricalOptionsFactory> WithHistoricalOptions<T1, T2>(this CombinedResult<T1, InnerBudgetAutoAdjustDataFactory, T2> combinedResult, Action<Humidifier.Budgets.BudgetTypes.HistoricalOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHistoricalOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBudgetAutoAdjustDataFactory, InnerBudgetHistoricalOptionsFactory> WithHistoricalOptions<T1, T2>(this CombinedResult<T1, T2, InnerBudgetAutoAdjustDataFactory> combinedResult, Action<Humidifier.Budgets.BudgetTypes.HistoricalOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHistoricalOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBudgetAutoAdjustDataFactory, T1, T2, T3, InnerBudgetHistoricalOptionsFactory> WithHistoricalOptions<T1, T2, T3>(this CombinedResult<InnerBudgetAutoAdjustDataFactory, T1, T2, T3> combinedResult, Action<Humidifier.Budgets.BudgetTypes.HistoricalOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHistoricalOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBudgetAutoAdjustDataFactory, T2, T3, InnerBudgetHistoricalOptionsFactory> WithHistoricalOptions<T1, T2, T3>(this CombinedResult<T1, InnerBudgetAutoAdjustDataFactory, T2, T3> combinedResult, Action<Humidifier.Budgets.BudgetTypes.HistoricalOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHistoricalOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBudgetAutoAdjustDataFactory, T3, InnerBudgetHistoricalOptionsFactory> WithHistoricalOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerBudgetAutoAdjustDataFactory, T3> combinedResult, Action<Humidifier.Budgets.BudgetTypes.HistoricalOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHistoricalOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBudgetAutoAdjustDataFactory, InnerBudgetHistoricalOptionsFactory> WithHistoricalOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBudgetAutoAdjustDataFactory> combinedResult, Action<Humidifier.Budgets.BudgetTypes.HistoricalOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHistoricalOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBudgetAutoAdjustDataFactory, T1, T2, T3, T4, InnerBudgetHistoricalOptionsFactory> WithHistoricalOptions<T1, T2, T3, T4>(this CombinedResult<InnerBudgetAutoAdjustDataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Budgets.BudgetTypes.HistoricalOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHistoricalOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBudgetAutoAdjustDataFactory, T2, T3, T4, InnerBudgetHistoricalOptionsFactory> WithHistoricalOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerBudgetAutoAdjustDataFactory, T2, T3, T4> combinedResult, Action<Humidifier.Budgets.BudgetTypes.HistoricalOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHistoricalOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBudgetAutoAdjustDataFactory, T3, T4, InnerBudgetHistoricalOptionsFactory> WithHistoricalOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBudgetAutoAdjustDataFactory, T3, T4> combinedResult, Action<Humidifier.Budgets.BudgetTypes.HistoricalOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHistoricalOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBudgetAutoAdjustDataFactory, T4, InnerBudgetHistoricalOptionsFactory> WithHistoricalOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBudgetAutoAdjustDataFactory, T4> combinedResult, Action<Humidifier.Budgets.BudgetTypes.HistoricalOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHistoricalOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBudgetAutoAdjustDataFactory, InnerBudgetHistoricalOptionsFactory> WithHistoricalOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBudgetAutoAdjustDataFactory> combinedResult, Action<Humidifier.Budgets.BudgetTypes.HistoricalOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHistoricalOptions(combinedResult.T5, subFactoryAction));
}
