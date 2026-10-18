// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class NetworkPerformanceMetricSubscriptionFactory(string resourceName = null, Action<Humidifier.EC2.NetworkPerformanceMetricSubscription> factoryAction = null) : ResourceFactory<Humidifier.EC2.NetworkPerformanceMetricSubscription>(resourceName)
{

    protected override Humidifier.EC2.NetworkPerformanceMetricSubscription Create()
    {
        var networkPerformanceMetricSubscriptionResult = CreateNetworkPerformanceMetricSubscription();
        factoryAction?.Invoke(networkPerformanceMetricSubscriptionResult);

        return networkPerformanceMetricSubscriptionResult;
    }

    private Humidifier.EC2.NetworkPerformanceMetricSubscription CreateNetworkPerformanceMetricSubscription()
    {
        var networkPerformanceMetricSubscriptionResult = new Humidifier.EC2.NetworkPerformanceMetricSubscription
        {
            GivenName = InputResourceName,
        };

        return networkPerformanceMetricSubscriptionResult;
    }

} // End Of Class

public static class NetworkPerformanceMetricSubscriptionFactoryExtensions
{
}
