// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class DevEndpointFactory(string resourceName = null, Action<Humidifier.Glue.DevEndpoint> factoryAction = null) : ResourceFactory<Humidifier.Glue.DevEndpoint>(resourceName)
{

    protected override Humidifier.Glue.DevEndpoint Create()
    {
        var devEndpointResult = CreateDevEndpoint();
        factoryAction?.Invoke(devEndpointResult);

        return devEndpointResult;
    }

    private Humidifier.Glue.DevEndpoint CreateDevEndpoint()
    {
        var devEndpointResult = new Humidifier.Glue.DevEndpoint
        {
            GivenName = InputResourceName,
        };

        return devEndpointResult;
    }

} // End Of Class

public static class DevEndpointFactoryExtensions
{
}
