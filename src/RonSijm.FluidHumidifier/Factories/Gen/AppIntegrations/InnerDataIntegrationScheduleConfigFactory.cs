// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppIntegrations;

public class InnerDataIntegrationScheduleConfigFactory(Action<Humidifier.AppIntegrations.DataIntegrationTypes.ScheduleConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppIntegrations.DataIntegrationTypes.ScheduleConfig>
{

    protected override Humidifier.AppIntegrations.DataIntegrationTypes.ScheduleConfig Create()
    {
        var scheduleConfigResult = CreateScheduleConfig();
        factoryAction?.Invoke(scheduleConfigResult);

        return scheduleConfigResult;
    }

    private Humidifier.AppIntegrations.DataIntegrationTypes.ScheduleConfig CreateScheduleConfig()
    {
        var scheduleConfigResult = new Humidifier.AppIntegrations.DataIntegrationTypes.ScheduleConfig();

        return scheduleConfigResult;
    }

} // End Of Class

public static class InnerDataIntegrationScheduleConfigFactoryExtensions
{
}
