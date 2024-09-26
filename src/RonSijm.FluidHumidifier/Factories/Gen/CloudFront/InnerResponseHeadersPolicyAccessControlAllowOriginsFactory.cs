// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerResponseHeadersPolicyAccessControlAllowOriginsFactory(Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlAllowOrigins> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlAllowOrigins>
{

    protected override Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlAllowOrigins Create()
    {
        var accessControlAllowOriginsResult = CreateAccessControlAllowOrigins();
        factoryAction?.Invoke(accessControlAllowOriginsResult);

        return accessControlAllowOriginsResult;
    }

    private Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlAllowOrigins CreateAccessControlAllowOrigins()
    {
        var accessControlAllowOriginsResult = new Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlAllowOrigins();

        return accessControlAllowOriginsResult;
    }

} // End Of Class

public static class InnerResponseHeadersPolicyAccessControlAllowOriginsFactoryExtensions
{
}
