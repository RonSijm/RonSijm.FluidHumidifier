// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerChannelNamespaceIntegrationFactory(Action<Humidifier.AppSync.ChannelNamespaceTypes.Integration> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.ChannelNamespaceTypes.Integration>
{

    internal InnerChannelNamespaceLambdaConfigFactory LambdaConfigFactory { get; set; }

    protected override Humidifier.AppSync.ChannelNamespaceTypes.Integration Create()
    {
        var integrationResult = CreateIntegration();
        factoryAction?.Invoke(integrationResult);

        return integrationResult;
    }

    private Humidifier.AppSync.ChannelNamespaceTypes.Integration CreateIntegration()
    {
        var integrationResult = new Humidifier.AppSync.ChannelNamespaceTypes.Integration();

        return integrationResult;
    }
    public override void CreateChildren(Humidifier.AppSync.ChannelNamespaceTypes.Integration result)
    {
        base.CreateChildren(result);

        result.LambdaConfig ??= LambdaConfigFactory?.Build();
    }

} // End Of Class

public static class InnerChannelNamespaceIntegrationFactoryExtensions
{
    public static CombinedResult<InnerChannelNamespaceIntegrationFactory, InnerChannelNamespaceLambdaConfigFactory> WithLambdaConfig(this InnerChannelNamespaceIntegrationFactory parentFactory, Action<Humidifier.AppSync.ChannelNamespaceTypes.LambdaConfig> subFactoryAction = null)
    {
        parentFactory.LambdaConfigFactory = new InnerChannelNamespaceLambdaConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LambdaConfigFactory);
    }

    public static CombinedResult<InnerChannelNamespaceIntegrationFactory, T1, InnerChannelNamespaceLambdaConfigFactory> WithLambdaConfig<T1>(this CombinedResult<InnerChannelNamespaceIntegrationFactory, T1> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.LambdaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLambdaConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelNamespaceIntegrationFactory, InnerChannelNamespaceLambdaConfigFactory> WithLambdaConfig<T1>(this CombinedResult<T1, InnerChannelNamespaceIntegrationFactory> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.LambdaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLambdaConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerChannelNamespaceIntegrationFactory, T1, T2, InnerChannelNamespaceLambdaConfigFactory> WithLambdaConfig<T1, T2>(this CombinedResult<InnerChannelNamespaceIntegrationFactory, T1, T2> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.LambdaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelNamespaceIntegrationFactory, T2, InnerChannelNamespaceLambdaConfigFactory> WithLambdaConfig<T1, T2>(this CombinedResult<T1, InnerChannelNamespaceIntegrationFactory, T2> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.LambdaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelNamespaceIntegrationFactory, InnerChannelNamespaceLambdaConfigFactory> WithLambdaConfig<T1, T2>(this CombinedResult<T1, T2, InnerChannelNamespaceIntegrationFactory> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.LambdaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerChannelNamespaceIntegrationFactory, T1, T2, T3, InnerChannelNamespaceLambdaConfigFactory> WithLambdaConfig<T1, T2, T3>(this CombinedResult<InnerChannelNamespaceIntegrationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.LambdaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelNamespaceIntegrationFactory, T2, T3, InnerChannelNamespaceLambdaConfigFactory> WithLambdaConfig<T1, T2, T3>(this CombinedResult<T1, InnerChannelNamespaceIntegrationFactory, T2, T3> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.LambdaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelNamespaceIntegrationFactory, T3, InnerChannelNamespaceLambdaConfigFactory> WithLambdaConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelNamespaceIntegrationFactory, T3> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.LambdaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelNamespaceIntegrationFactory, InnerChannelNamespaceLambdaConfigFactory> WithLambdaConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelNamespaceIntegrationFactory> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.LambdaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerChannelNamespaceIntegrationFactory, T1, T2, T3, T4, InnerChannelNamespaceLambdaConfigFactory> WithLambdaConfig<T1, T2, T3, T4>(this CombinedResult<InnerChannelNamespaceIntegrationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.LambdaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelNamespaceIntegrationFactory, T2, T3, T4, InnerChannelNamespaceLambdaConfigFactory> WithLambdaConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelNamespaceIntegrationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.LambdaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelNamespaceIntegrationFactory, T3, T4, InnerChannelNamespaceLambdaConfigFactory> WithLambdaConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelNamespaceIntegrationFactory, T3, T4> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.LambdaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelNamespaceIntegrationFactory, T4, InnerChannelNamespaceLambdaConfigFactory> WithLambdaConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelNamespaceIntegrationFactory, T4> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.LambdaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerChannelNamespaceIntegrationFactory, InnerChannelNamespaceLambdaConfigFactory> WithLambdaConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelNamespaceIntegrationFactory> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.LambdaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfig(combinedResult.T5, subFactoryAction).T2);
}
