// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerDataflowEndpointGroupRangedSocketAddressFactory(Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedSocketAddress> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedSocketAddress>
{

    internal InnerDataflowEndpointGroupIntegerRangeFactory PortRangeFactory { get; set; }

    protected override Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedSocketAddress Create()
    {
        var rangedSocketAddressResult = CreateRangedSocketAddress();
        factoryAction?.Invoke(rangedSocketAddressResult);

        return rangedSocketAddressResult;
    }

    private Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedSocketAddress CreateRangedSocketAddress()
    {
        var rangedSocketAddressResult = new Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedSocketAddress();

        return rangedSocketAddressResult;
    }
    public override void CreateChildren(Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedSocketAddress result)
    {
        base.CreateChildren(result);

        result.PortRange ??= PortRangeFactory?.Build();
    }

} // End Of Class

public static class InnerDataflowEndpointGroupRangedSocketAddressFactoryExtensions
{
    public static CombinedResult<InnerDataflowEndpointGroupRangedSocketAddressFactory, InnerDataflowEndpointGroupIntegerRangeFactory> WithPortRange(this InnerDataflowEndpointGroupRangedSocketAddressFactory parentFactory, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.IntegerRange> subFactoryAction = null)
    {
        parentFactory.PortRangeFactory = new InnerDataflowEndpointGroupIntegerRangeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PortRangeFactory);
    }

    public static CombinedResult<InnerDataflowEndpointGroupRangedSocketAddressFactory, T1, InnerDataflowEndpointGroupIntegerRangeFactory> WithPortRange<T1>(this CombinedResult<InnerDataflowEndpointGroupRangedSocketAddressFactory, T1> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithPortRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataflowEndpointGroupRangedSocketAddressFactory, InnerDataflowEndpointGroupIntegerRangeFactory> WithPortRange<T1>(this CombinedResult<T1, InnerDataflowEndpointGroupRangedSocketAddressFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithPortRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataflowEndpointGroupRangedSocketAddressFactory, T1, T2, InnerDataflowEndpointGroupIntegerRangeFactory> WithPortRange<T1, T2>(this CombinedResult<InnerDataflowEndpointGroupRangedSocketAddressFactory, T1, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataflowEndpointGroupRangedSocketAddressFactory, T2, InnerDataflowEndpointGroupIntegerRangeFactory> WithPortRange<T1, T2>(this CombinedResult<T1, InnerDataflowEndpointGroupRangedSocketAddressFactory, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupRangedSocketAddressFactory, InnerDataflowEndpointGroupIntegerRangeFactory> WithPortRange<T1, T2>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupRangedSocketAddressFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataflowEndpointGroupRangedSocketAddressFactory, T1, T2, T3, InnerDataflowEndpointGroupIntegerRangeFactory> WithPortRange<T1, T2, T3>(this CombinedResult<InnerDataflowEndpointGroupRangedSocketAddressFactory, T1, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataflowEndpointGroupRangedSocketAddressFactory, T2, T3, InnerDataflowEndpointGroupIntegerRangeFactory> WithPortRange<T1, T2, T3>(this CombinedResult<T1, InnerDataflowEndpointGroupRangedSocketAddressFactory, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupRangedSocketAddressFactory, T3, InnerDataflowEndpointGroupIntegerRangeFactory> WithPortRange<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupRangedSocketAddressFactory, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupRangedSocketAddressFactory, InnerDataflowEndpointGroupIntegerRangeFactory> WithPortRange<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupRangedSocketAddressFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataflowEndpointGroupRangedSocketAddressFactory, T1, T2, T3, T4, InnerDataflowEndpointGroupIntegerRangeFactory> WithPortRange<T1, T2, T3, T4>(this CombinedResult<InnerDataflowEndpointGroupRangedSocketAddressFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataflowEndpointGroupRangedSocketAddressFactory, T2, T3, T4, InnerDataflowEndpointGroupIntegerRangeFactory> WithPortRange<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataflowEndpointGroupRangedSocketAddressFactory, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupRangedSocketAddressFactory, T3, T4, InnerDataflowEndpointGroupIntegerRangeFactory> WithPortRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupRangedSocketAddressFactory, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupRangedSocketAddressFactory, T4, InnerDataflowEndpointGroupIntegerRangeFactory> WithPortRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupRangedSocketAddressFactory, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataflowEndpointGroupRangedSocketAddressFactory, InnerDataflowEndpointGroupIntegerRangeFactory> WithPortRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataflowEndpointGroupRangedSocketAddressFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.IntegerRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortRange(combinedResult.T5, subFactoryAction));
}
