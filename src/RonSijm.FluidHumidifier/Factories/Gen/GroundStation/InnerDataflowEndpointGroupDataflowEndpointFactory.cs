// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerDataflowEndpointGroupDataflowEndpointFactory(Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.DataflowEndpoint> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.DataflowEndpointGroupTypes.DataflowEndpoint>
{

    internal InnerDataflowEndpointGroupSocketAddressFactory AddressFactory { get; set; }

    protected override Humidifier.GroundStation.DataflowEndpointGroupTypes.DataflowEndpoint Create()
    {
        var dataflowEndpointResult = CreateDataflowEndpoint();
        factoryAction?.Invoke(dataflowEndpointResult);

        return dataflowEndpointResult;
    }

    private Humidifier.GroundStation.DataflowEndpointGroupTypes.DataflowEndpoint CreateDataflowEndpoint()
    {
        var dataflowEndpointResult = new Humidifier.GroundStation.DataflowEndpointGroupTypes.DataflowEndpoint();

        return dataflowEndpointResult;
    }
    public override void CreateChildren(Humidifier.GroundStation.DataflowEndpointGroupTypes.DataflowEndpoint result)
    {
        base.CreateChildren(result);

        result.Address ??= AddressFactory?.Build();
    }

} // End Of Class

public static class InnerDataflowEndpointGroupDataflowEndpointFactoryExtensions
{
    public static CombinedResult<InnerDataflowEndpointGroupDataflowEndpointFactory, InnerDataflowEndpointGroupSocketAddressFactory> WithAddress(this InnerDataflowEndpointGroupDataflowEndpointFactory parentFactory, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null)
    {
        parentFactory.AddressFactory = new InnerDataflowEndpointGroupSocketAddressFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AddressFactory);
    }

    public static CombinedResult<InnerDataflowEndpointGroupDataflowEndpointFactory, T1, InnerDataflowEndpointGroupSocketAddressFactory> WithAddress<T1>(this CombinedResult<InnerDataflowEndpointGroupDataflowEndpointFactory, T1> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, WithAddress(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataflowEndpointGroupDataflowEndpointFactory, InnerDataflowEndpointGroupSocketAddressFactory> WithAddress<T1>(this CombinedResult<T1, InnerDataflowEndpointGroupDataflowEndpointFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, WithAddress(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataflowEndpointGroupDataflowEndpointFactory, T1, T2, InnerDataflowEndpointGroupSocketAddressFactory> WithAddress<T1, T2>(this CombinedResult<InnerDataflowEndpointGroupDataflowEndpointFactory, T1, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAddress(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataflowEndpointGroupDataflowEndpointFactory, T2, InnerDataflowEndpointGroupSocketAddressFactory> WithAddress<T1, T2>(this CombinedResult<T1, InnerDataflowEndpointGroupDataflowEndpointFactory, T2> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAddress(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupDataflowEndpointFactory, InnerDataflowEndpointGroupSocketAddressFactory> WithAddress<T1, T2>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupDataflowEndpointFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAddress(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataflowEndpointGroupDataflowEndpointFactory, T1, T2, T3, InnerDataflowEndpointGroupSocketAddressFactory> WithAddress<T1, T2, T3>(this CombinedResult<InnerDataflowEndpointGroupDataflowEndpointFactory, T1, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAddress(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataflowEndpointGroupDataflowEndpointFactory, T2, T3, InnerDataflowEndpointGroupSocketAddressFactory> WithAddress<T1, T2, T3>(this CombinedResult<T1, InnerDataflowEndpointGroupDataflowEndpointFactory, T2, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAddress(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupDataflowEndpointFactory, T3, InnerDataflowEndpointGroupSocketAddressFactory> WithAddress<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupDataflowEndpointFactory, T3> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAddress(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupDataflowEndpointFactory, InnerDataflowEndpointGroupSocketAddressFactory> WithAddress<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupDataflowEndpointFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAddress(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataflowEndpointGroupDataflowEndpointFactory, T1, T2, T3, T4, InnerDataflowEndpointGroupSocketAddressFactory> WithAddress<T1, T2, T3, T4>(this CombinedResult<InnerDataflowEndpointGroupDataflowEndpointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAddress(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataflowEndpointGroupDataflowEndpointFactory, T2, T3, T4, InnerDataflowEndpointGroupSocketAddressFactory> WithAddress<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataflowEndpointGroupDataflowEndpointFactory, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAddress(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataflowEndpointGroupDataflowEndpointFactory, T3, T4, InnerDataflowEndpointGroupSocketAddressFactory> WithAddress<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataflowEndpointGroupDataflowEndpointFactory, T3, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAddress(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupDataflowEndpointFactory, T4, InnerDataflowEndpointGroupSocketAddressFactory> WithAddress<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataflowEndpointGroupDataflowEndpointFactory, T4> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAddress(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataflowEndpointGroupDataflowEndpointFactory, InnerDataflowEndpointGroupSocketAddressFactory> WithAddress<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataflowEndpointGroupDataflowEndpointFactory> combinedResult, Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAddress(combinedResult.T5, subFactoryAction));
}
