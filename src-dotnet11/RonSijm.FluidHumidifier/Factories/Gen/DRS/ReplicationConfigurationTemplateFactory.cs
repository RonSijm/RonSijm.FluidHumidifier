// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DRS;

public class ReplicationConfigurationTemplateFactory(string resourceName = null, Action<Humidifier.DRS.ReplicationConfigurationTemplate> factoryAction = null) : ResourceFactory<Humidifier.DRS.ReplicationConfigurationTemplate>(resourceName)
{

    internal List<InnerReplicationConfigurationTemplatePITPolicyRuleFactory> PitPolicyFactories { get; set; } = [];

    protected override Humidifier.DRS.ReplicationConfigurationTemplate Create()
    {
        var replicationConfigurationTemplateResult = CreateReplicationConfigurationTemplate();
        factoryAction?.Invoke(replicationConfigurationTemplateResult);

        return replicationConfigurationTemplateResult;
    }

    private Humidifier.DRS.ReplicationConfigurationTemplate CreateReplicationConfigurationTemplate()
    {
        var replicationConfigurationTemplateResult = new Humidifier.DRS.ReplicationConfigurationTemplate
        {
            GivenName = InputResourceName,
        };

        return replicationConfigurationTemplateResult;
    }
    public override void CreateChildren(Humidifier.DRS.ReplicationConfigurationTemplate result)
    {
        base.CreateChildren(result);

        result.PitPolicy = PitPolicyFactories.Any() ? PitPolicyFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ReplicationConfigurationTemplateFactoryExtensions
{
    public static CombinedResult<ReplicationConfigurationTemplateFactory, InnerReplicationConfigurationTemplatePITPolicyRuleFactory> WithPitPolicy(this ReplicationConfigurationTemplateFactory parentFactory, Action<Humidifier.DRS.ReplicationConfigurationTemplateTypes.PITPolicyRule> subFactoryAction = null)
    {
        var factory = new InnerReplicationConfigurationTemplatePITPolicyRuleFactory(subFactoryAction);
        parentFactory.PitPolicyFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ReplicationConfigurationTemplateFactory, T1, InnerReplicationConfigurationTemplatePITPolicyRuleFactory> WithPitPolicy<T1>(this CombinedResult<ReplicationConfigurationTemplateFactory, T1> combinedResult, Action<Humidifier.DRS.ReplicationConfigurationTemplateTypes.PITPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithPitPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ReplicationConfigurationTemplateFactory, InnerReplicationConfigurationTemplatePITPolicyRuleFactory> WithPitPolicy<T1>(this CombinedResult<T1, ReplicationConfigurationTemplateFactory> combinedResult, Action<Humidifier.DRS.ReplicationConfigurationTemplateTypes.PITPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithPitPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ReplicationConfigurationTemplateFactory, T1, T2, InnerReplicationConfigurationTemplatePITPolicyRuleFactory> WithPitPolicy<T1, T2>(this CombinedResult<ReplicationConfigurationTemplateFactory, T1, T2> combinedResult, Action<Humidifier.DRS.ReplicationConfigurationTemplateTypes.PITPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPitPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ReplicationConfigurationTemplateFactory, T2, InnerReplicationConfigurationTemplatePITPolicyRuleFactory> WithPitPolicy<T1, T2>(this CombinedResult<T1, ReplicationConfigurationTemplateFactory, T2> combinedResult, Action<Humidifier.DRS.ReplicationConfigurationTemplateTypes.PITPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPitPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ReplicationConfigurationTemplateFactory, InnerReplicationConfigurationTemplatePITPolicyRuleFactory> WithPitPolicy<T1, T2>(this CombinedResult<T1, T2, ReplicationConfigurationTemplateFactory> combinedResult, Action<Humidifier.DRS.ReplicationConfigurationTemplateTypes.PITPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPitPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ReplicationConfigurationTemplateFactory, T1, T2, T3, InnerReplicationConfigurationTemplatePITPolicyRuleFactory> WithPitPolicy<T1, T2, T3>(this CombinedResult<ReplicationConfigurationTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.DRS.ReplicationConfigurationTemplateTypes.PITPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPitPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ReplicationConfigurationTemplateFactory, T2, T3, InnerReplicationConfigurationTemplatePITPolicyRuleFactory> WithPitPolicy<T1, T2, T3>(this CombinedResult<T1, ReplicationConfigurationTemplateFactory, T2, T3> combinedResult, Action<Humidifier.DRS.ReplicationConfigurationTemplateTypes.PITPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPitPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ReplicationConfigurationTemplateFactory, T3, InnerReplicationConfigurationTemplatePITPolicyRuleFactory> WithPitPolicy<T1, T2, T3>(this CombinedResult<T1, T2, ReplicationConfigurationTemplateFactory, T3> combinedResult, Action<Humidifier.DRS.ReplicationConfigurationTemplateTypes.PITPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPitPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ReplicationConfigurationTemplateFactory, InnerReplicationConfigurationTemplatePITPolicyRuleFactory> WithPitPolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, ReplicationConfigurationTemplateFactory> combinedResult, Action<Humidifier.DRS.ReplicationConfigurationTemplateTypes.PITPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPitPolicy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ReplicationConfigurationTemplateFactory, T1, T2, T3, T4, InnerReplicationConfigurationTemplatePITPolicyRuleFactory> WithPitPolicy<T1, T2, T3, T4>(this CombinedResult<ReplicationConfigurationTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DRS.ReplicationConfigurationTemplateTypes.PITPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPitPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ReplicationConfigurationTemplateFactory, T2, T3, T4, InnerReplicationConfigurationTemplatePITPolicyRuleFactory> WithPitPolicy<T1, T2, T3, T4>(this CombinedResult<T1, ReplicationConfigurationTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.DRS.ReplicationConfigurationTemplateTypes.PITPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPitPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ReplicationConfigurationTemplateFactory, T3, T4, InnerReplicationConfigurationTemplatePITPolicyRuleFactory> WithPitPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, ReplicationConfigurationTemplateFactory, T3, T4> combinedResult, Action<Humidifier.DRS.ReplicationConfigurationTemplateTypes.PITPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPitPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ReplicationConfigurationTemplateFactory, T4, InnerReplicationConfigurationTemplatePITPolicyRuleFactory> WithPitPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ReplicationConfigurationTemplateFactory, T4> combinedResult, Action<Humidifier.DRS.ReplicationConfigurationTemplateTypes.PITPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPitPolicy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ReplicationConfigurationTemplateFactory, InnerReplicationConfigurationTemplatePITPolicyRuleFactory> WithPitPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ReplicationConfigurationTemplateFactory> combinedResult, Action<Humidifier.DRS.ReplicationConfigurationTemplateTypes.PITPolicyRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPitPolicy(combinedResult.T5, subFactoryAction).T2);
}
