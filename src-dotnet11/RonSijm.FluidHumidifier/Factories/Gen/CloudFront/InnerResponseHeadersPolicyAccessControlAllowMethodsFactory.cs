// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerResponseHeadersPolicyAccessControlAllowMethodsFactory(Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlAllowMethods> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlAllowMethods>
{

    protected override Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlAllowMethods Create()
    {
        var accessControlAllowMethodsResult = CreateAccessControlAllowMethods();
        factoryAction?.Invoke(accessControlAllowMethodsResult);

        return accessControlAllowMethodsResult;
    }

    private Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlAllowMethods CreateAccessControlAllowMethods()
    {
        var accessControlAllowMethodsResult = new Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlAllowMethods();

        return accessControlAllowMethodsResult;
    }

} // End Of Class

public static class InnerResponseHeadersPolicyAccessControlAllowMethodsFactoryExtensions
{
}
