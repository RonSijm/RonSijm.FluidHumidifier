// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerVerifiedAccessTrustProviderOidcOptionsFactory(Action<Humidifier.EC2.VerifiedAccessTrustProviderTypes.OidcOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.VerifiedAccessTrustProviderTypes.OidcOptions>
{

    protected override Humidifier.EC2.VerifiedAccessTrustProviderTypes.OidcOptions Create()
    {
        var oidcOptionsResult = CreateOidcOptions();
        factoryAction?.Invoke(oidcOptionsResult);

        return oidcOptionsResult;
    }

    private Humidifier.EC2.VerifiedAccessTrustProviderTypes.OidcOptions CreateOidcOptions()
    {
        var oidcOptionsResult = new Humidifier.EC2.VerifiedAccessTrustProviderTypes.OidcOptions();

        return oidcOptionsResult;
    }

} // End Of Class

public static class InnerVerifiedAccessTrustProviderOidcOptionsFactoryExtensions
{
}
