// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerDomainConfigurationClientCertificateConfigFactory(Action<Humidifier.IoT.DomainConfigurationTypes.ClientCertificateConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoT.DomainConfigurationTypes.ClientCertificateConfig>
{

    protected override Humidifier.IoT.DomainConfigurationTypes.ClientCertificateConfig Create()
    {
        var clientCertificateConfigResult = CreateClientCertificateConfig();
        factoryAction?.Invoke(clientCertificateConfigResult);

        return clientCertificateConfigResult;
    }

    private Humidifier.IoT.DomainConfigurationTypes.ClientCertificateConfig CreateClientCertificateConfig()
    {
        var clientCertificateConfigResult = new Humidifier.IoT.DomainConfigurationTypes.ClientCertificateConfig();

        return clientCertificateConfigResult;
    }

} // End Of Class

public static class InnerDomainConfigurationClientCertificateConfigFactoryExtensions
{
}
