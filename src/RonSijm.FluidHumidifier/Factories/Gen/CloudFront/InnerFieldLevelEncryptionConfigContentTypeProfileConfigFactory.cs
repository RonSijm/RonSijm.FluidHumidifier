// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerFieldLevelEncryptionConfigContentTypeProfileConfigFactory(Action<Humidifier.CloudFront.FieldLevelEncryptionConfigTypes.ContentTypeProfileConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.FieldLevelEncryptionConfigTypes.ContentTypeProfileConfig>
{

    protected override Humidifier.CloudFront.FieldLevelEncryptionConfigTypes.ContentTypeProfileConfig Create()
    {
        var contentTypeProfileConfigResult = CreateContentTypeProfileConfig();
        factoryAction?.Invoke(contentTypeProfileConfigResult);

        return contentTypeProfileConfigResult;
    }

    private Humidifier.CloudFront.FieldLevelEncryptionConfigTypes.ContentTypeProfileConfig CreateContentTypeProfileConfig()
    {
        var contentTypeProfileConfigResult = new Humidifier.CloudFront.FieldLevelEncryptionConfigTypes.ContentTypeProfileConfig();

        return contentTypeProfileConfigResult;
    }

} // End Of Class

public static class InnerFieldLevelEncryptionConfigContentTypeProfileConfigFactoryExtensions
{
}
