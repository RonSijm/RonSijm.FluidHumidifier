// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class ApiKeyFactory(string resourceName = null, Action<Humidifier.ApiGateway.ApiKey> factoryAction = null) : ResourceFactory<Humidifier.ApiGateway.ApiKey>(resourceName)
{

    internal List<InnerApiKeyStageKeyFactory> StageKeysFactories { get; set; } = [];

    protected override Humidifier.ApiGateway.ApiKey Create()
    {
        var apiKeyResult = CreateApiKey();
        factoryAction?.Invoke(apiKeyResult);

        return apiKeyResult;
    }

    private Humidifier.ApiGateway.ApiKey CreateApiKey()
    {
        var apiKeyResult = new Humidifier.ApiGateway.ApiKey
        {
            GivenName = InputResourceName,
        };

        return apiKeyResult;
    }
    public override void CreateChildren(Humidifier.ApiGateway.ApiKey result)
    {
        base.CreateChildren(result);

        result.StageKeys = StageKeysFactories.Any() ? StageKeysFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ApiKeyFactoryExtensions
{
    public static CombinedResult<ApiKeyFactory, InnerApiKeyStageKeyFactory> WithStageKeys(this ApiKeyFactory parentFactory, Action<Humidifier.ApiGateway.ApiKeyTypes.StageKey> subFactoryAction = null)
    {
        var factory = new InnerApiKeyStageKeyFactory(subFactoryAction);
        parentFactory.StageKeysFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ApiKeyFactory, T1, InnerApiKeyStageKeyFactory> WithStageKeys<T1>(this CombinedResult<ApiKeyFactory, T1> combinedResult, Action<Humidifier.ApiGateway.ApiKeyTypes.StageKey> subFactoryAction = null) => new (combinedResult, combinedResult, WithStageKeys(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApiKeyFactory, InnerApiKeyStageKeyFactory> WithStageKeys<T1>(this CombinedResult<T1, ApiKeyFactory> combinedResult, Action<Humidifier.ApiGateway.ApiKeyTypes.StageKey> subFactoryAction = null) => new (combinedResult, combinedResult, WithStageKeys(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApiKeyFactory, T1, T2, InnerApiKeyStageKeyFactory> WithStageKeys<T1, T2>(this CombinedResult<ApiKeyFactory, T1, T2> combinedResult, Action<Humidifier.ApiGateway.ApiKeyTypes.StageKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStageKeys(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApiKeyFactory, T2, InnerApiKeyStageKeyFactory> WithStageKeys<T1, T2>(this CombinedResult<T1, ApiKeyFactory, T2> combinedResult, Action<Humidifier.ApiGateway.ApiKeyTypes.StageKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStageKeys(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApiKeyFactory, InnerApiKeyStageKeyFactory> WithStageKeys<T1, T2>(this CombinedResult<T1, T2, ApiKeyFactory> combinedResult, Action<Humidifier.ApiGateway.ApiKeyTypes.StageKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStageKeys(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApiKeyFactory, T1, T2, T3, InnerApiKeyStageKeyFactory> WithStageKeys<T1, T2, T3>(this CombinedResult<ApiKeyFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGateway.ApiKeyTypes.StageKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStageKeys(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApiKeyFactory, T2, T3, InnerApiKeyStageKeyFactory> WithStageKeys<T1, T2, T3>(this CombinedResult<T1, ApiKeyFactory, T2, T3> combinedResult, Action<Humidifier.ApiGateway.ApiKeyTypes.StageKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStageKeys(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApiKeyFactory, T3, InnerApiKeyStageKeyFactory> WithStageKeys<T1, T2, T3>(this CombinedResult<T1, T2, ApiKeyFactory, T3> combinedResult, Action<Humidifier.ApiGateway.ApiKeyTypes.StageKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStageKeys(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApiKeyFactory, InnerApiKeyStageKeyFactory> WithStageKeys<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApiKeyFactory> combinedResult, Action<Humidifier.ApiGateway.ApiKeyTypes.StageKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStageKeys(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApiKeyFactory, T1, T2, T3, T4, InnerApiKeyStageKeyFactory> WithStageKeys<T1, T2, T3, T4>(this CombinedResult<ApiKeyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.ApiKeyTypes.StageKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStageKeys(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApiKeyFactory, T2, T3, T4, InnerApiKeyStageKeyFactory> WithStageKeys<T1, T2, T3, T4>(this CombinedResult<T1, ApiKeyFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.ApiKeyTypes.StageKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStageKeys(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApiKeyFactory, T3, T4, InnerApiKeyStageKeyFactory> WithStageKeys<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApiKeyFactory, T3, T4> combinedResult, Action<Humidifier.ApiGateway.ApiKeyTypes.StageKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStageKeys(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApiKeyFactory, T4, InnerApiKeyStageKeyFactory> WithStageKeys<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApiKeyFactory, T4> combinedResult, Action<Humidifier.ApiGateway.ApiKeyTypes.StageKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStageKeys(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApiKeyFactory, InnerApiKeyStageKeyFactory> WithStageKeys<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApiKeyFactory> combinedResult, Action<Humidifier.ApiGateway.ApiKeyTypes.StageKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStageKeys(combinedResult.T5, subFactoryAction));
}
