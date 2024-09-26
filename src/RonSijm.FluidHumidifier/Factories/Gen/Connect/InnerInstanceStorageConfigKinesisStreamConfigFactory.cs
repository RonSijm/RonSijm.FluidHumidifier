// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerInstanceStorageConfigKinesisStreamConfigFactory(Action<Humidifier.Connect.InstanceStorageConfigTypes.KinesisStreamConfig> factoryAction = null) : SubResourceFactory<Humidifier.Connect.InstanceStorageConfigTypes.KinesisStreamConfig>
{

    protected override Humidifier.Connect.InstanceStorageConfigTypes.KinesisStreamConfig Create()
    {
        var kinesisStreamConfigResult = CreateKinesisStreamConfig();
        factoryAction?.Invoke(kinesisStreamConfigResult);

        return kinesisStreamConfigResult;
    }

    private Humidifier.Connect.InstanceStorageConfigTypes.KinesisStreamConfig CreateKinesisStreamConfig()
    {
        var kinesisStreamConfigResult = new Humidifier.Connect.InstanceStorageConfigTypes.KinesisStreamConfig();

        return kinesisStreamConfigResult;
    }

} // End Of Class

public static class InnerInstanceStorageConfigKinesisStreamConfigFactoryExtensions
{
}
