// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerReplicatorLogDeliveryFactory(Action<Humidifier.MSK.ReplicatorTypes.LogDelivery> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ReplicatorTypes.LogDelivery>
{

    internal InnerReplicatorReplicatorLogDeliveryFactory ReplicatorLogDeliveryFactory { get; set; }

    protected override Humidifier.MSK.ReplicatorTypes.LogDelivery Create()
    {
        var logDeliveryResult = CreateLogDelivery();
        factoryAction?.Invoke(logDeliveryResult);

        return logDeliveryResult;
    }

    private Humidifier.MSK.ReplicatorTypes.LogDelivery CreateLogDelivery()
    {
        var logDeliveryResult = new Humidifier.MSK.ReplicatorTypes.LogDelivery();

        return logDeliveryResult;
    }
    public override void CreateChildren(Humidifier.MSK.ReplicatorTypes.LogDelivery result)
    {
        base.CreateChildren(result);

        result.ReplicatorLogDelivery ??= ReplicatorLogDeliveryFactory?.Build();
    }

} // End Of Class

public static class InnerReplicatorLogDeliveryFactoryExtensions
{
    public static CombinedResult<InnerReplicatorLogDeliveryFactory, InnerReplicatorReplicatorLogDeliveryFactory> WithReplicatorLogDelivery(this InnerReplicatorLogDeliveryFactory parentFactory, Action<Humidifier.MSK.ReplicatorTypes.ReplicatorLogDelivery> subFactoryAction = null)
    {
        parentFactory.ReplicatorLogDeliveryFactory = new InnerReplicatorReplicatorLogDeliveryFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ReplicatorLogDeliveryFactory);
    }

    public static CombinedResult<InnerReplicatorLogDeliveryFactory, T1, InnerReplicatorReplicatorLogDeliveryFactory> WithReplicatorLogDelivery<T1>(this CombinedResult<InnerReplicatorLogDeliveryFactory, T1> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicatorLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, WithReplicatorLogDelivery(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerReplicatorLogDeliveryFactory, InnerReplicatorReplicatorLogDeliveryFactory> WithReplicatorLogDelivery<T1>(this CombinedResult<T1, InnerReplicatorLogDeliveryFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicatorLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, WithReplicatorLogDelivery(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerReplicatorLogDeliveryFactory, T1, T2, InnerReplicatorReplicatorLogDeliveryFactory> WithReplicatorLogDelivery<T1, T2>(this CombinedResult<InnerReplicatorLogDeliveryFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicatorLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReplicatorLogDelivery(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerReplicatorLogDeliveryFactory, T2, InnerReplicatorReplicatorLogDeliveryFactory> WithReplicatorLogDelivery<T1, T2>(this CombinedResult<T1, InnerReplicatorLogDeliveryFactory, T2> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicatorLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReplicatorLogDelivery(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerReplicatorLogDeliveryFactory, InnerReplicatorReplicatorLogDeliveryFactory> WithReplicatorLogDelivery<T1, T2>(this CombinedResult<T1, T2, InnerReplicatorLogDeliveryFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicatorLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReplicatorLogDelivery(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerReplicatorLogDeliveryFactory, T1, T2, T3, InnerReplicatorReplicatorLogDeliveryFactory> WithReplicatorLogDelivery<T1, T2, T3>(this CombinedResult<InnerReplicatorLogDeliveryFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicatorLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicatorLogDelivery(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerReplicatorLogDeliveryFactory, T2, T3, InnerReplicatorReplicatorLogDeliveryFactory> WithReplicatorLogDelivery<T1, T2, T3>(this CombinedResult<T1, InnerReplicatorLogDeliveryFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicatorLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicatorLogDelivery(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerReplicatorLogDeliveryFactory, T3, InnerReplicatorReplicatorLogDeliveryFactory> WithReplicatorLogDelivery<T1, T2, T3>(this CombinedResult<T1, T2, InnerReplicatorLogDeliveryFactory, T3> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicatorLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicatorLogDelivery(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerReplicatorLogDeliveryFactory, InnerReplicatorReplicatorLogDeliveryFactory> WithReplicatorLogDelivery<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerReplicatorLogDeliveryFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicatorLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicatorLogDelivery(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerReplicatorLogDeliveryFactory, T1, T2, T3, T4, InnerReplicatorReplicatorLogDeliveryFactory> WithReplicatorLogDelivery<T1, T2, T3, T4>(this CombinedResult<InnerReplicatorLogDeliveryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicatorLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicatorLogDelivery(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerReplicatorLogDeliveryFactory, T2, T3, T4, InnerReplicatorReplicatorLogDeliveryFactory> WithReplicatorLogDelivery<T1, T2, T3, T4>(this CombinedResult<T1, InnerReplicatorLogDeliveryFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicatorLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicatorLogDelivery(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerReplicatorLogDeliveryFactory, T3, T4, InnerReplicatorReplicatorLogDeliveryFactory> WithReplicatorLogDelivery<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerReplicatorLogDeliveryFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicatorLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicatorLogDelivery(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerReplicatorLogDeliveryFactory, T4, InnerReplicatorReplicatorLogDeliveryFactory> WithReplicatorLogDelivery<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerReplicatorLogDeliveryFactory, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicatorLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicatorLogDelivery(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerReplicatorLogDeliveryFactory, InnerReplicatorReplicatorLogDeliveryFactory> WithReplicatorLogDelivery<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerReplicatorLogDeliveryFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicatorLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicatorLogDelivery(combinedResult.T5, subFactoryAction).T2);
}
