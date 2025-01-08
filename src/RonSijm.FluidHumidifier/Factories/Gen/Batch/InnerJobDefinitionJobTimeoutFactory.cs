// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerJobDefinitionJobTimeoutFactory(Action<Humidifier.Batch.JobDefinitionTypes.JobTimeout> factoryAction = null) : SubResourceFactory<Humidifier.Batch.JobDefinitionTypes.JobTimeout>
{

    protected override Humidifier.Batch.JobDefinitionTypes.JobTimeout Create()
    {
        var jobTimeoutResult = CreateJobTimeout();
        factoryAction?.Invoke(jobTimeoutResult);

        return jobTimeoutResult;
    }

    private Humidifier.Batch.JobDefinitionTypes.JobTimeout CreateJobTimeout()
    {
        var jobTimeoutResult = new Humidifier.Batch.JobDefinitionTypes.JobTimeout();

        return jobTimeoutResult;
    }

} // End Of Class

public static class InnerJobDefinitionJobTimeoutFactoryExtensions
{
}
