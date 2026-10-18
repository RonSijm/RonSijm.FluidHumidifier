// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerResponseHeadersPolicyReferrerPolicyFactory(Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ReferrerPolicy> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ReferrerPolicy>
{

    protected override Humidifier.CloudFront.ResponseHeadersPolicyTypes.ReferrerPolicy Create()
    {
        var referrerPolicyResult = CreateReferrerPolicy();
        factoryAction?.Invoke(referrerPolicyResult);

        return referrerPolicyResult;
    }

    private Humidifier.CloudFront.ResponseHeadersPolicyTypes.ReferrerPolicy CreateReferrerPolicy()
    {
        var referrerPolicyResult = new Humidifier.CloudFront.ResponseHeadersPolicyTypes.ReferrerPolicy();

        return referrerPolicyResult;
    }

} // End Of Class

public static class InnerResponseHeadersPolicyReferrerPolicyFactoryExtensions
{
}
