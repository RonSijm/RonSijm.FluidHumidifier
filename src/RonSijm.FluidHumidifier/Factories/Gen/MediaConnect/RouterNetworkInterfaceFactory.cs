// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class RouterNetworkInterfaceFactory(string resourceName = null, Action<Humidifier.MediaConnect.RouterNetworkInterface> factoryAction = null) : ResourceFactory<Humidifier.MediaConnect.RouterNetworkInterface>(resourceName)
{

    internal InnerRouterNetworkInterfaceRouterNetworkInterfaceConfigurationFactory ConfigurationFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterNetworkInterface Create()
    {
        var routerNetworkInterfaceResult = CreateRouterNetworkInterface();
        factoryAction?.Invoke(routerNetworkInterfaceResult);

        return routerNetworkInterfaceResult;
    }

    private Humidifier.MediaConnect.RouterNetworkInterface CreateRouterNetworkInterface()
    {
        var routerNetworkInterfaceResult = new Humidifier.MediaConnect.RouterNetworkInterface
        {
            GivenName = InputResourceName,
        };

        return routerNetworkInterfaceResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterNetworkInterface result)
    {
        base.CreateChildren(result);

        result.Configuration ??= ConfigurationFactory?.Build();
    }

} // End Of Class

public static class RouterNetworkInterfaceFactoryExtensions
{
    public static CombinedResult<RouterNetworkInterfaceFactory, InnerRouterNetworkInterfaceRouterNetworkInterfaceConfigurationFactory> WithConfiguration(this RouterNetworkInterfaceFactory parentFactory, Action<Humidifier.MediaConnect.RouterNetworkInterfaceTypes.RouterNetworkInterfaceConfiguration> subFactoryAction = null)
    {
        parentFactory.ConfigurationFactory = new InnerRouterNetworkInterfaceRouterNetworkInterfaceConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationFactory);
    }

    public static CombinedResult<RouterNetworkInterfaceFactory, T1, InnerRouterNetworkInterfaceRouterNetworkInterfaceConfigurationFactory> WithConfiguration<T1>(this CombinedResult<RouterNetworkInterfaceFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterNetworkInterfaceTypes.RouterNetworkInterfaceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RouterNetworkInterfaceFactory, InnerRouterNetworkInterfaceRouterNetworkInterfaceConfigurationFactory> WithConfiguration<T1>(this CombinedResult<T1, RouterNetworkInterfaceFactory> combinedResult, Action<Humidifier.MediaConnect.RouterNetworkInterfaceTypes.RouterNetworkInterfaceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<RouterNetworkInterfaceFactory, T1, T2, InnerRouterNetworkInterfaceRouterNetworkInterfaceConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<RouterNetworkInterfaceFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterNetworkInterfaceTypes.RouterNetworkInterfaceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RouterNetworkInterfaceFactory, T2, InnerRouterNetworkInterfaceRouterNetworkInterfaceConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, RouterNetworkInterfaceFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterNetworkInterfaceTypes.RouterNetworkInterfaceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RouterNetworkInterfaceFactory, InnerRouterNetworkInterfaceRouterNetworkInterfaceConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, RouterNetworkInterfaceFactory> combinedResult, Action<Humidifier.MediaConnect.RouterNetworkInterfaceTypes.RouterNetworkInterfaceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<RouterNetworkInterfaceFactory, T1, T2, T3, InnerRouterNetworkInterfaceRouterNetworkInterfaceConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<RouterNetworkInterfaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterNetworkInterfaceTypes.RouterNetworkInterfaceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RouterNetworkInterfaceFactory, T2, T3, InnerRouterNetworkInterfaceRouterNetworkInterfaceConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, RouterNetworkInterfaceFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterNetworkInterfaceTypes.RouterNetworkInterfaceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RouterNetworkInterfaceFactory, T3, InnerRouterNetworkInterfaceRouterNetworkInterfaceConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, RouterNetworkInterfaceFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterNetworkInterfaceTypes.RouterNetworkInterfaceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RouterNetworkInterfaceFactory, InnerRouterNetworkInterfaceRouterNetworkInterfaceConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, RouterNetworkInterfaceFactory> combinedResult, Action<Humidifier.MediaConnect.RouterNetworkInterfaceTypes.RouterNetworkInterfaceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<RouterNetworkInterfaceFactory, T1, T2, T3, T4, InnerRouterNetworkInterfaceRouterNetworkInterfaceConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<RouterNetworkInterfaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterNetworkInterfaceTypes.RouterNetworkInterfaceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RouterNetworkInterfaceFactory, T2, T3, T4, InnerRouterNetworkInterfaceRouterNetworkInterfaceConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, RouterNetworkInterfaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterNetworkInterfaceTypes.RouterNetworkInterfaceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RouterNetworkInterfaceFactory, T3, T4, InnerRouterNetworkInterfaceRouterNetworkInterfaceConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, RouterNetworkInterfaceFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterNetworkInterfaceTypes.RouterNetworkInterfaceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RouterNetworkInterfaceFactory, T4, InnerRouterNetworkInterfaceRouterNetworkInterfaceConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RouterNetworkInterfaceFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterNetworkInterfaceTypes.RouterNetworkInterfaceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, RouterNetworkInterfaceFactory, InnerRouterNetworkInterfaceRouterNetworkInterfaceConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RouterNetworkInterfaceFactory> combinedResult, Action<Humidifier.MediaConnect.RouterNetworkInterfaceTypes.RouterNetworkInterfaceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction).T2);
}
