// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSecureTunneling;

public class TunnelFactory(string resourceName = null, Action<Humidifier.IoTSecureTunneling.Tunnel> factoryAction = null) : ResourceFactory<Humidifier.IoTSecureTunneling.Tunnel>(resourceName)
{

    internal InnerTunnelTimeoutConfigFactory TimeoutConfigFactory { get; set; }

    internal InnerTunnelDestinationConfigFactory DestinationConfigFactory { get; set; }

    protected override Humidifier.IoTSecureTunneling.Tunnel Create()
    {
        var tunnelResult = CreateTunnel();
        factoryAction?.Invoke(tunnelResult);

        return tunnelResult;
    }

    private Humidifier.IoTSecureTunneling.Tunnel CreateTunnel()
    {
        var tunnelResult = new Humidifier.IoTSecureTunneling.Tunnel
        {
            GivenName = InputResourceName,
        };

        return tunnelResult;
    }
    public override void CreateChildren(Humidifier.IoTSecureTunneling.Tunnel result)
    {
        base.CreateChildren(result);

        result.TimeoutConfig ??= TimeoutConfigFactory?.Build();
        result.DestinationConfig ??= DestinationConfigFactory?.Build();
    }

} // End Of Class

public static class TunnelFactoryExtensions
{
    public static CombinedResult<TunnelFactory, InnerTunnelTimeoutConfigFactory> WithTimeoutConfig(this TunnelFactory parentFactory, Action<Humidifier.IoTSecureTunneling.TunnelTypes.TimeoutConfig> subFactoryAction = null)
    {
        parentFactory.TimeoutConfigFactory = new InnerTunnelTimeoutConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TimeoutConfigFactory);
    }

    public static CombinedResult<TunnelFactory, InnerTunnelDestinationConfigFactory> WithDestinationConfig(this TunnelFactory parentFactory, Action<Humidifier.IoTSecureTunneling.TunnelTypes.DestinationConfig> subFactoryAction = null)
    {
        parentFactory.DestinationConfigFactory = new InnerTunnelDestinationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationConfigFactory);
    }

    public static CombinedResult<TunnelFactory, T1, InnerTunnelTimeoutConfigFactory> WithTimeoutConfig<T1>(this CombinedResult<TunnelFactory, T1> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TunnelFactory, InnerTunnelTimeoutConfigFactory> WithTimeoutConfig<T1>(this CombinedResult<T1, TunnelFactory> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TunnelFactory, T1, T2, InnerTunnelTimeoutConfigFactory> WithTimeoutConfig<T1, T2>(this CombinedResult<TunnelFactory, T1, T2> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TunnelFactory, T2, InnerTunnelTimeoutConfigFactory> WithTimeoutConfig<T1, T2>(this CombinedResult<T1, TunnelFactory, T2> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TunnelFactory, InnerTunnelTimeoutConfigFactory> WithTimeoutConfig<T1, T2>(this CombinedResult<T1, T2, TunnelFactory> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TunnelFactory, T1, T2, T3, InnerTunnelTimeoutConfigFactory> WithTimeoutConfig<T1, T2, T3>(this CombinedResult<TunnelFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TunnelFactory, T2, T3, InnerTunnelTimeoutConfigFactory> WithTimeoutConfig<T1, T2, T3>(this CombinedResult<T1, TunnelFactory, T2, T3> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TunnelFactory, T3, InnerTunnelTimeoutConfigFactory> WithTimeoutConfig<T1, T2, T3>(this CombinedResult<T1, T2, TunnelFactory, T3> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TunnelFactory, InnerTunnelTimeoutConfigFactory> WithTimeoutConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, TunnelFactory> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TunnelFactory, T1, T2, T3, T4, InnerTunnelTimeoutConfigFactory> WithTimeoutConfig<T1, T2, T3, T4>(this CombinedResult<TunnelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TunnelFactory, T2, T3, T4, InnerTunnelTimeoutConfigFactory> WithTimeoutConfig<T1, T2, T3, T4>(this CombinedResult<T1, TunnelFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TunnelFactory, T3, T4, InnerTunnelTimeoutConfigFactory> WithTimeoutConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, TunnelFactory, T3, T4> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TunnelFactory, T4, InnerTunnelTimeoutConfigFactory> WithTimeoutConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TunnelFactory, T4> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TunnelFactory, InnerTunnelTimeoutConfigFactory> WithTimeoutConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TunnelFactory> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.TimeoutConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutConfig(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<TunnelFactory, T1, InnerTunnelDestinationConfigFactory> WithDestinationConfig<T1>(this CombinedResult<TunnelFactory, T1> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TunnelFactory, InnerTunnelDestinationConfigFactory> WithDestinationConfig<T1>(this CombinedResult<T1, TunnelFactory> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TunnelFactory, T1, T2, InnerTunnelDestinationConfigFactory> WithDestinationConfig<T1, T2>(this CombinedResult<TunnelFactory, T1, T2> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TunnelFactory, T2, InnerTunnelDestinationConfigFactory> WithDestinationConfig<T1, T2>(this CombinedResult<T1, TunnelFactory, T2> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TunnelFactory, InnerTunnelDestinationConfigFactory> WithDestinationConfig<T1, T2>(this CombinedResult<T1, T2, TunnelFactory> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TunnelFactory, T1, T2, T3, InnerTunnelDestinationConfigFactory> WithDestinationConfig<T1, T2, T3>(this CombinedResult<TunnelFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TunnelFactory, T2, T3, InnerTunnelDestinationConfigFactory> WithDestinationConfig<T1, T2, T3>(this CombinedResult<T1, TunnelFactory, T2, T3> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TunnelFactory, T3, InnerTunnelDestinationConfigFactory> WithDestinationConfig<T1, T2, T3>(this CombinedResult<T1, T2, TunnelFactory, T3> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TunnelFactory, InnerTunnelDestinationConfigFactory> WithDestinationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, TunnelFactory> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TunnelFactory, T1, T2, T3, T4, InnerTunnelDestinationConfigFactory> WithDestinationConfig<T1, T2, T3, T4>(this CombinedResult<TunnelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TunnelFactory, T2, T3, T4, InnerTunnelDestinationConfigFactory> WithDestinationConfig<T1, T2, T3, T4>(this CombinedResult<T1, TunnelFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TunnelFactory, T3, T4, InnerTunnelDestinationConfigFactory> WithDestinationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, TunnelFactory, T3, T4> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TunnelFactory, T4, InnerTunnelDestinationConfigFactory> WithDestinationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TunnelFactory, T4> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TunnelFactory, InnerTunnelDestinationConfigFactory> WithDestinationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TunnelFactory> combinedResult, Action<Humidifier.IoTSecureTunneling.TunnelTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfig(combinedResult.T5, subFactoryAction).T2);
}
