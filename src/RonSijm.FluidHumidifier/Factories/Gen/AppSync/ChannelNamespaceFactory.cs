// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class ChannelNamespaceFactory(string resourceName = null, Action<Humidifier.AppSync.ChannelNamespace> factoryAction = null) : ResourceFactory<Humidifier.AppSync.ChannelNamespace>(resourceName)
{

    internal List<InnerChannelNamespaceAuthModeFactory> SubscribeAuthModesFactories { get; set; } = [];

    internal List<InnerChannelNamespaceAuthModeFactory> PublishAuthModesFactories { get; set; } = [];

    protected override Humidifier.AppSync.ChannelNamespace Create()
    {
        var channelNamespaceResult = CreateChannelNamespace();
        factoryAction?.Invoke(channelNamespaceResult);

        return channelNamespaceResult;
    }

    private Humidifier.AppSync.ChannelNamespace CreateChannelNamespace()
    {
        var channelNamespaceResult = new Humidifier.AppSync.ChannelNamespace
        {
            GivenName = InputResourceName,
        };

        return channelNamespaceResult;
    }
    public override void CreateChildren(Humidifier.AppSync.ChannelNamespace result)
    {
        base.CreateChildren(result);

        result.SubscribeAuthModes = SubscribeAuthModesFactories.Any() ? SubscribeAuthModesFactories.Select(x => x.Build()).ToList() : null;
        result.PublishAuthModes = PublishAuthModesFactories.Any() ? PublishAuthModesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ChannelNamespaceFactoryExtensions
{
    public static CombinedResult<ChannelNamespaceFactory, InnerChannelNamespaceAuthModeFactory> WithSubscribeAuthModes(this ChannelNamespaceFactory parentFactory, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null)
    {
        var factory = new InnerChannelNamespaceAuthModeFactory(subFactoryAction);
        parentFactory.SubscribeAuthModesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ChannelNamespaceFactory, InnerChannelNamespaceAuthModeFactory> WithPublishAuthModes(this ChannelNamespaceFactory parentFactory, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null)
    {
        var factory = new InnerChannelNamespaceAuthModeFactory(subFactoryAction);
        parentFactory.PublishAuthModesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ChannelNamespaceFactory, T1, InnerChannelNamespaceAuthModeFactory> WithSubscribeAuthModes<T1>(this CombinedResult<ChannelNamespaceFactory, T1> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubscribeAuthModes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelNamespaceFactory, InnerChannelNamespaceAuthModeFactory> WithSubscribeAuthModes<T1>(this CombinedResult<T1, ChannelNamespaceFactory> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubscribeAuthModes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ChannelNamespaceFactory, T1, T2, InnerChannelNamespaceAuthModeFactory> WithSubscribeAuthModes<T1, T2>(this CombinedResult<ChannelNamespaceFactory, T1, T2> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubscribeAuthModes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelNamespaceFactory, T2, InnerChannelNamespaceAuthModeFactory> WithSubscribeAuthModes<T1, T2>(this CombinedResult<T1, ChannelNamespaceFactory, T2> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubscribeAuthModes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelNamespaceFactory, InnerChannelNamespaceAuthModeFactory> WithSubscribeAuthModes<T1, T2>(this CombinedResult<T1, T2, ChannelNamespaceFactory> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubscribeAuthModes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ChannelNamespaceFactory, T1, T2, T3, InnerChannelNamespaceAuthModeFactory> WithSubscribeAuthModes<T1, T2, T3>(this CombinedResult<ChannelNamespaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscribeAuthModes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelNamespaceFactory, T2, T3, InnerChannelNamespaceAuthModeFactory> WithSubscribeAuthModes<T1, T2, T3>(this CombinedResult<T1, ChannelNamespaceFactory, T2, T3> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscribeAuthModes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelNamespaceFactory, T3, InnerChannelNamespaceAuthModeFactory> WithSubscribeAuthModes<T1, T2, T3>(this CombinedResult<T1, T2, ChannelNamespaceFactory, T3> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscribeAuthModes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelNamespaceFactory, InnerChannelNamespaceAuthModeFactory> WithSubscribeAuthModes<T1, T2, T3>(this CombinedResult<T1, T2, T3, ChannelNamespaceFactory> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscribeAuthModes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ChannelNamespaceFactory, T1, T2, T3, T4, InnerChannelNamespaceAuthModeFactory> WithSubscribeAuthModes<T1, T2, T3, T4>(this CombinedResult<ChannelNamespaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscribeAuthModes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelNamespaceFactory, T2, T3, T4, InnerChannelNamespaceAuthModeFactory> WithSubscribeAuthModes<T1, T2, T3, T4>(this CombinedResult<T1, ChannelNamespaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscribeAuthModes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelNamespaceFactory, T3, T4, InnerChannelNamespaceAuthModeFactory> WithSubscribeAuthModes<T1, T2, T3, T4>(this CombinedResult<T1, T2, ChannelNamespaceFactory, T3, T4> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscribeAuthModes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelNamespaceFactory, T4, InnerChannelNamespaceAuthModeFactory> WithSubscribeAuthModes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ChannelNamespaceFactory, T4> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscribeAuthModes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ChannelNamespaceFactory, InnerChannelNamespaceAuthModeFactory> WithSubscribeAuthModes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ChannelNamespaceFactory> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscribeAuthModes(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ChannelNamespaceFactory, T1, InnerChannelNamespaceAuthModeFactory> WithPublishAuthModes<T1>(this CombinedResult<ChannelNamespaceFactory, T1> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, WithPublishAuthModes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelNamespaceFactory, InnerChannelNamespaceAuthModeFactory> WithPublishAuthModes<T1>(this CombinedResult<T1, ChannelNamespaceFactory> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, WithPublishAuthModes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ChannelNamespaceFactory, T1, T2, InnerChannelNamespaceAuthModeFactory> WithPublishAuthModes<T1, T2>(this CombinedResult<ChannelNamespaceFactory, T1, T2> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublishAuthModes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelNamespaceFactory, T2, InnerChannelNamespaceAuthModeFactory> WithPublishAuthModes<T1, T2>(this CombinedResult<T1, ChannelNamespaceFactory, T2> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublishAuthModes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelNamespaceFactory, InnerChannelNamespaceAuthModeFactory> WithPublishAuthModes<T1, T2>(this CombinedResult<T1, T2, ChannelNamespaceFactory> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublishAuthModes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ChannelNamespaceFactory, T1, T2, T3, InnerChannelNamespaceAuthModeFactory> WithPublishAuthModes<T1, T2, T3>(this CombinedResult<ChannelNamespaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublishAuthModes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelNamespaceFactory, T2, T3, InnerChannelNamespaceAuthModeFactory> WithPublishAuthModes<T1, T2, T3>(this CombinedResult<T1, ChannelNamespaceFactory, T2, T3> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublishAuthModes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelNamespaceFactory, T3, InnerChannelNamespaceAuthModeFactory> WithPublishAuthModes<T1, T2, T3>(this CombinedResult<T1, T2, ChannelNamespaceFactory, T3> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublishAuthModes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelNamespaceFactory, InnerChannelNamespaceAuthModeFactory> WithPublishAuthModes<T1, T2, T3>(this CombinedResult<T1, T2, T3, ChannelNamespaceFactory> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublishAuthModes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ChannelNamespaceFactory, T1, T2, T3, T4, InnerChannelNamespaceAuthModeFactory> WithPublishAuthModes<T1, T2, T3, T4>(this CombinedResult<ChannelNamespaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublishAuthModes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelNamespaceFactory, T2, T3, T4, InnerChannelNamespaceAuthModeFactory> WithPublishAuthModes<T1, T2, T3, T4>(this CombinedResult<T1, ChannelNamespaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublishAuthModes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelNamespaceFactory, T3, T4, InnerChannelNamespaceAuthModeFactory> WithPublishAuthModes<T1, T2, T3, T4>(this CombinedResult<T1, T2, ChannelNamespaceFactory, T3, T4> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublishAuthModes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelNamespaceFactory, T4, InnerChannelNamespaceAuthModeFactory> WithPublishAuthModes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ChannelNamespaceFactory, T4> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublishAuthModes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ChannelNamespaceFactory, InnerChannelNamespaceAuthModeFactory> WithPublishAuthModes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ChannelNamespaceFactory> combinedResult, Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublishAuthModes(combinedResult.T5, subFactoryAction));
}
