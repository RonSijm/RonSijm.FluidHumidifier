// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketDefaultRetentionFactory(Action<Humidifier.S3.BucketTypes.DefaultRetention> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.DefaultRetention>
{

    protected override Humidifier.S3.BucketTypes.DefaultRetention Create()
    {
        var defaultRetentionResult = CreateDefaultRetention();
        factoryAction?.Invoke(defaultRetentionResult);

        return defaultRetentionResult;
    }

    private Humidifier.S3.BucketTypes.DefaultRetention CreateDefaultRetention()
    {
        var defaultRetentionResult = new Humidifier.S3.BucketTypes.DefaultRetention();

        return defaultRetentionResult;
    }

} // End Of Class

public static class InnerBucketDefaultRetentionFactoryExtensions
{
}
