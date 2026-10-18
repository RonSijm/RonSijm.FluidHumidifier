// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kinesis;

public class InnerChannelRecordConfigurationFactory(Action<Humidifier.Kinesis.ChannelTypes.RecordConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kinesis.ChannelTypes.RecordConfiguration>
{

    protected override Humidifier.Kinesis.ChannelTypes.RecordConfiguration Create()
    {
        var recordConfigurationResult = CreateRecordConfiguration();
        factoryAction?.Invoke(recordConfigurationResult);

        return recordConfigurationResult;
    }

    private Humidifier.Kinesis.ChannelTypes.RecordConfiguration CreateRecordConfiguration()
    {
        var recordConfigurationResult = new Humidifier.Kinesis.ChannelTypes.RecordConfiguration();

        return recordConfigurationResult;
    }

} // End Of Class

public static class InnerChannelRecordConfigurationFactoryExtensions
{
}
