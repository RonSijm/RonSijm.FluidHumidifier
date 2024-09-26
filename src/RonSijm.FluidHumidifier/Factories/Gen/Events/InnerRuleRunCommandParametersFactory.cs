// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerRuleRunCommandParametersFactory(Action<Humidifier.Events.RuleTypes.RunCommandParameters> factoryAction = null) : SubResourceFactory<Humidifier.Events.RuleTypes.RunCommandParameters>
{

    protected override Humidifier.Events.RuleTypes.RunCommandParameters Create()
    {
        var runCommandParametersResult = CreateRunCommandParameters();
        factoryAction?.Invoke(runCommandParametersResult);

        return runCommandParametersResult;
    }

    private Humidifier.Events.RuleTypes.RunCommandParameters CreateRunCommandParameters()
    {
        var runCommandParametersResult = new Humidifier.Events.RuleTypes.RunCommandParameters();

        return runCommandParametersResult;
    }

} // End Of Class

public static class InnerRuleRunCommandParametersFactoryExtensions
{
}
