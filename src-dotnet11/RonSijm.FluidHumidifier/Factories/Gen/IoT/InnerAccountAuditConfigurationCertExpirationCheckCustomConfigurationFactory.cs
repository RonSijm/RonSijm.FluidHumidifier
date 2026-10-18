// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerAccountAuditConfigurationCertExpirationCheckCustomConfigurationFactory(Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertExpirationCheckCustomConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoT.AccountAuditConfigurationTypes.CertExpirationCheckCustomConfiguration>
{

    protected override Humidifier.IoT.AccountAuditConfigurationTypes.CertExpirationCheckCustomConfiguration Create()
    {
        var certExpirationCheckCustomConfigurationResult = CreateCertExpirationCheckCustomConfiguration();
        factoryAction?.Invoke(certExpirationCheckCustomConfigurationResult);

        return certExpirationCheckCustomConfigurationResult;
    }

    private Humidifier.IoT.AccountAuditConfigurationTypes.CertExpirationCheckCustomConfiguration CreateCertExpirationCheckCustomConfiguration()
    {
        var certExpirationCheckCustomConfigurationResult = new Humidifier.IoT.AccountAuditConfigurationTypes.CertExpirationCheckCustomConfiguration();

        return certExpirationCheckCustomConfigurationResult;
    }

} // End Of Class

public static class InnerAccountAuditConfigurationCertExpirationCheckCustomConfigurationFactoryExtensions
{
}
