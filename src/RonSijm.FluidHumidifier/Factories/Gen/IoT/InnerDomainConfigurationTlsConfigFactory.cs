// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerDomainConfigurationTlsConfigFactory(Action<Humidifier.IoT.DomainConfigurationTypes.TlsConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoT.DomainConfigurationTypes.TlsConfig>
{

    protected override Humidifier.IoT.DomainConfigurationTypes.TlsConfig Create()
    {
        var tlsConfigResult = CreateTlsConfig();
        factoryAction?.Invoke(tlsConfigResult);

        return tlsConfigResult;
    }

    private Humidifier.IoT.DomainConfigurationTypes.TlsConfig CreateTlsConfig()
    {
        var tlsConfigResult = new Humidifier.IoT.DomainConfigurationTypes.TlsConfig();

        return tlsConfigResult;
    }

} // End Of Class

public static class InnerDomainConfigurationTlsConfigFactoryExtensions
{
}
