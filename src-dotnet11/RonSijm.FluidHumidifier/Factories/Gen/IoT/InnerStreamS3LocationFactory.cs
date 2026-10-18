// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerStreamS3LocationFactory(Action<Humidifier.IoT.StreamTypes.S3Location> factoryAction = null) : SubResourceFactory<Humidifier.IoT.StreamTypes.S3Location>
{

    protected override Humidifier.IoT.StreamTypes.S3Location Create()
    {
        var s3LocationResult = CreateS3Location();
        factoryAction?.Invoke(s3LocationResult);

        return s3LocationResult;
    }

    private Humidifier.IoT.StreamTypes.S3Location CreateS3Location()
    {
        var s3LocationResult = new Humidifier.IoT.StreamTypes.S3Location();

        return s3LocationResult;
    }

} // End Of Class

public static class InnerStreamS3LocationFactoryExtensions
{
}
