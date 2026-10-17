// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Amplify;

public class JobsFactory(string resourceName = null, Action<Humidifier.Amplify.Jobs> factoryAction = null) : ResourceFactory<Humidifier.Amplify.Jobs>(resourceName)
{

    protected override Humidifier.Amplify.Jobs Create()
    {
        var jobsResult = CreateJobs();
        factoryAction?.Invoke(jobsResult);

        return jobsResult;
    }

    private Humidifier.Amplify.Jobs CreateJobs()
    {
        var jobsResult = new Humidifier.Amplify.Jobs
        {
            GivenName = InputResourceName,
        };

        return jobsResult;
    }

} // End Of Class

public static class JobsFactoryExtensions
{
}
