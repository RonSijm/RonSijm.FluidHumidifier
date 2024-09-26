// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class InnerApiBodyS3LocationFactory(Action<Humidifier.ApiGatewayV2.ApiTypes.BodyS3Location> factoryAction = null) : SubResourceFactory<Humidifier.ApiGatewayV2.ApiTypes.BodyS3Location>
{

    protected override Humidifier.ApiGatewayV2.ApiTypes.BodyS3Location Create()
    {
        var bodyS3LocationResult = CreateBodyS3Location();
        factoryAction?.Invoke(bodyS3LocationResult);

        return bodyS3LocationResult;
    }

    private Humidifier.ApiGatewayV2.ApiTypes.BodyS3Location CreateBodyS3Location()
    {
        var bodyS3LocationResult = new Humidifier.ApiGatewayV2.ApiTypes.BodyS3Location();

        return bodyS3LocationResult;
    }

} // End Of Class

public static class InnerApiBodyS3LocationFactoryExtensions
{
}
