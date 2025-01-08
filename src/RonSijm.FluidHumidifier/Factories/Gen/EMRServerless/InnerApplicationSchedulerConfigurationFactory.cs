// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRServerless;

public class InnerApplicationSchedulerConfigurationFactory(Action<Humidifier.EMRServerless.ApplicationTypes.SchedulerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRServerless.ApplicationTypes.SchedulerConfiguration>
{

    protected override Humidifier.EMRServerless.ApplicationTypes.SchedulerConfiguration Create()
    {
        var schedulerConfigurationResult = CreateSchedulerConfiguration();
        factoryAction?.Invoke(schedulerConfigurationResult);

        return schedulerConfigurationResult;
    }

    private Humidifier.EMRServerless.ApplicationTypes.SchedulerConfiguration CreateSchedulerConfiguration()
    {
        var schedulerConfigurationResult = new Humidifier.EMRServerless.ApplicationTypes.SchedulerConfiguration();

        return schedulerConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationSchedulerConfigurationFactoryExtensions
{
}
