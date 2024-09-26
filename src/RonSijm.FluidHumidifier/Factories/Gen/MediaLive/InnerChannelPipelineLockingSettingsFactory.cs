// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelPipelineLockingSettingsFactory(Action<Humidifier.MediaLive.ChannelTypes.PipelineLockingSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.PipelineLockingSettings>
{

    protected override Humidifier.MediaLive.ChannelTypes.PipelineLockingSettings Create()
    {
        var pipelineLockingSettingsResult = CreatePipelineLockingSettings();
        factoryAction?.Invoke(pipelineLockingSettingsResult);

        return pipelineLockingSettingsResult;
    }

    private Humidifier.MediaLive.ChannelTypes.PipelineLockingSettings CreatePipelineLockingSettings()
    {
        var pipelineLockingSettingsResult = new Humidifier.MediaLive.ChannelTypes.PipelineLockingSettings();

        return pipelineLockingSettingsResult;
    }

} // End Of Class

public static class InnerChannelPipelineLockingSettingsFactoryExtensions
{
}
