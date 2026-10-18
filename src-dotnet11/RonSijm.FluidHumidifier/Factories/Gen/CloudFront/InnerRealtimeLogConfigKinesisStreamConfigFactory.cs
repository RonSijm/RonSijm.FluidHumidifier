// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerRealtimeLogConfigKinesisStreamConfigFactory(Action<Humidifier.CloudFront.RealtimeLogConfigTypes.KinesisStreamConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.RealtimeLogConfigTypes.KinesisStreamConfig>
{

    protected override Humidifier.CloudFront.RealtimeLogConfigTypes.KinesisStreamConfig Create()
    {
        var kinesisStreamConfigResult = CreateKinesisStreamConfig();
        factoryAction?.Invoke(kinesisStreamConfigResult);

        return kinesisStreamConfigResult;
    }

    private Humidifier.CloudFront.RealtimeLogConfigTypes.KinesisStreamConfig CreateKinesisStreamConfig()
    {
        var kinesisStreamConfigResult = new Humidifier.CloudFront.RealtimeLogConfigTypes.KinesisStreamConfig();

        return kinesisStreamConfigResult;
    }

} // End Of Class

public static class InnerRealtimeLogConfigKinesisStreamConfigFactoryExtensions
{
}
