// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class ReceiptRuleFactory(string resourceName = null, Action<Humidifier.SES.ReceiptRule> factoryAction = null) : ResourceFactory<Humidifier.SES.ReceiptRule>(resourceName)
{

    internal InnerReceiptRuleRuleFactory RuleFactory { get; set; }

    protected override Humidifier.SES.ReceiptRule Create()
    {
        var receiptRuleResult = CreateReceiptRule();
        factoryAction?.Invoke(receiptRuleResult);

        return receiptRuleResult;
    }

    private Humidifier.SES.ReceiptRule CreateReceiptRule()
    {
        var receiptRuleResult = new Humidifier.SES.ReceiptRule
        {
            GivenName = InputResourceName,
        };

        return receiptRuleResult;
    }
    public override void CreateChildren(Humidifier.SES.ReceiptRule result)
    {
        base.CreateChildren(result);

        result.Rule ??= RuleFactory?.Build();
    }

} // End Of Class

public static class ReceiptRuleFactoryExtensions
{
    public static CombinedResult<ReceiptRuleFactory, InnerReceiptRuleRuleFactory> WithRule(this ReceiptRuleFactory parentFactory, Action<Humidifier.SES.ReceiptRuleTypes.Rule> subFactoryAction = null)
    {
        parentFactory.RuleFactory = new InnerReceiptRuleRuleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RuleFactory);
    }

    public static CombinedResult<ReceiptRuleFactory, T1, InnerReceiptRuleRuleFactory> WithRule<T1>(this CombinedResult<ReceiptRuleFactory, T1> combinedResult, Action<Humidifier.SES.ReceiptRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReceiptRuleFactory, InnerReceiptRuleRuleFactory> WithRule<T1>(this CombinedResult<T1, ReceiptRuleFactory> combinedResult, Action<Humidifier.SES.ReceiptRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ReceiptRuleFactory, T1, T2, InnerReceiptRuleRuleFactory> WithRule<T1, T2>(this CombinedResult<ReceiptRuleFactory, T1, T2> combinedResult, Action<Humidifier.SES.ReceiptRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReceiptRuleFactory, T2, InnerReceiptRuleRuleFactory> WithRule<T1, T2>(this CombinedResult<T1, ReceiptRuleFactory, T2> combinedResult, Action<Humidifier.SES.ReceiptRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReceiptRuleFactory, InnerReceiptRuleRuleFactory> WithRule<T1, T2>(this CombinedResult<T1, T2, ReceiptRuleFactory> combinedResult, Action<Humidifier.SES.ReceiptRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ReceiptRuleFactory, T1, T2, T3, InnerReceiptRuleRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<ReceiptRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.SES.ReceiptRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReceiptRuleFactory, T2, T3, InnerReceiptRuleRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<T1, ReceiptRuleFactory, T2, T3> combinedResult, Action<Humidifier.SES.ReceiptRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReceiptRuleFactory, T3, InnerReceiptRuleRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<T1, T2, ReceiptRuleFactory, T3> combinedResult, Action<Humidifier.SES.ReceiptRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReceiptRuleFactory, InnerReceiptRuleRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<T1, T2, T3, ReceiptRuleFactory> combinedResult, Action<Humidifier.SES.ReceiptRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ReceiptRuleFactory, T1, T2, T3, T4, InnerReceiptRuleRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<ReceiptRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SES.ReceiptRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReceiptRuleFactory, T2, T3, T4, InnerReceiptRuleRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, ReceiptRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.SES.ReceiptRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReceiptRuleFactory, T3, T4, InnerReceiptRuleRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, ReceiptRuleFactory, T3, T4> combinedResult, Action<Humidifier.SES.ReceiptRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReceiptRuleFactory, T4, InnerReceiptRuleRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ReceiptRuleFactory, T4> combinedResult, Action<Humidifier.SES.ReceiptRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ReceiptRuleFactory, InnerReceiptRuleRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ReceiptRuleFactory> combinedResult, Action<Humidifier.SES.ReceiptRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T5, subFactoryAction));
}
