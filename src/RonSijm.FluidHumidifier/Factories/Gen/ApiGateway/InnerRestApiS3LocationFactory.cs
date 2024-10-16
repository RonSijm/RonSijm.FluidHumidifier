// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class InnerRestApiS3LocationFactory(Action<Humidifier.ApiGateway.RestApiTypes.S3Location> factoryAction = null) : SubResourceFactory<Humidifier.ApiGateway.RestApiTypes.S3Location>
{

    protected override Humidifier.ApiGateway.RestApiTypes.S3Location Create()
    {
        var s3LocationResult = CreateS3Location();
        factoryAction?.Invoke(s3LocationResult);

        return s3LocationResult;
    }

    private Humidifier.ApiGateway.RestApiTypes.S3Location CreateS3Location()
    {
        var s3LocationResult = new Humidifier.ApiGateway.RestApiTypes.S3Location();

        return s3LocationResult;
    }

} // End Of Class

public static class InnerRestApiS3LocationFactoryExtensions
{
}
