// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IAM;

public class ServerCertificateFactory(string resourceName = null, Action<Humidifier.IAM.ServerCertificate> factoryAction = null) : ResourceFactory<Humidifier.IAM.ServerCertificate>(resourceName)
{

    protected override Humidifier.IAM.ServerCertificate Create()
    {
        var serverCertificateResult = CreateServerCertificate();
        factoryAction?.Invoke(serverCertificateResult);

        return serverCertificateResult;
    }

    private Humidifier.IAM.ServerCertificate CreateServerCertificate()
    {
        var serverCertificateResult = new Humidifier.IAM.ServerCertificate
        {
            GivenName = InputResourceName,
        };

        return serverCertificateResult;
    }

} // End Of Class

public static class ServerCertificateFactoryExtensions
{
}
