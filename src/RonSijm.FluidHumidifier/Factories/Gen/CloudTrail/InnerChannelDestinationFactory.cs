// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudTrail;

public class InnerChannelDestinationFactory(Action<Humidifier.CloudTrail.ChannelTypes.Destination> factoryAction = null) : SubResourceFactory<Humidifier.CloudTrail.ChannelTypes.Destination>
{

    protected override Humidifier.CloudTrail.ChannelTypes.Destination Create()
    {
        var destinationResult = CreateDestination();
        factoryAction?.Invoke(destinationResult);

        return destinationResult;
    }

    private Humidifier.CloudTrail.ChannelTypes.Destination CreateDestination()
    {
        var destinationResult = new Humidifier.CloudTrail.ChannelTypes.Destination();

        return destinationResult;
    }

} // End Of Class

public static class InnerChannelDestinationFactoryExtensions
{
}
