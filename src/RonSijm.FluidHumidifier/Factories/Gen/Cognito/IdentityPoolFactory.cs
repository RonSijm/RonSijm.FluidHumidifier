// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class IdentityPoolFactory(string resourceName = null, Action<Humidifier.Cognito.IdentityPool> factoryAction = null) : ResourceFactory<Humidifier.Cognito.IdentityPool>(resourceName)
{

    internal List<InnerIdentityPoolCognitoIdentityProviderFactory> CognitoIdentityProvidersFactories { get; set; } = [];

    internal InnerIdentityPoolPushSyncFactory PushSyncFactory { get; set; }

    internal InnerIdentityPoolCognitoStreamsFactory CognitoStreamsFactory { get; set; }

    protected override Humidifier.Cognito.IdentityPool Create()
    {
        var identityPoolResult = CreateIdentityPool();
        factoryAction?.Invoke(identityPoolResult);

        return identityPoolResult;
    }

    private Humidifier.Cognito.IdentityPool CreateIdentityPool()
    {
        var identityPoolResult = new Humidifier.Cognito.IdentityPool
        {
            GivenName = InputResourceName,
        };

        return identityPoolResult;
    }
    public override void CreateChildren(Humidifier.Cognito.IdentityPool result)
    {
        base.CreateChildren(result);

        result.CognitoIdentityProviders = CognitoIdentityProvidersFactories.Any() ? CognitoIdentityProvidersFactories.Select(x => x.Build()).ToList() : null;
        result.PushSync ??= PushSyncFactory?.Build();
        result.CognitoStreams ??= CognitoStreamsFactory?.Build();
    }

} // End Of Class

public static class IdentityPoolFactoryExtensions
{
    public static CombinedResult<IdentityPoolFactory, InnerIdentityPoolCognitoIdentityProviderFactory> WithCognitoIdentityProviders(this IdentityPoolFactory parentFactory, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoIdentityProvider> subFactoryAction = null)
    {
        var factory = new InnerIdentityPoolCognitoIdentityProviderFactory(subFactoryAction);
        parentFactory.CognitoIdentityProvidersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<IdentityPoolFactory, InnerIdentityPoolPushSyncFactory> WithPushSync(this IdentityPoolFactory parentFactory, Action<Humidifier.Cognito.IdentityPoolTypes.PushSync> subFactoryAction = null)
    {
        parentFactory.PushSyncFactory = new InnerIdentityPoolPushSyncFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PushSyncFactory);
    }

