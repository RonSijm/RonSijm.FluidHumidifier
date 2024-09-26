// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class BucketPolicyFactory(string resourceName = null, Action<Humidifier.S3.BucketPolicy> factoryAction = null) : ResourceFactory<Humidifier.S3.BucketPolicy>(resourceName)
{

    protected override Humidifier.S3.BucketPolicy Create()
    {
        var bucketPolicyResult = CreateBucketPolicy();
        factoryAction?.Invoke(bucketPolicyResult);

        return bucketPolicyResult;
    }

    private Humidifier.S3.BucketPolicy CreateBucketPolicy()
    {
        var bucketPolicyResult = new Humidifier.S3.BucketPolicy
        {
            GivenName = InputResourceName,
        };

        return bucketPolicyResult;
    }

} // End Of Class

public static class BucketPolicyFactoryExtensions
{
}
