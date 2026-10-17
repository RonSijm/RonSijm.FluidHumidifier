// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataExchange;

public class JobFactory(string resourceName = null, Action<Humidifier.DataExchange.Job> factoryAction = null) : ResourceFactory<Humidifier.DataExchange.Job>(resourceName)
{

    protected override Humidifier.DataExchange.Job Create()
    {
        var jobResult = CreateJob();
        factoryAction?.Invoke(jobResult);

        return jobResult;
    }

    private Humidifier.DataExchange.Job CreateJob()
    {
        var jobResult = new Humidifier.DataExchange.Job
        {
            GivenName = InputResourceName,
        };

        return jobResult;
    }

} // End Of Class

public static class JobFactoryExtensions
{
}
