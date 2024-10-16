// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class TrafficMirrorFilterFactory(string resourceName = null, Action<Humidifier.EC2.TrafficMirrorFilter> factoryAction = null) : ResourceFactory<Humidifier.EC2.TrafficMirrorFilter>(resourceName)
{

    protected override Humidifier.EC2.TrafficMirrorFilter Create()
    {
        var trafficMirrorFilterResult = CreateTrafficMirrorFilter();
        factoryAction?.Invoke(trafficMirrorFilterResult);

        return trafficMirrorFilterResult;
    }

    private Humidifier.EC2.TrafficMirrorFilter CreateTrafficMirrorFilter()
    {
        var trafficMirrorFilterResult = new Humidifier.EC2.TrafficMirrorFilter
        {
            GivenName = InputResourceName,
        };

        return trafficMirrorFilterResult;
    }

} // End Of Class

public static class TrafficMirrorFilterFactoryExtensions
{
}
