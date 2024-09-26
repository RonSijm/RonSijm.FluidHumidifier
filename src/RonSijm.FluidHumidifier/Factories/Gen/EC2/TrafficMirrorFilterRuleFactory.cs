// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class TrafficMirrorFilterRuleFactory(string resourceName = null, Action<Humidifier.EC2.TrafficMirrorFilterRule> factoryAction = null) : ResourceFactory<Humidifier.EC2.TrafficMirrorFilterRule>(resourceName)
{

    internal InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory DestinationPortRangeFactory { get; set; }

    internal InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory SourcePortRangeFactory { get; set; }

    protected override Humidifier.EC2.TrafficMirrorFilterRule Create()
    {
        var trafficMirrorFilterRuleResult = CreateTrafficMirrorFilterRule();
        factoryAction?.Invoke(trafficMirrorFilterRuleResult);

        return trafficMirrorFilterRuleResult;
    }

    private Humidifier.EC2.TrafficMirrorFilterRule CreateTrafficMirrorFilterRule()
    {
        var trafficMirrorFilterRuleResult = new Humidifier.EC2.TrafficMirrorFilterRule
        {
            GivenName = InputResourceName,
        };

        return trafficMirrorFilterRuleResult;
    }
    public override void CreateChildren(Humidifier.EC2.TrafficMirrorFilterRule result)
    {
        base.CreateChildren(result);

        result.DestinationPortRange ??= DestinationPortRangeFactory?.Build();
        result.SourcePortRange ??= SourcePortRangeFactory?.Build();
    }

} // End Of Class

public static class TrafficMirrorFilterRuleFactoryExtensions
{
    public static CombinedResult<TrafficMirrorFilterRuleFactory, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithDestinationPortRange(this TrafficMirrorFilterRuleFactory parentFactory, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null)
    {
        parentFactory.DestinationPortRangeFactory = new InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationPortRangeFactory);
    }

    public static CombinedResult<TrafficMirrorFilterRuleFactory, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithSourcePortRange(this TrafficMirrorFilterRuleFactory parentFactory, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null)
    {
        parentFactory.SourcePortRangeFactory = new InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourcePortRangeFactory);
    }

    public static CombinedResult<TrafficMirrorFilterRuleFactory, T1, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithDestinationPortRange<T1>(this CombinedResult<TrafficMirrorFilterRuleFactory, T1> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrafficMirrorFilterRuleFactory, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithDestinationPortRange<T1>(this CombinedResult<T1, TrafficMirrorFilterRuleFactory> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TrafficMirrorFilterRuleFactory, T1, T2, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithDestinationPortRange<T1, T2>(this CombinedResult<TrafficMirrorFilterRuleFactory, T1, T2> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrafficMirrorFilterRuleFactory, T2, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithDestinationPortRange<T1, T2>(this CombinedResult<T1, TrafficMirrorFilterRuleFactory, T2> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrafficMirrorFilterRuleFactory, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithDestinationPortRange<T1, T2>(this CombinedResult<T1, T2, TrafficMirrorFilterRuleFactory> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TrafficMirrorFilterRuleFactory, T1, T2, T3, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithDestinationPortRange<T1, T2, T3>(this CombinedResult<TrafficMirrorFilterRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrafficMirrorFilterRuleFactory, T2, T3, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithDestinationPortRange<T1, T2, T3>(this CombinedResult<T1, TrafficMirrorFilterRuleFactory, T2, T3> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrafficMirrorFilterRuleFactory, T3, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithDestinationPortRange<T1, T2, T3>(this CombinedResult<T1, T2, TrafficMirrorFilterRuleFactory, T3> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TrafficMirrorFilterRuleFactory, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithDestinationPortRange<T1, T2, T3>(this CombinedResult<T1, T2, T3, TrafficMirrorFilterRuleFactory> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TrafficMirrorFilterRuleFactory, T1, T2, T3, T4, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithDestinationPortRange<T1, T2, T3, T4>(this CombinedResult<TrafficMirrorFilterRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrafficMirrorFilterRuleFactory, T2, T3, T4, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithDestinationPortRange<T1, T2, T3, T4>(this CombinedResult<T1, TrafficMirrorFilterRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrafficMirrorFilterRuleFactory, T3, T4, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithDestinationPortRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, TrafficMirrorFilterRuleFactory, T3, T4> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TrafficMirrorFilterRuleFactory, T4, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithDestinationPortRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TrafficMirrorFilterRuleFactory, T4> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TrafficMirrorFilterRuleFactory, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithDestinationPortRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TrafficMirrorFilterRuleFactory> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T5, subFactoryAction));
    public static CombinedResult<TrafficMirrorFilterRuleFactory, T1, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithSourcePortRange<T1>(this CombinedResult<TrafficMirrorFilterRuleFactory, T1> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourcePortRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrafficMirrorFilterRuleFactory, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithSourcePortRange<T1>(this CombinedResult<T1, TrafficMirrorFilterRuleFactory> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourcePortRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TrafficMirrorFilterRuleFactory, T1, T2, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithSourcePortRange<T1, T2>(this CombinedResult<TrafficMirrorFilterRuleFactory, T1, T2> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourcePortRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrafficMirrorFilterRuleFactory, T2, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithSourcePortRange<T1, T2>(this CombinedResult<T1, TrafficMirrorFilterRuleFactory, T2> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourcePortRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrafficMirrorFilterRuleFactory, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithSourcePortRange<T1, T2>(this CombinedResult<T1, T2, TrafficMirrorFilterRuleFactory> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourcePortRange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TrafficMirrorFilterRuleFactory, T1, T2, T3, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithSourcePortRange<T1, T2, T3>(this CombinedResult<TrafficMirrorFilterRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePortRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrafficMirrorFilterRuleFactory, T2, T3, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithSourcePortRange<T1, T2, T3>(this CombinedResult<T1, TrafficMirrorFilterRuleFactory, T2, T3> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePortRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrafficMirrorFilterRuleFactory, T3, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithSourcePortRange<T1, T2, T3>(this CombinedResult<T1, T2, TrafficMirrorFilterRuleFactory, T3> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePortRange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TrafficMirrorFilterRuleFactory, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithSourcePortRange<T1, T2, T3>(this CombinedResult<T1, T2, T3, TrafficMirrorFilterRuleFactory> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePortRange(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TrafficMirrorFilterRuleFactory, T1, T2, T3, T4, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithSourcePortRange<T1, T2, T3, T4>(this CombinedResult<TrafficMirrorFilterRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePortRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrafficMirrorFilterRuleFactory, T2, T3, T4, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithSourcePortRange<T1, T2, T3, T4>(this CombinedResult<T1, TrafficMirrorFilterRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePortRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrafficMirrorFilterRuleFactory, T3, T4, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithSourcePortRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, TrafficMirrorFilterRuleFactory, T3, T4> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePortRange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TrafficMirrorFilterRuleFactory, T4, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithSourcePortRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TrafficMirrorFilterRuleFactory, T4> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePortRange(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TrafficMirrorFilterRuleFactory, InnerTrafficMirrorFilterRuleTrafficMirrorPortRangeFactory> WithSourcePortRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TrafficMirrorFilterRuleFactory> combinedResult, Action<Humidifier.EC2.TrafficMirrorFilterRuleTypes.TrafficMirrorPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePortRange(combinedResult.T5, subFactoryAction));
}
