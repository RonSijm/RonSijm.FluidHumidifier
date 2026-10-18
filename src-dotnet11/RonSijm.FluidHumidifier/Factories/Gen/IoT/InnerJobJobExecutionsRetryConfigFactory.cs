// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerJobJobExecutionsRetryConfigFactory(Action<Humidifier.IoT.JobTypes.JobExecutionsRetryConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoT.JobTypes.JobExecutionsRetryConfig>
{

    protected override Humidifier.IoT.JobTypes.JobExecutionsRetryConfig Create()
    {
        var jobExecutionsRetryConfigResult = CreateJobExecutionsRetryConfig();
        factoryAction?.Invoke(jobExecutionsRetryConfigResult);

        return jobExecutionsRetryConfigResult;
    }

    private Humidifier.IoT.JobTypes.JobExecutionsRetryConfig CreateJobExecutionsRetryConfig()
    {
        var jobExecutionsRetryConfigResult = new Humidifier.IoT.JobTypes.JobExecutionsRetryConfig();

        return jobExecutionsRetryConfigResult;
    }

} // End Of Class

public static class InnerJobJobExecutionsRetryConfigFactoryExtensions
{
}
