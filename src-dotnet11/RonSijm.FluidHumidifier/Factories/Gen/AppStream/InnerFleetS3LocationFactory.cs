// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class InnerFleetS3LocationFactory(Action<Humidifier.AppStream.FleetTypes.S3Location> factoryAction = null) : SubResourceFactory<Humidifier.AppStream.FleetTypes.S3Location>
{

    protected override Humidifier.AppStream.FleetTypes.S3Location Create()
    {
        var s3LocationResult = CreateS3Location();
        factoryAction?.Invoke(s3LocationResult);

        return s3LocationResult;
    }

    private Humidifier.AppStream.FleetTypes.S3Location CreateS3Location()
    {
        var s3LocationResult = new Humidifier.AppStream.FleetTypes.S3Location();

        return s3LocationResult;
    }

} // End Of Class

public static class InnerFleetS3LocationFactoryExtensions
{
}
