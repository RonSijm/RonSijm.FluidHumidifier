// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerPipelineS3LocationFactory(Action<Humidifier.SageMaker.PipelineTypes.S3Location> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.PipelineTypes.S3Location>
{

    protected override Humidifier.SageMaker.PipelineTypes.S3Location Create()
    {
        var s3LocationResult = CreateS3Location();
        factoryAction?.Invoke(s3LocationResult);

        return s3LocationResult;
    }

    private Humidifier.SageMaker.PipelineTypes.S3Location CreateS3Location()
    {
        var s3LocationResult = new Humidifier.SageMaker.PipelineTypes.S3Location();

        return s3LocationResult;
    }

} // End Of Class

public static class InnerPipelineS3LocationFactoryExtensions
{
}
