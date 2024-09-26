// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class InnerSolutionSolutionConfigFactory(Action<Humidifier.Personalize.SolutionTypes.SolutionConfig> factoryAction = null) : SubResourceFactory<Humidifier.Personalize.SolutionTypes.SolutionConfig>
{

    internal InnerSolutionHpoConfigFactory HpoConfigFactory { get; set; }

    internal InnerSolutionAutoMLConfigFactory AutoMLConfigFactory { get; set; }

    protected override Humidifier.Personalize.SolutionTypes.SolutionConfig Create()
    {
        var solutionConfigResult = CreateSolutionConfig();
        factoryAction?.Invoke(solutionConfigResult);

        return solutionConfigResult;
    }

    private Humidifier.Personalize.SolutionTypes.SolutionConfig CreateSolutionConfig()
    {
        var solutionConfigResult = new Humidifier.Personalize.SolutionTypes.SolutionConfig();

        return solutionConfigResult;
    }
    public override void CreateChildren(Humidifier.Personalize.SolutionTypes.SolutionConfig result)
    {
        base.CreateChildren(result);

        result.HpoConfig ??= HpoConfigFactory?.Build();
        result.AutoMLConfig ??= AutoMLConfigFactory?.Build();
    }

} // End Of Class

public static class InnerSolutionSolutionConfigFactoryExtensions
{
    public static CombinedResult<InnerSolutionSolutionConfigFactory, InnerSolutionHpoConfigFactory> WithHpoConfig(this InnerSolutionSolutionConfigFactory parentFactory, Action<Humidifier.Personalize.SolutionTypes.HpoConfig> subFactoryAction = null)
    {
        parentFactory.HpoConfigFactory = new InnerSolutionHpoConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HpoConfigFactory);
    }

    public static CombinedResult<InnerSolutionSolutionConfigFactory, InnerSolutionAutoMLConfigFactory> WithAutoMLConfig(this InnerSolutionSolutionConfigFactory parentFactory, Action<Humidifier.Personalize.SolutionTypes.AutoMLConfig> subFactoryAction = null)
    {
        parentFactory.AutoMLConfigFactory = new InnerSolutionAutoMLConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AutoMLConfigFactory);
    }

    public static CombinedResult<InnerSolutionSolutionConfigFactory, T1, InnerSolutionHpoConfigFactory> WithHpoConfig<T1>(this CombinedResult<InnerSolutionSolutionConfigFactory, T1> combinedResult, Action<Humidifier.Personalize.SolutionTypes.HpoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHpoConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSolutionSolutionConfigFactory, InnerSolutionHpoConfigFactory> WithHpoConfig<T1>(this CombinedResult<T1, InnerSolutionSolutionConfigFactory> combinedResult, Action<Humidifier.Personalize.SolutionTypes.HpoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHpoConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSolutionSolutionConfigFactory, T1, T2, InnerSolutionHpoConfigFactory> WithHpoConfig<T1, T2>(this CombinedResult<InnerSolutionSolutionConfigFactory, T1, T2> combinedResult, Action<Humidifier.Personalize.SolutionTypes.HpoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHpoConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSolutionSolutionConfigFactory, T2, InnerSolutionHpoConfigFactory> WithHpoConfig<T1, T2>(this CombinedResult<T1, InnerSolutionSolutionConfigFactory, T2> combinedResult, Action<Humidifier.Personalize.SolutionTypes.HpoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHpoConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSolutionSolutionConfigFactory, InnerSolutionHpoConfigFactory> WithHpoConfig<T1, T2>(this CombinedResult<T1, T2, InnerSolutionSolutionConfigFactory> combinedResult, Action<Humidifier.Personalize.SolutionTypes.HpoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHpoConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSolutionSolutionConfigFactory, T1, T2, T3, InnerSolutionHpoConfigFactory> WithHpoConfig<T1, T2, T3>(this CombinedResult<InnerSolutionSolutionConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Personalize.SolutionTypes.HpoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHpoConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSolutionSolutionConfigFactory, T2, T3, InnerSolutionHpoConfigFactory> WithHpoConfig<T1, T2, T3>(this CombinedResult<T1, InnerSolutionSolutionConfigFactory, T2, T3> combinedResult, Action<Humidifier.Personalize.SolutionTypes.HpoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHpoConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSolutionSolutionConfigFactory, T3, InnerSolutionHpoConfigFactory> WithHpoConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerSolutionSolutionConfigFactory, T3> combinedResult, Action<Humidifier.Personalize.SolutionTypes.HpoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHpoConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSolutionSolutionConfigFactory, InnerSolutionHpoConfigFactory> WithHpoConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSolutionSolutionConfigFactory> combinedResult, Action<Humidifier.Personalize.SolutionTypes.HpoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHpoConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSolutionSolutionConfigFactory, T1, T2, T3, T4, InnerSolutionHpoConfigFactory> WithHpoConfig<T1, T2, T3, T4>(this CombinedResult<InnerSolutionSolutionConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.SolutionTypes.HpoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHpoConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSolutionSolutionConfigFactory, T2, T3, T4, InnerSolutionHpoConfigFactory> WithHpoConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerSolutionSolutionConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.SolutionTypes.HpoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHpoConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSolutionSolutionConfigFactory, T3, T4, InnerSolutionHpoConfigFactory> WithHpoConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSolutionSolutionConfigFactory, T3, T4> combinedResult, Action<Humidifier.Personalize.SolutionTypes.HpoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHpoConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSolutionSolutionConfigFactory, T4, InnerSolutionHpoConfigFactory> WithHpoConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSolutionSolutionConfigFactory, T4> combinedResult, Action<Humidifier.Personalize.SolutionTypes.HpoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHpoConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSolutionSolutionConfigFactory, InnerSolutionHpoConfigFactory> WithHpoConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSolutionSolutionConfigFactory> combinedResult, Action<Humidifier.Personalize.SolutionTypes.HpoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHpoConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerSolutionSolutionConfigFactory, T1, InnerSolutionAutoMLConfigFactory> WithAutoMLConfig<T1>(this CombinedResult<InnerSolutionSolutionConfigFactory, T1> combinedResult, Action<Humidifier.Personalize.SolutionTypes.AutoMLConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAutoMLConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSolutionSolutionConfigFactory, InnerSolutionAutoMLConfigFactory> WithAutoMLConfig<T1>(this CombinedResult<T1, InnerSolutionSolutionConfigFactory> combinedResult, Action<Humidifier.Personalize.SolutionTypes.AutoMLConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAutoMLConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSolutionSolutionConfigFactory, T1, T2, InnerSolutionAutoMLConfigFactory> WithAutoMLConfig<T1, T2>(this CombinedResult<InnerSolutionSolutionConfigFactory, T1, T2> combinedResult, Action<Humidifier.Personalize.SolutionTypes.AutoMLConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoMLConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSolutionSolutionConfigFactory, T2, InnerSolutionAutoMLConfigFactory> WithAutoMLConfig<T1, T2>(this CombinedResult<T1, InnerSolutionSolutionConfigFactory, T2> combinedResult, Action<Humidifier.Personalize.SolutionTypes.AutoMLConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoMLConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSolutionSolutionConfigFactory, InnerSolutionAutoMLConfigFactory> WithAutoMLConfig<T1, T2>(this CombinedResult<T1, T2, InnerSolutionSolutionConfigFactory> combinedResult, Action<Humidifier.Personalize.SolutionTypes.AutoMLConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoMLConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSolutionSolutionConfigFactory, T1, T2, T3, InnerSolutionAutoMLConfigFactory> WithAutoMLConfig<T1, T2, T3>(this CombinedResult<InnerSolutionSolutionConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Personalize.SolutionTypes.AutoMLConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoMLConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSolutionSolutionConfigFactory, T2, T3, InnerSolutionAutoMLConfigFactory> WithAutoMLConfig<T1, T2, T3>(this CombinedResult<T1, InnerSolutionSolutionConfigFactory, T2, T3> combinedResult, Action<Humidifier.Personalize.SolutionTypes.AutoMLConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoMLConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSolutionSolutionConfigFactory, T3, InnerSolutionAutoMLConfigFactory> WithAutoMLConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerSolutionSolutionConfigFactory, T3> combinedResult, Action<Humidifier.Personalize.SolutionTypes.AutoMLConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoMLConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSolutionSolutionConfigFactory, InnerSolutionAutoMLConfigFactory> WithAutoMLConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSolutionSolutionConfigFactory> combinedResult, Action<Humidifier.Personalize.SolutionTypes.AutoMLConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoMLConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSolutionSolutionConfigFactory, T1, T2, T3, T4, InnerSolutionAutoMLConfigFactory> WithAutoMLConfig<T1, T2, T3, T4>(this CombinedResult<InnerSolutionSolutionConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.SolutionTypes.AutoMLConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoMLConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSolutionSolutionConfigFactory, T2, T3, T4, InnerSolutionAutoMLConfigFactory> WithAutoMLConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerSolutionSolutionConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.SolutionTypes.AutoMLConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoMLConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSolutionSolutionConfigFactory, T3, T4, InnerSolutionAutoMLConfigFactory> WithAutoMLConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSolutionSolutionConfigFactory, T3, T4> combinedResult, Action<Humidifier.Personalize.SolutionTypes.AutoMLConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoMLConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSolutionSolutionConfigFactory, T4, InnerSolutionAutoMLConfigFactory> WithAutoMLConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSolutionSolutionConfigFactory, T4> combinedResult, Action<Humidifier.Personalize.SolutionTypes.AutoMLConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoMLConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSolutionSolutionConfigFactory, InnerSolutionAutoMLConfigFactory> WithAutoMLConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSolutionSolutionConfigFactory> combinedResult, Action<Humidifier.Personalize.SolutionTypes.AutoMLConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoMLConfig(combinedResult.T5, subFactoryAction));
}
