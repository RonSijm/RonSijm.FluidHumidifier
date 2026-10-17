// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobS3InitiateRestoreObjectOperationFactory(Action<Humidifier.S3.JobTypes.S3InitiateRestoreObjectOperation> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.S3InitiateRestoreObjectOperation>
{

    protected override Humidifier.S3.JobTypes.S3InitiateRestoreObjectOperation Create()
    {
        var s3InitiateRestoreObjectOperationResult = CreateS3InitiateRestoreObjectOperation();
        factoryAction?.Invoke(s3InitiateRestoreObjectOperationResult);

        return s3InitiateRestoreObjectOperationResult;
    }

    private Humidifier.S3.JobTypes.S3InitiateRestoreObjectOperation CreateS3InitiateRestoreObjectOperation()
    {
        var s3InitiateRestoreObjectOperationResult = new Humidifier.S3.JobTypes.S3InitiateRestoreObjectOperation();

        return s3InitiateRestoreObjectOperationResult;
    }

} // End Of Class

public static class InnerJobS3InitiateRestoreObjectOperationFactoryExtensions
{
}
