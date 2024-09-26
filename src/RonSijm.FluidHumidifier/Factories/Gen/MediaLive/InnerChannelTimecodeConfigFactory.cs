// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelTimecodeConfigFactory(Action<Humidifier.MediaLive.ChannelTypes.TimecodeConfig> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.TimecodeConfig>
{

    protected override Humidifier.MediaLive.ChannelTypes.TimecodeConfig Create()
    {
        var timecodeConfigResult = CreateTimecodeConfig();
        factoryAction?.Invoke(timecodeConfigResult);

        return timecodeConfigResult;
    }

    private Humidifier.MediaLive.ChannelTypes.TimecodeConfig CreateTimecodeConfig()
    {
        var timecodeConfigResult = new Humidifier.MediaLive.ChannelTypes.TimecodeConfig();

        return timecodeConfigResult;
    }

} // End Of Class

public static class InnerChannelTimecodeConfigFactoryExtensions
{
}
