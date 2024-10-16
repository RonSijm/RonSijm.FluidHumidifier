// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerDataflowEndpointGroupRangedConnectionDetailsFactory(Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedConnectionDetails> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedConnectionDetails>
{

    internal InnerDataflowEndpointGroupRangedSocketAddressFactory SocketAddressFactory { get; set; }

    protected override Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedConnectionDetails Create()
    {
        var rangedConnectionDetailsResult = CreateRangedConnectionDetails();
        factoryAction?.Invoke(rangedConnectionDetailsResult);

        return rangedConnectionDetailsResult;
    }

    private Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedConnectionDetails CreateRangedConnectionDetails()
    {
        var rangedConnectionDetailsResult = new Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedConnectionDetails();

        return rangedConnectionDetailsResult;
    }
    public override void CreateChildren(Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedConnectionDetails result)
    {
        base.CreateChildren(result);

        result.SocketAddress ??= SocketAddressFactory?.Build();
    }

} // End Of Class

public static class InnerDataflowEndpointGroupRangedConnectionDetailsFactoryExtensions
{
    public static CombinedResult<InnerDataflowEndpointGroupRangedConnectionDetailsFactory, InnerDataflowEndpointGroupRangedSocketAddressFactory> WithSocketAddress(this InnerDataflowEndpointGroupRangedConnectionDetailsFactory parentFactory, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedSocketAddress> subFactoryAction = null)
    {
        parentFactory.SocketAddressFactory = new InnerDataflowEndpointGroupRangedSocketAddressFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SocketAddressFactory);
    }

    public static CombinedResult<InnerDataflowEndpointGroupRangedConnectionDetailsFactory, T1, InnerDataflowEndpointGroupRangedSocketAddressFactory> WithSocketAddress<T1>(this CombinedResult<InnerDataflowEndpointGroupRangedConnectionDetailsFactory, T1> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, WithSocketAddress(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataflowEndpointGroupRangedConnectionDetailsFactory, InnerDataflowEndpointGroupRangedSocketAddressFactory> WithSocketAddress<T1>(this CombinedResult<T1, InnerDataflowEndpointGroupRangedConnectionDetailsFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, WithSocketAddress(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataflowEndpointGroupRangedConnectionDetailsFactory, T1, T2, InnerDataflowEndpointGroupRangedSocketAddressFactory> WithSocketAddress<T1, T2>(this CombinedResult<InnerDataflowEndpointGroupRangedConnectionDetailsFactory, T1, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataflowEndpointGroupRangedConnectionDetailsFactory, T2, InnerDataflowEndpointGroupRangedSocketAddressFactory> WithSocketAddress<T1, T2>(this CombinedResult<T1, InnerDataflowEndpointGroupRangedConnectionDetailsFactory, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupRangedConnectionDetailsFactory, InnerDataflowEndpointGroupRangedSocketAddressFactory> WithSocketAddress<T1, T2>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupRangedConnectionDetailsFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataflowEndpointGroupRangedConnectionDetailsFactory, T1, T2, T3, InnerDataflowEndpointGroupRangedSocketAddressFactory> WithSocketAddress<T1, T2, T3>(this CombinedResult<InnerDataflowEndpointGroupRangedConnectionDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataflowEndpointGroupRangedConnectionDetailsFactory, T2, T3, InnerDataflowEndpointGroupRangedSocketAddressFactory> WithSocketAddress<T1, T2, T3>(this CombinedResult<T1, InnerDataflowEndpointGroupRangedConnectionDetailsFactory, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupRangedConnectionDetailsFactory, T3, InnerDataflowEndpointGroupRangedSocketAddressFactory> WithSocketAddress<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupRangedConnectionDetailsFactory, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupRangedConnectionDetailsFactory, InnerDataflowEndpointGroupRangedSocketAddressFactory> WithSocketAddress<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupRangedConnectionDetailsFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataflowEndpointGroupRangedConnectionDetailsFactory, T1, T2, T3, T4, InnerDataflowEndpointGroupRangedSocketAddressFactory> WithSocketAddress<T1, T2, T3, T4>(this CombinedResult<InnerDataflowEndpointGroupRangedConnectionDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataflowEndpointGroupRangedConnectionDetailsFactory, T2, T3, T4, InnerDataflowEndpointGroupRangedSocketAddressFactory> WithSocketAddress<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataflowEndpointGroupRangedConnectionDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupRangedConnectionDetailsFactory, T3, T4, InnerDataflowEndpointGroupRangedSocketAddressFactory> WithSocketAddress<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupRangedConnectionDetailsFactory, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupRangedConnectionDetailsFactory, T4, InnerDataflowEndpointGroupRangedSocketAddressFactory> WithSocketAddress<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupRangedConnectionDetailsFactory, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataflowEndpointGroupRangedConnectionDetailsFactory, InnerDataflowEndpointGroupRangedSocketAddressFactory> WithSocketAddress<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataflowEndpointGroupRangedConnectionDetailsFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedSocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T5, subFactoryAction));
}
