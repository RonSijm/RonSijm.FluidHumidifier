// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Braket;

public class InnerJobS3DataSourceFactory(Action<Humidifier.Braket.JobTypes.S3DataSource> factoryAction = null) : SubResourceFactory<Humidifier.Braket.JobTypes.S3DataSource>
{

    protected override Humidifier.Braket.JobTypes.S3DataSource Create()
    {
        var s3DataSourceResult = CreateS3DataSource();
        factoryAction?.Invoke(s3DataSourceResult);

        return s3DataSourceResult;
    }

    private Humidifier.Braket.JobTypes.S3DataSource CreateS3DataSource()
    {
        var s3DataSourceResult = new Humidifier.Braket.JobTypes.S3DataSource();

        return s3DataSourceResult;
    }

} // End Of Class

public static class InnerJobS3DataSourceFactoryExtensions
{
}
