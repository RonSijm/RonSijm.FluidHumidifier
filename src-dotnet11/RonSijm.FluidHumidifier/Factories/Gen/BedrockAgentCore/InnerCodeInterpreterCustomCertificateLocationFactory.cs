// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerCodeInterpreterCustomCertificateLocationFactory(Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CertificateLocation> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CertificateLocation>
{

    protected override Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CertificateLocation Create()
    {
        var certificateLocationResult = CreateCertificateLocation();
        factoryAction?.Invoke(certificateLocationResult);

        return certificateLocationResult;
    }

    private Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CertificateLocation CreateCertificateLocation()
    {
        var certificateLocationResult = new Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CertificateLocation();

        return certificateLocationResult;
    }

} // End Of Class

public static class InnerCodeInterpreterCustomCertificateLocationFactoryExtensions
{
}