    public static CombinedResult<IdentityPoolFactory, InnerIdentityPoolCognitoStreamsFactory> WithCognitoStreams(this IdentityPoolFactory parentFactory, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoStreams> subFactoryAction = null)
    {
        parentFactory.CognitoStreamsFactory = new InnerIdentityPoolCognitoStreamsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CognitoStreamsFactory);
    }

    public static CombinedResult<IdentityPoolFactory, T1, InnerIdentityPoolCognitoIdentityProviderFactory> WithCognitoIdentityProviders<T1>(this CombinedResult<IdentityPoolFactory, T1> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoIdentityProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithCognitoIdentityProviders(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentityPoolFactory, InnerIdentityPoolCognitoIdentityProviderFactory> WithCognitoIdentityProviders<T1>(this CombinedResult<T1, IdentityPoolFactory> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoIdentityProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithCognitoIdentityProviders(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IdentityPoolFactory, T1, T2, InnerIdentityPoolCognitoIdentityProviderFactory> WithCognitoIdentityProviders<T1, T2>(this CombinedResult<IdentityPoolFactory, T1, T2> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoIdentityProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCognitoIdentityProviders(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentityPoolFactory, T2, InnerIdentityPoolCognitoIdentityProviderFactory> WithCognitoIdentityProviders<T1, T2>(this CombinedResult<T1, IdentityPoolFactory, T2> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoIdentityProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCognitoIdentityProviders(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdentityPoolFactory, InnerIdentityPoolCognitoIdentityProviderFactory> WithCognitoIdentityProviders<T1, T2>(this CombinedResult<T1, T2, IdentityPoolFactory> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoIdentityProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCognitoIdentityProviders(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IdentityPoolFactory, T1, T2, T3, InnerIdentityPoolCognitoIdentityProviderFactory> WithCognitoIdentityProviders<T1, T2, T3>(this CombinedResult<IdentityPoolFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoIdentityProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoIdentityProviders(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentityPoolFactory, T2, T3, InnerIdentityPoolCognitoIdentityProviderFactory> WithCognitoIdentityProviders<T1, T2, T3>(this CombinedResult<T1, IdentityPoolFactory, T2, T3> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoIdentityProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoIdentityProviders(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdentityPoolFactory, T3, InnerIdentityPoolCognitoIdentityProviderFactory> WithCognitoIdentityProviders<T1, T2, T3>(this CombinedResult<T1, T2, IdentityPoolFactory, T3> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoIdentityProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoIdentityProviders(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdentityPoolFactory, InnerIdentityPoolCognitoIdentityProviderFactory> WithCognitoIdentityProviders<T1, T2, T3>(this CombinedResult<T1, T2, T3, IdentityPoolFactory> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoIdentityProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoIdentityProviders(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IdentityPoolFactory, T1, T2, T3, T4, InnerIdentityPoolCognitoIdentityProviderFactory> WithCognitoIdentityProviders<T1, T2, T3, T4>(this CombinedResult<IdentityPoolFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoIdentityProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoIdentityProviders(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentityPoolFactory, T2, T3, T4, InnerIdentityPoolCognitoIdentityProviderFactory> WithCognitoIdentityProviders<T1, T2, T3, T4>(this CombinedResult<T1, IdentityPoolFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoIdentityProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoIdentityProviders(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdentityPoolFactory, T3, T4, InnerIdentityPoolCognitoIdentityProviderFactory> WithCognitoIdentityProviders<T1, T2, T3, T4>(this CombinedResult<T1, T2, IdentityPoolFactory, T3, T4> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoIdentityProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoIdentityProviders(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdentityPoolFactory, T4, InnerIdentityPoolCognitoIdentityProviderFactory> WithCognitoIdentityProviders<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IdentityPoolFactory, T4> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoIdentityProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoIdentityProviders(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IdentityPoolFactory, InnerIdentityPoolCognitoIdentityProviderFactory> WithCognitoIdentityProviders<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IdentityPoolFactory> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoIdentityProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoIdentityProviders(combinedResult.T5, subFactoryAction));
    public static CombinedResult<IdentityPoolFactory, T1, InnerIdentityPoolPushSyncFactory> WithPushSync<T1>(this CombinedResult<IdentityPoolFactory, T1> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.PushSync> subFactoryAction = null) => new (combinedResult, combinedResult, WithPushSync(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentityPoolFactory, InnerIdentityPoolPushSyncFactory> WithPushSync<T1>(this CombinedResult<T1, IdentityPoolFactory> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.PushSync> subFactoryAction = null) => new (combinedResult, combinedResult, WithPushSync(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IdentityPoolFactory, T1, T2, InnerIdentityPoolPushSyncFactory> WithPushSync<T1, T2>(this CombinedResult<IdentityPoolFactory, T1, T2> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.PushSync> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPushSync(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentityPoolFactory, T2, InnerIdentityPoolPushSyncFactory> WithPushSync<T1, T2>(this CombinedResult<T1, IdentityPoolFactory, T2> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.PushSync> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPushSync(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdentityPoolFactory, InnerIdentityPoolPushSyncFactory> WithPushSync<T1, T2>(this CombinedResult<T1, T2, IdentityPoolFactory> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.PushSync> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPushSync(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IdentityPoolFactory, T1, T2, T3, InnerIdentityPoolPushSyncFactory> WithPushSync<T1, T2, T3>(this CombinedResult<IdentityPoolFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.PushSync> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPushSync(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentityPoolFactory, T2, T3, InnerIdentityPoolPushSyncFactory> WithPushSync<T1, T2, T3>(this CombinedResult<T1, IdentityPoolFactory, T2, T3> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.PushSync> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPushSync(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdentityPoolFactory, T3, InnerIdentityPoolPushSyncFactory> WithPushSync<T1, T2, T3>(this CombinedResult<T1, T2, IdentityPoolFactory, T3> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.PushSync> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPushSync(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdentityPoolFactory, InnerIdentityPoolPushSyncFactory> WithPushSync<T1, T2, T3>(this CombinedResult<T1, T2, T3, IdentityPoolFactory> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.PushSync> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPushSync(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IdentityPoolFactory, T1, T2, T3, T4, InnerIdentityPoolPushSyncFactory> WithPushSync<T1, T2, T3, T4>(this CombinedResult<IdentityPoolFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.PushSync> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPushSync(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentityPoolFactory, T2, T3, T4, InnerIdentityPoolPushSyncFactory> WithPushSync<T1, T2, T3, T4>(this CombinedResult<T1, IdentityPoolFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.PushSync> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPushSync(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdentityPoolFactory, T3, T4, InnerIdentityPoolPushSyncFactory> WithPushSync<T1, T2, T3, T4>(this CombinedResult<T1, T2, IdentityPoolFactory, T3, T4> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.PushSync> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPushSync(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdentityPoolFactory, T4, InnerIdentityPoolPushSyncFactory> WithPushSync<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IdentityPoolFactory, T4> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.PushSync> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPushSync(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IdentityPoolFactory, InnerIdentityPoolPushSyncFactory> WithPushSync<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IdentityPoolFactory> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.PushSync> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPushSync(combinedResult.T5, subFactoryAction));
    public static CombinedResult<IdentityPoolFactory, T1, InnerIdentityPoolCognitoStreamsFactory> WithCognitoStreams<T1>(this CombinedResult<IdentityPoolFactory, T1> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, WithCognitoStreams(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentityPoolFactory, InnerIdentityPoolCognitoStreamsFactory> WithCognitoStreams<T1>(this CombinedResult<T1, IdentityPoolFactory> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, WithCognitoStreams(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IdentityPoolFactory, T1, T2, InnerIdentityPoolCognitoStreamsFactory> WithCognitoStreams<T1, T2>(this CombinedResult<IdentityPoolFactory, T1, T2> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCognitoStreams(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentityPoolFactory, T2, InnerIdentityPoolCognitoStreamsFactory> WithCognitoStreams<T1, T2>(this CombinedResult<T1, IdentityPoolFactory, T2> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCognitoStreams(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdentityPoolFactory, InnerIdentityPoolCognitoStreamsFactory> WithCognitoStreams<T1, T2>(this CombinedResult<T1, T2, IdentityPoolFactory> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCognitoStreams(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IdentityPoolFactory, T1, T2, T3, InnerIdentityPoolCognitoStreamsFactory> WithCognitoStreams<T1, T2, T3>(this CombinedResult<IdentityPoolFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoStreams(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentityPoolFactory, T2, T3, InnerIdentityPoolCognitoStreamsFactory> WithCognitoStreams<T1, T2, T3>(this CombinedResult<T1, IdentityPoolFactory, T2, T3> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoStreams(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdentityPoolFactory, T3, InnerIdentityPoolCognitoStreamsFactory> WithCognitoStreams<T1, T2, T3>(this CombinedResult<T1, T2, IdentityPoolFactory, T3> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoStreams(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdentityPoolFactory, InnerIdentityPoolCognitoStreamsFactory> WithCognitoStreams<T1, T2, T3>(this CombinedResult<T1, T2, T3, IdentityPoolFactory> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoStreams(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IdentityPoolFactory, T1, T2, T3, T4, InnerIdentityPoolCognitoStreamsFactory> WithCognitoStreams<T1, T2, T3, T4>(this CombinedResult<IdentityPoolFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoStreams(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentityPoolFactory, T2, T3, T4, InnerIdentityPoolCognitoStreamsFactory> WithCognitoStreams<T1, T2, T3, T4>(this CombinedResult<T1, IdentityPoolFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoStreams(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdentityPoolFactory, T3, T4, InnerIdentityPoolCognitoStreamsFactory> WithCognitoStreams<T1, T2, T3, T4>(this CombinedResult<T1, T2, IdentityPoolFactory, T3, T4> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoStreams(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdentityPoolFactory, T4, InnerIdentityPoolCognitoStreamsFactory> WithCognitoStreams<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IdentityPoolFactory, T4> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoStreams(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IdentityPoolFactory, InnerIdentityPoolCognitoStreamsFactory> WithCognitoStreams<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IdentityPoolFactory> combinedResult, Action<Humidifier.Cognito.IdentityPoolTypes.CognitoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCognitoStreams(combinedResult.T5, subFactoryAction));
}
