// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECR;

public class InnerReplicationConfigurationReplicationRuleFactory(Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationRule> factoryAction = null) : SubResourceFactory<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationRule>
{

    protected override Humidifier.ECR.ReplicationConfigurationTypes.ReplicationRule Create()
    {
        var replicationRuleResult = CreateReplicationRule();
        factoryAction?.Invoke(replicationRuleResult);

        return replicationRuleResult;
    }

    private Humidifier.ECR.ReplicationConfigurationTypes.ReplicationRule CreateReplicationRule()
    {
        var replicationRuleResult = new Humidifier.ECR.ReplicationConfigurationTypes.ReplicationRule();

        return replicationRuleResult;
    }

} // End Of Class

public static class InnerReplicationConfigurationReplicationRuleFactoryExtensions
{
}
