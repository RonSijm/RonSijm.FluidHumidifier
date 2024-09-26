// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerJobTemplateJobExecutionsRetryConfigFactory(Action<Humidifier.IoT.JobTemplateTypes.JobExecutionsRetryConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoT.JobTemplateTypes.JobExecutionsRetryConfig>
{

    protected override Humidifier.IoT.JobTemplateTypes.JobExecutionsRetryConfig Create()
    {
        var jobExecutionsRetryConfigResult = CreateJobExecutionsRetryConfig();
        factoryAction?.Invoke(jobExecutionsRetryConfigResult);

        return jobExecutionsRetryConfigResult;
    }

    private Humidifier.IoT.JobTemplateTypes.JobExecutionsRetryConfig CreateJobExecutionsRetryConfig()
    {
        var jobExecutionsRetryConfigResult = new Humidifier.IoT.JobTemplateTypes.JobExecutionsRetryConfig();

        return jobExecutionsRetryConfigResult;
    }

} // End Of Class

public static class InnerJobTemplateJobExecutionsRetryConfigFactoryExtensions
{
}
