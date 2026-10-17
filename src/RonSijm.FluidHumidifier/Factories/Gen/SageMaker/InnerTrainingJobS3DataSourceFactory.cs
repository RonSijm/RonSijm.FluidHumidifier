// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTrainingJobS3DataSourceFactory(Action<Humidifier.SageMaker.TrainingJobTypes.S3DataSource> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TrainingJobTypes.S3DataSource>
{

    protected override Humidifier.SageMaker.TrainingJobTypes.S3DataSource Create()
    {
        var s3DataSourceResult = CreateS3DataSource();
        factoryAction?.Invoke(s3DataSourceResult);

        return s3DataSourceResult;
    }

    private Humidifier.SageMaker.TrainingJobTypes.S3DataSource CreateS3DataSource()
    {
        var s3DataSourceResult = new Humidifier.SageMaker.TrainingJobTypes.S3DataSource();

        return s3DataSourceResult;
    }

} // End Of Class

public static class InnerTrainingJobS3DataSourceFactoryExtensions
{
}
