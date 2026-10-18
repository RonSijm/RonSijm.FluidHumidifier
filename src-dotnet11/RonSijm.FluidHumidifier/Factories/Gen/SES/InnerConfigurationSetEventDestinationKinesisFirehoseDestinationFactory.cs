// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerConfigurationSetEventDestinationKinesisFirehoseDestinationFactory(Action<Humidifier.SES.ConfigurationSetEventDestinationTypes.KinesisFirehoseDestination> factoryAction = null) : SubResourceFactory<Humidifier.SES.ConfigurationSetEventDestinationTypes.KinesisFirehoseDestination>
{

    protected override Humidifier.SES.ConfigurationSetEventDestinationTypes.KinesisFirehoseDestination Create()
    {
        var kinesisFirehoseDestinationResult = CreateKinesisFirehoseDestination();
        factoryAction?.Invoke(kinesisFirehoseDestinationResult);

        return kinesisFirehoseDestinationResult;
    }

    private Humidifier.SES.ConfigurationSetEventDestinationTypes.KinesisFirehoseDestination CreateKinesisFirehoseDestination()
    {
        var kinesisFirehoseDestinationResult = new Humidifier.SES.ConfigurationSetEventDestinationTypes.KinesisFirehoseDestination();

        return kinesisFirehoseDestinationResult;
    }

} // End Of Class

public static class InnerConfigurationSetEventDestinationKinesisFirehoseDestinationFactoryExtensions
{
}
