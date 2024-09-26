// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class InnerStackAccessEndpointFactory(Action<Humidifier.AppStream.StackTypes.AccessEndpoint> factoryAction = null) : SubResourceFactory<Humidifier.AppStream.StackTypes.AccessEndpoint>
{

    protected override Humidifier.AppStream.StackTypes.AccessEndpoint Create()
    {
        var accessEndpointResult = CreateAccessEndpoint();
        factoryAction?.Invoke(accessEndpointResult);

        return accessEndpointResult;
    }

    private Humidifier.AppStream.StackTypes.AccessEndpoint CreateAccessEndpoint()
    {
        var accessEndpointResult = new Humidifier.AppStream.StackTypes.AccessEndpoint();

        return accessEndpointResult;
    }

} // End Of Class

public static class InnerStackAccessEndpointFactoryExtensions
{
}
