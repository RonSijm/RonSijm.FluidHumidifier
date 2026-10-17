// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerReplayDestinationFactory(Action<Humidifier.Events.ReplayTypes.Destination> factoryAction = null) : SubResourceFactory<Humidifier.Events.ReplayTypes.Destination>
{

    protected override Humidifier.Events.ReplayTypes.Destination Create()
    {
        var destinationResult = CreateDestination();
        factoryAction?.Invoke(destinationResult);

        return destinationResult;
    }

    private Humidifier.Events.ReplayTypes.Destination CreateDestination()
    {
        var destinationResult = new Humidifier.Events.ReplayTypes.Destination();

        return destinationResult;
    }

} // End Of Class

public static class InnerReplayDestinationFactoryExtensions
{
}
