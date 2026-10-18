// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerConfigKinesisDataStreamDataFactory(Action<Humidifier.GroundStation.ConfigTypes.KinesisDataStreamData> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.ConfigTypes.KinesisDataStreamData>
{

    protected override Humidifier.GroundStation.ConfigTypes.KinesisDataStreamData Create()
    {
        var kinesisDataStreamDataResult = CreateKinesisDataStreamData();
        factoryAction?.Invoke(kinesisDataStreamDataResult);

        return kinesisDataStreamDataResult;
    }

    private Humidifier.GroundStation.ConfigTypes.KinesisDataStreamData CreateKinesisDataStreamData()
    {
        var kinesisDataStreamDataResult = new Humidifier.GroundStation.ConfigTypes.KinesisDataStreamData();

        return kinesisDataStreamDataResult;
    }

} // End Of Class

public static class InnerConfigKinesisDataStreamDataFactoryExtensions
{
}
