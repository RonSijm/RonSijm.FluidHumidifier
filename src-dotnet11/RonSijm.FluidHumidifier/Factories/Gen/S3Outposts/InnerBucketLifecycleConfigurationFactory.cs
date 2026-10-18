// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Outposts;

public class InnerBucketLifecycleConfigurationFactory(Action<Humidifier.S3Outposts.BucketTypes.LifecycleConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3Outposts.BucketTypes.LifecycleConfiguration>
{

    protected override Humidifier.S3Outposts.BucketTypes.LifecycleConfiguration Create()
    {
        var lifecycleConfigurationResult = CreateLifecycleConfiguration();
        factoryAction?.Invoke(lifecycleConfigurationResult);

        return lifecycleConfigurationResult;
    }

    private Humidifier.S3Outposts.BucketTypes.LifecycleConfiguration CreateLifecycleConfiguration()
    {
        var lifecycleConfigurationResult = new Humidifier.S3Outposts.BucketTypes.LifecycleConfiguration();

        return lifecycleConfigurationResult;
    }

} // End Of Class

public static class InnerBucketLifecycleConfigurationFactoryExtensions
{
}
