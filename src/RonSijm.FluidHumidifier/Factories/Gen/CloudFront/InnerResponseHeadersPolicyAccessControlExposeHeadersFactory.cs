// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerResponseHeadersPolicyAccessControlExposeHeadersFactory(Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlExposeHeaders> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlExposeHeaders>
{

    protected override Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlExposeHeaders Create()
    {
        var accessControlExposeHeadersResult = CreateAccessControlExposeHeaders();
        factoryAction?.Invoke(accessControlExposeHeadersResult);

        return accessControlExposeHeadersResult;
    }

    private Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlExposeHeaders CreateAccessControlExposeHeaders()
    {
        var accessControlExposeHeadersResult = new Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlExposeHeaders();

        return accessControlExposeHeadersResult;
    }

} // End Of Class

public static class InnerResponseHeadersPolicyAccessControlExposeHeadersFactoryExtensions
{
}
