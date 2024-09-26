// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class InnerLinkBandwidthFactory(Action<Humidifier.NetworkManager.LinkTypes.Bandwidth> factoryAction = null) : SubResourceFactory<Humidifier.NetworkManager.LinkTypes.Bandwidth>
{

    protected override Humidifier.NetworkManager.LinkTypes.Bandwidth Create()
    {
        var bandwidthResult = CreateBandwidth();
        factoryAction?.Invoke(bandwidthResult);

        return bandwidthResult;
    }

    private Humidifier.NetworkManager.LinkTypes.Bandwidth CreateBandwidth()
    {
        var bandwidthResult = new Humidifier.NetworkManager.LinkTypes.Bandwidth();

        return bandwidthResult;
    }

} // End Of Class

public static class InnerLinkBandwidthFactoryExtensions
{
}
