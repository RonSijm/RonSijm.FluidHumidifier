// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerResponseHeadersPolicyContentSecurityPolicyFactory(Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ContentSecurityPolicy> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ContentSecurityPolicy>
{

    protected override Humidifier.CloudFront.ResponseHeadersPolicyTypes.ContentSecurityPolicy Create()
    {
        var contentSecurityPolicyResult = CreateContentSecurityPolicy();
        factoryAction?.Invoke(contentSecurityPolicyResult);

        return contentSecurityPolicyResult;
    }

    private Humidifier.CloudFront.ResponseHeadersPolicyTypes.ContentSecurityPolicy CreateContentSecurityPolicy()
    {
        var contentSecurityPolicyResult = new Humidifier.CloudFront.ResponseHeadersPolicyTypes.ContentSecurityPolicy();

        return contentSecurityPolicyResult;
    }

} // End Of Class

public static class InnerResponseHeadersPolicyContentSecurityPolicyFactoryExtensions
{
}
