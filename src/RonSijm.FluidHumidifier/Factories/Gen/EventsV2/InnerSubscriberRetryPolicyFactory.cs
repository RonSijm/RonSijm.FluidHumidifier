// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventsV2;

public class InnerSubscriberRetryPolicyFactory(Action<Humidifier.EventsV2.SubscriberTypes.RetryPolicy> factoryAction = null) : SubResourceFactory<Humidifier.EventsV2.SubscriberTypes.RetryPolicy>
{

    protected override Humidifier.EventsV2.SubscriberTypes.RetryPolicy Create()
    {
        var retryPolicyResult = CreateRetryPolicy();
        factoryAction?.Invoke(retryPolicyResult);

        return retryPolicyResult;
    }

    private Humidifier.EventsV2.SubscriberTypes.RetryPolicy CreateRetryPolicy()
    {
        var retryPolicyResult = new Humidifier.EventsV2.SubscriberTypes.RetryPolicy();

        return retryPolicyResult;
    }

} // End Of Class

public static class InnerSubscriberRetryPolicyFactoryExtensions
{
}
