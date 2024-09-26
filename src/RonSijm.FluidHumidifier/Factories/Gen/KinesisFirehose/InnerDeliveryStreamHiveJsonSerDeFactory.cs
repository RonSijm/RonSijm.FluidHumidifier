// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamHiveJsonSerDeFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.HiveJsonSerDe> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.HiveJsonSerDe>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.HiveJsonSerDe Create()
    {
        var hiveJsonSerDeResult = CreateHiveJsonSerDe();
        factoryAction?.Invoke(hiveJsonSerDeResult);

        return hiveJsonSerDeResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.HiveJsonSerDe CreateHiveJsonSerDe()
    {
        var hiveJsonSerDeResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.HiveJsonSerDe();

        return hiveJsonSerDeResult;
    }

} // End Of Class

public static class InnerDeliveryStreamHiveJsonSerDeFactoryExtensions
{
}
