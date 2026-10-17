// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerSoftwarePackageVersionS3LocationFactory(Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> factoryAction = null) : SubResourceFactory<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location>
{

    protected override Humidifier.IoT.SoftwarePackageVersionTypes.S3Location Create()
    {
        var s3LocationResult = CreateS3Location();
        factoryAction?.Invoke(s3LocationResult);

        return s3LocationResult;
    }

    private Humidifier.IoT.SoftwarePackageVersionTypes.S3Location CreateS3Location()
    {
        var s3LocationResult = new Humidifier.IoT.SoftwarePackageVersionTypes.S3Location();

        return s3LocationResult;
    }

} // End Of Class

public static class InnerSoftwarePackageVersionS3LocationFactoryExtensions
{
}
