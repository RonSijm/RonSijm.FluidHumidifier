// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerRuleActionsFactory(Action<Humidifier.Connect.RuleTypes.Actions> factoryAction = null) : SubResourceFactory<Humidifier.Connect.RuleTypes.Actions>
{

    protected override Humidifier.Connect.RuleTypes.Actions Create()
    {
        var actionsResult = CreateActions();
        factoryAction?.Invoke(actionsResult);

        return actionsResult;
    }

    private Humidifier.Connect.RuleTypes.Actions CreateActions()
    {
        var actionsResult = new Humidifier.Connect.RuleTypes.Actions();

        return actionsResult;
    }

} // End Of Class

public static class InnerRuleActionsFactoryExtensions
{
}
