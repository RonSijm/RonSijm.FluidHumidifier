// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterSchedulerConfigSchedulerConfigFactory(Action<Humidifier.SageMaker.ClusterSchedulerConfigTypes.SchedulerConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterSchedulerConfigTypes.SchedulerConfig>
{

    protected override Humidifier.SageMaker.ClusterSchedulerConfigTypes.SchedulerConfig Create()
    {
        var schedulerConfigResult = CreateSchedulerConfig();
        factoryAction?.Invoke(schedulerConfigResult);

        return schedulerConfigResult;
    }

    private Humidifier.SageMaker.ClusterSchedulerConfigTypes.SchedulerConfig CreateSchedulerConfig()
    {
        var schedulerConfigResult = new Humidifier.SageMaker.ClusterSchedulerConfigTypes.SchedulerConfig();

        return schedulerConfigResult;
    }

} // End Of Class

public static class InnerClusterSchedulerConfigSchedulerConfigFactoryExtensions
{
}
