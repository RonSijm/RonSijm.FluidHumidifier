// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamDatabaseTablesFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.DatabaseTables> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.DatabaseTables>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.DatabaseTables Create()
    {
        var databaseTablesResult = CreateDatabaseTables();
        factoryAction?.Invoke(databaseTablesResult);

        return databaseTablesResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.DatabaseTables CreateDatabaseTables()
    {
        var databaseTablesResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.DatabaseTables();

        return databaseTablesResult;
    }

} // End Of Class

public static class InnerDeliveryStreamDatabaseTablesFactoryExtensions
{
}
