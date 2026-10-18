// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Vectors;

public class VectorBucketPolicyFactory(string resourceName = null, Action<Humidifier.S3Vectors.VectorBucketPolicy> factoryAction = null) : ResourceFactory<Humidifier.S3Vectors.VectorBucketPolicy>(resourceName)
{

    protected override Humidifier.S3Vectors.VectorBucketPolicy Create()
    {
        var vectorBucketPolicyResult = CreateVectorBucketPolicy();
        factoryAction?.Invoke(vectorBucketPolicyResult);

        return vectorBucketPolicyResult;
    }

    private Humidifier.S3Vectors.VectorBucketPolicy CreateVectorBucketPolicy()
    {
        var vectorBucketPolicyResult = new Humidifier.S3Vectors.VectorBucketPolicy
        {
            GivenName = InputResourceName,
        };

        return vectorBucketPolicyResult;
    }

} // End Of Class

public static class VectorBucketPolicyFactoryExtensions
{
}
