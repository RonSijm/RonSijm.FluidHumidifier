// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MGN;

public class JobFactory(string resourceName = null, Action<Humidifier.MGN.Job> factoryAction = null) : ResourceFactory<Humidifier.MGN.Job>(resourceName)
{

    protected override Humidifier.MGN.Job Create()
    {
        var jobResult = CreateJob();
        factoryAction?.Invoke(jobResult);

        return jobResult;
    }

    private Humidifier.MGN.Job CreateJob()
    {
        var jobResult = new Humidifier.MGN.Job
        {
            GivenName = InputResourceName,
        };

        return jobResult;
    }

} // End Of Class

public static class JobFactoryExtensions
{
}
