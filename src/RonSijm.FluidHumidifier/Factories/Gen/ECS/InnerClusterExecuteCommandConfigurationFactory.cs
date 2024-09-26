// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerClusterExecuteCommandConfigurationFactory(Action<Humidifier.ECS.ClusterTypes.ExecuteCommandConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ClusterTypes.ExecuteCommandConfiguration>
{

    internal InnerClusterExecuteCommandLogConfigurationFactory LogConfigurationFactory { get; set; }

    protected override Humidifier.ECS.ClusterTypes.ExecuteCommandConfiguration Create()
    {
        var executeCommandConfigurationResult = CreateExecuteCommandConfiguration();
        factoryAction?.Invoke(executeCommandConfigurationResult);

        return executeCommandConfigurationResult;
    }

    private Humidifier.ECS.ClusterTypes.ExecuteCommandConfiguration CreateExecuteCommandConfiguration()
    {
        var executeCommandConfigurationResult = new Humidifier.ECS.ClusterTypes.ExecuteCommandConfiguration();

        return executeCommandConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ECS.ClusterTypes.ExecuteCommandConfiguration result)
    {
        base.CreateChildren(result);

        result.LogConfiguration ??= LogConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerClusterExecuteCommandConfigurationFactoryExtensions
{
    public static CombinedResult<InnerClusterExecuteCommandConfigurationFactory, InnerClusterExecuteCommandLogConfigurationFactory> WithLogConfiguration(this InnerClusterExecuteCommandConfigurationFactory parentFactory, Action<Humidifier.ECS.ClusterTypes.ExecuteCommandLogConfiguration> subFactoryAction = null)
    {
        parentFactory.LogConfigurationFactory = new InnerClusterExecuteCommandLogConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LogConfigurationFactory);
    }

    public static CombinedResult<InnerClusterExecuteCommandConfigurationFactory, T1, InnerClusterExecuteCommandLogConfigurationFactory> WithLogConfiguration<T1>(this CombinedResult<InnerClusterExecuteCommandConfigurationFactory, T1> combinedResult, Action<Humidifier.ECS.ClusterTypes.ExecuteCommandLogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterExecuteCommandConfigurationFactory, InnerClusterExecuteCommandLogConfigurationFactory> WithLogConfiguration<T1>(this CombinedResult<T1, InnerClusterExecuteCommandConfigurationFactory> combinedResult, Action<Humidifier.ECS.ClusterTypes.ExecuteCommandLogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterExecuteCommandConfigurationFactory, T1, T2, InnerClusterExecuteCommandLogConfigurationFactory> WithLogConfiguration<T1, T2>(this CombinedResult<InnerClusterExecuteCommandConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ECS.ClusterTypes.ExecuteCommandLogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterExecuteCommandConfigurationFactory, T2, InnerClusterExecuteCommandLogConfigurationFactory> WithLogConfiguration<T1, T2>(this CombinedResult<T1, InnerClusterExecuteCommandConfigurationFactory, T2> combinedResult, Action<Humidifier.ECS.ClusterTypes.ExecuteCommandLogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterExecuteCommandConfigurationFactory, InnerClusterExecuteCommandLogConfigurationFactory> WithLogConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerClusterExecuteCommandConfigurationFactory> combinedResult, Action<Humidifier.ECS.ClusterTypes.ExecuteCommandLogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterExecuteCommandConfigurationFactory, T1, T2, T3, InnerClusterExecuteCommandLogConfigurationFactory> WithLogConfiguration<T1, T2, T3>(this CombinedResult<InnerClusterExecuteCommandConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.ClusterTypes.ExecuteCommandLogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterExecuteCommandConfigurationFactory, T2, T3, InnerClusterExecuteCommandLogConfigurationFactory> WithLogConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerClusterExecuteCommandConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ECS.ClusterTypes.ExecuteCommandLogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterExecuteCommandConfigurationFactory, T3, InnerClusterExecuteCommandLogConfigurationFactory> WithLogConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterExecuteCommandConfigurationFactory, T3> combinedResult, Action<Humidifier.ECS.ClusterTypes.ExecuteCommandLogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterExecuteCommandConfigurationFactory, InnerClusterExecuteCommandLogConfigurationFactory> WithLogConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterExecuteCommandConfigurationFactory> combinedResult, Action<Humidifier.ECS.ClusterTypes.ExecuteCommandLogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterExecuteCommandConfigurationFactory, T1, T2, T3, T4, InnerClusterExecuteCommandLogConfigurationFactory> WithLogConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerClusterExecuteCommandConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ClusterTypes.ExecuteCommandLogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterExecuteCommandConfigurationFactory, T2, T3, T4, InnerClusterExecuteCommandLogConfigurationFactory> WithLogConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterExecuteCommandConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ClusterTypes.ExecuteCommandLogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterExecuteCommandConfigurationFactory, T3, T4, InnerClusterExecuteCommandLogConfigurationFactory> WithLogConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterExecuteCommandConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ECS.ClusterTypes.ExecuteCommandLogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterExecuteCommandConfigurationFactory, T4, InnerClusterExecuteCommandLogConfigurationFactory> WithLogConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterExecuteCommandConfigurationFactory, T4> combinedResult, Action<Humidifier.ECS.ClusterTypes.ExecuteCommandLogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterExecuteCommandConfigurationFactory, InnerClusterExecuteCommandLogConfigurationFactory> WithLogConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterExecuteCommandConfigurationFactory> combinedResult, Action<Humidifier.ECS.ClusterTypes.ExecuteCommandLogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T5, subFactoryAction));
}
