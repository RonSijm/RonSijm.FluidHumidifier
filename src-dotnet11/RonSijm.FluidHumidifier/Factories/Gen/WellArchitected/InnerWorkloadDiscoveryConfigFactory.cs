// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WellArchitected;

public class InnerWorkloadDiscoveryConfigFactory(Action<Humidifier.WellArchitected.WorkloadTypes.DiscoveryConfig> factoryAction = null) : SubResourceFactory<Humidifier.WellArchitected.WorkloadTypes.DiscoveryConfig>
{

    protected override Humidifier.WellArchitected.WorkloadTypes.DiscoveryConfig Create()
    {
        var discoveryConfigResult = CreateDiscoveryConfig();
        factoryAction?.Invoke(discoveryConfigResult);

        return discoveryConfigResult;
    }

    private Humidifier.WellArchitected.WorkloadTypes.DiscoveryConfig CreateDiscoveryConfig()
    {
        var discoveryConfigResult = new Humidifier.WellArchitected.WorkloadTypes.DiscoveryConfig();

        return discoveryConfigResult;
    }

} // End Of Class

public static class InnerWorkloadDiscoveryConfigFactoryExtensions
{
}
