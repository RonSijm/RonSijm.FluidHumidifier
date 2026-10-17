// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SupportAuthZ;

public class InnerSupportPermitSigningKeyInfoFactory(Action<Humidifier.SupportAuthZ.SupportPermitTypes.SigningKeyInfo> factoryAction = null) : SubResourceFactory<Humidifier.SupportAuthZ.SupportPermitTypes.SigningKeyInfo>
{

    protected override Humidifier.SupportAuthZ.SupportPermitTypes.SigningKeyInfo Create()
    {
        var signingKeyInfoResult = CreateSigningKeyInfo();
        factoryAction?.Invoke(signingKeyInfoResult);

        return signingKeyInfoResult;
    }

    private Humidifier.SupportAuthZ.SupportPermitTypes.SigningKeyInfo CreateSigningKeyInfo()
    {
        var signingKeyInfoResult = new Humidifier.SupportAuthZ.SupportPermitTypes.SigningKeyInfo();

        return signingKeyInfoResult;
    }

} // End Of Class

public static class InnerSupportPermitSigningKeyInfoFactoryExtensions
{
}
