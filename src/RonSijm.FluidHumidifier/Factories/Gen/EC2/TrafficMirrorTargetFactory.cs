// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class TrafficMirrorTargetFactory(string resourceName = null, Action<Humidifier.EC2.TrafficMirrorTarget> factoryAction = null) : ResourceFactory<Humidifier.EC2.TrafficMirrorTarget>(resourceName)
{

    protected override Humidifier.EC2.TrafficMirrorTarget Create()
    {
        var trafficMirrorTargetResult = CreateTrafficMirrorTarget();
        factoryAction?.Invoke(trafficMirrorTargetResult);

        return trafficMirrorTargetResult;
    }

    private Humidifier.EC2.TrafficMirrorTarget CreateTrafficMirrorTarget()
    {
        var trafficMirrorTargetResult = new Humidifier.EC2.TrafficMirrorTarget
        {
            GivenName = InputResourceName,
        };

        return trafficMirrorTargetResult;
    }

} // End Of Class

public static class TrafficMirrorTargetFactoryExtensions
{
}
