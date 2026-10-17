// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Amplify;

public class InnerAppJobConfigFactory(Action<Humidifier.Amplify.AppTypes.JobConfig> factoryAction = null) : SubResourceFactory<Humidifier.Amplify.AppTypes.JobConfig>
{

    protected override Humidifier.Amplify.AppTypes.JobConfig Create()
    {
        var jobConfigResult = CreateJobConfig();
        factoryAction?.Invoke(jobConfigResult);

        return jobConfigResult;
    }

    private Humidifier.Amplify.AppTypes.JobConfig CreateJobConfig()
    {
        var jobConfigResult = new Humidifier.Amplify.AppTypes.JobConfig();

        return jobConfigResult;
    }

} // End Of Class

public static class InnerAppJobConfigFactoryExtensions
{
}
