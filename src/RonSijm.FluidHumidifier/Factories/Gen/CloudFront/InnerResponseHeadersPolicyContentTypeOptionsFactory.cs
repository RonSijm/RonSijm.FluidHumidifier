// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerResponseHeadersPolicyContentTypeOptionsFactory(Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ContentTypeOptions> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ContentTypeOptions>
{

    protected override Humidifier.CloudFront.ResponseHeadersPolicyTypes.ContentTypeOptions Create()
    {
        var contentTypeOptionsResult = CreateContentTypeOptions();
        factoryAction?.Invoke(contentTypeOptionsResult);

        return contentTypeOptionsResult;
    }

    private Humidifier.CloudFront.ResponseHeadersPolicyTypes.ContentTypeOptions CreateContentTypeOptions()
    {
        var contentTypeOptionsResult = new Humidifier.CloudFront.ResponseHeadersPolicyTypes.ContentTypeOptions();

        return contentTypeOptionsResult;
    }

} // End Of Class

public static class InnerResponseHeadersPolicyContentTypeOptionsFactoryExtensions
{
}
