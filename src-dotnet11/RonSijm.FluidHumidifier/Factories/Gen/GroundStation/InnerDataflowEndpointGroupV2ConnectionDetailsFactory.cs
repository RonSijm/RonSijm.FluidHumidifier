// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerDataflowEndpointGroupV2ConnectionDetailsFactory(Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.ConnectionDetails> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.DataflowEndpointGroupV2Types.ConnectionDetails>
{

    internal InnerDataflowEndpointGroupV2SocketAddressFactory SocketAddressFactory { get; set; }

    protected override Humidifier.GroundStation.DataflowEndpointGroupV2Types.ConnectionDetails Create()
    {
        var connectionDetailsResult = CreateConnectionDetails();
        factoryAction?.Invoke(connectionDetailsResult);

        return connectionDetailsResult;
    }

    private Humidifier.GroundStation.DataflowEndpointGroupV2Types.ConnectionDetails CreateConnectionDetails()
    {
        var connectionDetailsResult = new Humidifier.GroundStation.DataflowEndpointGroupV2Types.ConnectionDetails();

        return connectionDetailsResult;
    }
    public override void CreateChildren(Humidifier.GroundStation.DataflowEndpointGroupV2Types.ConnectionDetails result)
    {
        base.CreateChildren(result);

        result.SocketAddress ??= SocketAddressFactory?.Build();
    }

} // End Of Class

public static class InnerDataflowEndpointGroupV2ConnectionDetailsFactoryExtensions
{
    public static CombinedResult<InnerDataflowEndpointGroupV2ConnectionDetailsFactory, InnerDataflowEndpointGroupV2SocketAddressFactory> WithSocketAddress(this InnerDataflowEndpointGroupV2ConnectionDetailsFactory parentFactory, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.SocketAddress> subFactoryAction = null)
    {
        parentFactory.SocketAddressFactory = new InnerDataflowEndpointGroupV2SocketAddressFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SocketAddressFactory);
    }

    public static CombinedResult<InnerDataflowEndpointGroupV2ConnectionDetailsFactory, T1, InnerDataflowEndpointGroupV2SocketAddressFactory> WithSocketAddress<T1>(this CombinedResult<InnerDataflowEndpointGroupV2ConnectionDetailsFactory, T1> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, WithSocketAddress(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2ConnectionDetailsFactory, InnerDataflowEndpointGroupV2SocketAddressFactory> WithSocketAddress<T1>(this CombinedResult<T1, InnerDataflowEndpointGroupV2ConnectionDetailsFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, WithSocketAddress(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataflowEndpointGroupV2ConnectionDetailsFactory, T1, T2, InnerDataflowEndpointGroupV2SocketAddressFactory> WithSocketAddress<T1, T2>(this CombinedResult<InnerDataflowEndpointGroupV2ConnectionDetailsFactory, T1, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2ConnectionDetailsFactory, T2, InnerDataflowEndpointGroupV2SocketAddressFactory> WithSocketAddress<T1, T2>(this CombinedResult<T1, InnerDataflowEndpointGroupV2ConnectionDetailsFactory, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupV2ConnectionDetailsFactory, InnerDataflowEndpointGroupV2SocketAddressFactory> WithSocketAddress<T1, T2>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupV2ConnectionDetailsFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataflowEndpointGroupV2ConnectionDetailsFactory, T1, T2, T3, InnerDataflowEndpointGroupV2SocketAddressFactory> WithSocketAddress<T1, T2, T3>(this CombinedResult<InnerDataflowEndpointGroupV2ConnectionDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2ConnectionDetailsFactory, T2, T3, InnerDataflowEndpointGroupV2SocketAddressFactory> WithSocketAddress<T1, T2, T3>(this CombinedResult<T1, InnerDataflowEndpointGroupV2ConnectionDetailsFactory, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupV2ConnectionDetailsFactory, T3, InnerDataflowEndpointGroupV2SocketAddressFactory> WithSocketAddress<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupV2ConnectionDetailsFactory, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2ConnectionDetailsFactory, InnerDataflowEndpointGroupV2SocketAddressFactory> WithSocketAddress<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2ConnectionDetailsFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataflowEndpointGroupV2ConnectionDetailsFactory, T1, T2, T3, T4, InnerDataflowEndpointGroupV2SocketAddressFactory> WithSocketAddress<T1, T2, T3, T4>(this CombinedResult<InnerDataflowEndpointGroupV2ConnectionDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataflowEndpointGroupV2ConnectionDetailsFactory, T2, T3, T4, InnerDataflowEndpointGroupV2SocketAddressFactory> WithSocketAddress<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataflowEndpointGroupV2ConnectionDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupV2ConnectionDetailsFactory, T3, T4, InnerDataflowEndpointGroupV2SocketAddressFactory> WithSocketAddress<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupV2ConnectionDetailsFactory, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2ConnectionDetailsFactory, T4, InnerDataflowEndpointGroupV2SocketAddressFactory> WithSocketAddress<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupV2ConnectionDetailsFactory, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataflowEndpointGroupV2ConnectionDetailsFactory, InnerDataflowEndpointGroupV2SocketAddressFactory> WithSocketAddress<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataflowEndpointGroupV2ConnectionDetailsFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T5, subFactoryAction).T2);
}
