// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class TrafficPolicyFactory(string resourceName = null, Action<Humidifier.Route53.TrafficPolicy> factoryAction = null) : ResourceFactory<Humidifier.Route53.TrafficPolicy>(resourceName)
{

    protected override Humidifier.Route53.TrafficPolicy Create()
    {
        var trafficPolicyResult = CreateTrafficPolicy();
        factoryAction?.Invoke(trafficPolicyResult);

        return trafficPolicyResult;
    }

    private Humidifier.Route53.TrafficPolicy CreateTrafficPolicy()
    {
        var trafficPolicyResult = new Humidifier.Route53.TrafficPolicy
        {
            GivenName = InputResourceName,
        };

        return trafficPolicyResult;
    }

} // End Of Class

public static class TrafficPolicyFactoryExtensions
{
}
