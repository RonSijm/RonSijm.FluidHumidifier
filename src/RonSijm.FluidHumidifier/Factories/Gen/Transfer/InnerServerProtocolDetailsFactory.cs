// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerServerProtocolDetailsFactory(Action<Humidifier.Transfer.ServerTypes.ProtocolDetails> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.ServerTypes.ProtocolDetails>
{

    internal InnerServerProxyConfigFactory ProxyConfigFactory { get; set; }

    protected override Humidifier.Transfer.ServerTypes.ProtocolDetails Create()
    {
        var protocolDetailsResult = CreateProtocolDetails();
        factoryAction?.Invoke(protocolDetailsResult);

        return protocolDetailsResult;
    }

    private Humidifier.Transfer.ServerTypes.ProtocolDetails CreateProtocolDetails()
    {
        var protocolDetailsResult = new Humidifier.Transfer.ServerTypes.ProtocolDetails();

        return protocolDetailsResult;
    }
    public override void CreateChildren(Humidifier.Transfer.ServerTypes.ProtocolDetails result)
    {
        base.CreateChildren(result);

        result.ProxyConfig ??= ProxyConfigFactory?.Build();
    }

} // End Of Class

public static class InnerServerProtocolDetailsFactoryExtensions
{
    public static CombinedResult<InnerServerProtocolDetailsFactory, InnerServerProxyConfigFactory> WithProxyConfig(this InnerServerProtocolDetailsFactory parentFactory, Action<Humidifier.Transfer.ServerTypes.ProxyConfig> subFactoryAction = null)
    {
        parentFactory.ProxyConfigFactory = new InnerServerProxyConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProxyConfigFactory);
    }

    public static CombinedResult<InnerServerProtocolDetailsFactory, T1, InnerServerProxyConfigFactory> WithProxyConfig<T1>(this CombinedResult<InnerServerProtocolDetailsFactory, T1> combinedResult, Action<Humidifier.Transfer.ServerTypes.ProxyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithProxyConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServerProtocolDetailsFactory, InnerServerProxyConfigFactory> WithProxyConfig<T1>(this CombinedResult<T1, InnerServerProtocolDetailsFactory> combinedResult, Action<Humidifier.Transfer.ServerTypes.ProxyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithProxyConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServerProtocolDetailsFactory, T1, T2, InnerServerProxyConfigFactory> WithProxyConfig<T1, T2>(this CombinedResult<InnerServerProtocolDetailsFactory, T1, T2> combinedResult, Action<Humidifier.Transfer.ServerTypes.ProxyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProxyConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServerProtocolDetailsFactory, T2, InnerServerProxyConfigFactory> WithProxyConfig<T1, T2>(this CombinedResult<T1, InnerServerProtocolDetailsFactory, T2> combinedResult, Action<Humidifier.Transfer.ServerTypes.ProxyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProxyConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServerProtocolDetailsFactory, InnerServerProxyConfigFactory> WithProxyConfig<T1, T2>(this CombinedResult<T1, T2, InnerServerProtocolDetailsFactory> combinedResult, Action<Humidifier.Transfer.ServerTypes.ProxyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProxyConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServerProtocolDetailsFactory, T1, T2, T3, InnerServerProxyConfigFactory> WithProxyConfig<T1, T2, T3>(this CombinedResult<InnerServerProtocolDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Transfer.ServerTypes.ProxyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProxyConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServerProtocolDetailsFactory, T2, T3, InnerServerProxyConfigFactory> WithProxyConfig<T1, T2, T3>(this CombinedResult<T1, InnerServerProtocolDetailsFactory, T2, T3> combinedResult, Action<Humidifier.Transfer.ServerTypes.ProxyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProxyConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServerProtocolDetailsFactory, T3, InnerServerProxyConfigFactory> WithProxyConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerServerProtocolDetailsFactory, T3> combinedResult, Action<Humidifier.Transfer.ServerTypes.ProxyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProxyConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServerProtocolDetailsFactory, InnerServerProxyConfigFactory> WithProxyConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServerProtocolDetailsFactory> combinedResult, Action<Humidifier.Transfer.ServerTypes.ProxyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProxyConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServerProtocolDetailsFactory, T1, T2, T3, T4, InnerServerProxyConfigFactory> WithProxyConfig<T1, T2, T3, T4>(this CombinedResult<InnerServerProtocolDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.ServerTypes.ProxyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProxyConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServerProtocolDetailsFactory, T2, T3, T4, InnerServerProxyConfigFactory> WithProxyConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerServerProtocolDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.ServerTypes.ProxyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProxyConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServerProtocolDetailsFactory, T3, T4, InnerServerProxyConfigFactory> WithProxyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServerProtocolDetailsFactory, T3, T4> combinedResult, Action<Humidifier.Transfer.ServerTypes.ProxyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProxyConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServerProtocolDetailsFactory, T4, InnerServerProxyConfigFactory> WithProxyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServerProtocolDetailsFactory, T4> combinedResult, Action<Humidifier.Transfer.ServerTypes.ProxyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProxyConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServerProtocolDetailsFactory, InnerServerProxyConfigFactory> WithProxyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServerProtocolDetailsFactory> combinedResult, Action<Humidifier.Transfer.ServerTypes.ProxyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProxyConfig(combinedResult.T5, subFactoryAction).T2);
}
