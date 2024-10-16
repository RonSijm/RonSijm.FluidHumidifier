// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerRoutingProfileRoutingProfileQueueConfigFactory(Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueConfig> factoryAction = null) : SubResourceFactory<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueConfig>
{

    internal InnerRoutingProfileRoutingProfileQueueReferenceFactory QueueReferenceFactory { get; set; }

    protected override Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueConfig Create()
    {
        var routingProfileQueueConfigResult = CreateRoutingProfileQueueConfig();
        factoryAction?.Invoke(routingProfileQueueConfigResult);

        return routingProfileQueueConfigResult;
    }

    private Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueConfig CreateRoutingProfileQueueConfig()
    {
        var routingProfileQueueConfigResult = new Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueConfig();

        return routingProfileQueueConfigResult;
    }
    public override void CreateChildren(Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueConfig result)
    {
        base.CreateChildren(result);

        result.QueueReference ??= QueueReferenceFactory?.Build();
    }

} // End Of Class

public static class InnerRoutingProfileRoutingProfileQueueConfigFactoryExtensions
{
    public static CombinedResult<InnerRoutingProfileRoutingProfileQueueConfigFactory, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference(this InnerRoutingProfileRoutingProfileQueueConfigFactory parentFactory, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null)
    {
        parentFactory.QueueReferenceFactory = new InnerRoutingProfileRoutingProfileQueueReferenceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.QueueReferenceFactory);
    }

    public static CombinedResult<InnerRoutingProfileRoutingProfileQueueConfigFactory, T1, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1>(this CombinedResult<InnerRoutingProfileRoutingProfileQueueConfigFactory, T1> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, WithQueueReference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRoutingProfileRoutingProfileQueueConfigFactory, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1>(this CombinedResult<T1, InnerRoutingProfileRoutingProfileQueueConfigFactory> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, WithQueueReference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRoutingProfileRoutingProfileQueueConfigFactory, T1, T2, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1, T2>(this CombinedResult<InnerRoutingProfileRoutingProfileQueueConfigFactory, T1, T2> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQueueReference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRoutingProfileRoutingProfileQueueConfigFactory, T2, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1, T2>(this CombinedResult<T1, InnerRoutingProfileRoutingProfileQueueConfigFactory, T2> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQueueReference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRoutingProfileRoutingProfileQueueConfigFactory, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1, T2>(this CombinedResult<T1, T2, InnerRoutingProfileRoutingProfileQueueConfigFactory> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQueueReference(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRoutingProfileRoutingProfileQueueConfigFactory, T1, T2, T3, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1, T2, T3>(this CombinedResult<InnerRoutingProfileRoutingProfileQueueConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueueReference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRoutingProfileRoutingProfileQueueConfigFactory, T2, T3, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1, T2, T3>(this CombinedResult<T1, InnerRoutingProfileRoutingProfileQueueConfigFactory, T2, T3> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueueReference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRoutingProfileRoutingProfileQueueConfigFactory, T3, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1, T2, T3>(this CombinedResult<T1, T2, InnerRoutingProfileRoutingProfileQueueConfigFactory, T3> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueueReference(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRoutingProfileRoutingProfileQueueConfigFactory, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRoutingProfileRoutingProfileQueueConfigFactory> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueueReference(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRoutingProfileRoutingProfileQueueConfigFactory, T1, T2, T3, T4, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1, T2, T3, T4>(this CombinedResult<InnerRoutingProfileRoutingProfileQueueConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueueReference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRoutingProfileRoutingProfileQueueConfigFactory, T2, T3, T4, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1, T2, T3, T4>(this CombinedResult<T1, InnerRoutingProfileRoutingProfileQueueConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueueReference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRoutingProfileRoutingProfileQueueConfigFactory, T3, T4, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRoutingProfileRoutingProfileQueueConfigFactory, T3, T4> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueueReference(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRoutingProfileRoutingProfileQueueConfigFactory, T4, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRoutingProfileRoutingProfileQueueConfigFactory, T4> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueueReference(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRoutingProfileRoutingProfileQueueConfigFactory, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRoutingProfileRoutingProfileQueueConfigFactory> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueueReference(combinedResult.T5, subFactoryAction));
}
