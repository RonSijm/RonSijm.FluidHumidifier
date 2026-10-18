// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class InnerImageBuilderAccessEndpointFactory(Action<Humidifier.AppStream.ImageBuilderTypes.AccessEndpoint> factoryAction = null) : SubResourceFactory<Humidifier.AppStream.ImageBuilderTypes.AccessEndpoint>
{

    protected override Humidifier.AppStream.ImageBuilderTypes.AccessEndpoint Create()
    {
        var accessEndpointResult = CreateAccessEndpoint();
        factoryAction?.Invoke(accessEndpointResult);

        return accessEndpointResult;
    }

    private Humidifier.AppStream.ImageBuilderTypes.AccessEndpoint CreateAccessEndpoint()
    {
        var accessEndpointResult = new Humidifier.AppStream.ImageBuilderTypes.AccessEndpoint();

        return accessEndpointResult;
    }

} // End Of Class

public static class InnerImageBuilderAccessEndpointFactoryExtensions
{
}
