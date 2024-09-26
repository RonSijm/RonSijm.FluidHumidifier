// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerConfigurationSetEventDestinationEventBridgeDestinationFactory(Action<Humidifier.SES.ConfigurationSetEventDestinationTypes.EventBridgeDestination> factoryAction = null) : SubResourceFactory<Humidifier.SES.ConfigurationSetEventDestinationTypes.EventBridgeDestination>
{

    protected override Humidifier.SES.ConfigurationSetEventDestinationTypes.EventBridgeDestination Create()
    {
        var eventBridgeDestinationResult = CreateEventBridgeDestination();
        factoryAction?.Invoke(eventBridgeDestinationResult);

        return eventBridgeDestinationResult;
    }

    private Humidifier.SES.ConfigurationSetEventDestinationTypes.EventBridgeDestination CreateEventBridgeDestination()
    {
        var eventBridgeDestinationResult = new Humidifier.SES.ConfigurationSetEventDestinationTypes.EventBridgeDestination();

        return eventBridgeDestinationResult;
    }

} // End Of Class

public static class InnerConfigurationSetEventDestinationEventBridgeDestinationFactoryExtensions
{
}
