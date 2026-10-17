// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerClusterInstanceTypeConfigFactory(Action<Humidifier.EMR.ClusterTypes.InstanceTypeConfig> factoryAction = null) : SubResourceFactory<Humidifier.EMR.ClusterTypes.InstanceTypeConfig>
{

    protected override Humidifier.EMR.ClusterTypes.InstanceTypeConfig Create()
    {
        var instanceTypeConfigResult = CreateInstanceTypeConfig();
        factoryAction?.Invoke(instanceTypeConfigResult);

        return instanceTypeConfigResult;
    }

    private Humidifier.EMR.ClusterTypes.InstanceTypeConfig CreateInstanceTypeConfig()
    {
        var instanceTypeConfigResult = new Humidifier.EMR.ClusterTypes.InstanceTypeConfig();

        return instanceTypeConfigResult;
    }

} // End Of Class

public static class InnerClusterInstanceTypeConfigFactoryExtensions
{
}
