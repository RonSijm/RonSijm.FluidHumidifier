// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerWebFunctionRevisionBuildConfigFactory(Action<Humidifier.Lambda.WebFunctionRevisionTypes.BuildConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.WebFunctionRevisionTypes.BuildConfig>
{

    internal InnerWebFunctionRevisionRuntimeConfigFactory RuntimeConfigFactory { get; set; }

    internal InnerWebFunctionRevisionCodeConfigFactory CodeConfigFactory { get; set; }

    protected override Humidifier.Lambda.WebFunctionRevisionTypes.BuildConfig Create()
    {
        var buildConfigResult = CreateBuildConfig();
        factoryAction?.Invoke(buildConfigResult);

        return buildConfigResult;
    }

    private Humidifier.Lambda.WebFunctionRevisionTypes.BuildConfig CreateBuildConfig()
    {
        var buildConfigResult = new Humidifier.Lambda.WebFunctionRevisionTypes.BuildConfig();

        return buildConfigResult;
    }
    public override void CreateChildren(Humidifier.Lambda.WebFunctionRevisionTypes.BuildConfig result)
    {
        base.CreateChildren(result);

        result.RuntimeConfig ??= RuntimeConfigFactory?.Build();
        result.CodeConfig ??= CodeConfigFactory?.Build();
    }

} // End Of Class

