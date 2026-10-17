// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerChannelNamespaceHandlerConfigFactory(Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig>
{

    internal InnerChannelNamespaceIntegrationFactory IntegrationFactory { get; set; }

    protected override Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig Create()
    {
        var handlerConfigResult = CreateHandlerConfig();
        factoryAction?.Invoke(handlerConfigResult);

        return handlerConfigResult;
    }

    private Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig CreateHandlerConfig()
    {
        var handlerConfigResult = new Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig();

        return handlerConfigResult;
    }
    public override void CreateChildren(Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig result)
    {
        base.CreateChildren(result);

        result.Integration ??= IntegrationFactory?.Build();
    }

} // End Of Class

public static class InnerChannelNamespaceHandlerConfigFactoryExtensions
{
    public static CombinedResult<InnerChannelNamespaceHandlerConfigFactory, InnerChannelNamespaceIntegrationFactory> WithIntegration(this InnerChannelNamespaceHandlerConfigFactory parentFactory, Action<Humidifier.AppSync.ChannelNamespaceTypes.Integration> subFactoryAction = null)
    {
        parentFactory.IntegrationFactory = new InnerChannelNamespaceIntegrationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IntegrationFactory);
    }

    public static CombinedResult<InnerChannelNamespaceHandlerConfigFactory, T1, InnerChannelNamespaceIntegrationFactory> WithIntegration<T1>(this CombinedResult<InnerChannelNamespaceHandlerConfigFactory, T1> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIntegration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelNamespaceHandlerConfigFactory, InnerChannelNamespaceIntegrationFactory> WithIntegration<T1>(this CombinedResult<T1, InnerChannelNamespaceHandlerConfigFactory> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIntegration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerChannelNamespaceHandlerConfigFactory, T1, T2, InnerChannelNamespaceIntegrationFactory> WithIntegration<T1, T2>(this CombinedResult<InnerChannelNamespaceHandlerConfigFactory, T1, T2> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntegration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelNamespaceHandlerConfigFactory, T2, InnerChannelNamespaceIntegrationFactory> WithIntegration<T1, T2>(this CombinedResult<T1, InnerChannelNamespaceHandlerConfigFactory, T2> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntegration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelNamespaceHandlerConfigFactory, InnerChannelNamespaceIntegrationFactory> WithIntegration<T1, T2>(this CombinedResult<T1, T2, InnerChannelNamespaceHandlerConfigFactory> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntegration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerChannelNamespaceHandlerConfigFactory, T1, T2, T3, InnerChannelNamespaceIntegrationFactory> WithIntegration<T1, T2, T3>(this CombinedResult<InnerChannelNamespaceHandlerConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntegration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelNamespaceHandlerConfigFactory, T2, T3, InnerChannelNamespaceIntegrationFactory> WithIntegration<T1, T2, T3>(this CombinedResult<T1, InnerChannelNamespaceHandlerConfigFactory, T2, T3> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntegration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelNamespaceHandlerConfigFactory, T3, InnerChannelNamespaceIntegrationFactory> WithIntegration<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelNamespaceHandlerConfigFactory, T3> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntegration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelNamespaceHandlerConfigFactory, InnerChannelNamespaceIntegrationFactory> WithIntegration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelNamespaceHandlerConfigFactory> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntegration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerChannelNamespaceHandlerConfigFactory, T1, T2, T3, T4, InnerChannelNamespaceIntegrationFactory> WithIntegration<T1, T2, T3, T4>(this CombinedResult<InnerChannelNamespaceHandlerConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntegration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelNamespaceHandlerConfigFactory, T2, T3, T4, InnerChannelNamespaceIntegrationFactory> WithIntegration<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelNamespaceHandlerConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntegration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelNamespaceHandlerConfigFactory, T3, T4, InnerChannelNamespaceIntegrationFactory> WithIntegration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelNamespaceHandlerConfigFactory, T3, T4> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntegration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelNamespaceHandlerConfigFactory, T4, InnerChannelNamespaceIntegrationFactory> WithIntegration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelNamespaceHandlerConfigFactory, T4> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntegration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerChannelNamespaceHandlerConfigFactory, InnerChannelNamespaceIntegrationFactory> WithIntegration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelNamespaceHandlerConfigFactory> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntegration(combinedResult.T5, subFactoryAction).T2);
}
