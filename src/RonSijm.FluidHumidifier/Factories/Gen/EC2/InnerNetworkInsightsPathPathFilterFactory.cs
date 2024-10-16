// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerNetworkInsightsPathPathFilterFactory(Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> factoryAction = null) : SubResourceFactory<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter>
{

    internal InnerNetworkInsightsPathFilterPortRangeFactory DestinationPortRangeFactory { get; set; }

    internal InnerNetworkInsightsPathFilterPortRangeFactory SourcePortRangeFactory { get; set; }

    protected override Humidifier.EC2.NetworkInsightsPathTypes.PathFilter Create()
    {
        var pathFilterResult = CreatePathFilter();
        factoryAction?.Invoke(pathFilterResult);

        return pathFilterResult;
    }

    private Humidifier.EC2.NetworkInsightsPathTypes.PathFilter CreatePathFilter()
    {
        var pathFilterResult = new Humidifier.EC2.NetworkInsightsPathTypes.PathFilter();

        return pathFilterResult;
    }
    public override void CreateChildren(Humidifier.EC2.NetworkInsightsPathTypes.PathFilter result)
    {
        base.CreateChildren(result);

        result.DestinationPortRange ??= DestinationPortRangeFactory?.Build();
        result.SourcePortRange ??= SourcePortRangeFactory?.Build();
    }

} // End Of Class

