// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamOrcSerDeFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OrcSerDe> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.OrcSerDe>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.OrcSerDe Create()
    {
        var orcSerDeResult = CreateOrcSerDe();
        factoryAction?.Invoke(orcSerDeResult);

        return orcSerDeResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.OrcSerDe CreateOrcSerDe()
    {
        var orcSerDeResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.OrcSerDe();

        return orcSerDeResult;
    }

} // End Of Class

public static class InnerDeliveryStreamOrcSerDeFactoryExtensions
{
}
