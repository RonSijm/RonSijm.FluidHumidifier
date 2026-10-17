// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerVerifiedAccessTrustProviderNativeApplicationOidcOptionsFactory(Action<Humidifier.EC2.VerifiedAccessTrustProviderTypes.NativeApplicationOidcOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.VerifiedAccessTrustProviderTypes.NativeApplicationOidcOptions>
{

    protected override Humidifier.EC2.VerifiedAccessTrustProviderTypes.NativeApplicationOidcOptions Create()
    {
        var nativeApplicationOidcOptionsResult = CreateNativeApplicationOidcOptions();
        factoryAction?.Invoke(nativeApplicationOidcOptionsResult);

        return nativeApplicationOidcOptionsResult;
    }

    private Humidifier.EC2.VerifiedAccessTrustProviderTypes.NativeApplicationOidcOptions CreateNativeApplicationOidcOptions()
    {
        var nativeApplicationOidcOptionsResult = new Humidifier.EC2.VerifiedAccessTrustProviderTypes.NativeApplicationOidcOptions();

        return nativeApplicationOidcOptionsResult;
    }

} // End Of Class

public static class InnerVerifiedAccessTrustProviderNativeApplicationOidcOptionsFactoryExtensions
{
}
