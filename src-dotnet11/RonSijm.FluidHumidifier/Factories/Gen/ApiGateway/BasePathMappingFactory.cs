// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class BasePathMappingFactory(string resourceName = null, Action<Humidifier.ApiGateway.BasePathMapping> factoryAction = null) : ResourceFactory<Humidifier.ApiGateway.BasePathMapping>(resourceName)
{

    protected override Humidifier.ApiGateway.BasePathMapping Create()
    {
        var basePathMappingResult = CreateBasePathMapping();
        factoryAction?.Invoke(basePathMappingResult);

        return basePathMappingResult;
    }

    private Humidifier.ApiGateway.BasePathMapping CreateBasePathMapping()
    {
        var basePathMappingResult = new Humidifier.ApiGateway.BasePathMapping
        {
            GivenName = InputResourceName,
        };

        return basePathMappingResult;
    }

} // End Of Class

public static class BasePathMappingFactoryExtensions
{
}
