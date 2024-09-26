// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTEvents;

public class InnerAlarmModelInitializationConfigurationFactory(Action<Humidifier.IoTEvents.AlarmModelTypes.InitializationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoTEvents.AlarmModelTypes.InitializationConfiguration>
{

    protected override Humidifier.IoTEvents.AlarmModelTypes.InitializationConfiguration Create()
    {
        var initializationConfigurationResult = CreateInitializationConfiguration();
        factoryAction?.Invoke(initializationConfigurationResult);

        return initializationConfigurationResult;
    }

    private Humidifier.IoTEvents.AlarmModelTypes.InitializationConfiguration CreateInitializationConfiguration()
    {
        var initializationConfigurationResult = new Humidifier.IoTEvents.AlarmModelTypes.InitializationConfiguration();

        return initializationConfigurationResult;
    }

} // End Of Class

public static class InnerAlarmModelInitializationConfigurationFactoryExtensions
{
}
