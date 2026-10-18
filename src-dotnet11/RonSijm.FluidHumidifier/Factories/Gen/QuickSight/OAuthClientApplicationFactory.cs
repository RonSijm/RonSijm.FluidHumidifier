// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class OAuthClientApplicationFactory(string resourceName = null, Action<Humidifier.QuickSight.OAuthClientApplication> factoryAction = null) : ResourceFactory<Humidifier.QuickSight.OAuthClientApplication>(resourceName)
{

    internal InnerOAuthClientApplicationIdentityProviderVpcConnectionPropertiesFactory IdentityProviderVpcConnectionPropertiesFactory { get; set; }

    protected override Humidifier.QuickSight.OAuthClientApplication Create()
    {
        var oAuthClientApplicationResult = CreateOAuthClientApplication();
        factoryAction?.Invoke(oAuthClientApplicationResult);

        return oAuthClientApplicationResult;
    }

    private Humidifier.QuickSight.OAuthClientApplication CreateOAuthClientApplication()
    {
        var oAuthClientApplicationResult = new Humidifier.QuickSight.OAuthClientApplication
        {
            GivenName = InputResourceName,
        };

        return oAuthClientApplicationResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.OAuthClientApplication result)
    {
        base.CreateChildren(result);

        result.IdentityProviderVpcConnectionProperties ??= IdentityProviderVpcConnectionPropertiesFactory?.Build();
    }

} // End Of Class

public static class OAuthClientApplicationFactoryExtensions
{
    public static CombinedResult<OAuthClientApplicationFactory, InnerOAuthClientApplicationIdentityProviderVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties(this OAuthClientApplicationFactory parentFactory, Action<Humidifier.QuickSight.OAuthClientApplicationTypes.IdentityProviderVpcConnectionProperties> subFactoryAction = null)
    {
        parentFactory.IdentityProviderVpcConnectionPropertiesFactory = new InnerOAuthClientApplicationIdentityProviderVpcConnectionPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdentityProviderVpcConnectionPropertiesFactory);
    }

    public static CombinedResult<OAuthClientApplicationFactory, T1, InnerOAuthClientApplicationIdentityProviderVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1>(this CombinedResult<OAuthClientApplicationFactory, T1> combinedResult, Action<Humidifier.QuickSight.OAuthClientApplicationTypes.IdentityProviderVpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OAuthClientApplicationFactory, InnerOAuthClientApplicationIdentityProviderVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1>(this CombinedResult<T1, OAuthClientApplicationFactory> combinedResult, Action<Humidifier.QuickSight.OAuthClientApplicationTypes.IdentityProviderVpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<OAuthClientApplicationFactory, T1, T2, InnerOAuthClientApplicationIdentityProviderVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1, T2>(this CombinedResult<OAuthClientApplicationFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.OAuthClientApplicationTypes.IdentityProviderVpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OAuthClientApplicationFactory, T2, InnerOAuthClientApplicationIdentityProviderVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1, T2>(this CombinedResult<T1, OAuthClientApplicationFactory, T2> combinedResult, Action<Humidifier.QuickSight.OAuthClientApplicationTypes.IdentityProviderVpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OAuthClientApplicationFactory, InnerOAuthClientApplicationIdentityProviderVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1, T2>(this CombinedResult<T1, T2, OAuthClientApplicationFactory> combinedResult, Action<Humidifier.QuickSight.OAuthClientApplicationTypes.IdentityProviderVpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<OAuthClientApplicationFactory, T1, T2, T3, InnerOAuthClientApplicationIdentityProviderVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1, T2, T3>(this CombinedResult<OAuthClientApplicationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.OAuthClientApplicationTypes.IdentityProviderVpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OAuthClientApplicationFactory, T2, T3, InnerOAuthClientApplicationIdentityProviderVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1, T2, T3>(this CombinedResult<T1, OAuthClientApplicationFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.OAuthClientApplicationTypes.IdentityProviderVpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OAuthClientApplicationFactory, T3, InnerOAuthClientApplicationIdentityProviderVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1, T2, T3>(this CombinedResult<T1, T2, OAuthClientApplicationFactory, T3> combinedResult, Action<Humidifier.QuickSight.OAuthClientApplicationTypes.IdentityProviderVpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, OAuthClientApplicationFactory, InnerOAuthClientApplicationIdentityProviderVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, OAuthClientApplicationFactory> combinedResult, Action<Humidifier.QuickSight.OAuthClientApplicationTypes.IdentityProviderVpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<OAuthClientApplicationFactory, T1, T2, T3, T4, InnerOAuthClientApplicationIdentityProviderVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1, T2, T3, T4>(this CombinedResult<OAuthClientApplicationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.OAuthClientApplicationTypes.IdentityProviderVpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OAuthClientApplicationFactory, T2, T3, T4, InnerOAuthClientApplicationIdentityProviderVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1, T2, T3, T4>(this CombinedResult<T1, OAuthClientApplicationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.OAuthClientApplicationTypes.IdentityProviderVpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OAuthClientApplicationFactory, T3, T4, InnerOAuthClientApplicationIdentityProviderVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, OAuthClientApplicationFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.OAuthClientApplicationTypes.IdentityProviderVpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, OAuthClientApplicationFactory, T4, InnerOAuthClientApplicationIdentityProviderVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, OAuthClientApplicationFactory, T4> combinedResult, Action<Humidifier.QuickSight.OAuthClientApplicationTypes.IdentityProviderVpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, OAuthClientApplicationFactory, InnerOAuthClientApplicationIdentityProviderVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, OAuthClientApplicationFactory> combinedResult, Action<Humidifier.QuickSight.OAuthClientApplicationTypes.IdentityProviderVpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T5, subFactoryAction).T2);
}
