// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerPlaybackConfigurationBumperFactory(Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.Bumper> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.PlaybackConfigurationTypes.Bumper>
{

    protected override Humidifier.MediaTailor.PlaybackConfigurationTypes.Bumper Create()
    {
        var bumperResult = CreateBumper();
        factoryAction?.Invoke(bumperResult);

        return bumperResult;
    }

    private Humidifier.MediaTailor.PlaybackConfigurationTypes.Bumper CreateBumper()
    {
        var bumperResult = new Humidifier.MediaTailor.PlaybackConfigurationTypes.Bumper();

        return bumperResult;
    }

} // End Of Class

public static class InnerPlaybackConfigurationBumperFactoryExtensions
{
}
