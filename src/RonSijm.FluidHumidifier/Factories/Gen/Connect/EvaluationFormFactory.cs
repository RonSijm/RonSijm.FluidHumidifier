// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class EvaluationFormFactory(string resourceName = null, Action<Humidifier.Connect.EvaluationForm> factoryAction = null) : ResourceFactory<Humidifier.Connect.EvaluationForm>(resourceName)
{

    internal List<InnerEvaluationFormEvaluationFormBaseItemFactory> ItemsFactories { get; set; } = [];

    internal InnerEvaluationFormScoringStrategyFactory ScoringStrategyFactory { get; set; }

    protected override Humidifier.Connect.EvaluationForm Create()
    {
        var evaluationFormResult = CreateEvaluationForm();
        factoryAction?.Invoke(evaluationFormResult);

        return evaluationFormResult;
    }

    private Humidifier.Connect.EvaluationForm CreateEvaluationForm()
    {
        var evaluationFormResult = new Humidifier.Connect.EvaluationForm
        {
            GivenName = InputResourceName,
        };

        return evaluationFormResult;
    }
    public override void CreateChildren(Humidifier.Connect.EvaluationForm result)
    {
        base.CreateChildren(result);

        result.Items = ItemsFactories.Any() ? ItemsFactories.Select(x => x.Build()).ToList() : null;
        result.ScoringStrategy ??= ScoringStrategyFactory?.Build();
    }

} // End Of Class

public static class EvaluationFormFactoryExtensions
{
    public static CombinedResult<EvaluationFormFactory, InnerEvaluationFormEvaluationFormBaseItemFactory> WithItems(this EvaluationFormFactory parentFactory, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormBaseItem> subFactoryAction = null)
    {
        var factory = new InnerEvaluationFormEvaluationFormBaseItemFactory(subFactoryAction);
        parentFactory.ItemsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<EvaluationFormFactory, InnerEvaluationFormScoringStrategyFactory> WithScoringStrategy(this EvaluationFormFactory parentFactory, Action<Humidifier.Connect.EvaluationFormTypes.ScoringStrategy> subFactoryAction = null)
    {
        parentFactory.ScoringStrategyFactory = new InnerEvaluationFormScoringStrategyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScoringStrategyFactory);
    }

