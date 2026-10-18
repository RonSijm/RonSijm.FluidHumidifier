// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketLifecycleConfigurationFactory(Action<Humidifier.S3.BucketTypes.LifecycleConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.LifecycleConfiguration>
{

    protected override Humidifier.S3.BucketTypes.LifecycleConfiguration Create()
    {
        var lifecycleConfigurationResult = CreateLifecycleConfiguration();
        factoryAction?.Invoke(lifecycleConfigurationResult);

        return lifecycleConfigurationResult;
    }

    private Humidifier.S3.BucketTypes.LifecycleConfiguration CreateLifecycleConfiguration()
    {
        var lifecycleConfigurationResult = new Humidifier.S3.BucketTypes.LifecycleConfiguration();

        return lifecycleConfigurationResult;
    }

} // End Of Class

public static class InnerBucketLifecycleConfigurationFactoryExtensions
{
}
