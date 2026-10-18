// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerRoutingProfileRoutingProfileQueueReferenceFactory(Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference> factoryAction = null) : SubResourceFactory<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference>
{

    protected override Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference Create()
    {
        var routingProfileQueueReferenceResult = CreateRoutingProfileQueueReference();
        factoryAction?.Invoke(routingProfileQueueReferenceResult);

        return routingProfileQueueReferenceResult;
    }

    private Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference CreateRoutingProfileQueueReference()
    {
        var routingProfileQueueReferenceResult = new Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference();

        return routingProfileQueueReferenceResult;
    }

} // End Of Class

public static class InnerRoutingProfileRoutingProfileQueueReferenceFactoryExtensions
{
}
