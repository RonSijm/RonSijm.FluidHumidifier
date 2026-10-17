// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MWAAServerless;

public class InnerWorkflowS3LocationFactory(Action<Humidifier.MWAAServerless.WorkflowTypes.S3Location> factoryAction = null) : SubResourceFactory<Humidifier.MWAAServerless.WorkflowTypes.S3Location>
{

    protected override Humidifier.MWAAServerless.WorkflowTypes.S3Location Create()
    {
        var s3LocationResult = CreateS3Location();
        factoryAction?.Invoke(s3LocationResult);

        return s3LocationResult;
    }

    private Humidifier.MWAAServerless.WorkflowTypes.S3Location CreateS3Location()
    {
        var s3LocationResult = new Humidifier.MWAAServerless.WorkflowTypes.S3Location();

        return s3LocationResult;
    }

} // End Of Class

public static class InnerWorkflowS3LocationFactoryExtensions
{
}
