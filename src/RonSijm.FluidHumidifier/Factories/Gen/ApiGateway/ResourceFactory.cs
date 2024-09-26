// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class ResourceFactory(string resourceName = null, Action<Humidifier.ApiGateway.Resource> factoryAction = null) : ResourceFactory<Humidifier.ApiGateway.Resource>(resourceName)
{

    protected override Humidifier.ApiGateway.Resource Create()
    {
        var resourceResult = CreateResource();
        factoryAction?.Invoke(resourceResult);

        return resourceResult;
    }

    private Humidifier.ApiGateway.Resource CreateResource()
    {
        var resourceResult = new Humidifier.ApiGateway.Resource
        {
            GivenName = InputResourceName,
        };

        return resourceResult;
    }

} // End Of Class

public static class ResourceFactoryExtensions
{
}
