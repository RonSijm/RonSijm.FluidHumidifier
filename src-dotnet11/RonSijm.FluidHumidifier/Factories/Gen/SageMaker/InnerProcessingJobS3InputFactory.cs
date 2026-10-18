// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerProcessingJobS3InputFactory(Action<Humidifier.SageMaker.ProcessingJobTypes.S3Input> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ProcessingJobTypes.S3Input>
{

    protected override Humidifier.SageMaker.ProcessingJobTypes.S3Input Create()
    {
        var s3InputResult = CreateS3Input();
        factoryAction?.Invoke(s3InputResult);

        return s3InputResult;
    }

    private Humidifier.SageMaker.ProcessingJobTypes.S3Input CreateS3Input()
    {
        var s3InputResult = new Humidifier.SageMaker.ProcessingJobTypes.S3Input();

        return s3InputResult;
    }

} // End Of Class

public static class InnerProcessingJobS3InputFactoryExtensions
{
}