public static class InnerWebFunctionRevisionBuildConfigFactoryExtensions
{
    public static CombinedResult<InnerWebFunctionRevisionBuildConfigFactory, InnerWebFunctionRevisionRuntimeConfigFactory> WithRuntimeConfig(this InnerWebFunctionRevisionBuildConfigFactory parentFactory, Action<Humidifier.Lambda.WebFunctionRevisionTypes.RuntimeConfig> subFactoryAction = null)
    {
        parentFactory.RuntimeConfigFactory = new InnerWebFunctionRevisionRuntimeConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RuntimeConfigFactory);
    }

    public static CombinedResult<InnerWebFunctionRevisionBuildConfigFactory, InnerWebFunctionRevisionCodeConfigFactory> WithCodeConfig(this InnerWebFunctionRevisionBuildConfigFactory parentFactory, Action<Humidifier.Lambda.WebFunctionRevisionTypes.CodeConfig> subFactoryAction = null)
    {
        parentFactory.CodeConfigFactory = new InnerWebFunctionRevisionCodeConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CodeConfigFactory);
    }

    public static CombinedResult<InnerWebFunctionRevisionBuildConfigFactory, T1, InnerWebFunctionRevisionRuntimeConfigFactory> WithRuntimeConfig<T1>(this CombinedResult<InnerWebFunctionRevisionBuildConfigFactory, T1> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.RuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebFunctionRevisionBuildConfigFactory, InnerWebFunctionRevisionRuntimeConfigFactory> WithRuntimeConfig<T1>(this CombinedResult<T1, InnerWebFunctionRevisionBuildConfigFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.RuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerWebFunctionRevisionBuildConfigFactory, T1, T2, InnerWebFunctionRevisionRuntimeConfigFactory> WithRuntimeConfig<T1, T2>(this CombinedResult<InnerWebFunctionRevisionBuildConfigFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.RuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebFunctionRevisionBuildConfigFactory, T2, InnerWebFunctionRevisionRuntimeConfigFactory> WithRuntimeConfig<T1, T2>(this CombinedResult<T1, InnerWebFunctionRevisionBuildConfigFactory, T2> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.RuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWebFunctionRevisionBuildConfigFactory, InnerWebFunctionRevisionRuntimeConfigFactory> WithRuntimeConfig<T1, T2>(this CombinedResult<T1, T2, InnerWebFunctionRevisionBuildConfigFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.RuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerWebFunctionRevisionBuildConfigFactory, T1, T2, T3, InnerWebFunctionRevisionRuntimeConfigFactory> WithRuntimeConfig<T1, T2, T3>(this CombinedResult<InnerWebFunctionRevisionBuildConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.RuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebFunctionRevisionBuildConfigFactory, T2, T3, InnerWebFunctionRevisionRuntimeConfigFactory> WithRuntimeConfig<T1, T2, T3>(this CombinedResult<T1, InnerWebFunctionRevisionBuildConfigFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.RuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWebFunctionRevisionBuildConfigFactory, T3, InnerWebFunctionRevisionRuntimeConfigFactory> WithRuntimeConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebFunctionRevisionBuildConfigFactory, T3> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.RuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWebFunctionRevisionBuildConfigFactory, InnerWebFunctionRevisionRuntimeConfigFactory> WithRuntimeConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebFunctionRevisionBuildConfigFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.RuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerWebFunctionRevisionBuildConfigFactory, T1, T2, T3, T4, InnerWebFunctionRevisionRuntimeConfigFactory> WithRuntimeConfig<T1, T2, T3, T4>(this CombinedResult<InnerWebFunctionRevisionBuildConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.RuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebFunctionRevisionBuildConfigFactory, T2, T3, T4, InnerWebFunctionRevisionRuntimeConfigFactory> WithRuntimeConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebFunctionRevisionBuildConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.RuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWebFunctionRevisionBuildConfigFactory, T3, T4, InnerWebFunctionRevisionRuntimeConfigFactory> WithRuntimeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebFunctionRevisionBuildConfigFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.RuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWebFunctionRevisionBuildConfigFactory, T4, InnerWebFunctionRevisionRuntimeConfigFactory> WithRuntimeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebFunctionRevisionBuildConfigFactory, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.RuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerWebFunctionRevisionBuildConfigFactory, InnerWebFunctionRevisionRuntimeConfigFactory> WithRuntimeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebFunctionRevisionBuildConfigFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.RuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerWebFunctionRevisionBuildConfigFactory, T1, InnerWebFunctionRevisionCodeConfigFactory> WithCodeConfig<T1>(this CombinedResult<InnerWebFunctionRevisionBuildConfigFactory, T1> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.CodeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCodeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebFunctionRevisionBuildConfigFactory, InnerWebFunctionRevisionCodeConfigFactory> WithCodeConfig<T1>(this CombinedResult<T1, InnerWebFunctionRevisionBuildConfigFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.CodeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCodeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerWebFunctionRevisionBuildConfigFactory, T1, T2, InnerWebFunctionRevisionCodeConfigFactory> WithCodeConfig<T1, T2>(this CombinedResult<InnerWebFunctionRevisionBuildConfigFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.CodeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebFunctionRevisionBuildConfigFactory, T2, InnerWebFunctionRevisionCodeConfigFactory> WithCodeConfig<T1, T2>(this CombinedResult<T1, InnerWebFunctionRevisionBuildConfigFactory, T2> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.CodeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWebFunctionRevisionBuildConfigFactory, InnerWebFunctionRevisionCodeConfigFactory> WithCodeConfig<T1, T2>(this CombinedResult<T1, T2, InnerWebFunctionRevisionBuildConfigFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.CodeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerWebFunctionRevisionBuildConfigFactory, T1, T2, T3, InnerWebFunctionRevisionCodeConfigFactory> WithCodeConfig<T1, T2, T3>(this CombinedResult<InnerWebFunctionRevisionBuildConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.CodeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebFunctionRevisionBuildConfigFactory, T2, T3, InnerWebFunctionRevisionCodeConfigFactory> WithCodeConfig<T1, T2, T3>(this CombinedResult<T1, InnerWebFunctionRevisionBuildConfigFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.CodeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWebFunctionRevisionBuildConfigFactory, T3, InnerWebFunctionRevisionCodeConfigFactory> WithCodeConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebFunctionRevisionBuildConfigFactory, T3> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.CodeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWebFunctionRevisionBuildConfigFactory, InnerWebFunctionRevisionCodeConfigFactory> WithCodeConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebFunctionRevisionBuildConfigFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.CodeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerWebFunctionRevisionBuildConfigFactory, T1, T2, T3, T4, InnerWebFunctionRevisionCodeConfigFactory> WithCodeConfig<T1, T2, T3, T4>(this CombinedResult<InnerWebFunctionRevisionBuildConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.CodeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebFunctionRevisionBuildConfigFactory, T2, T3, T4, InnerWebFunctionRevisionCodeConfigFactory> WithCodeConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebFunctionRevisionBuildConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.CodeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWebFunctionRevisionBuildConfigFactory, T3, T4, InnerWebFunctionRevisionCodeConfigFactory> WithCodeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebFunctionRevisionBuildConfigFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.CodeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWebFunctionRevisionBuildConfigFactory, T4, InnerWebFunctionRevisionCodeConfigFactory> WithCodeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebFunctionRevisionBuildConfigFactory, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.CodeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerWebFunctionRevisionBuildConfigFactory, InnerWebFunctionRevisionCodeConfigFactory> WithCodeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebFunctionRevisionBuildConfigFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.CodeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfig(combinedResult.T5, subFactoryAction).T2);
}
