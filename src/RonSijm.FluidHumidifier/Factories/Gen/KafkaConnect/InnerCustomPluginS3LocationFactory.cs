// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KafkaConnect;

public class InnerCustomPluginS3LocationFactory(Action<Humidifier.KafkaConnect.CustomPluginTypes.S3Location> factoryAction = null) : SubResourceFactory<Humidifier.KafkaConnect.CustomPluginTypes.S3Location>
{

    protected override Humidifier.KafkaConnect.CustomPluginTypes.S3Location Create()
    {
        var s3LocationResult = CreateS3Location();
        factoryAction?.Invoke(s3LocationResult);

        return s3LocationResult;
    }

    private Humidifier.KafkaConnect.CustomPluginTypes.S3Location CreateS3Location()
    {
        var s3LocationResult = new Humidifier.KafkaConnect.CustomPluginTypes.S3Location();

        return s3LocationResult;
    }

} // End Of Class

public static class InnerCustomPluginS3LocationFactoryExtensions
{
}
