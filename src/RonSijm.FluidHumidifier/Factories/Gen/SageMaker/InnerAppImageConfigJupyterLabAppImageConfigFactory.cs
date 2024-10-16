// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAppImageConfigJupyterLabAppImageConfigFactory(Action<Humidifier.SageMaker.AppImageConfigTypes.JupyterLabAppImageConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AppImageConfigTypes.JupyterLabAppImageConfig>
{

    internal InnerAppImageConfigContainerConfigFactory ContainerConfigFactory { get; set; }

    protected override Humidifier.SageMaker.AppImageConfigTypes.JupyterLabAppImageConfig Create()
    {
        var jupyterLabAppImageConfigResult = CreateJupyterLabAppImageConfig();
        factoryAction?.Invoke(jupyterLabAppImageConfigResult);

        return jupyterLabAppImageConfigResult;
    }

    private Humidifier.SageMaker.AppImageConfigTypes.JupyterLabAppImageConfig CreateJupyterLabAppImageConfig()
    {
        var jupyterLabAppImageConfigResult = new Humidifier.SageMaker.AppImageConfigTypes.JupyterLabAppImageConfig();

        return jupyterLabAppImageConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.AppImageConfigTypes.JupyterLabAppImageConfig result)
    {
        base.CreateChildren(result);

        result.ContainerConfig ??= ContainerConfigFactory?.Build();
    }

} // End Of Class

public static class InnerAppImageConfigJupyterLabAppImageConfigFactoryExtensions
{
    public static CombinedResult<InnerAppImageConfigJupyterLabAppImageConfigFactory, InnerAppImageConfigContainerConfigFactory> WithContainerConfig(this InnerAppImageConfigJupyterLabAppImageConfigFactory parentFactory, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null)
    {
        parentFactory.ContainerConfigFactory = new InnerAppImageConfigContainerConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ContainerConfigFactory);
    }

    public static CombinedResult<InnerAppImageConfigJupyterLabAppImageConfigFactory, T1, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1>(this CombinedResult<InnerAppImageConfigJupyterLabAppImageConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAppImageConfigJupyterLabAppImageConfigFactory, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1>(this CombinedResult<T1, InnerAppImageConfigJupyterLabAppImageConfigFactory> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAppImageConfigJupyterLabAppImageConfigFactory, T1, T2, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1, T2>(this CombinedResult<InnerAppImageConfigJupyterLabAppImageConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAppImageConfigJupyterLabAppImageConfigFactory, T2, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1, T2>(this CombinedResult<T1, InnerAppImageConfigJupyterLabAppImageConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAppImageConfigJupyterLabAppImageConfigFactory, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1, T2>(this CombinedResult<T1, T2, InnerAppImageConfigJupyterLabAppImageConfigFactory> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAppImageConfigJupyterLabAppImageConfigFactory, T1, T2, T3, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1, T2, T3>(this CombinedResult<InnerAppImageConfigJupyterLabAppImageConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAppImageConfigJupyterLabAppImageConfigFactory, T2, T3, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1, T2, T3>(this CombinedResult<T1, InnerAppImageConfigJupyterLabAppImageConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAppImageConfigJupyterLabAppImageConfigFactory, T3, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerAppImageConfigJupyterLabAppImageConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAppImageConfigJupyterLabAppImageConfigFactory, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAppImageConfigJupyterLabAppImageConfigFactory> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAppImageConfigJupyterLabAppImageConfigFactory, T1, T2, T3, T4, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1, T2, T3, T4>(this CombinedResult<InnerAppImageConfigJupyterLabAppImageConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAppImageConfigJupyterLabAppImageConfigFactory, T2, T3, T4, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerAppImageConfigJupyterLabAppImageConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAppImageConfigJupyterLabAppImageConfigFactory, T3, T4, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAppImageConfigJupyterLabAppImageConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAppImageConfigJupyterLabAppImageConfigFactory, T4, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAppImageConfigJupyterLabAppImageConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAppImageConfigJupyterLabAppImageConfigFactory, InnerAppImageConfigContainerConfigFactory> WithContainerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAppImageConfigJupyterLabAppImageConfigFactory> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfig(combinedResult.T5, subFactoryAction));
}
