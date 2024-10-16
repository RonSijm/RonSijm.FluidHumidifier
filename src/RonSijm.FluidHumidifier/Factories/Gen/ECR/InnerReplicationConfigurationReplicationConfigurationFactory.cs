// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECR;

public class InnerReplicationConfigurationReplicationConfigurationFactory(Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationConfiguration>
{

    internal List<InnerReplicationConfigurationReplicationRuleFactory> RulesFactories { get; set; } = [];

    protected override Humidifier.ECR.ReplicationConfigurationTypes.ReplicationConfiguration Create()
    {
        var replicationConfigurationResult = CreateReplicationConfiguration();
        factoryAction?.Invoke(replicationConfigurationResult);

        return replicationConfigurationResult;
    }

    private Humidifier.ECR.ReplicationConfigurationTypes.ReplicationConfiguration CreateReplicationConfiguration()
    {
        var replicationConfigurationResult = new Humidifier.ECR.ReplicationConfigurationTypes.ReplicationConfiguration();

        return replicationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ECR.ReplicationConfigurationTypes.ReplicationConfiguration result)
    {
        base.CreateChildren(result);

        result.Rules = RulesFactories.Any() ? RulesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class InnerReplicationConfigurationReplicationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerReplicationConfigurationReplicationConfigurationFactory, InnerReplicationConfigurationReplicationRuleFactory> WithRules(this InnerReplicationConfigurationReplicationConfigurationFactory parentFactory, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationRule> subFactoryAction = null)
    {
        var factory = new InnerReplicationConfigurationReplicationRuleFactory(subFactoryAction);
        parentFactory.RulesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<InnerReplicationConfigurationReplicationConfigurationFactory, T1, InnerReplicationConfigurationReplicationRuleFactory> WithRules<T1>(this CombinedResult<InnerReplicationConfigurationReplicationConfigurationFactory, T1> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicationConfigurationReplicationConfigurationFactory, InnerReplicationConfigurationReplicationRuleFactory> WithRules<T1>(this CombinedResult<T1, InnerReplicationConfigurationReplicationConfigurationFactory> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerReplicationConfigurationReplicationConfigurationFactory, T1, T2, InnerReplicationConfigurationReplicationRuleFactory> WithRules<T1, T2>(this CombinedResult<InnerReplicationConfigurationReplicationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicationConfigurationReplicationConfigurationFactory, T2, InnerReplicationConfigurationReplicationRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, InnerReplicationConfigurationReplicationConfigurationFactory, T2> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReplicationConfigurationReplicationConfigurationFactory, InnerReplicationConfigurationReplicationRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, T2, InnerReplicationConfigurationReplicationConfigurationFactory> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerReplicationConfigurationReplicationConfigurationFactory, T1, T2, T3, InnerReplicationConfigurationReplicationRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<InnerReplicationConfigurationReplicationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicationConfigurationReplicationConfigurationFactory, T2, T3, InnerReplicationConfigurationReplicationRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, InnerReplicationConfigurationReplicationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReplicationConfigurationReplicationConfigurationFactory, T3, InnerReplicationConfigurationReplicationRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, InnerReplicationConfigurationReplicationConfigurationFactory, T3> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerReplicationConfigurationReplicationConfigurationFactory, InnerReplicationConfigurationReplicationRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerReplicationConfigurationReplicationConfigurationFactory> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerReplicationConfigurationReplicationConfigurationFactory, T1, T2, T3, T4, InnerReplicationConfigurationReplicationRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<InnerReplicationConfigurationReplicationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicationConfigurationReplicationConfigurationFactory, T2, T3, T4, InnerReplicationConfigurationReplicationRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, InnerReplicationConfigurationReplicationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReplicationConfigurationReplicationConfigurationFactory, T3, T4, InnerReplicationConfigurationReplicationRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerReplicationConfigurationReplicationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerReplicationConfigurationReplicationConfigurationFactory, T4, InnerReplicationConfigurationReplicationRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerReplicationConfigurationReplicationConfigurationFactory, T4> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerReplicationConfigurationReplicationConfigurationFactory, InnerReplicationConfigurationReplicationRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerReplicationConfigurationReplicationConfigurationFactory> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T5, subFactoryAction));
}
