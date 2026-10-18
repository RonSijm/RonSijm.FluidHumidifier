// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NeptuneGraph;

public class PrivateGraphEndpointFactory(string resourceName = null, Action<Humidifier.NeptuneGraph.PrivateGraphEndpoint> factoryAction = null) : ResourceFactory<Humidifier.NeptuneGraph.PrivateGraphEndpoint>(resourceName)
{

    protected override Humidifier.NeptuneGraph.PrivateGraphEndpoint Create()
    {
        var privateGraphEndpointResult = CreatePrivateGraphEndpoint();
        factoryAction?.Invoke(privateGraphEndpointResult);

        return privateGraphEndpointResult;
    }

    private Humidifier.NeptuneGraph.PrivateGraphEndpoint CreatePrivateGraphEndpoint()
    {
        var privateGraphEndpointResult = new Humidifier.NeptuneGraph.PrivateGraphEndpoint
        {
            GivenName = InputResourceName,
        };

        return privateGraphEndpointResult;
    }

} // End Of Class

public static class PrivateGraphEndpointFactoryExtensions
{
}
