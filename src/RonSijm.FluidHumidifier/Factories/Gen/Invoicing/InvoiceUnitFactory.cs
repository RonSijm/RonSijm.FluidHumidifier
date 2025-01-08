// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Invoicing;

public class InvoiceUnitFactory(string resourceName = null, Action<Humidifier.Invoicing.InvoiceUnit> factoryAction = null) : ResourceFactory<Humidifier.Invoicing.InvoiceUnit>(resourceName)
{

    internal List<InnerInvoiceUnitResourceTagFactory> ResourceTagsFactories { get; set; } = [];

    internal InnerInvoiceUnitRuleFactory RuleFactory { get; set; }

    protected override Humidifier.Invoicing.InvoiceUnit Create()
    {
        var invoiceUnitResult = CreateInvoiceUnit();
        factoryAction?.Invoke(invoiceUnitResult);

        return invoiceUnitResult;
    }

    private Humidifier.Invoicing.InvoiceUnit CreateInvoiceUnit()
    {
        var invoiceUnitResult = new Humidifier.Invoicing.InvoiceUnit
        {
            GivenName = InputResourceName,
        };

        return invoiceUnitResult;
    }
    public override void CreateChildren(Humidifier.Invoicing.InvoiceUnit result)
    {
        base.CreateChildren(result);

        result.ResourceTags = ResourceTagsFactories.Any() ? ResourceTagsFactories.Select(x => x.Build()).ToList() : null;
        result.Rule ??= RuleFactory?.Build();
    }

} // End Of Class

public static class InvoiceUnitFactoryExtensions
{
    public static CombinedResult<InvoiceUnitFactory, InnerInvoiceUnitResourceTagFactory> WithResourceTags(this InvoiceUnitFactory parentFactory, Action<Humidifier.Invoicing.InvoiceUnitTypes.ResourceTag> subFactoryAction = null)
    {
        var factory = new InnerInvoiceUnitResourceTagFactory(subFactoryAction);
        parentFactory.ResourceTagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<InvoiceUnitFactory, InnerInvoiceUnitRuleFactory> WithRule(this InvoiceUnitFactory parentFactory, Action<Humidifier.Invoicing.InvoiceUnitTypes.Rule> subFactoryAction = null)
    {
        parentFactory.RuleFactory = new InnerInvoiceUnitRuleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RuleFactory);
    }

    public static CombinedResult<InvoiceUnitFactory, T1, InnerInvoiceUnitResourceTagFactory> WithResourceTags<T1>(this CombinedResult<InvoiceUnitFactory, T1> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InvoiceUnitFactory, InnerInvoiceUnitResourceTagFactory> WithResourceTags<T1>(this CombinedResult<T1, InvoiceUnitFactory> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InvoiceUnitFactory, T1, T2, InnerInvoiceUnitResourceTagFactory> WithResourceTags<T1, T2>(this CombinedResult<InvoiceUnitFactory, T1, T2> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InvoiceUnitFactory, T2, InnerInvoiceUnitResourceTagFactory> WithResourceTags<T1, T2>(this CombinedResult<T1, InvoiceUnitFactory, T2> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InvoiceUnitFactory, InnerInvoiceUnitResourceTagFactory> WithResourceTags<T1, T2>(this CombinedResult<T1, T2, InvoiceUnitFactory> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InvoiceUnitFactory, T1, T2, T3, InnerInvoiceUnitResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<InvoiceUnitFactory, T1, T2, T3> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InvoiceUnitFactory, T2, T3, InnerInvoiceUnitResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<T1, InvoiceUnitFactory, T2, T3> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InvoiceUnitFactory, T3, InnerInvoiceUnitResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<T1, T2, InvoiceUnitFactory, T3> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InvoiceUnitFactory, InnerInvoiceUnitResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, InvoiceUnitFactory> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InvoiceUnitFactory, T1, T2, T3, T4, InnerInvoiceUnitResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<InvoiceUnitFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InvoiceUnitFactory, T2, T3, T4, InnerInvoiceUnitResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, InvoiceUnitFactory, T2, T3, T4> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InvoiceUnitFactory, T3, T4, InnerInvoiceUnitResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, InvoiceUnitFactory, T3, T4> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InvoiceUnitFactory, T4, InnerInvoiceUnitResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InvoiceUnitFactory, T4> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InvoiceUnitFactory, InnerInvoiceUnitResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InvoiceUnitFactory> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InvoiceUnitFactory, T1, InnerInvoiceUnitRuleFactory> WithRule<T1>(this CombinedResult<InvoiceUnitFactory, T1> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InvoiceUnitFactory, InnerInvoiceUnitRuleFactory> WithRule<T1>(this CombinedResult<T1, InvoiceUnitFactory> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InvoiceUnitFactory, T1, T2, InnerInvoiceUnitRuleFactory> WithRule<T1, T2>(this CombinedResult<InvoiceUnitFactory, T1, T2> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InvoiceUnitFactory, T2, InnerInvoiceUnitRuleFactory> WithRule<T1, T2>(this CombinedResult<T1, InvoiceUnitFactory, T2> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InvoiceUnitFactory, InnerInvoiceUnitRuleFactory> WithRule<T1, T2>(this CombinedResult<T1, T2, InvoiceUnitFactory> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InvoiceUnitFactory, T1, T2, T3, InnerInvoiceUnitRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<InvoiceUnitFactory, T1, T2, T3> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InvoiceUnitFactory, T2, T3, InnerInvoiceUnitRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<T1, InvoiceUnitFactory, T2, T3> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InvoiceUnitFactory, T3, InnerInvoiceUnitRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<T1, T2, InvoiceUnitFactory, T3> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InvoiceUnitFactory, InnerInvoiceUnitRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<T1, T2, T3, InvoiceUnitFactory> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InvoiceUnitFactory, T1, T2, T3, T4, InnerInvoiceUnitRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<InvoiceUnitFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InvoiceUnitFactory, T2, T3, T4, InnerInvoiceUnitRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, InvoiceUnitFactory, T2, T3, T4> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InvoiceUnitFactory, T3, T4, InnerInvoiceUnitRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, InvoiceUnitFactory, T3, T4> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InvoiceUnitFactory, T4, InnerInvoiceUnitRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InvoiceUnitFactory, T4> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InvoiceUnitFactory, InnerInvoiceUnitRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InvoiceUnitFactory> combinedResult, Action<Humidifier.Invoicing.InvoiceUnitTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T5, subFactoryAction));
}
