// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAppImageConfigCodeEditorAppImageConfigFactory(Action<Humidifier.SageMaker.AppImageConfigTypes.CodeEditorAppImageConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AppImageConfigTypes.CodeEditorAppImageConfig>
{

    internal InnerAppImageConfigContainerConfigFactory ContainerConfigFactory { get; set; }

    protected override Humidifier.SageMaker.AppImageConfigTypes.CodeEditorAppImageConfig Create()
    {
        var codeEditorAppImageConfigResult = CreateCodeEditorAppImageConfig();
        factoryAction?.Invoke(codeEditorAppImageConfigResult);

        return codeEditorAppImageConfigResult;
    }

    private Humidifier.SageMaker.AppImageConfigTypes.CodeEditorAppImageConfig CreateCodeEditorAppImageConfig()
    {
        var codeEditorAppImageConfigResult = new Humidifier.SageMaker.AppImageConfigTypes.CodeEditorAppImageConfig();

        return codeEditorAppImageConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.AppImageConfigTypes.CodeEditorAppImageConfig result)
    {
        base.CreateChildren(result);

        result.ContainerConfig ??= ContainerConfigFactory?.Build();
    }

} // End Of Class

public static class InnerAppImageConfigCodeEditorAppImageConfigFactoryExtensions
{
    public static CombinedResult<InnerAppImageConfigCodeEditorAppImageConfigFactory, InnerAppImageConfigContainerConfigFactory> WithContainerConfig(this InnerAppImageConfigCodeEditorAppImageConfigFactory parentFactory, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null)
    {
        parentFactory.ContainerConfigFactory = new InnerAppImageConfigContainerConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ContainerConfigFactory);
    }

    public static CombinedResult<InnerAppImageConfigCodeEditorAppImageConfigFactory, T1, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1>(this CombinedResult<InnerAppImageConfigCodeEditorAppImageConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAppImageConfigCodeEditorAppImageConfigFactory, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1>(this CombinedResult<T1, InnerAppImageConfigCodeEditorAppImageConfigFactory> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAppImageConfigCodeEditorAppImageConfigFactory, T1, T2, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1, T2>(this CombinedResult<InnerAppImageConfigCodeEditorAppImageConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAppImageConfigCodeEditorAppImageConfigFactory, T2, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1, T2>(this CombinedResult<T1, InnerAppImageConfigCodeEditorAppImageConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAppImageConfigCodeEditorAppImageConfigFactory, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1, T2>(this CombinedResult<T1, T2, InnerAppImageConfigCodeEditorAppImageConfigFactory> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAppImageConfigCodeEditorAppImageConfigFactory, T1, T2, T3, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1, T2, T3>(this CombinedResult<InnerAppImageConfigCodeEditorAppImageConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAppImageConfigCodeEditorAppImageConfigFactory, T2, T3, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1, T2, T3>(this CombinedResult<T1, InnerAppImageConfigCodeEditorAppImageConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAppImageConfigCodeEditorAppImageConfigFactory, T3, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerAppImageConfigCodeEditorAppImageConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAppImageConfigCodeEditorAppImageConfigFactory, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAppImageConfigCodeEditorAppImageConfigFactory> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAppImageConfigCodeEditorAppImageConfigFactory, T1, T2, T3, T4, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1, T2, T3, T4>(this CombinedResult<InnerAppImageConfigCodeEditorAppImageConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAppImageConfigCodeEditorAppImageConfigFactory, T2, T3, T4, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerAppImageConfigCodeEditorAppImageConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAppImageConfigCodeEditorAppImageConfigFactory, T3, T4, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAppImageConfigCodeEditorAppImageConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAppImageConfigCodeEditorAppImageConfigFactory, T4, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAppImageConfigCodeEditorAppImageConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAppImageConfigCodeEditorAppImageConfigFactory, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAppImageConfigCodeEditorAppImageConfigFactory> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfig(combinedResult.T5, subFactoryAction));
}
