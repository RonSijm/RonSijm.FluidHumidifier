// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class TrafficMirrorSessionFactory(string resourceName = null, Action<Humidifier.EC2.TrafficMirrorSession> factoryAction = null) : ResourceFactory<Humidifier.EC2.TrafficMirrorSession>(resourceName)
{

    protected override Humidifier.EC2.TrafficMirrorSession Create()
    {
        var trafficMirrorSessionResult = CreateTrafficMirrorSession();
        factoryAction?.Invoke(trafficMirrorSessionResult);

        return trafficMirrorSessionResult;
    }

    private Humidifier.EC2.TrafficMirrorSession CreateTrafficMirrorSession()
    {
        var trafficMirrorSessionResult = new Humidifier.EC2.TrafficMirrorSession
        {
            GivenName = InputResourceName,
        };

        return trafficMirrorSessionResult;
    }

} // End Of Class

public static class TrafficMirrorSessionFactoryExtensions
{
}
