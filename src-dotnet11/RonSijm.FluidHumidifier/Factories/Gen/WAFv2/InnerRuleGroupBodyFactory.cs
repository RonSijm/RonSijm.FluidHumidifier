// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupBodyFactory(Action<Humidifier.WAFv2.RuleGroupTypes.Body> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.Body>
{

    protected override Humidifier.WAFv2.RuleGroupTypes.Body Create()
    {
        var bodyResult = CreateBody();
        factoryAction?.Invoke(bodyResult);

        return bodyResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.Body CreateBody()
    {
        var bodyResult = new Humidifier.WAFv2.RuleGroupTypes.Body();

        return bodyResult;
    }

} // End Of Class

public static class InnerRuleGroupBodyFactoryExtensions
{
}
