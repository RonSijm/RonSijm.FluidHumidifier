// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobS3SetObjectTaggingOperationFactory(Action<Humidifier.S3.JobTypes.S3SetObjectTaggingOperation> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.S3SetObjectTaggingOperation>
{

    protected override Humidifier.S3.JobTypes.S3SetObjectTaggingOperation Create()
    {
        var s3SetObjectTaggingOperationResult = CreateS3SetObjectTaggingOperation();
        factoryAction?.Invoke(s3SetObjectTaggingOperationResult);

        return s3SetObjectTaggingOperationResult;
    }

    private Humidifier.S3.JobTypes.S3SetObjectTaggingOperation CreateS3SetObjectTaggingOperation()
    {
        var s3SetObjectTaggingOperationResult = new Humidifier.S3.JobTypes.S3SetObjectTaggingOperation();

        return s3SetObjectTaggingOperationResult;
    }

} // End Of Class

public static class InnerJobS3SetObjectTaggingOperationFactoryExtensions
{
}
