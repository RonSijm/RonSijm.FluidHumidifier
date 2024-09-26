// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory(Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> factoryAction = null) : SubResourceFactory<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange>
{

    protected override Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange Create()
    {
        var trafficMirrorPortRangeResult = CreateTrafficMirrorPortRange();
        factoryAction?.Invoke(trafficMirrorPortRangeResult);

        return trafficMirrorPortRangeResult;
    }

    private Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange CreateTrafficMirrorPortRange()
    {
        var trafficMirrorPortRangeResult = new Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange();

        return trafficMirrorPortRangeResult;
    }

} // End Of Class

public static class InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactoryExtensions
{
}
