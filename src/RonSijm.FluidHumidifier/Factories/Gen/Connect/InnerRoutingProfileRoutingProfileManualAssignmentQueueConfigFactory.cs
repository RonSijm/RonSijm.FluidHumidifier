// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory(Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileManualAssignmentQueueConfig> factoryAction = null) : SubResourceFactory<Humidifier.Connect.RoutingProfileTypes.RoutingProfileManualAssignmentQueueConfig>
{

    internal InnerRoutingProfileRoutingProfileQueueReferenceFactory QueueReferenceFactory { get; set; }

    protected override Humidifier.Connect.RoutingProfileTypes.RoutingProfileManualAssignmentQueueConfig Create()
    {
        var routingProfileManualAssignmentQueueConfigResult = CreateRoutingProfileManualAssignmentQueueConfig();
        factoryAction?.Invoke(routingProfileManualAssignmentQueueConfigResult);

        return routingProfileManualAssignmentQueueConfigResult;
    }

    private Humidifier.Connect.RoutingProfileTypes.RoutingProfileManualAssignmentQueueConfig CreateRoutingProfileManualAssignmentQueueConfig()
    {
        var routingProfileManualAssignmentQueueConfigResult = new Humidifier.Connect.RoutingProfileTypes.RoutingProfileManualAssignmentQueueConfig();

        return routingProfileManualAssignmentQueueConfigResult;
    }
    public override void CreateChildren(Humidifier.Connect.RoutingProfileTypes.RoutingProfileManualAssignmentQueueConfig result)
    {
        base.CreateChildren(result);

        result.QueueReference ??= QueueReferenceFactory?.Build();
    }

} // End Of Class

public static class InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactoryExtensions
{
    public static CombinedResult<InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference(this InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory parentFactory, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null)
    {
        parentFactory.QueueReferenceFactory = new InnerRoutingProfileRoutingProfileQueueReferenceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.QueueReferenceFactory);
    }

    public static CombinedResult<InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory, T1, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1>(this CombinedResult<InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory, T1> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, WithQueueReference(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1>(this CombinedResult<T1, InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, WithQueueReference(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory, T1, T2, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1, T2>(this CombinedResult<InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory, T1, T2> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQueueReference(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory, T2, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1, T2>(this CombinedResult<T1, InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory, T2> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQueueReference(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1, T2>(this CombinedResult<T1, T2, InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQueueReference(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory, T1, T2, T3, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1, T2, T3>(this CombinedResult<InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueueReference(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory, T2, T3, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1, T2, T3>(this CombinedResult<T1, InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory, T2, T3> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueueReference(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory, T3, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1, T2, T3>(this CombinedResult<T1, T2, InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory, T3> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueueReference(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueueReference(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory, T1, T2, T3, T4, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1, T2, T3, T4>(this CombinedResult<InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueueReference(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory, T2, T3, T4, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1, T2, T3, T4>(this CombinedResult<T1, InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueueReference(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory, T3, T4, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory, T3, T4> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueueReference(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory, T4, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory, T4> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueueReference(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory, InnerRoutingProfileRoutingProfileQueueReferenceFactory> WithQueueReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRoutingProfileRoutingProfileManualAssignmentQueueConfigFactory> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueueReference(combinedResult.T5, subFactoryAction).T2);
}
