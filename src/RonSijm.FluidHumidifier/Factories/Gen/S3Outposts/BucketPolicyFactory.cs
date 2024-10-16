// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Outposts;

public class BucketPolicyFactory(string resourceName = null, Action<Humidifier.S3Outposts.BucketPolicy> factoryAction = null) : ResourceFactory<Humidifier.S3Outposts.BucketPolicy>(resourceName)
{

    protected override Humidifier.S3Outposts.BucketPolicy Create()
    {
        var bucketPolicyResult = CreateBucketPolicy();
        factoryAction?.Invoke(bucketPolicyResult);

        return bucketPolicyResult;
    }

    private Humidifier.S3Outposts.BucketPolicy CreateBucketPolicy()
    {
        var bucketPolicyResult = new Humidifier.S3Outposts.BucketPolicy
        {
            GivenName = InputResourceName,
        };

        return bucketPolicyResult;
    }

} // End Of Class

public static class BucketPolicyFactoryExtensions
{
}
