// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerJobSchedulingConfigFactory(Action<Humidifier.IoT.JobTypes.SchedulingConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoT.JobTypes.SchedulingConfig>
{

    protected override Humidifier.IoT.JobTypes.SchedulingConfig Create()
    {
        var schedulingConfigResult = CreateSchedulingConfig();
        factoryAction?.Invoke(schedulingConfigResult);

        return schedulingConfigResult;
    }

    private Humidifier.IoT.JobTypes.SchedulingConfig CreateSchedulingConfig()
    {
        var schedulingConfigResult = new Humidifier.IoT.JobTypes.SchedulingConfig();

        return schedulingConfigResult;
    }

} // End Of Class

public static class InnerJobSchedulingConfigFactoryExtensions
{
}
