// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class WarmPoolFactory(string resourceName = null, Action<Humidifier.AutoScaling.WarmPool> factoryAction = null) : ResourceFactory<Humidifier.AutoScaling.WarmPool>(resourceName)
{

    internal InnerWarmPoolInstanceReusePolicyFactory InstanceReusePolicyFactory { get; set; }

    protected override Humidifier.AutoScaling.WarmPool Create()
    {
        var warmPoolResult = CreateWarmPool();
        factoryAction?.Invoke(warmPoolResult);

        return warmPoolResult;
    }

    private Humidifier.AutoScaling.WarmPool CreateWarmPool()
    {
        var warmPoolResult = new Humidifier.AutoScaling.WarmPool
        {
            GivenName = InputResourceName,
        };

        return warmPoolResult;
    }
    public override void CreateChildren(Humidifier.AutoScaling.WarmPool result)
    {
        base.CreateChildren(result);

        result.InstanceReusePolicy ??= InstanceReusePolicyFactory?.Build();
    }

} // End Of Class

public static class WarmPoolFactoryExtensions
{
    public static CombinedResult<WarmPoolFactory, InnerWarmPoolInstanceReusePolicyFactory> WithInstanceReusePolicy(this WarmPoolFactory parentFactory, Action<Humidifier.AutoScaling.WarmPoolTypes.InstanceReusePolicy> subFactoryAction = null)
    {
        parentFactory.InstanceReusePolicyFactory = new InnerWarmPoolInstanceReusePolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InstanceReusePolicyFactory);
    }

    public static CombinedResult<WarmPoolFactory, T1, InnerWarmPoolInstanceReusePolicyFactory> WithInstanceReusePolicy<T1>(this CombinedResult<WarmPoolFactory, T1> combinedResult, Action<Humidifier.AutoScaling.WarmPoolTypes.InstanceReusePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithInstanceReusePolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WarmPoolFactory, InnerWarmPoolInstanceReusePolicyFactory> WithInstanceReusePolicy<T1>(this CombinedResult<T1, WarmPoolFactory> combinedResult, Action<Humidifier.AutoScaling.WarmPoolTypes.InstanceReusePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithInstanceReusePolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<WarmPoolFactory, T1, T2, InnerWarmPoolInstanceReusePolicyFactory> WithInstanceReusePolicy<T1, T2>(this CombinedResult<WarmPoolFactory, T1, T2> combinedResult, Action<Humidifier.AutoScaling.WarmPoolTypes.InstanceReusePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstanceReusePolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WarmPoolFactory, T2, InnerWarmPoolInstanceReusePolicyFactory> WithInstanceReusePolicy<T1, T2>(this CombinedResult<T1, WarmPoolFactory, T2> combinedResult, Action<Humidifier.AutoScaling.WarmPoolTypes.InstanceReusePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstanceReusePolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WarmPoolFactory, InnerWarmPoolInstanceReusePolicyFactory> WithInstanceReusePolicy<T1, T2>(this CombinedResult<T1, T2, WarmPoolFactory> combinedResult, Action<Humidifier.AutoScaling.WarmPoolTypes.InstanceReusePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstanceReusePolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<WarmPoolFactory, T1, T2, T3, InnerWarmPoolInstanceReusePolicyFactory> WithInstanceReusePolicy<T1, T2, T3>(this CombinedResult<WarmPoolFactory, T1, T2, T3> combinedResult, Action<Humidifier.AutoScaling.WarmPoolTypes.InstanceReusePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceReusePolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WarmPoolFactory, T2, T3, InnerWarmPoolInstanceReusePolicyFactory> WithInstanceReusePolicy<T1, T2, T3>(this CombinedResult<T1, WarmPoolFactory, T2, T3> combinedResult, Action<Humidifier.AutoScaling.WarmPoolTypes.InstanceReusePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceReusePolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WarmPoolFactory, T3, InnerWarmPoolInstanceReusePolicyFactory> WithInstanceReusePolicy<T1, T2, T3>(this CombinedResult<T1, T2, WarmPoolFactory, T3> combinedResult, Action<Humidifier.AutoScaling.WarmPoolTypes.InstanceReusePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceReusePolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WarmPoolFactory, InnerWarmPoolInstanceReusePolicyFactory> WithInstanceReusePolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, WarmPoolFactory> combinedResult, Action<Humidifier.AutoScaling.WarmPoolTypes.InstanceReusePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceReusePolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<WarmPoolFactory, T1, T2, T3, T4, InnerWarmPoolInstanceReusePolicyFactory> WithInstanceReusePolicy<T1, T2, T3, T4>(this CombinedResult<WarmPoolFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AutoScaling.WarmPoolTypes.InstanceReusePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceReusePolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WarmPoolFactory, T2, T3, T4, InnerWarmPoolInstanceReusePolicyFactory> WithInstanceReusePolicy<T1, T2, T3, T4>(this CombinedResult<T1, WarmPoolFactory, T2, T3, T4> combinedResult, Action<Humidifier.AutoScaling.WarmPoolTypes.InstanceReusePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceReusePolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WarmPoolFactory, T3, T4, InnerWarmPoolInstanceReusePolicyFactory> WithInstanceReusePolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, WarmPoolFactory, T3, T4> combinedResult, Action<Humidifier.AutoScaling.WarmPoolTypes.InstanceReusePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceReusePolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WarmPoolFactory, T4, InnerWarmPoolInstanceReusePolicyFactory> WithInstanceReusePolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WarmPoolFactory, T4> combinedResult, Action<Humidifier.AutoScaling.WarmPoolTypes.InstanceReusePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceReusePolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, WarmPoolFactory, InnerWarmPoolInstanceReusePolicyFactory> WithInstanceReusePolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WarmPoolFactory> combinedResult, Action<Humidifier.AutoScaling.WarmPoolTypes.InstanceReusePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceReusePolicy(combinedResult.T5, subFactoryAction));
}
