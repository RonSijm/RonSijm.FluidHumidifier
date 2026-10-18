// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerMonitoringScheduleClusterConfigFactory(Action<Humidifier.SageMaker.MonitoringScheduleTypes.ClusterConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.MonitoringScheduleTypes.ClusterConfig>
{

    protected override Humidifier.SageMaker.MonitoringScheduleTypes.ClusterConfig Create()
    {
        var clusterConfigResult = CreateClusterConfig();
        factoryAction?.Invoke(clusterConfigResult);

        return clusterConfigResult;
    }

    private Humidifier.SageMaker.MonitoringScheduleTypes.ClusterConfig CreateClusterConfig()
    {
        var clusterConfigResult = new Humidifier.SageMaker.MonitoringScheduleTypes.ClusterConfig();

        return clusterConfigResult;
    }

} // End Of Class

public static class InnerMonitoringScheduleClusterConfigFactoryExtensions
{
}
