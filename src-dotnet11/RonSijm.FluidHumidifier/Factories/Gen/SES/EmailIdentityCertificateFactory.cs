// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class EmailIdentityCertificateFactory(string resourceName = null, Action<Humidifier.SES.EmailIdentityCertificate> factoryAction = null) : ResourceFactory<Humidifier.SES.EmailIdentityCertificate>(resourceName)
{

    protected override Humidifier.SES.EmailIdentityCertificate Create()
    {
        var emailIdentityCertificateResult = CreateEmailIdentityCertificate();
        factoryAction?.Invoke(emailIdentityCertificateResult);

        return emailIdentityCertificateResult;
    }

    private Humidifier.SES.EmailIdentityCertificate CreateEmailIdentityCertificate()
    {
        var emailIdentityCertificateResult = new Humidifier.SES.EmailIdentityCertificate
        {
            GivenName = InputResourceName,
        };

        return emailIdentityCertificateResult;
    }

} // End Of Class

public static class EmailIdentityCertificateFactoryExtensions
{
}
