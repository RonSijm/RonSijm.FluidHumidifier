// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory(Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedConnectionDetails> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedConnectionDetails>
{

    internal InnerDataflowEndpointGroupV2RangedSocketAddressFactory SocketAddressFactory { get; set; }

    protected override Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedConnectionDetails Create()
    {
        var rangedConnectionDetailsResult = CreateRangedConnectionDetails();
        factoryAction?.Invoke(rangedConnectionDetailsResult);

        return rangedConnectionDetailsResult;
    }

    private Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedConnectionDetails CreateRangedConnectionDetails()
    {
        var rangedConnectionDetailsResult = new Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedConnectionDetails();

        return rangedConnectionDetailsResult;
    }
    public override void CreateChildren(Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedConnectionDetails result)
    {
        base.CreateChildren(result);

        result.SocketAddress ??= SocketAddressFactory?.Build();
    }

} // End Of Class

public static class InnerDataflowEndpointGroupV2RangedConnectionDetailsFactoryExtensions
{
    public static CombinedResult<InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory, InnerDataflowEndpointGroupV2RangedSocketAddressFactory> WithSocketAddress(this InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory parentFactory, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedSocketAddress> subFactoryAction = null)
    {
        parentFactory.SocketAddressFactory = new InnerDataflowEndpointGroupV2RangedSocketAddressFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SocketAddressFactory);
    }

    public static CombinedResult<InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory, T1, InnerDataflowEndpointGroupV2RangedSocketAddressFactory> WithSocketAddress<T1>(this CombinedResult<InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory, T1> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, WithSocketAddress(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory, InnerDataflowEndpointGroupV2RangedSocketAddressFactory> WithSocketAddress<T1>(this CombinedResult<T1, InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, WithSocketAddress(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory, T1, T2, InnerDataflowEndpointGroupV2RangedSocketAddressFactory> WithSocketAddress<T1, T2>(this CombinedResult<InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory, T1, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory, T2, InnerDataflowEndpointGroupV2RangedSocketAddressFactory> WithSocketAddress<T1, T2>(this CombinedResult<T1, InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory, InnerDataflowEndpointGroupV2RangedSocketAddressFactory> WithSocketAddress<T1, T2>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory, T1, T2, T3, InnerDataflowEndpointGroupV2RangedSocketAddressFactory> WithSocketAddress<T1, T2, T3>(this CombinedResult<InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory, T2, T3, InnerDataflowEndpointGroupV2RangedSocketAddressFactory> WithSocketAddress<T1, T2, T3>(this CombinedResult<T1, InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory, T3, InnerDataflowEndpointGroupV2RangedSocketAddressFactory> WithSocketAddress<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory, InnerDataflowEndpointGroupV2RangedSocketAddressFactory> WithSocketAddress<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory, T1, T2, T3, T4, InnerDataflowEndpointGroupV2RangedSocketAddressFactory> WithSocketAddress<T1, T2, T3, T4>(this CombinedResult<InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory, T2, T3, T4, InnerDataflowEndpointGroupV2RangedSocketAddressFactory> WithSocketAddress<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory, T3, T4, InnerDataflowEndpointGroupV2RangedSocketAddressFactory> WithSocketAddress<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory, T4, InnerDataflowEndpointGroupV2RangedSocketAddressFactory> WithSocketAddress<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory, InnerDataflowEndpointGroupV2RangedSocketAddressFactory> WithSocketAddress<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataflowEndpointGroupV2RangedConnectionDetailsFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T5, subFactoryAction).T2);
}
