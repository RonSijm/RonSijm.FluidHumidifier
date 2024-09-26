// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerRuleDeadLetterConfigFactory(Action<Humidifier.Events.RuleTypes.DeadLetterConfig> factoryAction = null) : SubResourceFactory<Humidifier.Events.RuleTypes.DeadLetterConfig>
{

    protected override Humidifier.Events.RuleTypes.DeadLetterConfig Create()
    {
        var deadLetterConfigResult = CreateDeadLetterConfig();
        factoryAction?.Invoke(deadLetterConfigResult);

        return deadLetterConfigResult;
    }

    private Humidifier.Events.RuleTypes.DeadLetterConfig CreateDeadLetterConfig()
    {
        var deadLetterConfigResult = new Humidifier.Events.RuleTypes.DeadLetterConfig();

        return deadLetterConfigResult;
    }

} // End Of Class

public static class InnerRuleDeadLetterConfigFactoryExtensions
{
}
