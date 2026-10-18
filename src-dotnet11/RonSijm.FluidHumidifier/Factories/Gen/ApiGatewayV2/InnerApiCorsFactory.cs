// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class InnerApiCorsFactory(Action<Humidifier.ApiGatewayV2.ApiTypes.Cors> factoryAction = null) : SubResourceFactory<Humidifier.ApiGatewayV2.ApiTypes.Cors>
{

    protected override Humidifier.ApiGatewayV2.ApiTypes.Cors Create()
    {
        var corsResult = CreateCors();
        factoryAction?.Invoke(corsResult);

        return corsResult;
    }

    private Humidifier.ApiGatewayV2.ApiTypes.Cors CreateCors()
    {
        var corsResult = new Humidifier.ApiGatewayV2.ApiTypes.Cors();

        return corsResult;
    }

} // End Of Class

public static class InnerApiCorsFactoryExtensions
{
}
