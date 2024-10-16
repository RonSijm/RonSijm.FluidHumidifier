// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECR;

public class ReplicationConfigurationFactory(string resourceName = null, Action<Humidifier.ECR.ReplicationConfiguration> factoryAction = null) : ResourceFactory<Humidifier.ECR.ReplicationConfiguration>(resourceName)
{

    internal InnerReplicationConfigurationReplicationConfigurationFactory ReplicationConfiguration_Factory { get; set; }

    protected override Humidifier.ECR.ReplicationConfiguration Create()
    {
        var replicationConfigurationResult = CreateReplicationConfiguration();
        factoryAction?.Invoke(replicationConfigurationResult);

        return replicationConfigurationResult;
    }

    private Humidifier.ECR.ReplicationConfiguration CreateReplicationConfiguration()
    {
        var replicationConfigurationResult = new Humidifier.ECR.ReplicationConfiguration
        {
            GivenName = InputResourceName,
        };

        return replicationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ECR.ReplicationConfiguration result)
    {
        base.CreateChildren(result);

        result.ReplicationConfiguration_ ??= ReplicationConfiguration_Factory?.Build();
    }

} // End Of Class

public static class ReplicationConfigurationFactoryExtensions
{
    public static CombinedResult<ReplicationConfigurationFactory, InnerReplicationConfigurationReplicationConfigurationFactory> WithReplicationConfiguration_(this ReplicationConfigurationFactory parentFactory, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationConfiguration> subFactoryAction = null)
    {
        parentFactory.ReplicationConfiguration_Factory = new InnerReplicationConfigurationReplicationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ReplicationConfiguration_Factory);
    }

    public static CombinedResult<ReplicationConfigurationFactory, T1, InnerReplicationConfigurationReplicationConfigurationFactory> WithReplicationConfiguration_<T1>(this CombinedResult<ReplicationConfigurationFactory, T1> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithReplicationConfiguration_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicationConfigurationFactory, InnerReplicationConfigurationReplicationConfigurationFactory> WithReplicationConfiguration_<T1>(this CombinedResult<T1, ReplicationConfigurationFactory> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithReplicationConfiguration_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ReplicationConfigurationFactory, T1, T2, InnerReplicationConfigurationReplicationConfigurationFactory> WithReplicationConfiguration_<T1, T2>(this CombinedResult<ReplicationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReplicationConfiguration_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicationConfigurationFactory, T2, InnerReplicationConfigurationReplicationConfigurationFactory> WithReplicationConfiguration_<T1, T2>(this CombinedResult<T1, ReplicationConfigurationFactory, T2> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReplicationConfiguration_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReplicationConfigurationFactory, InnerReplicationConfigurationReplicationConfigurationFactory> WithReplicationConfiguration_<T1, T2>(this CombinedResult<T1, T2, ReplicationConfigurationFactory> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReplicationConfiguration_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ReplicationConfigurationFactory, T1, T2, T3, InnerReplicationConfigurationReplicationConfigurationFactory> WithReplicationConfiguration_<T1, T2, T3>(this CombinedResult<ReplicationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfiguration_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicationConfigurationFactory, T2, T3, InnerReplicationConfigurationReplicationConfigurationFactory> WithReplicationConfiguration_<T1, T2, T3>(this CombinedResult<T1, ReplicationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfiguration_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReplicationConfigurationFactory, T3, InnerReplicationConfigurationReplicationConfigurationFactory> WithReplicationConfiguration_<T1, T2, T3>(this CombinedResult<T1, T2, ReplicationConfigurationFactory, T3> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfiguration_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReplicationConfigurationFactory, InnerReplicationConfigurationReplicationConfigurationFactory> WithReplicationConfiguration_<T1, T2, T3>(this CombinedResult<T1, T2, T3, ReplicationConfigurationFactory> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfiguration_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ReplicationConfigurationFactory, T1, T2, T3, T4, InnerReplicationConfigurationReplicationConfigurationFactory> WithReplicationConfiguration_<T1, T2, T3, T4>(this CombinedResult<ReplicationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfiguration_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicationConfigurationFactory, T2, T3, T4, InnerReplicationConfigurationReplicationConfigurationFactory> WithReplicationConfiguration_<T1, T2, T3, T4>(this CombinedResult<T1, ReplicationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfiguration_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReplicationConfigurationFactory, T3, T4, InnerReplicationConfigurationReplicationConfigurationFactory> WithReplicationConfiguration_<T1, T2, T3, T4>(this CombinedResult<T1, T2, ReplicationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfiguration_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReplicationConfigurationFactory, T4, InnerReplicationConfigurationReplicationConfigurationFactory> WithReplicationConfiguration_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ReplicationConfigurationFactory, T4> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfiguration_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ReplicationConfigurationFactory, InnerReplicationConfigurationReplicationConfigurationFactory> WithReplicationConfiguration_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ReplicationConfigurationFactory> combinedResult, Action<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfiguration_(combinedResult.T5, subFactoryAction));
}
