// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerEventBusDeadLetterConfigFactory(Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> factoryAction = null) : SubResourceFactory<Humidifier.Events.EventBusTypes.DeadLetterConfig>
{

    protected override Humidifier.Events.EventBusTypes.DeadLetterConfig Create()
    {
        var deadLetterConfigResult = CreateDeadLetterConfig();
        factoryAction?.Invoke(deadLetterConfigResult);

        return deadLetterConfigResult;
    }

    private Humidifier.Events.EventBusTypes.DeadLetterConfig CreateDeadLetterConfig()
    {
        var deadLetterConfigResult = new Humidifier.Events.EventBusTypes.DeadLetterConfig();

        return deadLetterConfigResult;
    }

} // End Of Class

public static class InnerEventBusDeadLetterConfigFactoryExtensions
{
}
