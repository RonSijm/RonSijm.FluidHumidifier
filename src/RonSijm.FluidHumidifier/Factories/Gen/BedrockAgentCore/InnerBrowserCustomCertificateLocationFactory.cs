// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerBrowserCustomCertificateLocationFactory(Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.CertificateLocation> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.BrowserCustomTypes.CertificateLocation>
{

    protected override Humidifier.BedrockAgentCore.BrowserCustomTypes.CertificateLocation Create()
    {
        var certificateLocationResult = CreateCertificateLocation();
        factoryAction?.Invoke(certificateLocationResult);

        return certificateLocationResult;
    }

    private Humidifier.BedrockAgentCore.BrowserCustomTypes.CertificateLocation CreateCertificateLocation()
    {
        var certificateLocationResult = new Humidifier.BedrockAgentCore.BrowserCustomTypes.CertificateLocation();

        return certificateLocationResult;
    }

} // End Of Class

public static class InnerBrowserCustomCertificateLocationFactoryExtensions
{
}
