// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTransformJobS3DataSourceFactory(Action<Humidifier.SageMaker.TransformJobTypes.S3DataSource> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TransformJobTypes.S3DataSource>
{

    protected override Humidifier.SageMaker.TransformJobTypes.S3DataSource Create()
    {
        var s3DataSourceResult = CreateS3DataSource();
        factoryAction?.Invoke(s3DataSourceResult);

        return s3DataSourceResult;
    }

    private Humidifier.SageMaker.TransformJobTypes.S3DataSource CreateS3DataSource()
    {
        var s3DataSourceResult = new Humidifier.SageMaker.TransformJobTypes.S3DataSource();

        return s3DataSourceResult;
    }

} // End Of Class

public static class InnerTransformJobS3DataSourceFactoryExtensions
{
}
