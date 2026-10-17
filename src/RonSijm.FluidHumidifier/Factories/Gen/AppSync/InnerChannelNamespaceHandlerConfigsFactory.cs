// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerChannelNamespaceHandlerConfigsFactory(Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfigs> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfigs>
{

    internal InnerChannelNamespaceHandlerConfigFactory OnPublishFactory { get; set; }

    internal InnerChannelNamespaceHandlerConfigFactory OnSubscribeFactory { get; set; }

    protected override Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfigs Create()
    {
        var handlerConfigsResult = CreateHandlerConfigs();
        factoryAction?.Invoke(handlerConfigsResult);

        return handlerConfigsResult;
    }

    private Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfigs CreateHandlerConfigs()
    {
        var handlerConfigsResult = new Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfigs();

        return handlerConfigsResult;
    }
    public override void CreateChildren(Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfigs result)
    {
        base.CreateChildren(result);

        result.OnPublish ??= OnPublishFactory?.Build();
        result.OnSubscribe ??= OnSubscribeFactory?.Build();
    }

} // End Of Class

public static class InnerChannelNamespaceHandlerConfigsFactoryExtensions
{
    public static CombinedResult<InnerChannelNamespaceHandlerConfigsFactory, InnerChannelNamespaceHandlerConfigFactory> WithOnPublish(this InnerChannelNamespaceHandlerConfigsFactory parentFactory, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null)
    {
        parentFactory.OnPublishFactory = new InnerChannelNamespaceHandlerConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OnPublishFactory);
    }

    public static CombinedResult<InnerChannelNamespaceHandlerConfigsFactory, InnerChannelNamespaceHandlerConfigFactory> WithOnSubscribe(this InnerChannelNamespaceHandlerConfigsFactory parentFactory, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null)
    {
        parentFactory.OnSubscribeFactory = new InnerChannelNamespaceHandlerConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OnSubscribeFactory);
    }

    public static CombinedResult<InnerChannelNamespaceHandlerConfigsFactory, T1, InnerChannelNamespaceHandlerConfigFactory> WithOnPublish<T1>(this CombinedResult<InnerChannelNamespaceHandlerConfigsFactory, T1> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOnPublish(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelNamespaceHandlerConfigsFactory, InnerChannelNamespaceHandlerConfigFactory> WithOnPublish<T1>(this CombinedResult<T1, InnerChannelNamespaceHandlerConfigsFactory> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOnPublish(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerChannelNamespaceHandlerConfigsFactory, T1, T2, InnerChannelNamespaceHandlerConfigFactory> WithOnPublish<T1, T2>(this CombinedResult<InnerChannelNamespaceHandlerConfigsFactory, T1, T2> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnPublish(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelNamespaceHandlerConfigsFactory, T2, InnerChannelNamespaceHandlerConfigFactory> WithOnPublish<T1, T2>(this CombinedResult<T1, InnerChannelNamespaceHandlerConfigsFactory, T2> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnPublish(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelNamespaceHandlerConfigsFactory, InnerChannelNamespaceHandlerConfigFactory> WithOnPublish<T1, T2>(this CombinedResult<T1, T2, InnerChannelNamespaceHandlerConfigsFactory> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnPublish(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerChannelNamespaceHandlerConfigsFactory, T1, T2, T3, InnerChannelNamespaceHandlerConfigFactory> WithOnPublish<T1, T2, T3>(this CombinedResult<InnerChannelNamespaceHandlerConfigsFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnPublish(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelNamespaceHandlerConfigsFactory, T2, T3, InnerChannelNamespaceHandlerConfigFactory> WithOnPublish<T1, T2, T3>(this CombinedResult<T1, InnerChannelNamespaceHandlerConfigsFactory, T2, T3> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnPublish(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelNamespaceHandlerConfigsFactory, T3, InnerChannelNamespaceHandlerConfigFactory> WithOnPublish<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelNamespaceHandlerConfigsFactory, T3> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnPublish(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelNamespaceHandlerConfigsFactory, InnerChannelNamespaceHandlerConfigFactory> WithOnPublish<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelNamespaceHandlerConfigsFactory> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnPublish(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerChannelNamespaceHandlerConfigsFactory, T1, T2, T3, T4, InnerChannelNamespaceHandlerConfigFactory> WithOnPublish<T1, T2, T3, T4>(this CombinedResult<InnerChannelNamespaceHandlerConfigsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnPublish(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelNamespaceHandlerConfigsFactory, T2, T3, T4, InnerChannelNamespaceHandlerConfigFactory> WithOnPublish<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelNamespaceHandlerConfigsFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnPublish(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelNamespaceHandlerConfigsFactory, T3, T4, InnerChannelNamespaceHandlerConfigFactory> WithOnPublish<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelNamespaceHandlerConfigsFactory, T3, T4> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnPublish(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelNamespaceHandlerConfigsFactory, T4, InnerChannelNamespaceHandlerConfigFactory> WithOnPublish<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelNamespaceHandlerConfigsFactory, T4> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnPublish(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerChannelNamespaceHandlerConfigsFactory, InnerChannelNamespaceHandlerConfigFactory> WithOnPublish<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelNamespaceHandlerConfigsFactory> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnPublish(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerChannelNamespaceHandlerConfigsFactory, T1, InnerChannelNamespaceHandlerConfigFactory> WithOnSubscribe<T1>(this CombinedResult<InnerChannelNamespaceHandlerConfigsFactory, T1> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOnSubscribe(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelNamespaceHandlerConfigsFactory, InnerChannelNamespaceHandlerConfigFactory> WithOnSubscribe<T1>(this CombinedResult<T1, InnerChannelNamespaceHandlerConfigsFactory> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOnSubscribe(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerChannelNamespaceHandlerConfigsFactory, T1, T2, InnerChannelNamespaceHandlerConfigFactory> WithOnSubscribe<T1, T2>(this CombinedResult<InnerChannelNamespaceHandlerConfigsFactory, T1, T2> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnSubscribe(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelNamespaceHandlerConfigsFactory, T2, InnerChannelNamespaceHandlerConfigFactory> WithOnSubscribe<T1, T2>(this CombinedResult<T1, InnerChannelNamespaceHandlerConfigsFactory, T2> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnSubscribe(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelNamespaceHandlerConfigsFactory, InnerChannelNamespaceHandlerConfigFactory> WithOnSubscribe<T1, T2>(this CombinedResult<T1, T2, InnerChannelNamespaceHandlerConfigsFactory> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnSubscribe(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerChannelNamespaceHandlerConfigsFactory, T1, T2, T3, InnerChannelNamespaceHandlerConfigFactory> WithOnSubscribe<T1, T2, T3>(this CombinedResult<InnerChannelNamespaceHandlerConfigsFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnSubscribe(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelNamespaceHandlerConfigsFactory, T2, T3, InnerChannelNamespaceHandlerConfigFactory> WithOnSubscribe<T1, T2, T3>(this CombinedResult<T1, InnerChannelNamespaceHandlerConfigsFactory, T2, T3> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnSubscribe(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelNamespaceHandlerConfigsFactory, T3, InnerChannelNamespaceHandlerConfigFactory> WithOnSubscribe<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelNamespaceHandlerConfigsFactory, T3> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnSubscribe(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelNamespaceHandlerConfigsFactory, InnerChannelNamespaceHandlerConfigFactory> WithOnSubscribe<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelNamespaceHandlerConfigsFactory> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnSubscribe(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerChannelNamespaceHandlerConfigsFactory, T1, T2, T3, T4, InnerChannelNamespaceHandlerConfigFactory> WithOnSubscribe<T1, T2, T3, T4>(this CombinedResult<InnerChannelNamespaceHandlerConfigsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnSubscribe(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelNamespaceHandlerConfigsFactory, T2, T3, T4, InnerChannelNamespaceHandlerConfigFactory> WithOnSubscribe<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelNamespaceHandlerConfigsFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnSubscribe(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelNamespaceHandlerConfigsFactory, T3, T4, InnerChannelNamespaceHandlerConfigFactory> WithOnSubscribe<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelNamespaceHandlerConfigsFactory, T3, T4> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnSubscribe(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelNamespaceHandlerConfigsFactory, T4, InnerChannelNamespaceHandlerConfigFactory> WithOnSubscribe<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelNamespaceHandlerConfigsFactory, T4> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnSubscribe(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerChannelNamespaceHandlerConfigsFactory, InnerChannelNamespaceHandlerConfigFactory> WithOnSubscribe<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelNamespaceHandlerConfigsFactory> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnSubscribe(combinedResult.T5, subFactoryAction).T2);
}
