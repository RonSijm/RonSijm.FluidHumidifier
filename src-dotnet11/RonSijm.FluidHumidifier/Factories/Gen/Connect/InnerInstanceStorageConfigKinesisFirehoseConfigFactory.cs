// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerInstanceStorageConfigKinesisFirehoseConfigFactory(Action<Humidifier.Connect.InstanceStorageConfigTypes.KinesisFirehoseConfig> factoryAction = null) : SubResourceFactory<Humidifier.Connect.InstanceStorageConfigTypes.KinesisFirehoseConfig>
{

    protected override Humidifier.Connect.InstanceStorageConfigTypes.KinesisFirehoseConfig Create()
    {
        var kinesisFirehoseConfigResult = CreateKinesisFirehoseConfig();
        factoryAction?.Invoke(kinesisFirehoseConfigResult);

        return kinesisFirehoseConfigResult;
    }

    private Humidifier.Connect.InstanceStorageConfigTypes.KinesisFirehoseConfig CreateKinesisFirehoseConfig()
    {
        var kinesisFirehoseConfigResult = new Humidifier.Connect.InstanceStorageConfigTypes.KinesisFirehoseConfig();

        return kinesisFirehoseConfigResult;
    }

} // End Of Class

public static class InnerInstanceStorageConfigKinesisFirehoseConfigFactoryExtensions
{
}
