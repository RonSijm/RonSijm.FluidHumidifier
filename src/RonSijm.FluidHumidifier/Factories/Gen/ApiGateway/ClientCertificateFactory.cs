// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class ClientCertificateFactory(string resourceName = null, Action<Humidifier.ApiGateway.ClientCertificate> factoryAction = null) : ResourceFactory<Humidifier.ApiGateway.ClientCertificate>(resourceName)
{

    protected override Humidifier.ApiGateway.ClientCertificate Create()
    {
        var clientCertificateResult = CreateClientCertificate();
        factoryAction?.Invoke(clientCertificateResult);

        return clientCertificateResult;
    }

    private Humidifier.ApiGateway.ClientCertificate CreateClientCertificate()
    {
        var clientCertificateResult = new Humidifier.ApiGateway.ClientCertificate
        {
            GivenName = InputResourceName,
        };

        return clientCertificateResult;
    }

} // End Of Class

public static class ClientCertificateFactoryExtensions
{
}
