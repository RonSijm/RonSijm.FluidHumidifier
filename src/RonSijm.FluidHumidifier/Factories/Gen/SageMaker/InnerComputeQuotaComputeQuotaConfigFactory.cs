// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerComputeQuotaComputeQuotaConfigFactory(Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaConfig>
{

    internal InnerComputeQuotaResourceSharingConfigFactory ResourceSharingConfigFactory { get; set; }

    protected override Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaConfig Create()
    {
        var computeQuotaConfigResult = CreateComputeQuotaConfig();
        factoryAction?.Invoke(computeQuotaConfigResult);

        return computeQuotaConfigResult;
    }

    private Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaConfig CreateComputeQuotaConfig()
    {
        var computeQuotaConfigResult = new Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaConfig();

        return computeQuotaConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaConfig result)
    {
        base.CreateChildren(result);

        result.ResourceSharingConfig ??= ResourceSharingConfigFactory?.Build();
    }

} // End Of Class

public static class InnerComputeQuotaComputeQuotaConfigFactoryExtensions
{
    public static CombinedResult<InnerComputeQuotaComputeQuotaConfigFactory, InnerComputeQuotaResourceSharingConfigFactory> WithResourceSharingConfig(this InnerComputeQuotaComputeQuotaConfigFactory parentFactory, Action<Humidifier.SageMaker.ComputeQuotaTypes.ResourceSharingConfig> subFactoryAction = null)
    {
        parentFactory.ResourceSharingConfigFactory = new InnerComputeQuotaResourceSharingConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ResourceSharingConfigFactory);
    }

    public static CombinedResult<InnerComputeQuotaComputeQuotaConfigFactory, T1, InnerComputeQuotaResourceSharingConfigFactory> WithResourceSharingConfig<T1>(this CombinedResult<InnerComputeQuotaComputeQuotaConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ResourceSharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceSharingConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerComputeQuotaComputeQuotaConfigFactory, InnerComputeQuotaResourceSharingConfigFactory> WithResourceSharingConfig<T1>(this CombinedResult<T1, InnerComputeQuotaComputeQuotaConfigFactory> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ResourceSharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceSharingConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerComputeQuotaComputeQuotaConfigFactory, T1, T2, InnerComputeQuotaResourceSharingConfigFactory> WithResourceSharingConfig<T1, T2>(this CombinedResult<InnerComputeQuotaComputeQuotaConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ResourceSharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceSharingConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerComputeQuotaComputeQuotaConfigFactory, T2, InnerComputeQuotaResourceSharingConfigFactory> WithResourceSharingConfig<T1, T2>(this CombinedResult<T1, InnerComputeQuotaComputeQuotaConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ResourceSharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceSharingConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerComputeQuotaComputeQuotaConfigFactory, InnerComputeQuotaResourceSharingConfigFactory> WithResourceSharingConfig<T1, T2>(this CombinedResult<T1, T2, InnerComputeQuotaComputeQuotaConfigFactory> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ResourceSharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceSharingConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerComputeQuotaComputeQuotaConfigFactory, T1, T2, T3, InnerComputeQuotaResourceSharingConfigFactory> WithResourceSharingConfig<T1, T2, T3>(this CombinedResult<InnerComputeQuotaComputeQuotaConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ResourceSharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSharingConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerComputeQuotaComputeQuotaConfigFactory, T2, T3, InnerComputeQuotaResourceSharingConfigFactory> WithResourceSharingConfig<T1, T2, T3>(this CombinedResult<T1, InnerComputeQuotaComputeQuotaConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ResourceSharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSharingConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerComputeQuotaComputeQuotaConfigFactory, T3, InnerComputeQuotaResourceSharingConfigFactory> WithResourceSharingConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerComputeQuotaComputeQuotaConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ResourceSharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSharingConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerComputeQuotaComputeQuotaConfigFactory, InnerComputeQuotaResourceSharingConfigFactory> WithResourceSharingConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerComputeQuotaComputeQuotaConfigFactory> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ResourceSharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSharingConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerComputeQuotaComputeQuotaConfigFactory, T1, T2, T3, T4, InnerComputeQuotaResourceSharingConfigFactory> WithResourceSharingConfig<T1, T2, T3, T4>(this CombinedResult<InnerComputeQuotaComputeQuotaConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ResourceSharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSharingConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerComputeQuotaComputeQuotaConfigFactory, T2, T3, T4, InnerComputeQuotaResourceSharingConfigFactory> WithResourceSharingConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerComputeQuotaComputeQuotaConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ResourceSharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSharingConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerComputeQuotaComputeQuotaConfigFactory, T3, T4, InnerComputeQuotaResourceSharingConfigFactory> WithResourceSharingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerComputeQuotaComputeQuotaConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ResourceSharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSharingConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerComputeQuotaComputeQuotaConfigFactory, T4, InnerComputeQuotaResourceSharingConfigFactory> WithResourceSharingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerComputeQuotaComputeQuotaConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ResourceSharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSharingConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerComputeQuotaComputeQuotaConfigFactory, InnerComputeQuotaResourceSharingConfigFactory> WithResourceSharingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerComputeQuotaComputeQuotaConfigFactory> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ResourceSharingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSharingConfig(combinedResult.T5, subFactoryAction).T2);
}
