// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCS;

public class InnerClusterSchedulerFactory(Action<Humidifier.PCS.ClusterTypes.Scheduler> factoryAction = null) : SubResourceFactory<Humidifier.PCS.ClusterTypes.Scheduler>
{

    protected override Humidifier.PCS.ClusterTypes.Scheduler Create()
    {
        var schedulerResult = CreateScheduler();
        factoryAction?.Invoke(schedulerResult);

        return schedulerResult;
    }

    private Humidifier.PCS.ClusterTypes.Scheduler CreateScheduler()
    {
        var schedulerResult = new Humidifier.PCS.ClusterTypes.Scheduler();

        return schedulerResult;
    }

} // End Of Class

public static class InnerClusterSchedulerFactoryExtensions
{
}
