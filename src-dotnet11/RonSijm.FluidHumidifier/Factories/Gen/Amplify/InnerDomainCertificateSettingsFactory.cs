// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Amplify;

public class InnerDomainCertificateSettingsFactory(Action<Humidifier.Amplify.DomainTypes.CertificateSettings> factoryAction = null) : SubResourceFactory<Humidifier.Amplify.DomainTypes.CertificateSettings>
{

    protected override Humidifier.Amplify.DomainTypes.CertificateSettings Create()
    {
        var certificateSettingsResult = CreateCertificateSettings();
        factoryAction?.Invoke(certificateSettingsResult);

        return certificateSettingsResult;
    }

    private Humidifier.Amplify.DomainTypes.CertificateSettings CreateCertificateSettings()
    {
        var certificateSettingsResult = new Humidifier.Amplify.DomainTypes.CertificateSettings();

        return certificateSettingsResult;
    }

} // End Of Class

public static class InnerDomainCertificateSettingsFactoryExtensions
{
}
