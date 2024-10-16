// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerRuleInputTransformerFactory(Action<Humidifier.Events.RuleTypes.InputTransformer> factoryAction = null) : SubResourceFactory<Humidifier.Events.RuleTypes.InputTransformer>
{

    protected override Humidifier.Events.RuleTypes.InputTransformer Create()
    {
        var inputTransformerResult = CreateInputTransformer();
        factoryAction?.Invoke(inputTransformerResult);

        return inputTransformerResult;
    }

    private Humidifier.Events.RuleTypes.InputTransformer CreateInputTransformer()
    {
        var inputTransformerResult = new Humidifier.Events.RuleTypes.InputTransformer();

        return inputTransformerResult;
    }

} // End Of Class

public static class InnerRuleInputTransformerFactoryExtensions
{
}
