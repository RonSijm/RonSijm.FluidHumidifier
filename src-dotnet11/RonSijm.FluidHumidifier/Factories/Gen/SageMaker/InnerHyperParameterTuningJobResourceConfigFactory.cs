// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerHyperParameterTuningJobResourceConfigFactory(Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.ResourceConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.HyperParameterTuningJobTypes.ResourceConfig>
{

    internal InnerHyperParameterTuningJobInstancePlacementConfigFactory InstancePlacementConfigFactory { get; set; }

    protected override Humidifier.SageMaker.HyperParameterTuningJobTypes.ResourceConfig Create()
    {
        var resourceConfigResult = CreateResourceConfig();
        factoryAction?.Invoke(resourceConfigResult);

        return resourceConfigResult;
    }

    private Humidifier.SageMaker.HyperParameterTuningJobTypes.ResourceConfig CreateResourceConfig()
    {
        var resourceConfigResult = new Humidifier.SageMaker.HyperParameterTuningJobTypes.ResourceConfig();

        return resourceConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.HyperParameterTuningJobTypes.ResourceConfig result)
    {
        base.CreateChildren(result);

        result.InstancePlacementConfig ??= InstancePlacementConfigFactory?.Build();
    }

} // End Of Class

public static class InnerHyperParameterTuningJobResourceConfigFactoryExtensions
{
    public static CombinedResult<InnerHyperParameterTuningJobResourceConfigFactory, InnerHyperParameterTuningJobInstancePlacementConfigFactory> WithInstancePlacementConfig(this InnerHyperParameterTuningJobResourceConfigFactory parentFactory, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.InstancePlacementConfig> subFactoryAction = null)
    {
        parentFactory.InstancePlacementConfigFactory = new InnerHyperParameterTuningJobInstancePlacementConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InstancePlacementConfigFactory);
    }

    public static CombinedResult<InnerHyperParameterTuningJobResourceConfigFactory, T1, InnerHyperParameterTuningJobInstancePlacementConfigFactory> WithInstancePlacementConfig<T1>(this CombinedResult<InnerHyperParameterTuningJobResourceConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.InstancePlacementConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInstancePlacementConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHyperParameterTuningJobResourceConfigFactory, InnerHyperParameterTuningJobInstancePlacementConfigFactory> WithInstancePlacementConfig<T1>(this CombinedResult<T1, InnerHyperParameterTuningJobResourceConfigFactory> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.InstancePlacementConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInstancePlacementConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerHyperParameterTuningJobResourceConfigFactory, T1, T2, InnerHyperParameterTuningJobInstancePlacementConfigFactory> WithInstancePlacementConfig<T1, T2>(this CombinedResult<InnerHyperParameterTuningJobResourceConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.InstancePlacementConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstancePlacementConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHyperParameterTuningJobResourceConfigFactory, T2, InnerHyperParameterTuningJobInstancePlacementConfigFactory> WithInstancePlacementConfig<T1, T2>(this CombinedResult<T1, InnerHyperParameterTuningJobResourceConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.InstancePlacementConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstancePlacementConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHyperParameterTuningJobResourceConfigFactory, InnerHyperParameterTuningJobInstancePlacementConfigFactory> WithInstancePlacementConfig<T1, T2>(this CombinedResult<T1, T2, InnerHyperParameterTuningJobResourceConfigFactory> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.InstancePlacementConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstancePlacementConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerHyperParameterTuningJobResourceConfigFactory, T1, T2, T3, InnerHyperParameterTuningJobInstancePlacementConfigFactory> WithInstancePlacementConfig<T1, T2, T3>(this CombinedResult<InnerHyperParameterTuningJobResourceConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.InstancePlacementConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstancePlacementConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHyperParameterTuningJobResourceConfigFactory, T2, T3, InnerHyperParameterTuningJobInstancePlacementConfigFactory> WithInstancePlacementConfig<T1, T2, T3>(this CombinedResult<T1, InnerHyperParameterTuningJobResourceConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.InstancePlacementConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstancePlacementConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHyperParameterTuningJobResourceConfigFactory, T3, InnerHyperParameterTuningJobInstancePlacementConfigFactory> WithInstancePlacementConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerHyperParameterTuningJobResourceConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.InstancePlacementConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstancePlacementConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHyperParameterTuningJobResourceConfigFactory, InnerHyperParameterTuningJobInstancePlacementConfigFactory> WithInstancePlacementConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerHyperParameterTuningJobResourceConfigFactory> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.InstancePlacementConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstancePlacementConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerHyperParameterTuningJobResourceConfigFactory, T1, T2, T3, T4, InnerHyperParameterTuningJobInstancePlacementConfigFactory> WithInstancePlacementConfig<T1, T2, T3, T4>(this CombinedResult<InnerHyperParameterTuningJobResourceConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.InstancePlacementConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstancePlacementConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHyperParameterTuningJobResourceConfigFactory, T2, T3, T4, InnerHyperParameterTuningJobInstancePlacementConfigFactory> WithInstancePlacementConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerHyperParameterTuningJobResourceConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.InstancePlacementConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstancePlacementConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHyperParameterTuningJobResourceConfigFactory, T3, T4, InnerHyperParameterTuningJobInstancePlacementConfigFactory> WithInstancePlacementConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerHyperParameterTuningJobResourceConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.InstancePlacementConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstancePlacementConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHyperParameterTuningJobResourceConfigFactory, T4, InnerHyperParameterTuningJobInstancePlacementConfigFactory> WithInstancePlacementConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerHyperParameterTuningJobResourceConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.InstancePlacementConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstancePlacementConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerHyperParameterTuningJobResourceConfigFactory, InnerHyperParameterTuningJobInstancePlacementConfigFactory> WithInstancePlacementConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerHyperParameterTuningJobResourceConfigFactory> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.InstancePlacementConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstancePlacementConfig(combinedResult.T5, subFactoryAction).T2);
}
