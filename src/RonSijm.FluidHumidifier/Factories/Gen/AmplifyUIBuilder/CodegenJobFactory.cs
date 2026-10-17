// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmplifyUIBuilder;

public class CodegenJobFactory(string resourceName = null, Action<Humidifier.AmplifyUIBuilder.CodegenJob> factoryAction = null) : ResourceFactory<Humidifier.AmplifyUIBuilder.CodegenJob>(resourceName)
{

    internal InnerCodegenJobCodegenJobRenderConfigFactory RenderConfigFactory { get; set; }

    internal InnerCodegenJobCodegenFeatureFlagsFactory FeaturesFactory { get; set; }

    protected override Humidifier.AmplifyUIBuilder.CodegenJob Create()
    {
        var codegenJobResult = CreateCodegenJob();
        factoryAction?.Invoke(codegenJobResult);

        return codegenJobResult;
    }

    private Humidifier.AmplifyUIBuilder.CodegenJob CreateCodegenJob()
    {
        var codegenJobResult = new Humidifier.AmplifyUIBuilder.CodegenJob
        {
            GivenName = InputResourceName,
        };

        return codegenJobResult;
    }
    public override void CreateChildren(Humidifier.AmplifyUIBuilder.CodegenJob result)
    {
        base.CreateChildren(result);

        result.RenderConfig ??= RenderConfigFactory?.Build();
        result.Features ??= FeaturesFactory?.Build();
    }

} // End Of Class

