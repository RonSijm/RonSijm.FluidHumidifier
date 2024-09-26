// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class IdentityProviderConfigFactory(string resourceName = null, Action<Humidifier.EKS.IdentityProviderConfig> factoryAction = null) : ResourceFactory<Humidifier.EKS.IdentityProviderConfig>(resourceName)
{

    internal InnerIdentityProviderConfigOidcIdentityProviderConfigFactory OidcFactory { get; set; }

    protected override Humidifier.EKS.IdentityProviderConfig Create()
    {
        var identityProviderConfigResult = CreateIdentityProviderConfig();
        factoryAction?.Invoke(identityProviderConfigResult);

        return identityProviderConfigResult;
    }

    private Humidifier.EKS.IdentityProviderConfig CreateIdentityProviderConfig()
    {
        var identityProviderConfigResult = new Humidifier.EKS.IdentityProviderConfig
        {
            GivenName = InputResourceName,
        };

        return identityProviderConfigResult;
    }
    public override void CreateChildren(Humidifier.EKS.IdentityProviderConfig result)
    {
        base.CreateChildren(result);

        result.Oidc ??= OidcFactory?.Build();
    }

} // End Of Class

public static class IdentityProviderConfigFactoryExtensions
{
    public static CombinedResult<IdentityProviderConfigFactory, InnerIdentityProviderConfigOidcIdentityProviderConfigFactory> WithOidc(this IdentityProviderConfigFactory parentFactory, Action<Humidifier.EKS.IdentityProviderConfigTypes.OidcIdentityProviderConfig> subFactoryAction = null)
    {
        parentFactory.OidcFactory = new InnerIdentityProviderConfigOidcIdentityProviderConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OidcFactory);
    }

    public static CombinedResult<IdentityProviderConfigFactory, T1, InnerIdentityProviderConfigOidcIdentityProviderConfigFactory> WithOidc<T1>(this CombinedResult<IdentityProviderConfigFactory, T1> combinedResult, Action<Humidifier.EKS.IdentityProviderConfigTypes.OidcIdentityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOidc(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentityProviderConfigFactory, InnerIdentityProviderConfigOidcIdentityProviderConfigFactory> WithOidc<T1>(this CombinedResult<T1, IdentityProviderConfigFactory> combinedResult, Action<Humidifier.EKS.IdentityProviderConfigTypes.OidcIdentityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOidc(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IdentityProviderConfigFactory, T1, T2, InnerIdentityProviderConfigOidcIdentityProviderConfigFactory> WithOidc<T1, T2>(this CombinedResult<IdentityProviderConfigFactory, T1, T2> combinedResult, Action<Humidifier.EKS.IdentityProviderConfigTypes.OidcIdentityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOidc(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentityProviderConfigFactory, T2, InnerIdentityProviderConfigOidcIdentityProviderConfigFactory> WithOidc<T1, T2>(this CombinedResult<T1, IdentityProviderConfigFactory, T2> combinedResult, Action<Humidifier.EKS.IdentityProviderConfigTypes.OidcIdentityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOidc(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdentityProviderConfigFactory, InnerIdentityProviderConfigOidcIdentityProviderConfigFactory> WithOidc<T1, T2>(this CombinedResult<T1, T2, IdentityProviderConfigFactory> combinedResult, Action<Humidifier.EKS.IdentityProviderConfigTypes.OidcIdentityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOidc(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IdentityProviderConfigFactory, T1, T2, T3, InnerIdentityProviderConfigOidcIdentityProviderConfigFactory> WithOidc<T1, T2, T3>(this CombinedResult<IdentityProviderConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.EKS.IdentityProviderConfigTypes.OidcIdentityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOidc(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentityProviderConfigFactory, T2, T3, InnerIdentityProviderConfigOidcIdentityProviderConfigFactory> WithOidc<T1, T2, T3>(this CombinedResult<T1, IdentityProviderConfigFactory, T2, T3> combinedResult, Action<Humidifier.EKS.IdentityProviderConfigTypes.OidcIdentityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOidc(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdentityProviderConfigFactory, T3, InnerIdentityProviderConfigOidcIdentityProviderConfigFactory> WithOidc<T1, T2, T3>(this CombinedResult<T1, T2, IdentityProviderConfigFactory, T3> combinedResult, Action<Humidifier.EKS.IdentityProviderConfigTypes.OidcIdentityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOidc(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdentityProviderConfigFactory, InnerIdentityProviderConfigOidcIdentityProviderConfigFactory> WithOidc<T1, T2, T3>(this CombinedResult<T1, T2, T3, IdentityProviderConfigFactory> combinedResult, Action<Humidifier.EKS.IdentityProviderConfigTypes.OidcIdentityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOidc(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IdentityProviderConfigFactory, T1, T2, T3, T4, InnerIdentityProviderConfigOidcIdentityProviderConfigFactory> WithOidc<T1, T2, T3, T4>(this CombinedResult<IdentityProviderConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EKS.IdentityProviderConfigTypes.OidcIdentityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOidc(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentityProviderConfigFactory, T2, T3, T4, InnerIdentityProviderConfigOidcIdentityProviderConfigFactory> WithOidc<T1, T2, T3, T4>(this CombinedResult<T1, IdentityProviderConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.EKS.IdentityProviderConfigTypes.OidcIdentityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOidc(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdentityProviderConfigFactory, T3, T4, InnerIdentityProviderConfigOidcIdentityProviderConfigFactory> WithOidc<T1, T2, T3, T4>(this CombinedResult<T1, T2, IdentityProviderConfigFactory, T3, T4> combinedResult, Action<Humidifier.EKS.IdentityProviderConfigTypes.OidcIdentityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOidc(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdentityProviderConfigFactory, T4, InnerIdentityProviderConfigOidcIdentityProviderConfigFactory> WithOidc<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IdentityProviderConfigFactory, T4> combinedResult, Action<Humidifier.EKS.IdentityProviderConfigTypes.OidcIdentityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOidc(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IdentityProviderConfigFactory, InnerIdentityProviderConfigOidcIdentityProviderConfigFactory> WithOidc<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IdentityProviderConfigFactory> combinedResult, Action<Humidifier.EKS.IdentityProviderConfigTypes.OidcIdentityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOidc(combinedResult.T5, subFactoryAction));
}
