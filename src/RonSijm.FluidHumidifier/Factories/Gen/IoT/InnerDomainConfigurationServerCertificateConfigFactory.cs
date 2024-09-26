// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerDomainConfigurationServerCertificateConfigFactory(Action<Humidifier.IoT.DomainConfigurationTypes.ServerCertificateConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoT.DomainConfigurationTypes.ServerCertificateConfig>
{

    protected override Humidifier.IoT.DomainConfigurationTypes.ServerCertificateConfig Create()
    {
        var serverCertificateConfigResult = CreateServerCertificateConfig();
        factoryAction?.Invoke(serverCertificateConfigResult);

        return serverCertificateConfigResult;
    }

    private Humidifier.IoT.DomainConfigurationTypes.ServerCertificateConfig CreateServerCertificateConfig()
    {
        var serverCertificateConfigResult = new Humidifier.IoT.DomainConfigurationTypes.ServerCertificateConfig();

        return serverCertificateConfigResult;
    }

} // End Of Class

public static class InnerDomainConfigurationServerCertificateConfigFactoryExtensions
{
}
