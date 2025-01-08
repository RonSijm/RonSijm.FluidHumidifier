// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Express;

public class InnerDirectoryBucketLifecycleConfigurationFactory(Action<Humidifier.S3Express.DirectoryBucketTypes.LifecycleConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3Express.DirectoryBucketTypes.LifecycleConfiguration>
{

    protected override Humidifier.S3Express.DirectoryBucketTypes.LifecycleConfiguration Create()
    {
        var lifecycleConfigurationResult = CreateLifecycleConfiguration();
        factoryAction?.Invoke(lifecycleConfigurationResult);

        return lifecycleConfigurationResult;
    }

    private Humidifier.S3Express.DirectoryBucketTypes.LifecycleConfiguration CreateLifecycleConfiguration()
    {
        var lifecycleConfigurationResult = new Humidifier.S3Express.DirectoryBucketTypes.LifecycleConfiguration();

        return lifecycleConfigurationResult;
    }

} // End Of Class

public static class InnerDirectoryBucketLifecycleConfigurationFactoryExtensions
{
}
