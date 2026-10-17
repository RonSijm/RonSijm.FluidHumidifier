// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamDatabasesFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Databases> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.Databases>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.Databases Create()
    {
        var databasesResult = CreateDatabases();
        factoryAction?.Invoke(databasesResult);

        return databasesResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.Databases CreateDatabases()
    {
        var databasesResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.Databases();

        return databasesResult;
    }

} // End Of Class

public static class InnerDeliveryStreamDatabasesFactoryExtensions
{
}
