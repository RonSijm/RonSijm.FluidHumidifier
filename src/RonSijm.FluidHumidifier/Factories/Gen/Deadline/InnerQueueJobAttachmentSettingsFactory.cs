// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerQueueJobAttachmentSettingsFactory(Action<Humidifier.Deadline.QueueTypes.JobAttachmentSettings> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.QueueTypes.JobAttachmentSettings>
{

    protected override Humidifier.Deadline.QueueTypes.JobAttachmentSettings Create()
    {
        var jobAttachmentSettingsResult = CreateJobAttachmentSettings();
        factoryAction?.Invoke(jobAttachmentSettingsResult);

        return jobAttachmentSettingsResult;
    }

    private Humidifier.Deadline.QueueTypes.JobAttachmentSettings CreateJobAttachmentSettings()
    {
        var jobAttachmentSettingsResult = new Humidifier.Deadline.QueueTypes.JobAttachmentSettings();

        return jobAttachmentSettingsResult;
    }

} // End Of Class

public static class InnerQueueJobAttachmentSettingsFactoryExtensions
{
}
