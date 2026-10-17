// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class TrafficPolicyInstanceFactory(string resourceName = null, Action<Humidifier.Route53.TrafficPolicyInstance> factoryAction = null) : ResourceFactory<Humidifier.Route53.TrafficPolicyInstance>(resourceName)
{

    protected override Humidifier.Route53.TrafficPolicyInstance Create()
    {
        var trafficPolicyInstanceResult = CreateTrafficPolicyInstance();
        factoryAction?.Invoke(trafficPolicyInstanceResult);

        return trafficPolicyInstanceResult;
    }

    private Humidifier.Route53.TrafficPolicyInstance CreateTrafficPolicyInstance()
    {
        var trafficPolicyInstanceResult = new Humidifier.Route53.TrafficPolicyInstance
        {
            GivenName = InputResourceName,
        };

        return trafficPolicyInstanceResult;
    }

} // End Of Class

public static class TrafficPolicyInstanceFactoryExtensions
{
}