    public static CombinedResult<EvaluationFormFactory, T1, InnerEvaluationFormEvaluationFormBaseItemFactory> WithItems<T1>(this CombinedResult<EvaluationFormFactory, T1> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormBaseItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithItems(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EvaluationFormFactory, InnerEvaluationFormEvaluationFormBaseItemFactory> WithItems<T1>(this CombinedResult<T1, EvaluationFormFactory> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormBaseItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithItems(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EvaluationFormFactory, T1, T2, InnerEvaluationFormEvaluationFormBaseItemFactory> WithItems<T1, T2>(this CombinedResult<EvaluationFormFactory, T1, T2> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormBaseItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithItems(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EvaluationFormFactory, T2, InnerEvaluationFormEvaluationFormBaseItemFactory> WithItems<T1, T2>(this CombinedResult<T1, EvaluationFormFactory, T2> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormBaseItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithItems(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EvaluationFormFactory, InnerEvaluationFormEvaluationFormBaseItemFactory> WithItems<T1, T2>(this CombinedResult<T1, T2, EvaluationFormFactory> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormBaseItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithItems(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EvaluationFormFactory, T1, T2, T3, InnerEvaluationFormEvaluationFormBaseItemFactory> WithItems<T1, T2, T3>(this CombinedResult<EvaluationFormFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormBaseItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithItems(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EvaluationFormFactory, T2, T3, InnerEvaluationFormEvaluationFormBaseItemFactory> WithItems<T1, T2, T3>(this CombinedResult<T1, EvaluationFormFactory, T2, T3> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormBaseItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithItems(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EvaluationFormFactory, T3, InnerEvaluationFormEvaluationFormBaseItemFactory> WithItems<T1, T2, T3>(this CombinedResult<T1, T2, EvaluationFormFactory, T3> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormBaseItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithItems(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EvaluationFormFactory, InnerEvaluationFormEvaluationFormBaseItemFactory> WithItems<T1, T2, T3>(this CombinedResult<T1, T2, T3, EvaluationFormFactory> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormBaseItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithItems(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EvaluationFormFactory, T1, T2, T3, T4, InnerEvaluationFormEvaluationFormBaseItemFactory> WithItems<T1, T2, T3, T4>(this CombinedResult<EvaluationFormFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormBaseItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithItems(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EvaluationFormFactory, T2, T3, T4, InnerEvaluationFormEvaluationFormBaseItemFactory> WithItems<T1, T2, T3, T4>(this CombinedResult<T1, EvaluationFormFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormBaseItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithItems(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EvaluationFormFactory, T3, T4, InnerEvaluationFormEvaluationFormBaseItemFactory> WithItems<T1, T2, T3, T4>(this CombinedResult<T1, T2, EvaluationFormFactory, T3, T4> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormBaseItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithItems(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EvaluationFormFactory, T4, InnerEvaluationFormEvaluationFormBaseItemFactory> WithItems<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EvaluationFormFactory, T4> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormBaseItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithItems(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EvaluationFormFactory, InnerEvaluationFormEvaluationFormBaseItemFactory> WithItems<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EvaluationFormFactory> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormBaseItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithItems(combinedResult.T5, subFactoryAction));
    public static CombinedResult<EvaluationFormFactory, T1, InnerEvaluationFormScoringStrategyFactory> WithScoringStrategy<T1>(this CombinedResult<EvaluationFormFactory, T1> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, WithScoringStrategy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EvaluationFormFactory, InnerEvaluationFormScoringStrategyFactory> WithScoringStrategy<T1>(this CombinedResult<T1, EvaluationFormFactory> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, WithScoringStrategy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EvaluationFormFactory, T1, T2, InnerEvaluationFormScoringStrategyFactory> WithScoringStrategy<T1, T2>(this CombinedResult<EvaluationFormFactory, T1, T2> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScoringStrategy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EvaluationFormFactory, T2, InnerEvaluationFormScoringStrategyFactory> WithScoringStrategy<T1, T2>(this CombinedResult<T1, EvaluationFormFactory, T2> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScoringStrategy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EvaluationFormFactory, InnerEvaluationFormScoringStrategyFactory> WithScoringStrategy<T1, T2>(this CombinedResult<T1, T2, EvaluationFormFactory> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScoringStrategy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EvaluationFormFactory, T1, T2, T3, InnerEvaluationFormScoringStrategyFactory> WithScoringStrategy<T1, T2, T3>(this CombinedResult<EvaluationFormFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScoringStrategy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EvaluationFormFactory, T2, T3, InnerEvaluationFormScoringStrategyFactory> WithScoringStrategy<T1, T2, T3>(this CombinedResult<T1, EvaluationFormFactory, T2, T3> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScoringStrategy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EvaluationFormFactory, T3, InnerEvaluationFormScoringStrategyFactory> WithScoringStrategy<T1, T2, T3>(this CombinedResult<T1, T2, EvaluationFormFactory, T3> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScoringStrategy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EvaluationFormFactory, InnerEvaluationFormScoringStrategyFactory> WithScoringStrategy<T1, T2, T3>(this CombinedResult<T1, T2, T3, EvaluationFormFactory> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScoringStrategy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EvaluationFormFactory, T1, T2, T3, T4, InnerEvaluationFormScoringStrategyFactory> WithScoringStrategy<T1, T2, T3, T4>(this CombinedResult<EvaluationFormFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScoringStrategy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EvaluationFormFactory, T2, T3, T4, InnerEvaluationFormScoringStrategyFactory> WithScoringStrategy<T1, T2, T3, T4>(this CombinedResult<T1, EvaluationFormFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScoringStrategy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EvaluationFormFactory, T3, T4, InnerEvaluationFormScoringStrategyFactory> WithScoringStrategy<T1, T2, T3, T4>(this CombinedResult<T1, T2, EvaluationFormFactory, T3, T4> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScoringStrategy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EvaluationFormFactory, T4, InnerEvaluationFormScoringStrategyFactory> WithScoringStrategy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EvaluationFormFactory, T4> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScoringStrategy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EvaluationFormFactory, InnerEvaluationFormScoringStrategyFactory> WithScoringStrategy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EvaluationFormFactory> combinedResult, Action<Humidifier.Connect.EvaluationFormTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScoringStrategy(combinedResult.T5, subFactoryAction));
}
