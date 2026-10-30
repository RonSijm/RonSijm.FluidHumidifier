// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerOTAUpdateCodeSigningSignatureFactory(Action<Humidifier.IoT.OTAUpdateTypes.CodeSigningSignature> factoryAction = null) : SubResourceFactory<Humidifier.IoT.OTAUpdateTypes.CodeSigningSignature>
{

    protected override Humidifier.IoT.OTAUpdateTypes.CodeSigningSignature Create()
    {
        var codeSigningSignatureResult = CreateCodeSigningSignature();
        factoryAction?.Invoke(codeSigningSignatureResult);

        return codeSigningSignatureResult;
    }

    private Humidifier.IoT.OTAUpdateTypes.CodeSigningSignature CreateCodeSigningSignature()
    {
        var codeSigningSignatureResult = new Humidifier.IoT.OTAUpdateTypes.CodeSigningSignature();

        return codeSigningSignatureResult;
    }

} // End Of Class

public static class InnerOTAUpdateCodeSigningSignatureFactoryExtensions
{
}
