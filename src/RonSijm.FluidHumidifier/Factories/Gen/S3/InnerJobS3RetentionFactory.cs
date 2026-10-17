// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobS3RetentionFactory(Action<Humidifier.S3.JobTypes.S3Retention> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.S3Retention>
{

    protected override Humidifier.S3.JobTypes.S3Retention Create()
    {
        var s3RetentionResult = CreateS3Retention();
        factoryAction?.Invoke(s3RetentionResult);

        return s3RetentionResult;
    }

    private Humidifier.S3.JobTypes.S3Retention CreateS3Retention()
    {
        var s3RetentionResult = new Humidifier.S3.JobTypes.S3Retention();

        return s3RetentionResult;
    }

} // End Of Class

public static class InnerJobS3RetentionFactoryExtensions
{
}
