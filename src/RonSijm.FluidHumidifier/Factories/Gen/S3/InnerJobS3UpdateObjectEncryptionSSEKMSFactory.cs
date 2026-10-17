// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobS3UpdateObjectEncryptionSSEKMSFactory(Action<Humidifier.S3.JobTypes.S3UpdateObjectEncryptionSSEKMS> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.S3UpdateObjectEncryptionSSEKMS>
{

    protected override Humidifier.S3.JobTypes.S3UpdateObjectEncryptionSSEKMS Create()
    {
        var s3UpdateObjectEncryptionSSEKMSResult = CreateS3UpdateObjectEncryptionSSEKMS();
        factoryAction?.Invoke(s3UpdateObjectEncryptionSSEKMSResult);

        return s3UpdateObjectEncryptionSSEKMSResult;
    }

    private Humidifier.S3.JobTypes.S3UpdateObjectEncryptionSSEKMS CreateS3UpdateObjectEncryptionSSEKMS()
    {
        var s3UpdateObjectEncryptionSSEKMSResult = new Humidifier.S3.JobTypes.S3UpdateObjectEncryptionSSEKMS();

        return s3UpdateObjectEncryptionSSEKMSResult;
    }

} // End Of Class

public static class InnerJobS3UpdateObjectEncryptionSSEKMSFactoryExtensions
{
}
