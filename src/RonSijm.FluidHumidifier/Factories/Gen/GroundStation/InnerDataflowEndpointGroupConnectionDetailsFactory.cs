// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerDataflowEndpointGroupConnectionDetailsFactory(Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.ConnectionDetails> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.DataflowEndpointGroupTypes.ConnectionDetails>
{

    internal InnerDataflowEndpointGroupSocketAddressFactory SocketAddressFactory { get; set; }

    protected override Humidifier.GroundStation.DataflowEndpointGroupTypes.ConnectionDetails Create()
    {
        var connectionDetailsResult = CreateConnectionDetails();
        factoryAction?.Invoke(connectionDetailsResult);

        return connectionDetailsResult;
    }

    private Humidifier.GroundStation.DataflowEndpointGroupTypes.ConnectionDetails CreateConnectionDetails()
    {
        var connectionDetailsResult = new Humidifier.GroundStation.DataflowEndpointGroupTypes.ConnectionDetails();

        return connectionDetailsResult;
    }
    public override void CreateChildren(Humidifier.GroundStation.DataflowEndpointGroupTypes.ConnectionDetails result)
    {
        base.CreateChildren(result);

        result.SocketAddress ??= SocketAddressFactory?.Build();
    }

} // End Of Class

public static class InnerDataflowEndpointGroupConnectionDetailsFactoryExtensions
{
    public static CombinedResult<InnerDataflowEndpointGroupConnectionDetailsFactory, InnerDataflowEndpointGroupSocketAddressFactory> WithSocketAddress(this InnerDataflowEndpointGroupConnectionDetailsFactory parentFactory, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null)
    {
        parentFactory.SocketAddressFactory = new InnerDataflowEndpointGroupSocketAddressFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SocketAddressFactory);
    }

    public static CombinedResult<InnerDataflowEndpointGroupConnectionDetailsFactory, T1, InnerDataflowEndpointGroupSocketAddressFactory> WithSocketAddress<T1>(this CombinedResult<InnerDataflowEndpointGroupConnectionDetailsFactory, T1> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, WithSocketAddress(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataflowEndpointGroupConnectionDetailsFactory, InnerDataflowEndpointGroupSocketAddressFactory> WithSocketAddress<T1>(this CombinedResult<T1, InnerDataflowEndpointGroupConnectionDetailsFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, WithSocketAddress(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataflowEndpointGroupConnectionDetailsFactory, T1, T2, InnerDataflowEndpointGroupSocketAddressFactory> WithSocketAddress<T1, T2>(this CombinedResult<InnerDataflowEndpointGroupConnectionDetailsFactory, T1, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataflowEndpointGroupConnectionDetailsFactory, T2, InnerDataflowEndpointGroupSocketAddressFactory> WithSocketAddress<T1, T2>(this CombinedResult<T1, InnerDataflowEndpointGroupConnectionDetailsFactory, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupConnectionDetailsFactory, InnerDataflowEndpointGroupSocketAddressFactory> WithSocketAddress<T1, T2>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupConnectionDetailsFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataflowEndpointGroupConnectionDetailsFactory, T1, T2, T3, InnerDataflowEndpointGroupSocketAddressFactory> WithSocketAddress<T1, T2, T3>(this CombinedResult<InnerDataflowEndpointGroupConnectionDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataflowEndpointGroupConnectionDetailsFactory, T2, T3, InnerDataflowEndpointGroupSocketAddressFactory> WithSocketAddress<T1, T2, T3>(this CombinedResult<T1, InnerDataflowEndpointGroupConnectionDetailsFactory, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupConnectionDetailsFactory, T3, InnerDataflowEndpointGroupSocketAddressFactory> WithSocketAddress<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupConnectionDetailsFactory, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupConnectionDetailsFactory, InnerDataflowEndpointGroupSocketAddressFactory> WithSocketAddress<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupConnectionDetailsFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataflowEndpointGroupConnectionDetailsFactory, T1, T2, T3, T4, InnerDataflowEndpointGroupSocketAddressFactory> WithSocketAddress<T1, T2, T3, T4>(this CombinedResult<InnerDataflowEndpointGroupConnectionDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataflowEndpointGroupConnectionDetailsFactory, T2, T3, T4, InnerDataflowEndpointGroupSocketAddressFactory> WithSocketAddress<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataflowEndpointGroupConnectionDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupConnectionDetailsFactory, T3, T4, InnerDataflowEndpointGroupSocketAddressFactory> WithSocketAddress<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupConnectionDetailsFactory, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupConnectionDetailsFactory, T4, InnerDataflowEndpointGroupSocketAddressFactory> WithSocketAddress<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupConnectionDetailsFactory, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataflowEndpointGroupConnectionDetailsFactory, InnerDataflowEndpointGroupSocketAddressFactory> WithSocketAddress<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataflowEndpointGroupConnectionDetailsFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSocketAddress(combinedResult.T5, subFactoryAction));
}
