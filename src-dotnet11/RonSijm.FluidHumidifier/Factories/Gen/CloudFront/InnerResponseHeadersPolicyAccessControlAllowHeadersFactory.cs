// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerResponseHeadersPolicyAccessControlAllowHeadersFactory(Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlAllowHeaders> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlAllowHeaders>
{

    protected override Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlAllowHeaders Create()
    {
        var accessControlAllowHeadersResult = CreateAccessControlAllowHeaders();
        factoryAction?.Invoke(accessControlAllowHeadersResult);

        return accessControlAllowHeadersResult;
    }

    private Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlAllowHeaders CreateAccessControlAllowHeaders()
    {
        var accessControlAllowHeadersResult = new Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlAllowHeaders();

        return accessControlAllowHeadersResult;
    }

} // End Of Class

public static class InnerResponseHeadersPolicyAccessControlAllowHeadersFactoryExtensions
{
}
