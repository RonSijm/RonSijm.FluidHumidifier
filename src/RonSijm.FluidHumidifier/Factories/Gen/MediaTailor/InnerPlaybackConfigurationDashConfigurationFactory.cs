// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerPlaybackConfigurationDashConfigurationFactory(Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.DashConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.PlaybackConfigurationTypes.DashConfiguration>
{

    protected override Humidifier.MediaTailor.PlaybackConfigurationTypes.DashConfiguration Create()
    {
        var dashConfigurationResult = CreateDashConfiguration();
        factoryAction?.Invoke(dashConfigurationResult);

        return dashConfigurationResult;
    }

    private Humidifier.MediaTailor.PlaybackConfigurationTypes.DashConfiguration CreateDashConfiguration()
    {
        var dashConfigurationResult = new Humidifier.MediaTailor.PlaybackConfigurationTypes.DashConfiguration();

        return dashConfigurationResult;
    }

} // End Of Class

public static class InnerPlaybackConfigurationDashConfigurationFactoryExtensions
{
}
