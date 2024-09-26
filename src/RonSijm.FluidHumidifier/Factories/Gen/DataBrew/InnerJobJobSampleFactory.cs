// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerJobJobSampleFactory(Action<Humidifier.DataBrew.JobTypes.JobSample> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.JobTypes.JobSample>
{

    protected override Humidifier.DataBrew.JobTypes.JobSample Create()
    {
        var jobSampleResult = CreateJobSample();
        factoryAction?.Invoke(jobSampleResult);

        return jobSampleResult;
    }

    private Humidifier.DataBrew.JobTypes.JobSample CreateJobSample()
    {
        var jobSampleResult = new Humidifier.DataBrew.JobTypes.JobSample();

        return jobSampleResult;
    }

} // End Of Class

public static class InnerJobJobSampleFactoryExtensions
{
}
