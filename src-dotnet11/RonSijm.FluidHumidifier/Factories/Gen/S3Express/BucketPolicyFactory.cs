// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Express;

public class BucketPolicyFactory(string resourceName = null, Action<Humidifier.S3Express.BucketPolicy> factoryAction = null) : ResourceFactory<Humidifier.S3Express.BucketPolicy>(resourceName)
{

    protected override Humidifier.S3Express.BucketPolicy Create()
    {
        var bucketPolicyResult = CreateBucketPolicy();
        factoryAction?.Invoke(bucketPolicyResult);

        return bucketPolicyResult;
    }

    private Humidifier.S3Express.BucketPolicy CreateBucketPolicy()
    {
        var bucketPolicyResult = new Humidifier.S3Express.BucketPolicy
        {
            GivenName = InputResourceName,
        };

        return bucketPolicyResult;
    }

} // End Of Class

public static class BucketPolicyFactoryExtensions
{
}
