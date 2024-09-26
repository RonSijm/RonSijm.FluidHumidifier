// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PinpointEmail;

public class InnerConfigurationSetEventDestinationKinesisFirehoseDestinationFactory(Action<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.KinesisFirehoseDestination> factoryAction = null) : SubResourceFactory<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.KinesisFirehoseDestination>
{

    protected override Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.KinesisFirehoseDestination Create()
    {
        var kinesisFirehoseDestinationResult = CreateKinesisFirehoseDestination();
        factoryAction?.Invoke(kinesisFirehoseDestinationResult);

        return kinesisFirehoseDestinationResult;
    }

    private Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.KinesisFirehoseDestination CreateKinesisFirehoseDestination()
    {
        var kinesisFirehoseDestinationResult = new Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.KinesisFirehoseDestination();

        return kinesisFirehoseDestinationResult;
    }

} // End Of Class

public static class InnerConfigurationSetEventDestinationKinesisFirehoseDestinationFactoryExtensions
{
}
