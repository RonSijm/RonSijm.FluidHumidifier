// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerFieldLevelEncryptionConfigQueryArgProfileConfigFactory(Action<Humidifier.CloudFront.FieldLevelEncryptionConfigTypes.QueryArgProfileConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.FieldLevelEncryptionConfigTypes.QueryArgProfileConfig>
{

    protected override Humidifier.CloudFront.FieldLevelEncryptionConfigTypes.QueryArgProfileConfig Create()
    {
        var queryArgProfileConfigResult = CreateQueryArgProfileConfig();
        factoryAction?.Invoke(queryArgProfileConfigResult);

        return queryArgProfileConfigResult;
    }

    private Humidifier.CloudFront.FieldLevelEncryptionConfigTypes.QueryArgProfileConfig CreateQueryArgProfileConfig()
    {
        var queryArgProfileConfigResult = new Humidifier.CloudFront.FieldLevelEncryptionConfigTypes.QueryArgProfileConfig();

        return queryArgProfileConfigResult;
    }

} // End Of Class

public static class InnerFieldLevelEncryptionConfigQueryArgProfileConfigFactoryExtensions
{
}
