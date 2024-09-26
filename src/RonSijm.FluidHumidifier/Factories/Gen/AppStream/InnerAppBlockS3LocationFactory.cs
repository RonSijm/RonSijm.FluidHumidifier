// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class InnerAppBlockS3LocationFactory(Action<Humidifier.AppStream.AppBlockTypes.S3Location> factoryAction = null) : SubResourceFactory<Humidifier.AppStream.AppBlockTypes.S3Location>
{

    protected override Humidifier.AppStream.AppBlockTypes.S3Location Create()
    {
        var s3LocationResult = CreateS3Location();
        factoryAction?.Invoke(s3LocationResult);

        return s3LocationResult;
    }

    private Humidifier.AppStream.AppBlockTypes.S3Location CreateS3Location()
    {
        var s3LocationResult = new Humidifier.AppStream.AppBlockTypes.S3Location();

        return s3LocationResult;
    }

} // End Of Class

public static class InnerAppBlockS3LocationFactoryExtensions
{
}
