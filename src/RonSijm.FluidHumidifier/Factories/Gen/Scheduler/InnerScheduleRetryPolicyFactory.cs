// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Scheduler;

public class InnerScheduleRetryPolicyFactory(Action<Humidifier.Scheduler.ScheduleTypes.RetryPolicy> factoryAction = null) : SubResourceFactory<Humidifier.Scheduler.ScheduleTypes.RetryPolicy>
{

    protected override Humidifier.Scheduler.ScheduleTypes.RetryPolicy Create()
    {
        var retryPolicyResult = CreateRetryPolicy();
        factoryAction?.Invoke(retryPolicyResult);

        return retryPolicyResult;
    }

    private Humidifier.Scheduler.ScheduleTypes.RetryPolicy CreateRetryPolicy()
    {
        var retryPolicyResult = new Humidifier.Scheduler.ScheduleTypes.RetryPolicy();

        return retryPolicyResult;
    }

} // End Of Class

public static class InnerScheduleRetryPolicyFactoryExtensions
{
}