public static class InnerNetworkInsightsPathPathFilterFactoryExtensions
{
    public static CombinedResult<InnerNetworkInsightsPathPathFilterFactory, InnerNetworkInsightsPathFilterPortRangeFactory> WithDestinationPortRange(this InnerNetworkInsightsPathPathFilterFactory parentFactory, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null)
    {
        parentFactory.DestinationPortRangeFactory = new InnerNetworkInsightsPathFilterPortRangeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationPortRangeFactory);
    }

    public static CombinedResult<InnerNetworkInsightsPathPathFilterFactory, InnerNetworkInsightsPathFilterPortRangeFactory> WithSourcePortRange(this InnerNetworkInsightsPathPathFilterFactory parentFactory, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null)
    {
        parentFactory.SourcePortRangeFactory = new InnerNetworkInsightsPathFilterPortRangeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourcePortRangeFactory);
    }

    public static CombinedResult<InnerNetworkInsightsPathPathFilterFactory, T1, InnerNetworkInsightsPathFilterPortRangeFactory> WithDestinationPortRange<T1>(this CombinedResult<InnerNetworkInsightsPathPathFilterFactory, T1> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerNetworkInsightsPathPathFilterFactory, InnerNetworkInsightsPathFilterPortRangeFactory> WithDestinationPortRange<T1>(this CombinedResult<T1, InnerNetworkInsightsPathPathFilterFactory> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerNetworkInsightsPathPathFilterFactory, T1, T2, InnerNetworkInsightsPathFilterPortRangeFactory> WithDestinationPortRange<T1, T2>(this CombinedResult<InnerNetworkInsightsPathPathFilterFactory, T1, T2> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerNetworkInsightsPathPathFilterFactory, T2, InnerNetworkInsightsPathFilterPortRangeFactory> WithDestinationPortRange<T1, T2>(this CombinedResult<T1, InnerNetworkInsightsPathPathFilterFactory, T2> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerNetworkInsightsPathPathFilterFactory, InnerNetworkInsightsPathFilterPortRangeFactory> WithDestinationPortRange<T1, T2>(this CombinedResult<T1, T2, InnerNetworkInsightsPathPathFilterFactory> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerNetworkInsightsPathPathFilterFactory, T1, T2, T3, InnerNetworkInsightsPathFilterPortRangeFactory> WithDestinationPortRange<T1, T2, T3>(this CombinedResult<InnerNetworkInsightsPathPathFilterFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerNetworkInsightsPathPathFilterFactory, T2, T3, InnerNetworkInsightsPathFilterPortRangeFactory> WithDestinationPortRange<T1, T2, T3>(this CombinedResult<T1, InnerNetworkInsightsPathPathFilterFactory, T2, T3> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerNetworkInsightsPathPathFilterFactory, T3, InnerNetworkInsightsPathFilterPortRangeFactory> WithDestinationPortRange<T1, T2, T3>(this CombinedResult<T1, T2, InnerNetworkInsightsPathPathFilterFactory, T3> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerNetworkInsightsPathPathFilterFactory, InnerNetworkInsightsPathFilterPortRangeFactory> WithDestinationPortRange<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerNetworkInsightsPathPathFilterFactory> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerNetworkInsightsPathPathFilterFactory, T1, T2, T3, T4, InnerNetworkInsightsPathFilterPortRangeFactory> WithDestinationPortRange<T1, T2, T3, T4>(this CombinedResult<InnerNetworkInsightsPathPathFilterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerNetworkInsightsPathPathFilterFactory, T2, T3, T4, InnerNetworkInsightsPathFilterPortRangeFactory> WithDestinationPortRange<T1, T2, T3, T4>(this CombinedResult<T1, InnerNetworkInsightsPathPathFilterFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerNetworkInsightsPathPathFilterFactory, T3, T4, InnerNetworkInsightsPathFilterPortRangeFactory> WithDestinationPortRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerNetworkInsightsPathPathFilterFactory, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerNetworkInsightsPathPathFilterFactory, T4, InnerNetworkInsightsPathFilterPortRangeFactory> WithDestinationPortRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerNetworkInsightsPathPathFilterFactory, T4> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerNetworkInsightsPathPathFilterFactory, InnerNetworkInsightsPathFilterPortRangeFactory> WithDestinationPortRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerNetworkInsightsPathPathFilterFactory> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationPortRange(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerNetworkInsightsPathPathFilterFactory, T1, InnerNetworkInsightsPathFilterPortRangeFactory> WithSourcePortRange<T1>(this CombinedResult<InnerNetworkInsightsPathPathFilterFactory, T1> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourcePortRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerNetworkInsightsPathPathFilterFactory, InnerNetworkInsightsPathFilterPortRangeFactory> WithSourcePortRange<T1>(this CombinedResult<T1, InnerNetworkInsightsPathPathFilterFactory> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourcePortRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerNetworkInsightsPathPathFilterFactory, T1, T2, InnerNetworkInsightsPathFilterPortRangeFactory> WithSourcePortRange<T1, T2>(this CombinedResult<InnerNetworkInsightsPathPathFilterFactory, T1, T2> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourcePortRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerNetworkInsightsPathPathFilterFactory, T2, InnerNetworkInsightsPathFilterPortRangeFactory> WithSourcePortRange<T1, T2>(this CombinedResult<T1, InnerNetworkInsightsPathPathFilterFactory, T2> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourcePortRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerNetworkInsightsPathPathFilterFactory, InnerNetworkInsightsPathFilterPortRangeFactory> WithSourcePortRange<T1, T2>(this CombinedResult<T1, T2, InnerNetworkInsightsPathPathFilterFactory> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourcePortRange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerNetworkInsightsPathPathFilterFactory, T1, T2, T3, InnerNetworkInsightsPathFilterPortRangeFactory> WithSourcePortRange<T1, T2, T3>(this CombinedResult<InnerNetworkInsightsPathPathFilterFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePortRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerNetworkInsightsPathPathFilterFactory, T2, T3, InnerNetworkInsightsPathFilterPortRangeFactory> WithSourcePortRange<T1, T2, T3>(this CombinedResult<T1, InnerNetworkInsightsPathPathFilterFactory, T2, T3> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePortRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerNetworkInsightsPathPathFilterFactory, T3, InnerNetworkInsightsPathFilterPortRangeFactory> WithSourcePortRange<T1, T2, T3>(this CombinedResult<T1, T2, InnerNetworkInsightsPathPathFilterFactory, T3> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePortRange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerNetworkInsightsPathPathFilterFactory, InnerNetworkInsightsPathFilterPortRangeFactory> WithSourcePortRange<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerNetworkInsightsPathPathFilterFactory> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePortRange(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerNetworkInsightsPathPathFilterFactory, T1, T2, T3, T4, InnerNetworkInsightsPathFilterPortRangeFactory> WithSourcePortRange<T1, T2, T3, T4>(this CombinedResult<InnerNetworkInsightsPathPathFilterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePortRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerNetworkInsightsPathPathFilterFactory, T2, T3, T4, InnerNetworkInsightsPathFilterPortRangeFactory> WithSourcePortRange<T1, T2, T3, T4>(this CombinedResult<T1, InnerNetworkInsightsPathPathFilterFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePortRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerNetworkInsightsPathPathFilterFactory, T3, T4, InnerNetworkInsightsPathFilterPortRangeFactory> WithSourcePortRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerNetworkInsightsPathPathFilterFactory, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePortRange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerNetworkInsightsPathPathFilterFactory, T4, InnerNetworkInsightsPathFilterPortRangeFactory> WithSourcePortRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerNetworkInsightsPathPathFilterFactory, T4> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePortRange(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerNetworkInsightsPathPathFilterFactory, InnerNetworkInsightsPathFilterPortRangeFactory> WithSourcePortRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerNetworkInsightsPathPathFilterFactory> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePortRange(combinedResult.T5, subFactoryAction));
}
