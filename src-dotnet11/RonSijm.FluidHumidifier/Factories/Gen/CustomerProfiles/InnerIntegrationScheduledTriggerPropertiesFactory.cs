// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerIntegrationScheduledTriggerPropertiesFactory(Action<Humidifier.CustomerProfiles.IntegrationTypes.ScheduledTriggerProperties> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.IntegrationTypes.ScheduledTriggerProperties>
{

    protected override Humidifier.CustomerProfiles.IntegrationTypes.ScheduledTriggerProperties Create()
    {
        var scheduledTriggerPropertiesResult = CreateScheduledTriggerProperties();
        factoryAction?.Invoke(scheduledTriggerPropertiesResult);

        return scheduledTriggerPropertiesResult;
    }

    private Humidifier.CustomerProfiles.IntegrationTypes.ScheduledTriggerProperties CreateScheduledTriggerProperties()
    {
        var scheduledTriggerPropertiesResult = new Humidifier.CustomerProfiles.IntegrationTypes.ScheduledTriggerProperties();

        return scheduledTriggerPropertiesResult;
    }

} // End Of Class

public static class InnerIntegrationScheduledTriggerPropertiesFactoryExtensions
{
}
