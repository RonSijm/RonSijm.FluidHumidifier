// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerAccountAuditConfigurationCertAgeCheckCustomConfigurationFactory(Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertAgeCheckCustomConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoT.AccountAuditConfigurationTypes.CertAgeCheckCustomConfiguration>
{

    protected override Humidifier.IoT.AccountAuditConfigurationTypes.CertAgeCheckCustomConfiguration Create()
    {
        var certAgeCheckCustomConfigurationResult = CreateCertAgeCheckCustomConfiguration();
        factoryAction?.Invoke(certAgeCheckCustomConfigurationResult);

        return certAgeCheckCustomConfigurationResult;
    }

    private Humidifier.IoT.AccountAuditConfigurationTypes.CertAgeCheckCustomConfiguration CreateCertAgeCheckCustomConfiguration()
    {
        var certAgeCheckCustomConfigurationResult = new Humidifier.IoT.AccountAuditConfigurationTypes.CertAgeCheckCustomConfiguration();

        return certAgeCheckCustomConfigurationResult;
    }

} // End Of Class

public static class InnerAccountAuditConfigurationCertAgeCheckCustomConfigurationFactoryExtensions
{
}
