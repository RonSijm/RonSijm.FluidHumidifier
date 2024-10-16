// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerCACertificateRegistrationConfigFactory(Action<Humidifier.IoT.CACertificateTypes.RegistrationConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoT.CACertificateTypes.RegistrationConfig>
{

    protected override Humidifier.IoT.CACertificateTypes.RegistrationConfig Create()
    {
        var registrationConfigResult = CreateRegistrationConfig();
        factoryAction?.Invoke(registrationConfigResult);

        return registrationConfigResult;
    }

    private Humidifier.IoT.CACertificateTypes.RegistrationConfig CreateRegistrationConfig()
    {
        var registrationConfigResult = new Humidifier.IoT.CACertificateTypes.RegistrationConfig();

        return registrationConfigResult;
    }

} // End Of Class

public static class InnerCACertificateRegistrationConfigFactoryExtensions
{
}
