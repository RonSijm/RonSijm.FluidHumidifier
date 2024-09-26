// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class GatewayFactory(string resourceName = null, Action<Humidifier.MediaConnect.Gateway> factoryAction = null) : ResourceFactory<Humidifier.MediaConnect.Gateway>(resourceName)
{

    internal List<InnerGatewayGatewayNetworkFactory> NetworksFactories { get; set; } = [];

    protected override Humidifier.MediaConnect.Gateway Create()
    {
        var gatewayResult = CreateGateway();
        factoryAction?.Invoke(gatewayResult);

        return gatewayResult;
    }

    private Humidifier.MediaConnect.Gateway CreateGateway()
    {
        var gatewayResult = new Humidifier.MediaConnect.Gateway
        {
            GivenName = InputResourceName,
        };

        return gatewayResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.Gateway result)
    {
        base.CreateChildren(result);

        result.Networks = NetworksFactories.Any() ? NetworksFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class GatewayFactoryExtensions
{
    public static CombinedResult<GatewayFactory, InnerGatewayGatewayNetworkFactory> WithNetworks(this GatewayFactory parentFactory, Action<Humidifier.MediaConnect.GatewayTypes.GatewayNetwork> subFactoryAction = null)
    {
        var factory = new InnerGatewayGatewayNetworkFactory(subFactoryAction);
        parentFactory.NetworksFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<GatewayFactory, T1, InnerGatewayGatewayNetworkFactory> WithNetworks<T1>(this CombinedResult<GatewayFactory, T1> combinedResult, Action<Humidifier.MediaConnect.GatewayTypes.GatewayNetwork> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworks(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GatewayFactory, InnerGatewayGatewayNetworkFactory> WithNetworks<T1>(this CombinedResult<T1, GatewayFactory> combinedResult, Action<Humidifier.MediaConnect.GatewayTypes.GatewayNetwork> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworks(combinedResult.T2, subFactoryAction));
    public static CombinedResult<GatewayFactory, T1, T2, InnerGatewayGatewayNetworkFactory> WithNetworks<T1, T2>(this CombinedResult<GatewayFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.GatewayTypes.GatewayNetwork> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworks(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GatewayFactory, T2, InnerGatewayGatewayNetworkFactory> WithNetworks<T1, T2>(this CombinedResult<T1, GatewayFactory, T2> combinedResult, Action<Humidifier.MediaConnect.GatewayTypes.GatewayNetwork> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworks(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GatewayFactory, InnerGatewayGatewayNetworkFactory> WithNetworks<T1, T2>(this CombinedResult<T1, T2, GatewayFactory> combinedResult, Action<Humidifier.MediaConnect.GatewayTypes.GatewayNetwork> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworks(combinedResult.T3, subFactoryAction));
    public static CombinedResult<GatewayFactory, T1, T2, T3, InnerGatewayGatewayNetworkFactory> WithNetworks<T1, T2, T3>(this CombinedResult<GatewayFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.GatewayTypes.GatewayNetwork> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworks(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GatewayFactory, T2, T3, InnerGatewayGatewayNetworkFactory> WithNetworks<T1, T2, T3>(this CombinedResult<T1, GatewayFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.GatewayTypes.GatewayNetwork> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworks(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GatewayFactory, T3, InnerGatewayGatewayNetworkFactory> WithNetworks<T1, T2, T3>(this CombinedResult<T1, T2, GatewayFactory, T3> combinedResult, Action<Humidifier.MediaConnect.GatewayTypes.GatewayNetwork> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworks(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GatewayFactory, InnerGatewayGatewayNetworkFactory> WithNetworks<T1, T2, T3>(this CombinedResult<T1, T2, T3, GatewayFactory> combinedResult, Action<Humidifier.MediaConnect.GatewayTypes.GatewayNetwork> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworks(combinedResult.T4, subFactoryAction));
    public static CombinedResult<GatewayFactory, T1, T2, T3, T4, InnerGatewayGatewayNetworkFactory> WithNetworks<T1, T2, T3, T4>(this CombinedResult<GatewayFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.GatewayTypes.GatewayNetwork> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworks(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GatewayFactory, T2, T3, T4, InnerGatewayGatewayNetworkFactory> WithNetworks<T1, T2, T3, T4>(this CombinedResult<T1, GatewayFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.GatewayTypes.GatewayNetwork> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworks(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GatewayFactory, T3, T4, InnerGatewayGatewayNetworkFactory> WithNetworks<T1, T2, T3, T4>(this CombinedResult<T1, T2, GatewayFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.GatewayTypes.GatewayNetwork> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworks(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GatewayFactory, T4, InnerGatewayGatewayNetworkFactory> WithNetworks<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GatewayFactory, T4> combinedResult, Action<Humidifier.MediaConnect.GatewayTypes.GatewayNetwork> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworks(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, GatewayFactory, InnerGatewayGatewayNetworkFactory> WithNetworks<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GatewayFactory> combinedResult, Action<Humidifier.MediaConnect.GatewayTypes.GatewayNetwork> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworks(combinedResult.T5, subFactoryAction));
}
