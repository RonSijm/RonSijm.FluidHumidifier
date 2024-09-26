// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Location;

public class APIKeyFactory(string resourceName = null, Action<Humidifier.Location.APIKey> factoryAction = null) : ResourceFactory<Humidifier.Location.APIKey>(resourceName)
{

    internal InnerAPIKeyApiKeyRestrictionsFactory RestrictionsFactory { get; set; }

    protected override Humidifier.Location.APIKey Create()
    {
        var aPIKeyResult = CreateAPIKey();
        factoryAction?.Invoke(aPIKeyResult);

        return aPIKeyResult;
    }

    private Humidifier.Location.APIKey CreateAPIKey()
    {
        var aPIKeyResult = new Humidifier.Location.APIKey
        {
            GivenName = InputResourceName,
        };

        return aPIKeyResult;
    }
    public override void CreateChildren(Humidifier.Location.APIKey result)
    {
        base.CreateChildren(result);

        result.Restrictions ??= RestrictionsFactory?.Build();
    }

} // End Of Class

public static class APIKeyFactoryExtensions
{
    public static CombinedResult<APIKeyFactory, InnerAPIKeyApiKeyRestrictionsFactory> WithRestrictions(this APIKeyFactory parentFactory, Action<Humidifier.Location.APIKeyTypes.ApiKeyRestrictions> subFactoryAction = null)
    {
        parentFactory.RestrictionsFactory = new InnerAPIKeyApiKeyRestrictionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RestrictionsFactory);
    }

    public static CombinedResult<APIKeyFactory, T1, InnerAPIKeyApiKeyRestrictionsFactory> WithRestrictions<T1>(this CombinedResult<APIKeyFactory, T1> combinedResult, Action<Humidifier.Location.APIKeyTypes.ApiKeyRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, WithRestrictions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, APIKeyFactory, InnerAPIKeyApiKeyRestrictionsFactory> WithRestrictions<T1>(this CombinedResult<T1, APIKeyFactory> combinedResult, Action<Humidifier.Location.APIKeyTypes.ApiKeyRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, WithRestrictions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<APIKeyFactory, T1, T2, InnerAPIKeyApiKeyRestrictionsFactory> WithRestrictions<T1, T2>(this CombinedResult<APIKeyFactory, T1, T2> combinedResult, Action<Humidifier.Location.APIKeyTypes.ApiKeyRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, APIKeyFactory, T2, InnerAPIKeyApiKeyRestrictionsFactory> WithRestrictions<T1, T2>(this CombinedResult<T1, APIKeyFactory, T2> combinedResult, Action<Humidifier.Location.APIKeyTypes.ApiKeyRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, APIKeyFactory, InnerAPIKeyApiKeyRestrictionsFactory> WithRestrictions<T1, T2>(this CombinedResult<T1, T2, APIKeyFactory> combinedResult, Action<Humidifier.Location.APIKeyTypes.ApiKeyRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<APIKeyFactory, T1, T2, T3, InnerAPIKeyApiKeyRestrictionsFactory> WithRestrictions<T1, T2, T3>(this CombinedResult<APIKeyFactory, T1, T2, T3> combinedResult, Action<Humidifier.Location.APIKeyTypes.ApiKeyRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, APIKeyFactory, T2, T3, InnerAPIKeyApiKeyRestrictionsFactory> WithRestrictions<T1, T2, T3>(this CombinedResult<T1, APIKeyFactory, T2, T3> combinedResult, Action<Humidifier.Location.APIKeyTypes.ApiKeyRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, APIKeyFactory, T3, InnerAPIKeyApiKeyRestrictionsFactory> WithRestrictions<T1, T2, T3>(this CombinedResult<T1, T2, APIKeyFactory, T3> combinedResult, Action<Humidifier.Location.APIKeyTypes.ApiKeyRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, APIKeyFactory, InnerAPIKeyApiKeyRestrictionsFactory> WithRestrictions<T1, T2, T3>(this CombinedResult<T1, T2, T3, APIKeyFactory> combinedResult, Action<Humidifier.Location.APIKeyTypes.ApiKeyRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<APIKeyFactory, T1, T2, T3, T4, InnerAPIKeyApiKeyRestrictionsFactory> WithRestrictions<T1, T2, T3, T4>(this CombinedResult<APIKeyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Location.APIKeyTypes.ApiKeyRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, APIKeyFactory, T2, T3, T4, InnerAPIKeyApiKeyRestrictionsFactory> WithRestrictions<T1, T2, T3, T4>(this CombinedResult<T1, APIKeyFactory, T2, T3, T4> combinedResult, Action<Humidifier.Location.APIKeyTypes.ApiKeyRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, APIKeyFactory, T3, T4, InnerAPIKeyApiKeyRestrictionsFactory> WithRestrictions<T1, T2, T3, T4>(this CombinedResult<T1, T2, APIKeyFactory, T3, T4> combinedResult, Action<Humidifier.Location.APIKeyTypes.ApiKeyRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, APIKeyFactory, T4, InnerAPIKeyApiKeyRestrictionsFactory> WithRestrictions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, APIKeyFactory, T4> combinedResult, Action<Humidifier.Location.APIKeyTypes.ApiKeyRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, APIKeyFactory, InnerAPIKeyApiKeyRestrictionsFactory> WithRestrictions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, APIKeyFactory> combinedResult, Action<Humidifier.Location.APIKeyTypes.ApiKeyRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T5, subFactoryAction));
}
