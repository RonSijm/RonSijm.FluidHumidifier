// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class InnerStackStreamingExperienceSettingsFactory(Action<Humidifier.AppStream.StackTypes.StreamingExperienceSettings> factoryAction = null) : SubResourceFactory<Humidifier.AppStream.StackTypes.StreamingExperienceSettings>
{

    protected override Humidifier.AppStream.StackTypes.StreamingExperienceSettings Create()
    {
        var streamingExperienceSettingsResult = CreateStreamingExperienceSettings();
        factoryAction?.Invoke(streamingExperienceSettingsResult);

        return streamingExperienceSettingsResult;
    }

    private Humidifier.AppStream.StackTypes.StreamingExperienceSettings CreateStreamingExperienceSettings()
    {
        var streamingExperienceSettingsResult = new Humidifier.AppStream.StackTypes.StreamingExperienceSettings();

        return streamingExperienceSettingsResult;
    }

} // End Of Class

public static class InnerStackStreamingExperienceSettingsFactoryExtensions
{
}
