// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CertificateManager;

public class InnerAcmeExternalAccountBindingExpirationFactory(Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.Expiration> factoryAction = null) : SubResourceFactory<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.Expiration>
{

    protected override Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.Expiration Create()
    {
        var expirationResult = CreateExpiration();
        factoryAction?.Invoke(expirationResult);

        return expirationResult;
    }

    private Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.Expiration CreateExpiration()
    {
        var expirationResult = new Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.Expiration();

        return expirationResult;
    }

} // End Of Class

public static class InnerAcmeExternalAccountBindingExpirationFactoryExtensions
{
}
