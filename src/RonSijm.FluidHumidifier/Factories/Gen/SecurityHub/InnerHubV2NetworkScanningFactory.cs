// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class InnerHubV2NetworkScanningFactory(Action<Humidifier.SecurityHub.HubV2Types.NetworkScanning> factoryAction = null) : SubResourceFactory<Humidifier.SecurityHub.HubV2Types.NetworkScanning>
{

    protected override Humidifier.SecurityHub.HubV2Types.NetworkScanning Create()
    {
        var networkScanningResult = CreateNetworkScanning();
        factoryAction?.Invoke(networkScanningResult);

        return networkScanningResult;
    }

    private Humidifier.SecurityHub.HubV2Types.NetworkScanning CreateNetworkScanning()
    {
        var networkScanningResult = new Humidifier.SecurityHub.HubV2Types.NetworkScanning();

        return networkScanningResult;
    }

} // End Of Class

public static class InnerHubV2NetworkScanningFactoryExtensions
{
}
