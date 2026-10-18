// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class TransitGatewayPolicyTableEntryFactory(string resourceName = null, Action<Humidifier.EC2.TransitGatewayPolicyTableEntry> factoryAction = null) : ResourceFactory<Humidifier.EC2.TransitGatewayPolicyTableEntry>(resourceName)
{

    internal InnerTransitGatewayPolicyTableEntryTransitGatewayPolicyRuleFactory PolicyRuleFactory { get; set; }

    protected override Humidifier.EC2.TransitGatewayPolicyTableEntry Create()
    {
        var transitGatewayPolicyTableEntryResult = CreateTransitGatewayPolicyTableEntry();
        factoryAction?.Invoke(transitGatewayPolicyTableEntryResult);

        return transitGatewayPolicyTableEntryResult;
    }

    private Humidifier.EC2.TransitGatewayPolicyTableEntry CreateTransitGatewayPolicyTableEntry()
    {
        var transitGatewayPolicyTableEntryResult = new Humidifier.EC2.TransitGatewayPolicyTableEntry
        {
            GivenName = InputResourceName,
        };

        return transitGatewayPolicyTableEntryResult;
    }
    public override void CreateChildren(Humidifier.EC2.TransitGatewayPolicyTableEntry result)
    {
        base.CreateChildren(result);

        result.PolicyRule ??= PolicyRuleFactory?.Build();
    }

} // End Of Class

public static class TransitGatewayPolicyTableEntryFactoryExtensions
{
    public static CombinedResult<TransitGatewayPolicyTableEntryFactory, InnerTransitGatewayPolicyTableEntryTransitGatewayPolicyRuleFactory> WithPolicyRule(this TransitGatewayPolicyTableEntryFactory parentFactory, Action<Humidifier.EC2.TransitGatewayPolicyTableEntryTypes.TransitGatewayPolicyRule> subFactoryAction = null)
    {
        parentFactory.PolicyRuleFactory = new InnerTransitGatewayPolicyTableEntryTransitGatewayPolicyRuleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PolicyRuleFactory);
    }

    public static CombinedResult<TransitGatewayPolicyTableEntryFactory, T1, InnerTransitGatewayPolicyTableEntryTransitGatewayPolicyRuleFactory> WithPolicyRule<T1>(this CombinedResult<TransitGatewayPolicyTableEntryFactory, T1> combinedResult, Action<Humidifier.EC2.TransitGatewayPolicyTableEntryTypes.TransitGatewayPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicyRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TransitGatewayPolicyTableEntryFactory, InnerTransitGatewayPolicyTableEntryTransitGatewayPolicyRuleFactory> WithPolicyRule<T1>(this CombinedResult<T1, TransitGatewayPolicyTableEntryFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayPolicyTableEntryTypes.TransitGatewayPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicyRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TransitGatewayPolicyTableEntryFactory, T1, T2, InnerTransitGatewayPolicyTableEntryTransitGatewayPolicyRuleFactory> WithPolicyRule<T1, T2>(this CombinedResult<TransitGatewayPolicyTableEntryFactory, T1, T2> combinedResult, Action<Humidifier.EC2.TransitGatewayPolicyTableEntryTypes.TransitGatewayPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicyRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TransitGatewayPolicyTableEntryFactory, T2, InnerTransitGatewayPolicyTableEntryTransitGatewayPolicyRuleFactory> WithPolicyRule<T1, T2>(this CombinedResult<T1, TransitGatewayPolicyTableEntryFactory, T2> combinedResult, Action<Humidifier.EC2.TransitGatewayPolicyTableEntryTypes.TransitGatewayPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicyRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TransitGatewayPolicyTableEntryFactory, InnerTransitGatewayPolicyTableEntryTransitGatewayPolicyRuleFactory> WithPolicyRule<T1, T2>(this CombinedResult<T1, T2, TransitGatewayPolicyTableEntryFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayPolicyTableEntryTypes.TransitGatewayPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicyRule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TransitGatewayPolicyTableEntryFactory, T1, T2, T3, InnerTransitGatewayPolicyTableEntryTransitGatewayPolicyRuleFactory> WithPolicyRule<T1, T2, T3>(this CombinedResult<TransitGatewayPolicyTableEntryFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.TransitGatewayPolicyTableEntryTypes.TransitGatewayPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TransitGatewayPolicyTableEntryFactory, T2, T3, InnerTransitGatewayPolicyTableEntryTransitGatewayPolicyRuleFactory> WithPolicyRule<T1, T2, T3>(this CombinedResult<T1, TransitGatewayPolicyTableEntryFactory, T2, T3> combinedResult, Action<Humidifier.EC2.TransitGatewayPolicyTableEntryTypes.TransitGatewayPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TransitGatewayPolicyTableEntryFactory, T3, InnerTransitGatewayPolicyTableEntryTransitGatewayPolicyRuleFactory> WithPolicyRule<T1, T2, T3>(this CombinedResult<T1, T2, TransitGatewayPolicyTableEntryFactory, T3> combinedResult, Action<Humidifier.EC2.TransitGatewayPolicyTableEntryTypes.TransitGatewayPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyRule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TransitGatewayPolicyTableEntryFactory, InnerTransitGatewayPolicyTableEntryTransitGatewayPolicyRuleFactory> WithPolicyRule<T1, T2, T3>(this CombinedResult<T1, T2, T3, TransitGatewayPolicyTableEntryFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayPolicyTableEntryTypes.TransitGatewayPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyRule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TransitGatewayPolicyTableEntryFactory, T1, T2, T3, T4, InnerTransitGatewayPolicyTableEntryTransitGatewayPolicyRuleFactory> WithPolicyRule<T1, T2, T3, T4>(this CombinedResult<TransitGatewayPolicyTableEntryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayPolicyTableEntryTypes.TransitGatewayPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TransitGatewayPolicyTableEntryFactory, T2, T3, T4, InnerTransitGatewayPolicyTableEntryTransitGatewayPolicyRuleFactory> WithPolicyRule<T1, T2, T3, T4>(this CombinedResult<T1, TransitGatewayPolicyTableEntryFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayPolicyTableEntryTypes.TransitGatewayPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TransitGatewayPolicyTableEntryFactory, T3, T4, InnerTransitGatewayPolicyTableEntryTransitGatewayPolicyRuleFactory> WithPolicyRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, TransitGatewayPolicyTableEntryFactory, T3, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayPolicyTableEntryTypes.TransitGatewayPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyRule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TransitGatewayPolicyTableEntryFactory, T4, InnerTransitGatewayPolicyTableEntryTransitGatewayPolicyRuleFactory> WithPolicyRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TransitGatewayPolicyTableEntryFactory, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayPolicyTableEntryTypes.TransitGatewayPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyRule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TransitGatewayPolicyTableEntryFactory, InnerTransitGatewayPolicyTableEntryTransitGatewayPolicyRuleFactory> WithPolicyRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TransitGatewayPolicyTableEntryFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayPolicyTableEntryTypes.TransitGatewayPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyRule(combinedResult.T5, subFactoryAction).T2);
}
