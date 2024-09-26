// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerDatasetS3LocationFactory(Action<Humidifier.DataBrew.DatasetTypes.S3Location> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.DatasetTypes.S3Location>
{

    protected override Humidifier.DataBrew.DatasetTypes.S3Location Create()
    {
        var s3LocationResult = CreateS3Location();
        factoryAction?.Invoke(s3LocationResult);

        return s3LocationResult;
    }

    private Humidifier.DataBrew.DatasetTypes.S3Location CreateS3Location()
    {
        var s3LocationResult = new Humidifier.DataBrew.DatasetTypes.S3Location();

        return s3LocationResult;
    }

} // End Of Class

public static class InnerDatasetS3LocationFactoryExtensions
{
}
