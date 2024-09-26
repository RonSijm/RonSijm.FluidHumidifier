// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamOpenXJsonSerDeFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OpenXJsonSerDe> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.OpenXJsonSerDe>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.OpenXJsonSerDe Create()
    {
        var openXJsonSerDeResult = CreateOpenXJsonSerDe();
        factoryAction?.Invoke(openXJsonSerDeResult);

        return openXJsonSerDeResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.OpenXJsonSerDe CreateOpenXJsonSerDe()
    {
        var openXJsonSerDeResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.OpenXJsonSerDe();

        return openXJsonSerDeResult;
    }

} // End Of Class

public static class InnerDeliveryStreamOpenXJsonSerDeFactoryExtensions
{
}
