// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DRS;

public class JobFactory(string resourceName = null, Action<Humidifier.DRS.Job> factoryAction = null) : ResourceFactory<Humidifier.DRS.Job>(resourceName)
{

    protected override Humidifier.DRS.Job Create()
    {
        var jobResult = CreateJob();
        factoryAction?.Invoke(jobResult);

        return jobResult;
    }

    private Humidifier.DRS.Job CreateJob()
    {
        var jobResult = new Humidifier.DRS.Job
        {
            GivenName = InputResourceName,
        };

        return jobResult;
    }

} // End Of Class

public static class JobFactoryExtensions
{
}
