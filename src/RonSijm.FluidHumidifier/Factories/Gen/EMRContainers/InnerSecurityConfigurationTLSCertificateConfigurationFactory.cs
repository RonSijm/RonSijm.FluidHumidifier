// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerSecurityConfigurationTLSCertificateConfigurationFactory(Action<Humidifier.EMRContainers.SecurityConfigurationTypes.TLSCertificateConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.SecurityConfigurationTypes.TLSCertificateConfiguration>
{

    protected override Humidifier.EMRContainers.SecurityConfigurationTypes.TLSCertificateConfiguration Create()
    {
        var tLSCertificateConfigurationResult = CreateTLSCertificateConfiguration();
        factoryAction?.Invoke(tLSCertificateConfigurationResult);

        return tLSCertificateConfigurationResult;
    }

    private Humidifier.EMRContainers.SecurityConfigurationTypes.TLSCertificateConfiguration CreateTLSCertificateConfiguration()
    {
        var tLSCertificateConfigurationResult = new Humidifier.EMRContainers.SecurityConfigurationTypes.TLSCertificateConfiguration();

        return tLSCertificateConfigurationResult;
    }

} // End Of Class

public static class InnerSecurityConfigurationTLSCertificateConfigurationFactoryExtensions
{
}
