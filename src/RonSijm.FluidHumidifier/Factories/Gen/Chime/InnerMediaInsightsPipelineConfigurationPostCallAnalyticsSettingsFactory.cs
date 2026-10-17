// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaInsightsPipelineConfigurationPostCallAnalyticsSettingsFactory(Action<Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.PostCallAnalyticsSettings> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.PostCallAnalyticsSettings>
{

    protected override Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.PostCallAnalyticsSettings Create()
    {
        var postCallAnalyticsSettingsResult = CreatePostCallAnalyticsSettings();
        factoryAction?.Invoke(postCallAnalyticsSettingsResult);

        return postCallAnalyticsSettingsResult;
    }

    private Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.PostCallAnalyticsSettings CreatePostCallAnalyticsSettings()
    {
        var postCallAnalyticsSettingsResult = new Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.PostCallAnalyticsSettings();

        return postCallAnalyticsSettingsResult;
    }

} // End Of Class

public static class InnerMediaInsightsPipelineConfigurationPostCallAnalyticsSettingsFactoryExtensions
{
}
