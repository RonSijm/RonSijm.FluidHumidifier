// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerFieldLevelEncryptionProfileFieldLevelEncryptionProfileConfigFactory(Action<Humidifier.CloudFront.FieldLevelEncryptionProfileTypes.FieldLevelEncryptionProfileConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.FieldLevelEncryptionProfileTypes.FieldLevelEncryptionProfileConfig>
{

    protected override Humidifier.CloudFront.FieldLevelEncryptionProfileTypes.FieldLevelEncryptionProfileConfig Create()
    {
        var fieldLevelEncryptionProfileConfigResult = CreateFieldLevelEncryptionProfileConfig();
        factoryAction?.Invoke(fieldLevelEncryptionProfileConfigResult);

        return fieldLevelEncryptionProfileConfigResult;
    }

    private Humidifier.CloudFront.FieldLevelEncryptionProfileTypes.FieldLevelEncryptionProfileConfig CreateFieldLevelEncryptionProfileConfig()
    {
        var fieldLevelEncryptionProfileConfigResult = new Humidifier.CloudFront.FieldLevelEncryptionProfileTypes.FieldLevelEncryptionProfileConfig();

        return fieldLevelEncryptionProfileConfigResult;
    }

} // End Of Class

public static class InnerFieldLevelEncryptionProfileFieldLevelEncryptionProfileConfigFactoryExtensions
{
}
