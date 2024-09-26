// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class CloudWatchAlarmTemplateFactory(string resourceName = null, Action<Humidifier.MediaLive.CloudWatchAlarmTemplate> factoryAction = null) : ResourceFactory<Humidifier.MediaLive.CloudWatchAlarmTemplate>(resourceName)
{

    protected override Humidifier.MediaLive.CloudWatchAlarmTemplate Create()
    {
        var cloudWatchAlarmTemplateResult = CreateCloudWatchAlarmTemplate();
        factoryAction?.Invoke(cloudWatchAlarmTemplateResult);

        return cloudWatchAlarmTemplateResult;
    }

    private Humidifier.MediaLive.CloudWatchAlarmTemplate CreateCloudWatchAlarmTemplate()
    {
        var cloudWatchAlarmTemplateResult = new Humidifier.MediaLive.CloudWatchAlarmTemplate
        {
            GivenName = InputResourceName,
        };

        return cloudWatchAlarmTemplateResult;
    }

} // End Of Class

public static class CloudWatchAlarmTemplateFactoryExtensions
{
}
