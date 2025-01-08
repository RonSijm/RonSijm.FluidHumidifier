// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamDatabaseSourceVPCConfigurationFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.DatabaseSourceVPCConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.DatabaseSourceVPCConfiguration>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.DatabaseSourceVPCConfiguration Create()
    {
        var databaseSourceVPCConfigurationResult = CreateDatabaseSourceVPCConfiguration();
        factoryAction?.Invoke(databaseSourceVPCConfigurationResult);

        return databaseSourceVPCConfigurationResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.DatabaseSourceVPCConfiguration CreateDatabaseSourceVPCConfiguration()
    {
        var databaseSourceVPCConfigurationResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.DatabaseSourceVPCConfiguration();

        return databaseSourceVPCConfigurationResult;
    }

} // End Of Class

public static class InnerDeliveryStreamDatabaseSourceVPCConfigurationFactoryExtensions
{
}
