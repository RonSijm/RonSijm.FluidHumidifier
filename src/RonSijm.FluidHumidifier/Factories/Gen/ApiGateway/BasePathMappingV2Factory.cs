// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class BasePathMappingV2Factory(string resourceName = null, Action<Humidifier.ApiGateway.BasePathMappingV2> factoryAction = null) : ResourceFactory<Humidifier.ApiGateway.BasePathMappingV2>(resourceName)
{

    protected override Humidifier.ApiGateway.BasePathMappingV2 Create()
    {
        var basePathMappingV2Result = CreateBasePathMappingV2();
        factoryAction?.Invoke(basePathMappingV2Result);

        return basePathMappingV2Result;
    }

    private Humidifier.ApiGateway.BasePathMappingV2 CreateBasePathMappingV2()
    {
        var basePathMappingV2Result = new Humidifier.ApiGateway.BasePathMappingV2
        {
            GivenName = InputResourceName,
        };

        return basePathMappingV2Result;
    }

} // End Of Class

public static class BasePathMappingV2FactoryExtensions
{
}
