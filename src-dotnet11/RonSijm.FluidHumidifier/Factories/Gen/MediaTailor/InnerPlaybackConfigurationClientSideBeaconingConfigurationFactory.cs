// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerPlaybackConfigurationClientSideBeaconingConfigurationFactory(Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.ClientSideBeaconingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.PlaybackConfigurationTypes.ClientSideBeaconingConfiguration>
{

    protected override Humidifier.MediaTailor.PlaybackConfigurationTypes.ClientSideBeaconingConfiguration Create()
    {
        var clientSideBeaconingConfigurationResult = CreateClientSideBeaconingConfiguration();
        factoryAction?.Invoke(clientSideBeaconingConfigurationResult);

        return clientSideBeaconingConfigurationResult;
    }

    private Humidifier.MediaTailor.PlaybackConfigurationTypes.ClientSideBeaconingConfiguration CreateClientSideBeaconingConfiguration()
    {
        var clientSideBeaconingConfigurationResult = new Humidifier.MediaTailor.PlaybackConfigurationTypes.ClientSideBeaconingConfiguration();

        return clientSideBeaconingConfigurationResult;
    }

} // End Of Class

public static class InnerPlaybackConfigurationClientSideBeaconingConfigurationFactoryExtensions
{
}
