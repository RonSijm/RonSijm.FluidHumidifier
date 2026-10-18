// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketVersioningConfigurationFactory(Action<Humidifier.S3.BucketTypes.VersioningConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.VersioningConfiguration>
{

    protected override Humidifier.S3.BucketTypes.VersioningConfiguration Create()
    {
        var versioningConfigurationResult = CreateVersioningConfiguration();
        factoryAction?.Invoke(versioningConfigurationResult);

        return versioningConfigurationResult;
    }

    private Humidifier.S3.BucketTypes.VersioningConfiguration CreateVersioningConfiguration()
    {
        var versioningConfigurationResult = new Humidifier.S3.BucketTypes.VersioningConfiguration();

        return versioningConfigurationResult;
    }

} // End Of Class

public static class InnerBucketVersioningConfigurationFactoryExtensions
{
}
