// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class CloudWatchAlarmTemplateGroupFactory(string resourceName = null, Action<Humidifier.MediaLive.CloudWatchAlarmTemplateGroup> factoryAction = null) : ResourceFactory<Humidifier.MediaLive.CloudWatchAlarmTemplateGroup>(resourceName)
{

    protected override Humidifier.MediaLive.CloudWatchAlarmTemplateGroup Create()
    {
        var cloudWatchAlarmTemplateGroupResult = CreateCloudWatchAlarmTemplateGroup();
        factoryAction?.Invoke(cloudWatchAlarmTemplateGroupResult);

        return cloudWatchAlarmTemplateGroupResult;
    }

    private Humidifier.MediaLive.CloudWatchAlarmTemplateGroup CreateCloudWatchAlarmTemplateGroup()
    {
        var cloudWatchAlarmTemplateGroupResult = new Humidifier.MediaLive.CloudWatchAlarmTemplateGroup
        {
            GivenName = InputResourceName,
        };

        return cloudWatchAlarmTemplateGroupResult;
    }

} // End Of Class

public static class CloudWatchAlarmTemplateGroupFactoryExtensions
{
}