public static class CodegenJobFactoryExtensions
{
    public static CombinedResult<CodegenJobFactory, InnerCodegenJobCodegenJobRenderConfigFactory> WithRenderConfig(this CodegenJobFactory parentFactory, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenJobRenderConfig> subFactoryAction = null)
    {
        parentFactory.RenderConfigFactory = new InnerCodegenJobCodegenJobRenderConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RenderConfigFactory);
    }

    public static CombinedResult<CodegenJobFactory, InnerCodegenJobCodegenFeatureFlagsFactory> WithFeatures(this CodegenJobFactory parentFactory, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenFeatureFlags> subFactoryAction = null)
    {
        parentFactory.FeaturesFactory = new InnerCodegenJobCodegenFeatureFlagsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FeaturesFactory);
    }

    public static CombinedResult<CodegenJobFactory, T1, InnerCodegenJobCodegenJobRenderConfigFactory> WithRenderConfig<T1>(this CombinedResult<CodegenJobFactory, T1> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenJobRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRenderConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CodegenJobFactory, InnerCodegenJobCodegenJobRenderConfigFactory> WithRenderConfig<T1>(this CombinedResult<T1, CodegenJobFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenJobRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRenderConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CodegenJobFactory, T1, T2, InnerCodegenJobCodegenJobRenderConfigFactory> WithRenderConfig<T1, T2>(this CombinedResult<CodegenJobFactory, T1, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenJobRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRenderConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CodegenJobFactory, T2, InnerCodegenJobCodegenJobRenderConfigFactory> WithRenderConfig<T1, T2>(this CombinedResult<T1, CodegenJobFactory, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenJobRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRenderConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CodegenJobFactory, InnerCodegenJobCodegenJobRenderConfigFactory> WithRenderConfig<T1, T2>(this CombinedResult<T1, T2, CodegenJobFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenJobRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRenderConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CodegenJobFactory, T1, T2, T3, InnerCodegenJobCodegenJobRenderConfigFactory> WithRenderConfig<T1, T2, T3>(this CombinedResult<CodegenJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenJobRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRenderConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CodegenJobFactory, T2, T3, InnerCodegenJobCodegenJobRenderConfigFactory> WithRenderConfig<T1, T2, T3>(this CombinedResult<T1, CodegenJobFactory, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenJobRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRenderConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CodegenJobFactory, T3, InnerCodegenJobCodegenJobRenderConfigFactory> WithRenderConfig<T1, T2, T3>(this CombinedResult<T1, T2, CodegenJobFactory, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenJobRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRenderConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CodegenJobFactory, InnerCodegenJobCodegenJobRenderConfigFactory> WithRenderConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, CodegenJobFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenJobRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRenderConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CodegenJobFactory, T1, T2, T3, T4, InnerCodegenJobCodegenJobRenderConfigFactory> WithRenderConfig<T1, T2, T3, T4>(this CombinedResult<CodegenJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenJobRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRenderConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CodegenJobFactory, T2, T3, T4, InnerCodegenJobCodegenJobRenderConfigFactory> WithRenderConfig<T1, T2, T3, T4>(this CombinedResult<T1, CodegenJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenJobRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRenderConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CodegenJobFactory, T3, T4, InnerCodegenJobCodegenJobRenderConfigFactory> WithRenderConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, CodegenJobFactory, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenJobRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRenderConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CodegenJobFactory, T4, InnerCodegenJobCodegenJobRenderConfigFactory> WithRenderConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CodegenJobFactory, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenJobRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRenderConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CodegenJobFactory, InnerCodegenJobCodegenJobRenderConfigFactory> WithRenderConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CodegenJobFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenJobRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRenderConfig(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<CodegenJobFactory, T1, InnerCodegenJobCodegenFeatureFlagsFactory> WithFeatures<T1>(this CombinedResult<CodegenJobFactory, T1> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenFeatureFlags> subFactoryAction = null) => new (combinedResult, combinedResult, WithFeatures(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CodegenJobFactory, InnerCodegenJobCodegenFeatureFlagsFactory> WithFeatures<T1>(this CombinedResult<T1, CodegenJobFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenFeatureFlags> subFactoryAction = null) => new (combinedResult, combinedResult, WithFeatures(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CodegenJobFactory, T1, T2, InnerCodegenJobCodegenFeatureFlagsFactory> WithFeatures<T1, T2>(this CombinedResult<CodegenJobFactory, T1, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenFeatureFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFeatures(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CodegenJobFactory, T2, InnerCodegenJobCodegenFeatureFlagsFactory> WithFeatures<T1, T2>(this CombinedResult<T1, CodegenJobFactory, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenFeatureFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFeatures(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CodegenJobFactory, InnerCodegenJobCodegenFeatureFlagsFactory> WithFeatures<T1, T2>(this CombinedResult<T1, T2, CodegenJobFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenFeatureFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFeatures(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CodegenJobFactory, T1, T2, T3, InnerCodegenJobCodegenFeatureFlagsFactory> WithFeatures<T1, T2, T3>(this CombinedResult<CodegenJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenFeatureFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFeatures(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CodegenJobFactory, T2, T3, InnerCodegenJobCodegenFeatureFlagsFactory> WithFeatures<T1, T2, T3>(this CombinedResult<T1, CodegenJobFactory, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenFeatureFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFeatures(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CodegenJobFactory, T3, InnerCodegenJobCodegenFeatureFlagsFactory> WithFeatures<T1, T2, T3>(this CombinedResult<T1, T2, CodegenJobFactory, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenFeatureFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFeatures(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CodegenJobFactory, InnerCodegenJobCodegenFeatureFlagsFactory> WithFeatures<T1, T2, T3>(this CombinedResult<T1, T2, T3, CodegenJobFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenFeatureFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFeatures(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CodegenJobFactory, T1, T2, T3, T4, InnerCodegenJobCodegenFeatureFlagsFactory> WithFeatures<T1, T2, T3, T4>(this CombinedResult<CodegenJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenFeatureFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFeatures(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CodegenJobFactory, T2, T3, T4, InnerCodegenJobCodegenFeatureFlagsFactory> WithFeatures<T1, T2, T3, T4>(this CombinedResult<T1, CodegenJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenFeatureFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFeatures(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CodegenJobFactory, T3, T4, InnerCodegenJobCodegenFeatureFlagsFactory> WithFeatures<T1, T2, T3, T4>(this CombinedResult<T1, T2, CodegenJobFactory, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenFeatureFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFeatures(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CodegenJobFactory, T4, InnerCodegenJobCodegenFeatureFlagsFactory> WithFeatures<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CodegenJobFactory, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenFeatureFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFeatures(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CodegenJobFactory, InnerCodegenJobCodegenFeatureFlagsFactory> WithFeatures<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CodegenJobFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenFeatureFlags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFeatures(combinedResult.T5, subFactoryAction).T2);
}
