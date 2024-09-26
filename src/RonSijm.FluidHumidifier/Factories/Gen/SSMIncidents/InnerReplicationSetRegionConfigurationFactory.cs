// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSMIncidents;

public class InnerReplicationSetRegionConfigurationFactory(Action<Humidifier.SSMIncidents.ReplicationSetTypes.RegionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SSMIncidents.ReplicationSetTypes.RegionConfiguration>
{

    protected override Humidifier.SSMIncidents.ReplicationSetTypes.RegionConfiguration Create()
    {
        var regionConfigurationResult = CreateRegionConfiguration();
        factoryAction?.Invoke(regionConfigurationResult);

        return regionConfigurationResult;
    }

    private Humidifier.SSMIncidents.ReplicationSetTypes.RegionConfiguration CreateRegionConfiguration()
    {
        var regionConfigurationResult = new Humidifier.SSMIncidents.ReplicationSetTypes.RegionConfiguration();

        return regionConfigurationResult;
    }

} // End Of Class

public static class InnerReplicationSetRegionConfigurationFactoryExtensions
{
}
