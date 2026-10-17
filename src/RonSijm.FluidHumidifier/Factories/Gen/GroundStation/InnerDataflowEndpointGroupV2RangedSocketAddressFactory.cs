// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerDataflowEndpointGroupV2RangedSocketAddressFactory(Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedSocketAddress> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedSocketAddress>
{

    internal InnerDataflowEndpointGroupV2IntegerRangeFactory PortRangeFactory { get; set; }

    protected override Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedSocketAddress Create()
    {
        var rangedSocketAddressResult = CreateRangedSocketAddress();
        factoryAction?.Invoke(rangedSocketAddressResult);

        return rangedSocketAddressResult;
    }

    private Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedSocketAddress CreateRangedSocketAddress()
    {
        var rangedSocketAddressResult = new Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedSocketAddress();

        return rangedSocketAddressResult;
    }
    public override void CreateChildren(Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedSocketAddress result)
    {
        base.CreateChildren(result);

        result.PortRange ??= PortRangeFactory?.Build();
    }

} // End Of Class

public static class InnerDataflowEndpointGroupV2RangedSocketAddressFactoryExtensions
{
    public static CombinedResult<InnerDataflowEndpointGroupV2RangedSocketAddressFactory, InnerDataflowEndpointGroupV2IntegerRangeFactory> WithPortRange(this InnerDataflowEndpointGroupV2RangedSocketAddressFactory parentFactory, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.IntegerRange> subFactoryAction = null)
    {
        parentFactory.PortRangeFactory = new InnerDataflowEndpointGroupV2IntegerRangeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PortRangeFactory);
    }

    public static CombinedResult<InnerDataflowEndpointGroupV2RangedSocketAddressFactory, T1, InnerDataflowEndpointGroupV2IntegerRangeFactory> WithPortRange<T1>(this CombinedResult<InnerDataflowEndpointGroupV2RangedSocketAddressFactory, T1> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithPortRange(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2RangedSocketAddressFactory, InnerDataflowEndpointGroupV2IntegerRangeFactory> WithPortRange<T1>(this CombinedResult<T1, InnerDataflowEndpointGroupV2RangedSocketAddressFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithPortRange(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataflowEndpointGroupV2RangedSocketAddressFactory, T1, T2, InnerDataflowEndpointGroupV2IntegerRangeFactory> WithPortRange<T1, T2>(this CombinedResult<InnerDataflowEndpointGroupV2RangedSocketAddressFactory, T1, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2RangedSocketAddressFactory, T2, InnerDataflowEndpointGroupV2IntegerRangeFactory> WithPortRange<T1, T2>(this CombinedResult<T1, InnerDataflowEndpointGroupV2RangedSocketAddressFactory, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupV2RangedSocketAddressFactory, InnerDataflowEndpointGroupV2IntegerRangeFactory> WithPortRange<T1, T2>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupV2RangedSocketAddressFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataflowEndpointGroupV2RangedSocketAddressFactory, T1, T2, T3, InnerDataflowEndpointGroupV2IntegerRangeFactory> WithPortRange<T1, T2, T3>(this CombinedResult<InnerDataflowEndpointGroupV2RangedSocketAddressFactory, T1, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2RangedSocketAddressFactory, T2, T3, InnerDataflowEndpointGroupV2IntegerRangeFactory> WithPortRange<T1, T2, T3>(this CombinedResult<T1, InnerDataflowEndpointGroupV2RangedSocketAddressFactory, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupV2RangedSocketAddressFactory, T3, InnerDataflowEndpointGroupV2IntegerRangeFactory> WithPortRange<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupV2RangedSocketAddressFactory, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2RangedSocketAddressFactory, InnerDataflowEndpointGroupV2IntegerRangeFactory> WithPortRange<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2RangedSocketAddressFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataflowEndpointGroupV2RangedSocketAddressFactory, T1, T2, T3, T4, InnerDataflowEndpointGroupV2IntegerRangeFactory> WithPortRange<T1, T2, T3, T4>(this CombinedResult<InnerDataflowEndpointGroupV2RangedSocketAddressFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2RangedSocketAddressFactory, T2, T3, T4, InnerDataflowEndpointGroupV2IntegerRangeFactory> WithPortRange<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataflowEndpointGroupV2RangedSocketAddressFactory, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupV2RangedSocketAddressFactory, T3, T4, InnerDataflowEndpointGroupV2IntegerRangeFactory> WithPortRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupV2RangedSocketAddressFactory, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2RangedSocketAddressFactory, T4, InnerDataflowEndpointGroupV2IntegerRangeFactory> WithPortRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2RangedSocketAddressFactory, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataflowEndpointGroupV2RangedSocketAddressFactory, InnerDataflowEndpointGroupV2IntegerRangeFactory> WithPortRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataflowEndpointGroupV2RangedSocketAddressFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T5, subFactoryAction).T2);
}
