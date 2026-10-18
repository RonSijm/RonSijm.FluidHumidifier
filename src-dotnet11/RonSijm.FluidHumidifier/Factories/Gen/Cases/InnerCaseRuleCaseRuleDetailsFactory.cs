// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cases;

public class InnerCaseRuleCaseRuleDetailsFactory(Action<Humidifier.Cases.CaseRuleTypes.CaseRuleDetails> factoryAction = null) : SubResourceFactory<Humidifier.Cases.CaseRuleTypes.CaseRuleDetails>
{

    internal InnerCaseRuleRequiredCaseRuleFactory RequiredFactory { get; set; }

    internal InnerCaseRuleHiddenCaseRuleFactory HiddenFactory { get; set; }

    protected override Humidifier.Cases.CaseRuleTypes.CaseRuleDetails Create()
    {
        var caseRuleDetailsResult = CreateCaseRuleDetails();
        factoryAction?.Invoke(caseRuleDetailsResult);

        return caseRuleDetailsResult;
    }

    private Humidifier.Cases.CaseRuleTypes.CaseRuleDetails CreateCaseRuleDetails()
    {
        var caseRuleDetailsResult = new Humidifier.Cases.CaseRuleTypes.CaseRuleDetails();

        return caseRuleDetailsResult;
    }
    public override void CreateChildren(Humidifier.Cases.CaseRuleTypes.CaseRuleDetails result)
    {
        base.CreateChildren(result);

        result.Required ??= RequiredFactory?.Build();
        result.Hidden ??= HiddenFactory?.Build();
    }

} // End Of Class

