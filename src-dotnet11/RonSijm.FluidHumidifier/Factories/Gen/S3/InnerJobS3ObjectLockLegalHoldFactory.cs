// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobS3ObjectLockLegalHoldFactory(Action<Humidifier.S3.JobTypes.S3ObjectLockLegalHold> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.S3ObjectLockLegalHold>
{

    protected override Humidifier.S3.JobTypes.S3ObjectLockLegalHold Create()
    {
        var s3ObjectLockLegalHoldResult = CreateS3ObjectLockLegalHold();
        factoryAction?.Invoke(s3ObjectLockLegalHoldResult);

        return s3ObjectLockLegalHoldResult;
    }

    private Humidifier.S3.JobTypes.S3ObjectLockLegalHold CreateS3ObjectLockLegalHold()
    {
        var s3ObjectLockLegalHoldResult = new Humidifier.S3.JobTypes.S3ObjectLockLegalHold();

        return s3ObjectLockLegalHoldResult;
    }

} // End Of Class

public static class InnerJobS3ObjectLockLegalHoldFactoryExtensions
{
}
