// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SMSVOICE;

public class InnerConfigurationSetKinesisFirehoseDestinationFactory(Action<Humidifier.SMSVOICE.ConfigurationSetTypes.KinesisFirehoseDestination> factoryAction = null) : SubResourceFactory<Humidifier.SMSVOICE.ConfigurationSetTypes.KinesisFirehoseDestination>
{

    protected override Humidifier.SMSVOICE.ConfigurationSetTypes.KinesisFirehoseDestination Create()
    {
        var kinesisFirehoseDestinationResult = CreateKinesisFirehoseDestination();
        factoryAction?.Invoke(kinesisFirehoseDestinationResult);

        return kinesisFirehoseDestinationResult;
    }

    private Humidifier.SMSVOICE.ConfigurationSetTypes.KinesisFirehoseDestination CreateKinesisFirehoseDestination()
    {
        var kinesisFirehoseDestinationResult = new Humidifier.SMSVOICE.ConfigurationSetTypes.KinesisFirehoseDestination();

        return kinesisFirehoseDestinationResult;
    }

} // End Of Class

public static class InnerConfigurationSetKinesisFirehoseDestinationFactoryExtensions
{
}
