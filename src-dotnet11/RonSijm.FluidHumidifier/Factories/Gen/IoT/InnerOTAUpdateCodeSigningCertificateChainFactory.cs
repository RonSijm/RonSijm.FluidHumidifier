// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerOTAUpdateCodeSigningCertificateChainFactory(Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningCertificateChain> factoryAction = null) : SubResourceFactory<Humidifier.IoT.OTAUpdateTypes.CodeSigningCertificateChain>
{

    protected override Humidifier.IoT.OTAUpdateTypes.CodeSigningCertificateChain Create()
    {
        var codeSigningCertificateChainResult = CreateCodeSigningCertificateChain();
        factoryAction?.Invoke(codeSigningCertificateChainResult);

        return codeSigningCertificateChainResult;
    }

    private Humidifier.IoT.OTAUpdateTypes.CodeSigningCertificateChain CreateCodeSigningCertificateChain()
    {
        var codeSigningCertificateChainResult = new Humidifier.IoT.OTAUpdateTypes.CodeSigningCertificateChain();

        return codeSigningCertificateChainResult;
    }

} // End Of Class

public static class InnerOTAUpdateCodeSigningCertificateChainFactoryExtensions
{
}
