// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class InnerDocumentationPartLocationFactory(Action<Humidifier.ApiGateway.DocumentationPartTypes.Location> factoryAction = null) : SubResourceFactory<Humidifier.ApiGateway.DocumentationPartTypes.Location>
{

    protected override Humidifier.ApiGateway.DocumentationPartTypes.Location Create()
    {
        var locationResult = CreateLocation();
        factoryAction?.Invoke(locationResult);

        return locationResult;
    }

    private Humidifier.ApiGateway.DocumentationPartTypes.Location CreateLocation()
    {
        var locationResult = new Humidifier.ApiGateway.DocumentationPartTypes.Location();

        return locationResult;
    }

} // End Of Class

public static class InnerDocumentationPartLocationFactoryExtensions
{
}
