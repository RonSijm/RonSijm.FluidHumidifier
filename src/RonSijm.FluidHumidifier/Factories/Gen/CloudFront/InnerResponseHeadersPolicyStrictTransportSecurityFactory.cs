// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerResponseHeadersPolicyStrictTransportSecurityFactory(Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.StrictTransportSecurity> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.ResponseHeadersPolicyTypes.StrictTransportSecurity>
{

    protected override Humidifier.CloudFront.ResponseHeadersPolicyTypes.StrictTransportSecurity Create()
    {
        var strictTransportSecurityResult = CreateStrictTransportSecurity();
        factoryAction?.Invoke(strictTransportSecurityResult);

        return strictTransportSecurityResult;
    }

    private Humidifier.CloudFront.ResponseHeadersPolicyTypes.StrictTransportSecurity CreateStrictTransportSecurity()
    {
        var strictTransportSecurityResult = new Humidifier.CloudFront.ResponseHeadersPolicyTypes.StrictTransportSecurity();

        return strictTransportSecurityResult;
    }

} // End Of Class

public static class InnerResponseHeadersPolicyStrictTransportSecurityFactoryExtensions
{
}
