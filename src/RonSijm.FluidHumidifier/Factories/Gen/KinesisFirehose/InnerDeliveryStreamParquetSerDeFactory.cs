// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamParquetSerDeFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.ParquetSerDe> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.ParquetSerDe>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.ParquetSerDe Create()
    {
        var parquetSerDeResult = CreateParquetSerDe();
        factoryAction?.Invoke(parquetSerDeResult);

        return parquetSerDeResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.ParquetSerDe CreateParquetSerDe()
    {
        var parquetSerDeResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.ParquetSerDe();

        return parquetSerDeResult;
    }

} // End Of Class

public static class InnerDeliveryStreamParquetSerDeFactoryExtensions
{
}
