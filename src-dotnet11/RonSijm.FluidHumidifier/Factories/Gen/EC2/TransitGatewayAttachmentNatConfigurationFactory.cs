// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class TransitGatewayAttachmentNatConfigurationFactory(string resourceName = null, Action<Humidifier.EC2.TransitGatewayAttachmentNatConfiguration> factoryAction = null) : ResourceFactory<Humidifier.EC2.TransitGatewayAttachmentNatConfiguration>(resourceName)
{

    internal List<InnerTransitGatewayAttachmentNatConfigurationNatRuleFactory> NatGatewayRulesFactories { get; set; } = [];

    protected override Humidifier.EC2.TransitGatewayAttachmentNatConfiguration Create()
    {
        var transitGatewayAttachmentNatConfigurationResult = CreateTransitGatewayAttachmentNatConfiguration();
        factoryAction?.Invoke(transitGatewayAttachmentNatConfigurationResult);

        return transitGatewayAttachmentNatConfigurationResult;
    }

    private Humidifier.EC2.TransitGatewayAttachmentNatConfiguration CreateTransitGatewayAttachmentNatConfiguration()
    {
        var transitGatewayAttachmentNatConfigurationResult = new Humidifier.EC2.TransitGatewayAttachmentNatConfiguration
        {
            GivenName = InputResourceName,
        };

        return transitGatewayAttachmentNatConfigurationResult;
    }
    public override void CreateChildren(Humidifier.EC2.TransitGatewayAttachmentNatConfiguration result)
    {
        base.CreateChildren(result);

        result.NatGatewayRules = NatGatewayRulesFactories.Any() ? NatGatewayRulesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class TransitGatewayAttachmentNatConfigurationFactoryExtensions
{
    public static CombinedResult<TransitGatewayAttachmentNatConfigurationFactory, InnerTransitGatewayAttachmentNatConfigurationNatRuleFactory> WithNatGatewayRules(this TransitGatewayAttachmentNatConfigurationFactory parentFactory, Action<Humidifier.EC2.TransitGatewayAttachmentNatConfigurationTypes.NatRule> subFactoryAction = null)
    {
        var factory = new InnerTransitGatewayAttachmentNatConfigurationNatRuleFactory(subFactoryAction);
        parentFactory.NatGatewayRulesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TransitGatewayAttachmentNatConfigurationFactory, T1, InnerTransitGatewayAttachmentNatConfigurationNatRuleFactory> WithNatGatewayRules<T1>(this CombinedResult<TransitGatewayAttachmentNatConfigurationFactory, T1> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentNatConfigurationTypes.NatRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithNatGatewayRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TransitGatewayAttachmentNatConfigurationFactory, InnerTransitGatewayAttachmentNatConfigurationNatRuleFactory> WithNatGatewayRules<T1>(this CombinedResult<T1, TransitGatewayAttachmentNatConfigurationFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentNatConfigurationTypes.NatRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithNatGatewayRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TransitGatewayAttachmentNatConfigurationFactory, T1, T2, InnerTransitGatewayAttachmentNatConfigurationNatRuleFactory> WithNatGatewayRules<T1, T2>(this CombinedResult<TransitGatewayAttachmentNatConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentNatConfigurationTypes.NatRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNatGatewayRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TransitGatewayAttachmentNatConfigurationFactory, T2, InnerTransitGatewayAttachmentNatConfigurationNatRuleFactory> WithNatGatewayRules<T1, T2>(this CombinedResult<T1, TransitGatewayAttachmentNatConfigurationFactory, T2> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentNatConfigurationTypes.NatRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNatGatewayRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TransitGatewayAttachmentNatConfigurationFactory, InnerTransitGatewayAttachmentNatConfigurationNatRuleFactory> WithNatGatewayRules<T1, T2>(this CombinedResult<T1, T2, TransitGatewayAttachmentNatConfigurationFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentNatConfigurationTypes.NatRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNatGatewayRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TransitGatewayAttachmentNatConfigurationFactory, T1, T2, T3, InnerTransitGatewayAttachmentNatConfigurationNatRuleFactory> WithNatGatewayRules<T1, T2, T3>(this CombinedResult<TransitGatewayAttachmentNatConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentNatConfigurationTypes.NatRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNatGatewayRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TransitGatewayAttachmentNatConfigurationFactory, T2, T3, InnerTransitGatewayAttachmentNatConfigurationNatRuleFactory> WithNatGatewayRules<T1, T2, T3>(this CombinedResult<T1, TransitGatewayAttachmentNatConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentNatConfigurationTypes.NatRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNatGatewayRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TransitGatewayAttachmentNatConfigurationFactory, T3, InnerTransitGatewayAttachmentNatConfigurationNatRuleFactory> WithNatGatewayRules<T1, T2, T3>(this CombinedResult<T1, T2, TransitGatewayAttachmentNatConfigurationFactory, T3> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentNatConfigurationTypes.NatRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNatGatewayRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TransitGatewayAttachmentNatConfigurationFactory, InnerTransitGatewayAttachmentNatConfigurationNatRuleFactory> WithNatGatewayRules<T1, T2, T3>(this CombinedResult<T1, T2, T3, TransitGatewayAttachmentNatConfigurationFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentNatConfigurationTypes.NatRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNatGatewayRules(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TransitGatewayAttachmentNatConfigurationFactory, T1, T2, T3, T4, InnerTransitGatewayAttachmentNatConfigurationNatRuleFactory> WithNatGatewayRules<T1, T2, T3, T4>(this CombinedResult<TransitGatewayAttachmentNatConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentNatConfigurationTypes.NatRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNatGatewayRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TransitGatewayAttachmentNatConfigurationFactory, T2, T3, T4, InnerTransitGatewayAttachmentNatConfigurationNatRuleFactory> WithNatGatewayRules<T1, T2, T3, T4>(this CombinedResult<T1, TransitGatewayAttachmentNatConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentNatConfigurationTypes.NatRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNatGatewayRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TransitGatewayAttachmentNatConfigurationFactory, T3, T4, InnerTransitGatewayAttachmentNatConfigurationNatRuleFactory> WithNatGatewayRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, TransitGatewayAttachmentNatConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentNatConfigurationTypes.NatRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNatGatewayRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TransitGatewayAttachmentNatConfigurationFactory, T4, InnerTransitGatewayAttachmentNatConfigurationNatRuleFactory> WithNatGatewayRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TransitGatewayAttachmentNatConfigurationFactory, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentNatConfigurationTypes.NatRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNatGatewayRules(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TransitGatewayAttachmentNatConfigurationFactory, InnerTransitGatewayAttachmentNatConfigurationNatRuleFactory> WithNatGatewayRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TransitGatewayAttachmentNatConfigurationFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentNatConfigurationTypes.NatRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNatGatewayRules(combinedResult.T5, subFactoryAction).T2);
}
