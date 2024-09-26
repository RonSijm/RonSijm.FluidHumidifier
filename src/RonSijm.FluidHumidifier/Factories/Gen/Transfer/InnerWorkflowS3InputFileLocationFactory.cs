// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerWorkflowS3InputFileLocationFactory(Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation>
{

    protected override Humidifier.Transfer.WorkflowTypes.S3InputFileLocation Create()
    {
        var s3InputFileLocationResult = CreateS3InputFileLocation();
        factoryAction?.Invoke(s3InputFileLocationResult);

        return s3InputFileLocationResult;
    }

    private Humidifier.Transfer.WorkflowTypes.S3InputFileLocation CreateS3InputFileLocation()
    {
        var s3InputFileLocationResult = new Humidifier.Transfer.WorkflowTypes.S3InputFileLocation();

        return s3InputFileLocationResult;
    }

} // End Of Class

public static class InnerWorkflowS3InputFileLocationFactoryExtensions
{
}
