// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Signer;

public class InnerSigningProfileSignatureValidityPeriodFactory(Action<Humidifier.Signer.SigningProfileTypes.SignatureValidityPeriod> factoryAction = null) : SubResourceFactory<Humidifier.Signer.SigningProfileTypes.SignatureValidityPeriod>
{

    protected override Humidifier.Signer.SigningProfileTypes.SignatureValidityPeriod Create()
    {
        var signatureValidityPeriodResult = CreateSignatureValidityPeriod();
        factoryAction?.Invoke(signatureValidityPeriodResult);

        return signatureValidityPeriodResult;
    }

    private Humidifier.Signer.SigningProfileTypes.SignatureValidityPeriod CreateSignatureValidityPeriod()
    {
        var signatureValidityPeriodResult = new Humidifier.Signer.SigningProfileTypes.SignatureValidityPeriod();

        return signatureValidityPeriodResult;
    }

} // End Of Class

public static class InnerSigningProfileSignatureValidityPeriodFactoryExtensions
{
}
