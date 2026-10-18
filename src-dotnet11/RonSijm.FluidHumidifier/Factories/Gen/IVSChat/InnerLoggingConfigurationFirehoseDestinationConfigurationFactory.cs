// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVSChat;

public class InnerLoggingConfigurationFirehoseDestinationConfigurationFactory(Action<Humidifier.IVSChat.LoggingConfigurationTypes.FirehoseDestinationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IVSChat.LoggingConfigurationTypes.FirehoseDestinationConfiguration>
{

    protected override Humidifier.IVSChat.LoggingConfigurationTypes.FirehoseDestinationConfiguration Create()
    {
        var firehoseDestinationConfigurationResult = CreateFirehoseDestinationConfiguration();
        factoryAction?.Invoke(firehoseDestinationConfigurationResult);

        return firehoseDestinationConfigurationResult;
    }

    private Humidifier.IVSChat.LoggingConfigurationTypes.FirehoseDestinationConfiguration CreateFirehoseDestinationConfiguration()
    {
        var firehoseDestinationConfigurationResult = new Humidifier.IVSChat.LoggingConfigurationTypes.FirehoseDestinationConfiguration();

        return firehoseDestinationConfigurationResult;
    }

} // End Of Class

public static class InnerLoggingConfigurationFirehoseDestinationConfigurationFactoryExtensions
{
}
