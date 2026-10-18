// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobS3ComputeObjectChecksumOperationFactory(Action<Humidifier.S3.JobTypes.S3ComputeObjectChecksumOperation> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.S3ComputeObjectChecksumOperation>
{

    protected override Humidifier.S3.JobTypes.S3ComputeObjectChecksumOperation Create()
    {
        var s3ComputeObjectChecksumOperationResult = CreateS3ComputeObjectChecksumOperation();
        factoryAction?.Invoke(s3ComputeObjectChecksumOperationResult);

        return s3ComputeObjectChecksumOperationResult;
    }

    private Humidifier.S3.JobTypes.S3ComputeObjectChecksumOperation CreateS3ComputeObjectChecksumOperation()
    {
        var s3ComputeObjectChecksumOperationResult = new Humidifier.S3.JobTypes.S3ComputeObjectChecksumOperation();

        return s3ComputeObjectChecksumOperationResult;
    }

} // End Of Class

public static class InnerJobS3ComputeObjectChecksumOperationFactoryExtensions
{
}
