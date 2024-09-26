// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerGameSessionQueuePriorityConfigurationFactory(Action<Humidifier.GameLift.GameSessionQueueTypes.PriorityConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.GameSessionQueueTypes.PriorityConfiguration>
{

    protected override Humidifier.GameLift.GameSessionQueueTypes.PriorityConfiguration Create()
    {
        var priorityConfigurationResult = CreatePriorityConfiguration();
        factoryAction?.Invoke(priorityConfigurationResult);

        return priorityConfigurationResult;
    }

    private Humidifier.GameLift.GameSessionQueueTypes.PriorityConfiguration CreatePriorityConfiguration()
    {
        var priorityConfigurationResult = new Humidifier.GameLift.GameSessionQueueTypes.PriorityConfiguration();

        return priorityConfigurationResult;
    }

} // End Of Class

public static class InnerGameSessionQueuePriorityConfigurationFactoryExtensions
{
}
