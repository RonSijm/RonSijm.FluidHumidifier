// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplateNetworkBandwidthGbpsFactory(Action<Humidifier.EC2.LaunchTemplateTypes.NetworkBandwidthGbps> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.NetworkBandwidthGbps>
{

    protected override Humidifier.EC2.LaunchTemplateTypes.NetworkBandwidthGbps Create()
    {
        var networkBandwidthGbpsResult = CreateNetworkBandwidthGbps();
        factoryAction?.Invoke(networkBandwidthGbpsResult);

        return networkBandwidthGbpsResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.NetworkBandwidthGbps CreateNetworkBandwidthGbps()
    {
        var networkBandwidthGbpsResult = new Humidifier.EC2.LaunchTemplateTypes.NetworkBandwidthGbps();

        return networkBandwidthGbpsResult;
    }

} // End Of Class

public static class InnerLaunchTemplateNetworkBandwidthGbpsFactoryExtensions
{
}
