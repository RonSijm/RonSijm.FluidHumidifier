// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerTLSInspectionConfigurationCheckCertificateRevocationStatusFactory(Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.CheckCertificateRevocationStatus> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.CheckCertificateRevocationStatus>
{

    protected override Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.CheckCertificateRevocationStatus Create()
    {
        var checkCertificateRevocationStatusResult = CreateCheckCertificateRevocationStatus();
        factoryAction?.Invoke(checkCertificateRevocationStatusResult);

        return checkCertificateRevocationStatusResult;
    }

    private Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.CheckCertificateRevocationStatus CreateCheckCertificateRevocationStatus()
    {
        var checkCertificateRevocationStatusResult = new Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.CheckCertificateRevocationStatus();

        return checkCertificateRevocationStatusResult;
    }

} // End Of Class

public static class InnerTLSInspectionConfigurationCheckCertificateRevocationStatusFactoryExtensions
{
}
