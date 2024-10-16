// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class SolutionFactory(string resourceName = null, Action<Humidifier.Personalize.Solution> factoryAction = null) : ResourceFactory<Humidifier.Personalize.Solution>(resourceName)
{

    internal InnerSolutionSolutionConfigFactory SolutionConfigFactory { get; set; }

    protected override Humidifier.Personalize.Solution Create()
    {
        var solutionResult = CreateSolution();
        factoryAction?.Invoke(solutionResult);

        return solutionResult;
    }

    private Humidifier.Personalize.Solution CreateSolution()
    {
        var solutionResult = new Humidifier.Personalize.Solution
        {
            GivenName = InputResourceName,
        };

        return solutionResult;
    }
    public override void CreateChildren(Humidifier.Personalize.Solution result)
    {
        base.CreateChildren(result);

        result.SolutionConfig ??= SolutionConfigFactory?.Build();
    }

} // End Of Class

public static class SolutionFactoryExtensions
{
    public static CombinedResult<SolutionFactory, InnerSolutionSolutionConfigFactory> WithSolutionConfig(this SolutionFactory parentFactory, Action<Humidifier.Personalize.SolutionTypes.SolutionConfig> subFactoryAction = null)
    {
        parentFactory.SolutionConfigFactory = new InnerSolutionSolutionConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SolutionConfigFactory);
    }

    public static CombinedResult<SolutionFactory, T1, InnerSolutionSolutionConfigFactory> WithSolutionConfig<T1>(this CombinedResult<SolutionFactory, T1> combinedResult, Action<Humidifier.Personalize.SolutionTypes.SolutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSolutionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SolutionFactory, InnerSolutionSolutionConfigFactory> WithSolutionConfig<T1>(this CombinedResult<T1, SolutionFactory> combinedResult, Action<Humidifier.Personalize.SolutionTypes.SolutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSolutionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SolutionFactory, T1, T2, InnerSolutionSolutionConfigFactory> WithSolutionConfig<T1, T2>(this CombinedResult<SolutionFactory, T1, T2> combinedResult, Action<Humidifier.Personalize.SolutionTypes.SolutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSolutionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SolutionFactory, T2, InnerSolutionSolutionConfigFactory> WithSolutionConfig<T1, T2>(this CombinedResult<T1, SolutionFactory, T2> combinedResult, Action<Humidifier.Personalize.SolutionTypes.SolutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSolutionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SolutionFactory, InnerSolutionSolutionConfigFactory> WithSolutionConfig<T1, T2>(this CombinedResult<T1, T2, SolutionFactory> combinedResult, Action<Humidifier.Personalize.SolutionTypes.SolutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSolutionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SolutionFactory, T1, T2, T3, InnerSolutionSolutionConfigFactory> WithSolutionConfig<T1, T2, T3>(this CombinedResult<SolutionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Personalize.SolutionTypes.SolutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSolutionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SolutionFactory, T2, T3, InnerSolutionSolutionConfigFactory> WithSolutionConfig<T1, T2, T3>(this CombinedResult<T1, SolutionFactory, T2, T3> combinedResult, Action<Humidifier.Personalize.SolutionTypes.SolutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSolutionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SolutionFactory, T3, InnerSolutionSolutionConfigFactory> WithSolutionConfig<T1, T2, T3>(this CombinedResult<T1, T2, SolutionFactory, T3> combinedResult, Action<Humidifier.Personalize.SolutionTypes.SolutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSolutionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SolutionFactory, InnerSolutionSolutionConfigFactory> WithSolutionConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, SolutionFactory> combinedResult, Action<Humidifier.Personalize.SolutionTypes.SolutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSolutionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SolutionFactory, T1, T2, T3, T4, InnerSolutionSolutionConfigFactory> WithSolutionConfig<T1, T2, T3, T4>(this CombinedResult<SolutionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.SolutionTypes.SolutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSolutionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SolutionFactory, T2, T3, T4, InnerSolutionSolutionConfigFactory> WithSolutionConfig<T1, T2, T3, T4>(this CombinedResult<T1, SolutionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.SolutionTypes.SolutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSolutionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SolutionFactory, T3, T4, InnerSolutionSolutionConfigFactory> WithSolutionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, SolutionFactory, T3, T4> combinedResult, Action<Humidifier.Personalize.SolutionTypes.SolutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSolutionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SolutionFactory, T4, InnerSolutionSolutionConfigFactory> WithSolutionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SolutionFactory, T4> combinedResult, Action<Humidifier.Personalize.SolutionTypes.SolutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSolutionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SolutionFactory, InnerSolutionSolutionConfigFactory> WithSolutionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SolutionFactory> combinedResult, Action<Humidifier.Personalize.SolutionTypes.SolutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSolutionConfig(combinedResult.T5, subFactoryAction));
}
