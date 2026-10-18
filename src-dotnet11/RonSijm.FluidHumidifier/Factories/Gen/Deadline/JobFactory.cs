// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class JobFactory(string resourceName = null, Action<Humidifier.Deadline.Job> factoryAction = null) : ResourceFactory<Humidifier.Deadline.Job>(resourceName)
{

    protected override Humidifier.Deadline.Job Create()
    {
        var jobResult = CreateJob();
        factoryAction?.Invoke(jobResult);

        return jobResult;
    }

    private Humidifier.Deadline.Job CreateJob()
    {
        var jobResult = new Humidifier.Deadline.Job
        {
            GivenName = InputResourceName,
        };

        return jobResult;
    }

} // End Of Class

public static class JobFactoryExtensions
{
}
