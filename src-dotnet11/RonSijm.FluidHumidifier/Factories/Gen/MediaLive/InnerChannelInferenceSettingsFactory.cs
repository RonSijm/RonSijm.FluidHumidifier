// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelInferenceSettingsFactory(Action<Humidifier.MediaLive.ChannelTypes.InferenceSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.InferenceSettings>
{

    protected override Humidifier.MediaLive.ChannelTypes.InferenceSettings Create()
    {
        var inferenceSettingsResult = CreateInferenceSettings();
        factoryAction?.Invoke(inferenceSettingsResult);

        return inferenceSettingsResult;
    }

    private Humidifier.MediaLive.ChannelTypes.InferenceSettings CreateInferenceSettings()
    {
        var inferenceSettingsResult = new Humidifier.MediaLive.ChannelTypes.InferenceSettings();

        return inferenceSettingsResult;
    }

} // End Of Class

public static class InnerChannelInferenceSettingsFactoryExtensions
{
}
