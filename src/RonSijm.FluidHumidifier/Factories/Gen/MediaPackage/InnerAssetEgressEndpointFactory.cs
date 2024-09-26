// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerAssetEgressEndpointFactory(Action<Humidifier.MediaPackage.AssetTypes.EgressEndpoint> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.AssetTypes.EgressEndpoint>
{

    protected override Humidifier.MediaPackage.AssetTypes.EgressEndpoint Create()
    {
        var egressEndpointResult = CreateEgressEndpoint();
        factoryAction?.Invoke(egressEndpointResult);

        return egressEndpointResult;
    }

    private Humidifier.MediaPackage.AssetTypes.EgressEndpoint CreateEgressEndpoint()
    {
        var egressEndpointResult = new Humidifier.MediaPackage.AssetTypes.EgressEndpoint();

        return egressEndpointResult;
    }

} // End Of Class

public static class InnerAssetEgressEndpointFactoryExtensions
{
}
