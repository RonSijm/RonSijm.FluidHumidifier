// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerEventBusPolicyConditionFactory(Action<Humidifier.Events.EventBusPolicyTypes.Condition> factoryAction = null) : SubResourceFactory<Humidifier.Events.EventBusPolicyTypes.Condition>
{

    protected override Humidifier.Events.EventBusPolicyTypes.Condition Create()
    {
        var conditionResult = CreateCondition();
        factoryAction?.Invoke(conditionResult);

        return conditionResult;
    }

    private Humidifier.Events.EventBusPolicyTypes.Condition CreateCondition()
    {
        var conditionResult = new Humidifier.Events.EventBusPolicyTypes.Condition();

        return conditionResult;
    }

} // End Of Class

public static class InnerEventBusPolicyConditionFactoryExtensions
{
}
