// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class ComputeQuotaFactory(string resourceName = null, Action<Humidifier.SageMaker.ComputeQuota> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.ComputeQuota>(resourceName)
{

    internal InnerComputeQuotaComputeQuotaTargetFactory ComputeQuotaTargetFactory { get; set; }

    internal InnerComputeQuotaComputeQuotaConfigFactory ComputeQuotaConfigFactory { get; set; }

    protected override Humidifier.SageMaker.ComputeQuota Create()
    {
        var computeQuotaResult = CreateComputeQuota();
        factoryAction?.Invoke(computeQuotaResult);

        return computeQuotaResult;
    }

    private Humidifier.SageMaker.ComputeQuota CreateComputeQuota()
    {
        var computeQuotaResult = new Humidifier.SageMaker.ComputeQuota
        {
            GivenName = InputResourceName,
        };

        return computeQuotaResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ComputeQuota result)
    {
        base.CreateChildren(result);

        result.ComputeQuotaTarget ??= ComputeQuotaTargetFactory?.Build();
        result.ComputeQuotaConfig ??= ComputeQuotaConfigFactory?.Build();
    }

} // End Of Class

public static class ComputeQuotaFactoryExtensions
{
    public static CombinedResult<ComputeQuotaFactory, InnerComputeQuotaComputeQuotaTargetFactory> WithComputeQuotaTarget(this ComputeQuotaFactory parentFactory, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaTarget> subFactoryAction = null)
    {
        parentFactory.ComputeQuotaTargetFactory = new InnerComputeQuotaComputeQuotaTargetFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ComputeQuotaTargetFactory);
    }

    public static CombinedResult<ComputeQuotaFactory, InnerComputeQuotaComputeQuotaConfigFactory> WithComputeQuotaConfig(this ComputeQuotaFactory parentFactory, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaConfig> subFactoryAction = null)
    {
        parentFactory.ComputeQuotaConfigFactory = new InnerComputeQuotaComputeQuotaConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ComputeQuotaConfigFactory);
    }

    public static CombinedResult<ComputeQuotaFactory, T1, InnerComputeQuotaComputeQuotaTargetFactory> WithComputeQuotaTarget<T1>(this CombinedResult<ComputeQuotaFactory, T1> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithComputeQuotaTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ComputeQuotaFactory, InnerComputeQuotaComputeQuotaTargetFactory> WithComputeQuotaTarget<T1>(this CombinedResult<T1, ComputeQuotaFactory> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithComputeQuotaTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ComputeQuotaFactory, T1, T2, InnerComputeQuotaComputeQuotaTargetFactory> WithComputeQuotaTarget<T1, T2>(this CombinedResult<ComputeQuotaFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeQuotaTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ComputeQuotaFactory, T2, InnerComputeQuotaComputeQuotaTargetFactory> WithComputeQuotaTarget<T1, T2>(this CombinedResult<T1, ComputeQuotaFactory, T2> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeQuotaTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ComputeQuotaFactory, InnerComputeQuotaComputeQuotaTargetFactory> WithComputeQuotaTarget<T1, T2>(this CombinedResult<T1, T2, ComputeQuotaFactory> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeQuotaTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ComputeQuotaFactory, T1, T2, T3, InnerComputeQuotaComputeQuotaTargetFactory> WithComputeQuotaTarget<T1, T2, T3>(this CombinedResult<ComputeQuotaFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeQuotaTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ComputeQuotaFactory, T2, T3, InnerComputeQuotaComputeQuotaTargetFactory> WithComputeQuotaTarget<T1, T2, T3>(this CombinedResult<T1, ComputeQuotaFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeQuotaTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ComputeQuotaFactory, T3, InnerComputeQuotaComputeQuotaTargetFactory> WithComputeQuotaTarget<T1, T2, T3>(this CombinedResult<T1, T2, ComputeQuotaFactory, T3> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeQuotaTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ComputeQuotaFactory, InnerComputeQuotaComputeQuotaTargetFactory> WithComputeQuotaTarget<T1, T2, T3>(this CombinedResult<T1, T2, T3, ComputeQuotaFactory> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeQuotaTarget(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ComputeQuotaFactory, T1, T2, T3, T4, InnerComputeQuotaComputeQuotaTargetFactory> WithComputeQuotaTarget<T1, T2, T3, T4>(this CombinedResult<ComputeQuotaFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeQuotaTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ComputeQuotaFactory, T2, T3, T4, InnerComputeQuotaComputeQuotaTargetFactory> WithComputeQuotaTarget<T1, T2, T3, T4>(this CombinedResult<T1, ComputeQuotaFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeQuotaTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ComputeQuotaFactory, T3, T4, InnerComputeQuotaComputeQuotaTargetFactory> WithComputeQuotaTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, ComputeQuotaFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeQuotaTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ComputeQuotaFactory, T4, InnerComputeQuotaComputeQuotaTargetFactory> WithComputeQuotaTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ComputeQuotaFactory, T4> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeQuotaTarget(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ComputeQuotaFactory, InnerComputeQuotaComputeQuotaTargetFactory> WithComputeQuotaTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ComputeQuotaFactory> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeQuotaTarget(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ComputeQuotaFactory, T1, InnerComputeQuotaComputeQuotaConfigFactory> WithComputeQuotaConfig<T1>(this CombinedResult<ComputeQuotaFactory, T1> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithComputeQuotaConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ComputeQuotaFactory, InnerComputeQuotaComputeQuotaConfigFactory> WithComputeQuotaConfig<T1>(this CombinedResult<T1, ComputeQuotaFactory> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithComputeQuotaConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ComputeQuotaFactory, T1, T2, InnerComputeQuotaComputeQuotaConfigFactory> WithComputeQuotaConfig<T1, T2>(this CombinedResult<ComputeQuotaFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeQuotaConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ComputeQuotaFactory, T2, InnerComputeQuotaComputeQuotaConfigFactory> WithComputeQuotaConfig<T1, T2>(this CombinedResult<T1, ComputeQuotaFactory, T2> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeQuotaConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ComputeQuotaFactory, InnerComputeQuotaComputeQuotaConfigFactory> WithComputeQuotaConfig<T1, T2>(this CombinedResult<T1, T2, ComputeQuotaFactory> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeQuotaConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ComputeQuotaFactory, T1, T2, T3, InnerComputeQuotaComputeQuotaConfigFactory> WithComputeQuotaConfig<T1, T2, T3>(this CombinedResult<ComputeQuotaFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeQuotaConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ComputeQuotaFactory, T2, T3, InnerComputeQuotaComputeQuotaConfigFactory> WithComputeQuotaConfig<T1, T2, T3>(this CombinedResult<T1, ComputeQuotaFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeQuotaConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ComputeQuotaFactory, T3, InnerComputeQuotaComputeQuotaConfigFactory> WithComputeQuotaConfig<T1, T2, T3>(this CombinedResult<T1, T2, ComputeQuotaFactory, T3> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeQuotaConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ComputeQuotaFactory, InnerComputeQuotaComputeQuotaConfigFactory> WithComputeQuotaConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ComputeQuotaFactory> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeQuotaConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ComputeQuotaFactory, T1, T2, T3, T4, InnerComputeQuotaComputeQuotaConfigFactory> WithComputeQuotaConfig<T1, T2, T3, T4>(this CombinedResult<ComputeQuotaFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeQuotaConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ComputeQuotaFactory, T2, T3, T4, InnerComputeQuotaComputeQuotaConfigFactory> WithComputeQuotaConfig<T1, T2, T3, T4>(this CombinedResult<T1, ComputeQuotaFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeQuotaConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ComputeQuotaFactory, T3, T4, InnerComputeQuotaComputeQuotaConfigFactory> WithComputeQuotaConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ComputeQuotaFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeQuotaConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ComputeQuotaFactory, T4, InnerComputeQuotaComputeQuotaConfigFactory> WithComputeQuotaConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ComputeQuotaFactory, T4> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeQuotaConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ComputeQuotaFactory, InnerComputeQuotaComputeQuotaConfigFactory> WithComputeQuotaConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ComputeQuotaFactory> combinedResult, Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeQuotaConfig(combinedResult.T5, subFactoryAction).T2);
}