public static class InnerCaseRuleCaseRuleDetailsFactoryExtensions
{
    public static CombinedResult<InnerCaseRuleCaseRuleDetailsFactory, InnerCaseRuleRequiredCaseRuleFactory> WithRequired(this InnerCaseRuleCaseRuleDetailsFactory parentFactory, Action<Humidifier.Cases.CaseRuleTypes.RequiredCaseRule> subFactoryAction = null)
    {
        parentFactory.RequiredFactory = new InnerCaseRuleRequiredCaseRuleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RequiredFactory);
    }

    public static CombinedResult<InnerCaseRuleCaseRuleDetailsFactory, InnerCaseRuleHiddenCaseRuleFactory> WithHidden(this InnerCaseRuleCaseRuleDetailsFactory parentFactory, Action<Humidifier.Cases.CaseRuleTypes.HiddenCaseRule> subFactoryAction = null)
    {
        parentFactory.HiddenFactory = new InnerCaseRuleHiddenCaseRuleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HiddenFactory);
    }

    public static CombinedResult<InnerCaseRuleCaseRuleDetailsFactory, T1, InnerCaseRuleRequiredCaseRuleFactory> WithRequired<T1>(this CombinedResult<InnerCaseRuleCaseRuleDetailsFactory, T1> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.RequiredCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRequired(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCaseRuleCaseRuleDetailsFactory, InnerCaseRuleRequiredCaseRuleFactory> WithRequired<T1>(this CombinedResult<T1, InnerCaseRuleCaseRuleDetailsFactory> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.RequiredCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRequired(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCaseRuleCaseRuleDetailsFactory, T1, T2, InnerCaseRuleRequiredCaseRuleFactory> WithRequired<T1, T2>(this CombinedResult<InnerCaseRuleCaseRuleDetailsFactory, T1, T2> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.RequiredCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRequired(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCaseRuleCaseRuleDetailsFactory, T2, InnerCaseRuleRequiredCaseRuleFactory> WithRequired<T1, T2>(this CombinedResult<T1, InnerCaseRuleCaseRuleDetailsFactory, T2> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.RequiredCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRequired(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCaseRuleCaseRuleDetailsFactory, InnerCaseRuleRequiredCaseRuleFactory> WithRequired<T1, T2>(this CombinedResult<T1, T2, InnerCaseRuleCaseRuleDetailsFactory> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.RequiredCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRequired(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCaseRuleCaseRuleDetailsFactory, T1, T2, T3, InnerCaseRuleRequiredCaseRuleFactory> WithRequired<T1, T2, T3>(this CombinedResult<InnerCaseRuleCaseRuleDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.RequiredCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRequired(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCaseRuleCaseRuleDetailsFactory, T2, T3, InnerCaseRuleRequiredCaseRuleFactory> WithRequired<T1, T2, T3>(this CombinedResult<T1, InnerCaseRuleCaseRuleDetailsFactory, T2, T3> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.RequiredCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRequired(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCaseRuleCaseRuleDetailsFactory, T3, InnerCaseRuleRequiredCaseRuleFactory> WithRequired<T1, T2, T3>(this CombinedResult<T1, T2, InnerCaseRuleCaseRuleDetailsFactory, T3> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.RequiredCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRequired(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCaseRuleCaseRuleDetailsFactory, InnerCaseRuleRequiredCaseRuleFactory> WithRequired<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCaseRuleCaseRuleDetailsFactory> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.RequiredCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRequired(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCaseRuleCaseRuleDetailsFactory, T1, T2, T3, T4, InnerCaseRuleRequiredCaseRuleFactory> WithRequired<T1, T2, T3, T4>(this CombinedResult<InnerCaseRuleCaseRuleDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.RequiredCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRequired(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCaseRuleCaseRuleDetailsFactory, T2, T3, T4, InnerCaseRuleRequiredCaseRuleFactory> WithRequired<T1, T2, T3, T4>(this CombinedResult<T1, InnerCaseRuleCaseRuleDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.RequiredCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRequired(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCaseRuleCaseRuleDetailsFactory, T3, T4, InnerCaseRuleRequiredCaseRuleFactory> WithRequired<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCaseRuleCaseRuleDetailsFactory, T3, T4> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.RequiredCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRequired(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCaseRuleCaseRuleDetailsFactory, T4, InnerCaseRuleRequiredCaseRuleFactory> WithRequired<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCaseRuleCaseRuleDetailsFactory, T4> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.RequiredCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRequired(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCaseRuleCaseRuleDetailsFactory, InnerCaseRuleRequiredCaseRuleFactory> WithRequired<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCaseRuleCaseRuleDetailsFactory> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.RequiredCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRequired(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerCaseRuleCaseRuleDetailsFactory, T1, InnerCaseRuleHiddenCaseRuleFactory> WithHidden<T1>(this CombinedResult<InnerCaseRuleCaseRuleDetailsFactory, T1> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.HiddenCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithHidden(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCaseRuleCaseRuleDetailsFactory, InnerCaseRuleHiddenCaseRuleFactory> WithHidden<T1>(this CombinedResult<T1, InnerCaseRuleCaseRuleDetailsFactory> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.HiddenCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithHidden(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCaseRuleCaseRuleDetailsFactory, T1, T2, InnerCaseRuleHiddenCaseRuleFactory> WithHidden<T1, T2>(this CombinedResult<InnerCaseRuleCaseRuleDetailsFactory, T1, T2> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.HiddenCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHidden(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCaseRuleCaseRuleDetailsFactory, T2, InnerCaseRuleHiddenCaseRuleFactory> WithHidden<T1, T2>(this CombinedResult<T1, InnerCaseRuleCaseRuleDetailsFactory, T2> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.HiddenCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHidden(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCaseRuleCaseRuleDetailsFactory, InnerCaseRuleHiddenCaseRuleFactory> WithHidden<T1, T2>(this CombinedResult<T1, T2, InnerCaseRuleCaseRuleDetailsFactory> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.HiddenCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHidden(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCaseRuleCaseRuleDetailsFactory, T1, T2, T3, InnerCaseRuleHiddenCaseRuleFactory> WithHidden<T1, T2, T3>(this CombinedResult<InnerCaseRuleCaseRuleDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.HiddenCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHidden(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCaseRuleCaseRuleDetailsFactory, T2, T3, InnerCaseRuleHiddenCaseRuleFactory> WithHidden<T1, T2, T3>(this CombinedResult<T1, InnerCaseRuleCaseRuleDetailsFactory, T2, T3> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.HiddenCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHidden(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCaseRuleCaseRuleDetailsFactory, T3, InnerCaseRuleHiddenCaseRuleFactory> WithHidden<T1, T2, T3>(this CombinedResult<T1, T2, InnerCaseRuleCaseRuleDetailsFactory, T3> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.HiddenCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHidden(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCaseRuleCaseRuleDetailsFactory, InnerCaseRuleHiddenCaseRuleFactory> WithHidden<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCaseRuleCaseRuleDetailsFactory> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.HiddenCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHidden(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCaseRuleCaseRuleDetailsFactory, T1, T2, T3, T4, InnerCaseRuleHiddenCaseRuleFactory> WithHidden<T1, T2, T3, T4>(this CombinedResult<InnerCaseRuleCaseRuleDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.HiddenCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHidden(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCaseRuleCaseRuleDetailsFactory, T2, T3, T4, InnerCaseRuleHiddenCaseRuleFactory> WithHidden<T1, T2, T3, T4>(this CombinedResult<T1, InnerCaseRuleCaseRuleDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.HiddenCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHidden(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCaseRuleCaseRuleDetailsFactory, T3, T4, InnerCaseRuleHiddenCaseRuleFactory> WithHidden<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCaseRuleCaseRuleDetailsFactory, T3, T4> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.HiddenCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHidden(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCaseRuleCaseRuleDetailsFactory, T4, InnerCaseRuleHiddenCaseRuleFactory> WithHidden<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCaseRuleCaseRuleDetailsFactory, T4> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.HiddenCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHidden(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCaseRuleCaseRuleDetailsFactory, InnerCaseRuleHiddenCaseRuleFactory> WithHidden<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCaseRuleCaseRuleDetailsFactory> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.HiddenCaseRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHidden(combinedResult.T5, subFactoryAction).T2);
}
