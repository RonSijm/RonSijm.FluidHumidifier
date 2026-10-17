// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamDatabaseColumnsFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.DatabaseColumns> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.DatabaseColumns>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.DatabaseColumns Create()
    {
        var databaseColumnsResult = CreateDatabaseColumns();
        factoryAction?.Invoke(databaseColumnsResult);

        return databaseColumnsResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.DatabaseColumns CreateDatabaseColumns()
    {
        var databaseColumnsResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.DatabaseColumns();

        return databaseColumnsResult;
    }

} // End Of Class

public static class InnerDeliveryStreamDatabaseColumnsFactoryExtensions
{
}
