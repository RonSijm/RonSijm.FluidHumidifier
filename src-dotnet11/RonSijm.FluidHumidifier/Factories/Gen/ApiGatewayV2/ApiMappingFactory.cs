// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class ApiMappingFactory(string resourceName = null, Action<Humidifier.ApiGatewayV2.ApiMapping> factoryAction = null) : ResourceFactory<Humidifier.ApiGatewayV2.ApiMapping>(resourceName)
{

    protected override Humidifier.ApiGatewayV2.ApiMapping Create()
    {
        var apiMappingResult = CreateApiMapping();
        factoryAction?.Invoke(apiMappingResult);

        return apiMappingResult;
    }

    private Humidifier.ApiGatewayV2.ApiMapping CreateApiMapping()
    {
        var apiMappingResult = new Humidifier.ApiGatewayV2.ApiMapping
        {
            GivenName = InputResourceName,
        };

        return apiMappingResult;
    }

} // End Of Class

public static class ApiMappingFactoryExtensions
{
}
