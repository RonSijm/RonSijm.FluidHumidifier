// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerReplicationConfigComputeConfigFactory(Action<Humidifier.DMS.ReplicationConfigTypes.ComputeConfig> factoryAction = null) : SubResourceFactory<Humidifier.DMS.ReplicationConfigTypes.ComputeConfig>
{

    protected override Humidifier.DMS.ReplicationConfigTypes.ComputeConfig Create()
    {
        var computeConfigResult = CreateComputeConfig();
        factoryAction?.Invoke(computeConfigResult);

        return computeConfigResult;
    }

    private Humidifier.DMS.ReplicationConfigTypes.ComputeConfig CreateComputeConfig()
    {
        var computeConfigResult = new Humidifier.DMS.ReplicationConfigTypes.ComputeConfig();

        return computeConfigResult;
    }

} // End Of Class

public static class InnerReplicationConfigComputeConfigFactoryExtensions
{
}
