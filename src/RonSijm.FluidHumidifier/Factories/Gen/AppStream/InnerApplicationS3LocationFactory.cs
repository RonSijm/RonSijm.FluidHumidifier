// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class InnerApplicationS3LocationFactory(Action<Humidifier.AppStream.ApplicationTypes.S3Location> factoryAction = null) : SubResourceFactory<Humidifier.AppStream.ApplicationTypes.S3Location>
{

    protected override Humidifier.AppStream.ApplicationTypes.S3Location Create()
    {
        var s3LocationResult = CreateS3Location();
        factoryAction?.Invoke(s3LocationResult);

        return s3LocationResult;
    }

    private Humidifier.AppStream.ApplicationTypes.S3Location CreateS3Location()
    {
        var s3LocationResult = new Humidifier.AppStream.ApplicationTypes.S3Location();

        return s3LocationResult;
    }

} // End Of Class

public static class InnerApplicationS3LocationFactoryExtensions
{
}
