// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class InnerAppBlockBuilderAccessEndpointFactory(Action<Humidifier.AppStream.AppBlockBuilderTypes.AccessEndpoint> factoryAction = null) : SubResourceFactory<Humidifier.AppStream.AppBlockBuilderTypes.AccessEndpoint>
{

    protected override Humidifier.AppStream.AppBlockBuilderTypes.AccessEndpoint Create()
    {
        var accessEndpointResult = CreateAccessEndpoint();
        factoryAction?.Invoke(accessEndpointResult);

        return accessEndpointResult;
    }

    private Humidifier.AppStream.AppBlockBuilderTypes.AccessEndpoint CreateAccessEndpoint()
    {
        var accessEndpointResult = new Humidifier.AppStream.AppBlockBuilderTypes.AccessEndpoint();

        return accessEndpointResult;
    }

} // End Of Class

public static class InnerAppBlockBuilderAccessEndpointFactoryExtensions
{
}
