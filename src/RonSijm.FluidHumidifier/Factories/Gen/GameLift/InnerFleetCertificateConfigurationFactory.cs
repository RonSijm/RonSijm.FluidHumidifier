// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerFleetCertificateConfigurationFactory(Action<Humidifier.GameLift.FleetTypes.CertificateConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.FleetTypes.CertificateConfiguration>
{

    protected override Humidifier.GameLift.FleetTypes.CertificateConfiguration Create()
    {
        var certificateConfigurationResult = CreateCertificateConfiguration();
        factoryAction?.Invoke(certificateConfigurationResult);

        return certificateConfigurationResult;
    }

    private Humidifier.GameLift.FleetTypes.CertificateConfiguration CreateCertificateConfiguration()
    {
        var certificateConfigurationResult = new Humidifier.GameLift.FleetTypes.CertificateConfiguration();

        return certificateConfigurationResult;
    }

} // End Of Class

public static class InnerFleetCertificateConfigurationFactoryExtensions
{
}
