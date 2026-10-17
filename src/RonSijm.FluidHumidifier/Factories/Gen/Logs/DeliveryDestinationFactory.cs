// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class DeliveryDestinationFactory(string resourceName = null, Action<Humidifier.Logs.DeliveryDestination> factoryAction = null) : ResourceFactory<Humidifier.Logs.DeliveryDestination>(resourceName)
{

    internal InnerDeliveryDestinationDestinationPolicyFactory DeliveryDestinationPolicyFactory { get; set; }

    protected override Humidifier.Logs.DeliveryDestination Create()
    {
        var deliveryDestinationResult = CreateDeliveryDestination();
        factoryAction?.Invoke(deliveryDestinationResult);

        return deliveryDestinationResult;
    }

    private Humidifier.Logs.DeliveryDestination CreateDeliveryDestination()
    {
        var deliveryDestinationResult = new Humidifier.Logs.DeliveryDestination
        {
            GivenName = InputResourceName,
        };

        return deliveryDestinationResult;
    }
    public override void CreateChildren(Humidifier.Logs.DeliveryDestination result)
    {
        base.CreateChildren(result);

        result.DeliveryDestinationPolicy ??= DeliveryDestinationPolicyFactory?.Build();
    }

} // End Of Class

public static class DeliveryDestinationFactoryExtensions
{
    public static CombinedResult<DeliveryDestinationFactory, InnerDeliveryDestinationDestinationPolicyFactory> WithDeliveryDestinationPolicy(this DeliveryDestinationFactory parentFactory, Action<Humidifier.Logs.DeliveryDestinationTypes.DestinationPolicy> subFactoryAction = null)
    {
        parentFactory.DeliveryDestinationPolicyFactory = new InnerDeliveryDestinationDestinationPolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DeliveryDestinationPolicyFactory);
    }

    public static CombinedResult<DeliveryDestinationFactory, T1, InnerDeliveryDestinationDestinationPolicyFactory> WithDeliveryDestinationPolicy<T1>(this CombinedResult<DeliveryDestinationFactory, T1> combinedResult, Action<Humidifier.Logs.DeliveryDestinationTypes.DestinationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeliveryDestinationPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DeliveryDestinationFactory, InnerDeliveryDestinationDestinationPolicyFactory> WithDeliveryDestinationPolicy<T1>(this CombinedResult<T1, DeliveryDestinationFactory> combinedResult, Action<Humidifier.Logs.DeliveryDestinationTypes.DestinationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeliveryDestinationPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DeliveryDestinationFactory, T1, T2, InnerDeliveryDestinationDestinationPolicyFactory> WithDeliveryDestinationPolicy<T1, T2>(this CombinedResult<DeliveryDestinationFactory, T1, T2> combinedResult, Action<Humidifier.Logs.DeliveryDestinationTypes.DestinationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeliveryDestinationPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DeliveryDestinationFactory, T2, InnerDeliveryDestinationDestinationPolicyFactory> WithDeliveryDestinationPolicy<T1, T2>(this CombinedResult<T1, DeliveryDestinationFactory, T2> combinedResult, Action<Humidifier.Logs.DeliveryDestinationTypes.DestinationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeliveryDestinationPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DeliveryDestinationFactory, InnerDeliveryDestinationDestinationPolicyFactory> WithDeliveryDestinationPolicy<T1, T2>(this CombinedResult<T1, T2, DeliveryDestinationFactory> combinedResult, Action<Humidifier.Logs.DeliveryDestinationTypes.DestinationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeliveryDestinationPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DeliveryDestinationFactory, T1, T2, T3, InnerDeliveryDestinationDestinationPolicyFactory> WithDeliveryDestinationPolicy<T1, T2, T3>(this CombinedResult<DeliveryDestinationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Logs.DeliveryDestinationTypes.DestinationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeliveryDestinationPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DeliveryDestinationFactory, T2, T3, InnerDeliveryDestinationDestinationPolicyFactory> WithDeliveryDestinationPolicy<T1, T2, T3>(this CombinedResult<T1, DeliveryDestinationFactory, T2, T3> combinedResult, Action<Humidifier.Logs.DeliveryDestinationTypes.DestinationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeliveryDestinationPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DeliveryDestinationFactory, T3, InnerDeliveryDestinationDestinationPolicyFactory> WithDeliveryDestinationPolicy<T1, T2, T3>(this CombinedResult<T1, T2, DeliveryDestinationFactory, T3> combinedResult, Action<Humidifier.Logs.DeliveryDestinationTypes.DestinationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeliveryDestinationPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DeliveryDestinationFactory, InnerDeliveryDestinationDestinationPolicyFactory> WithDeliveryDestinationPolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, DeliveryDestinationFactory> combinedResult, Action<Humidifier.Logs.DeliveryDestinationTypes.DestinationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeliveryDestinationPolicy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DeliveryDestinationFactory, T1, T2, T3, T4, InnerDeliveryDestinationDestinationPolicyFactory> WithDeliveryDestinationPolicy<T1, T2, T3, T4>(this CombinedResult<DeliveryDestinationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Logs.DeliveryDestinationTypes.DestinationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeliveryDestinationPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DeliveryDestinationFactory, T2, T3, T4, InnerDeliveryDestinationDestinationPolicyFactory> WithDeliveryDestinationPolicy<T1, T2, T3, T4>(this CombinedResult<T1, DeliveryDestinationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Logs.DeliveryDestinationTypes.DestinationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeliveryDestinationPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DeliveryDestinationFactory, T3, T4, InnerDeliveryDestinationDestinationPolicyFactory> WithDeliveryDestinationPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, DeliveryDestinationFactory, T3, T4> combinedResult, Action<Humidifier.Logs.DeliveryDestinationTypes.DestinationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeliveryDestinationPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DeliveryDestinationFactory, T4, InnerDeliveryDestinationDestinationPolicyFactory> WithDeliveryDestinationPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DeliveryDestinationFactory, T4> combinedResult, Action<Humidifier.Logs.DeliveryDestinationTypes.DestinationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeliveryDestinationPolicy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DeliveryDestinationFactory, InnerDeliveryDestinationDestinationPolicyFactory> WithDeliveryDestinationPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DeliveryDestinationFactory> combinedResult, Action<Humidifier.Logs.DeliveryDestinationTypes.DestinationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeliveryDestinationPolicy(combinedResult.T5, subFactoryAction).T2);
}
