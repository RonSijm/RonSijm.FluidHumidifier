// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class CertificateFactory(string resourceName = null, Action<Humidifier.Transfer.Certificate> factoryAction = null) : ResourceFactory<Humidifier.Transfer.Certificate>(resourceName)
{

    protected override Humidifier.Transfer.Certificate Create()
    {
        var certificateResult = CreateCertificate();
        factoryAction?.Invoke(certificateResult);

        return certificateResult;
    }

    private Humidifier.Transfer.Certificate CreateCertificate()
    {
        var certificateResult = new Humidifier.Transfer.Certificate
        {
            GivenName = InputResourceName,
        };

        return certificateResult;
    }

} // End Of Class

public static class CertificateFactoryExtensions
{
}
