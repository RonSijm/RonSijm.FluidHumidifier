// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupCustomResponseFactory(Action<Humidifier.WAFv2.RuleGroupTypes.CustomResponse> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.CustomResponse>
{

    protected override Humidifier.WAFv2.RuleGroupTypes.CustomResponse Create()
    {
        var customResponseResult = CreateCustomResponse();
        factoryAction?.Invoke(customResponseResult);

        return customResponseResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.CustomResponse CreateCustomResponse()
    {
        var customResponseResult = new Humidifier.WAFv2.RuleGroupTypes.CustomResponse();

        return customResponseResult;
    }

} // End Of Class

public static class InnerRuleGroupCustomResponseFactoryExtensions
{
}
