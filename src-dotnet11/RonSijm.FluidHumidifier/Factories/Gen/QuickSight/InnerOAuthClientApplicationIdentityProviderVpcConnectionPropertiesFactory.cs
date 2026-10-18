// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerOAuthClientApplicationIdentityProviderVpcConnectionPropertiesFactory(Action<Humidifier.QuickSight.OAuthClientApplicationTypes.IdentityProviderVpcConnectionProperties> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.OAuthClientApplicationTypes.IdentityProviderVpcConnectionProperties>
{

    protected override Humidifier.QuickSight.OAuthClientApplicationTypes.IdentityProviderVpcConnectionProperties Create()
    {
        var identityProviderVpcConnectionPropertiesResult = CreateIdentityProviderVpcConnectionProperties();
        factoryAction?.Invoke(identityProviderVpcConnectionPropertiesResult);

        return identityProviderVpcConnectionPropertiesResult;
    }

    private Humidifier.QuickSight.OAuthClientApplicationTypes.IdentityProviderVpcConnectionProperties CreateIdentityProviderVpcConnectionProperties()
    {
        var identityProviderVpcConnectionPropertiesResult = new Humidifier.QuickSight.OAuthClientApplicationTypes.IdentityProviderVpcConnectionProperties();

        return identityProviderVpcConnectionPropertiesResult;
    }

} // End Of Class

public static class InnerOAuthClientApplicationIdentityProviderVpcConnectionPropertiesFactoryExtensions
{
}
