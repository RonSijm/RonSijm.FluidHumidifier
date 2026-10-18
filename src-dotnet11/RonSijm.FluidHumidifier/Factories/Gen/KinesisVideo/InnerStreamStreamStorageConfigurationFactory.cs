// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisVideo;

public class InnerStreamStreamStorageConfigurationFactory(Action<Humidifier.KinesisVideo.StreamTypes.StreamStorageConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisVideo.StreamTypes.StreamStorageConfiguration>
{

    protected override Humidifier.KinesisVideo.StreamTypes.StreamStorageConfiguration Create()
    {
        var streamStorageConfigurationResult = CreateStreamStorageConfiguration();
        factoryAction?.Invoke(streamStorageConfigurationResult);

        return streamStorageConfigurationResult;
    }

    private Humidifier.KinesisVideo.StreamTypes.StreamStorageConfiguration CreateStreamStorageConfiguration()
    {
        var streamStorageConfigurationResult = new Humidifier.KinesisVideo.StreamTypes.StreamStorageConfiguration();

        return streamStorageConfigurationResult;
    }

} // End Of Class

public static class InnerStreamStreamStorageConfigurationFactoryExtensions
{
}
