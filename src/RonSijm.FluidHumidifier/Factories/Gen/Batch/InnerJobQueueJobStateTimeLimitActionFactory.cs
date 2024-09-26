// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerJobQueueJobStateTimeLimitActionFactory(Action<Humidifier.Batch.JobQueueTypes.JobStateTimeLimitAction> factoryAction = null) : SubResourceFactory<Humidifier.Batch.JobQueueTypes.JobStateTimeLimitAction>
{

    protected override Humidifier.Batch.JobQueueTypes.JobStateTimeLimitAction Create()
    {
        var jobStateTimeLimitActionResult = CreateJobStateTimeLimitAction();
        factoryAction?.Invoke(jobStateTimeLimitActionResult);

        return jobStateTimeLimitActionResult;
    }

    private Humidifier.Batch.JobQueueTypes.JobStateTimeLimitAction CreateJobStateTimeLimitAction()
    {
        var jobStateTimeLimitActionResult = new Humidifier.Batch.JobQueueTypes.JobStateTimeLimitAction();

        return jobStateTimeLimitActionResult;
    }

} // End Of Class

public static class InnerJobQueueJobStateTimeLimitActionFactoryExtensions
{
}
