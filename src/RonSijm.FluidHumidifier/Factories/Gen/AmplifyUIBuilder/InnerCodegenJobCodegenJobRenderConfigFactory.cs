// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmplifyUIBuilder;

public class InnerCodegenJobCodegenJobRenderConfigFactory(Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenJobRenderConfig> factoryAction = null) : SubResourceFactory<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenJobRenderConfig>
{

    internal InnerCodegenJobReactStartCodegenJobDataFactory ReactFactory { get; set; }

    protected override Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenJobRenderConfig Create()
    {
        var codegenJobRenderConfigResult = CreateCodegenJobRenderConfig();
        factoryAction?.Invoke(codegenJobRenderConfigResult);

        return codegenJobRenderConfigResult;
    }

    private Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenJobRenderConfig CreateCodegenJobRenderConfig()
    {
        var codegenJobRenderConfigResult = new Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenJobRenderConfig();

        return codegenJobRenderConfigResult;
    }
    public override void CreateChildren(Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenJobRenderConfig result)
    {
        base.CreateChildren(result);

        result.React ??= ReactFactory?.Build();
    }

} // End Of Class

public static class InnerCodegenJobCodegenJobRenderConfigFactoryExtensions
{
    public static CombinedResult<InnerCodegenJobCodegenJobRenderConfigFactory, InnerCodegenJobReactStartCodegenJobDataFactory> WithReact(this InnerCodegenJobCodegenJobRenderConfigFactory parentFactory, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ReactStartCodegenJobData> subFactoryAction = null)
    {
        parentFactory.ReactFactory = new InnerCodegenJobReactStartCodegenJobDataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ReactFactory);
    }

    public static CombinedResult<InnerCodegenJobCodegenJobRenderConfigFactory, T1, InnerCodegenJobReactStartCodegenJobDataFactory> WithReact<T1>(this CombinedResult<InnerCodegenJobCodegenJobRenderConfigFactory, T1> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ReactStartCodegenJobData> subFactoryAction = null) => new (combinedResult, combinedResult, WithReact(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCodegenJobCodegenJobRenderConfigFactory, InnerCodegenJobReactStartCodegenJobDataFactory> WithReact<T1>(this CombinedResult<T1, InnerCodegenJobCodegenJobRenderConfigFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ReactStartCodegenJobData> subFactoryAction = null) => new (combinedResult, combinedResult, WithReact(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCodegenJobCodegenJobRenderConfigFactory, T1, T2, InnerCodegenJobReactStartCodegenJobDataFactory> WithReact<T1, T2>(this CombinedResult<InnerCodegenJobCodegenJobRenderConfigFactory, T1, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ReactStartCodegenJobData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReact(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCodegenJobCodegenJobRenderConfigFactory, T2, InnerCodegenJobReactStartCodegenJobDataFactory> WithReact<T1, T2>(this CombinedResult<T1, InnerCodegenJobCodegenJobRenderConfigFactory, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ReactStartCodegenJobData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReact(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCodegenJobCodegenJobRenderConfigFactory, InnerCodegenJobReactStartCodegenJobDataFactory> WithReact<T1, T2>(this CombinedResult<T1, T2, InnerCodegenJobCodegenJobRenderConfigFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ReactStartCodegenJobData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReact(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCodegenJobCodegenJobRenderConfigFactory, T1, T2, T3, InnerCodegenJobReactStartCodegenJobDataFactory> WithReact<T1, T2, T3>(this CombinedResult<InnerCodegenJobCodegenJobRenderConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ReactStartCodegenJobData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReact(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCodegenJobCodegenJobRenderConfigFactory, T2, T3, InnerCodegenJobReactStartCodegenJobDataFactory> WithReact<T1, T2, T3>(this CombinedResult<T1, InnerCodegenJobCodegenJobRenderConfigFactory, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ReactStartCodegenJobData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReact(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCodegenJobCodegenJobRenderConfigFactory, T3, InnerCodegenJobReactStartCodegenJobDataFactory> WithReact<T1, T2, T3>(this CombinedResult<T1, T2, InnerCodegenJobCodegenJobRenderConfigFactory, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ReactStartCodegenJobData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReact(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCodegenJobCodegenJobRenderConfigFactory, InnerCodegenJobReactStartCodegenJobDataFactory> WithReact<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCodegenJobCodegenJobRenderConfigFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ReactStartCodegenJobData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReact(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCodegenJobCodegenJobRenderConfigFactory, T1, T2, T3, T4, InnerCodegenJobReactStartCodegenJobDataFactory> WithReact<T1, T2, T3, T4>(this CombinedResult<InnerCodegenJobCodegenJobRenderConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ReactStartCodegenJobData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReact(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCodegenJobCodegenJobRenderConfigFactory, T2, T3, T4, InnerCodegenJobReactStartCodegenJobDataFactory> WithReact<T1, T2, T3, T4>(this CombinedResult<T1, InnerCodegenJobCodegenJobRenderConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ReactStartCodegenJobData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReact(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCodegenJobCodegenJobRenderConfigFactory, T3, T4, InnerCodegenJobReactStartCodegenJobDataFactory> WithReact<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCodegenJobCodegenJobRenderConfigFactory, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ReactStartCodegenJobData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReact(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCodegenJobCodegenJobRenderConfigFactory, T4, InnerCodegenJobReactStartCodegenJobDataFactory> WithReact<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCodegenJobCodegenJobRenderConfigFactory, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ReactStartCodegenJobData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReact(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCodegenJobCodegenJobRenderConfigFactory, InnerCodegenJobReactStartCodegenJobDataFactory> WithReact<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCodegenJobCodegenJobRenderConfigFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ReactStartCodegenJobData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReact(combinedResult.T5, subFactoryAction).T2);
}
