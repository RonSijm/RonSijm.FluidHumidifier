// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterClusterOrchestratorSlurmConfigFactory(Action<Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorSlurmConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorSlurmConfig>
{

    internal InnerClusterClusterAccountingDatabaseFactory AccountingDatabaseFactory { get; set; }

    protected override Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorSlurmConfig Create()
    {
        var clusterOrchestratorSlurmConfigResult = CreateClusterOrchestratorSlurmConfig();
        factoryAction?.Invoke(clusterOrchestratorSlurmConfigResult);

        return clusterOrchestratorSlurmConfigResult;
    }

    private Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorSlurmConfig CreateClusterOrchestratorSlurmConfig()
    {
        var clusterOrchestratorSlurmConfigResult = new Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorSlurmConfig();

        return clusterOrchestratorSlurmConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorSlurmConfig result)
    {
        base.CreateChildren(result);

        result.AccountingDatabase ??= AccountingDatabaseFactory?.Build();
    }

} // End Of Class

public static class InnerClusterClusterOrchestratorSlurmConfigFactoryExtensions
{
    public static CombinedResult<InnerClusterClusterOrchestratorSlurmConfigFactory, InnerClusterClusterAccountingDatabaseFactory> WithAccountingDatabase(this InnerClusterClusterOrchestratorSlurmConfigFactory parentFactory, Action<Humidifier.SageMaker.ClusterTypes.ClusterAccountingDatabase> subFactoryAction = null)
    {
        parentFactory.AccountingDatabaseFactory = new InnerClusterClusterAccountingDatabaseFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AccountingDatabaseFactory);
    }

    public static CombinedResult<InnerClusterClusterOrchestratorSlurmConfigFactory, T1, InnerClusterClusterAccountingDatabaseFactory> WithAccountingDatabase<T1>(this CombinedResult<InnerClusterClusterOrchestratorSlurmConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterAccountingDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccountingDatabase(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterClusterOrchestratorSlurmConfigFactory, InnerClusterClusterAccountingDatabaseFactory> WithAccountingDatabase<T1>(this CombinedResult<T1, InnerClusterClusterOrchestratorSlurmConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterAccountingDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccountingDatabase(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerClusterClusterOrchestratorSlurmConfigFactory, T1, T2, InnerClusterClusterAccountingDatabaseFactory> WithAccountingDatabase<T1, T2>(this CombinedResult<InnerClusterClusterOrchestratorSlurmConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterAccountingDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccountingDatabase(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterClusterOrchestratorSlurmConfigFactory, T2, InnerClusterClusterAccountingDatabaseFactory> WithAccountingDatabase<T1, T2>(this CombinedResult<T1, InnerClusterClusterOrchestratorSlurmConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterAccountingDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccountingDatabase(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterClusterOrchestratorSlurmConfigFactory, InnerClusterClusterAccountingDatabaseFactory> WithAccountingDatabase<T1, T2>(this CombinedResult<T1, T2, InnerClusterClusterOrchestratorSlurmConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterAccountingDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccountingDatabase(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerClusterClusterOrchestratorSlurmConfigFactory, T1, T2, T3, InnerClusterClusterAccountingDatabaseFactory> WithAccountingDatabase<T1, T2, T3>(this CombinedResult<InnerClusterClusterOrchestratorSlurmConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterAccountingDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccountingDatabase(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterClusterOrchestratorSlurmConfigFactory, T2, T3, InnerClusterClusterAccountingDatabaseFactory> WithAccountingDatabase<T1, T2, T3>(this CombinedResult<T1, InnerClusterClusterOrchestratorSlurmConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterAccountingDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccountingDatabase(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterClusterOrchestratorSlurmConfigFactory, T3, InnerClusterClusterAccountingDatabaseFactory> WithAccountingDatabase<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterClusterOrchestratorSlurmConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterAccountingDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccountingDatabase(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterClusterOrchestratorSlurmConfigFactory, InnerClusterClusterAccountingDatabaseFactory> WithAccountingDatabase<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterClusterOrchestratorSlurmConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterAccountingDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccountingDatabase(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerClusterClusterOrchestratorSlurmConfigFactory, T1, T2, T3, T4, InnerClusterClusterAccountingDatabaseFactory> WithAccountingDatabase<T1, T2, T3, T4>(this CombinedResult<InnerClusterClusterOrchestratorSlurmConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterAccountingDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccountingDatabase(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterClusterOrchestratorSlurmConfigFactory, T2, T3, T4, InnerClusterClusterAccountingDatabaseFactory> WithAccountingDatabase<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterClusterOrchestratorSlurmConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterAccountingDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccountingDatabase(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterClusterOrchestratorSlurmConfigFactory, T3, T4, InnerClusterClusterAccountingDatabaseFactory> WithAccountingDatabase<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterClusterOrchestratorSlurmConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterAccountingDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccountingDatabase(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterClusterOrchestratorSlurmConfigFactory, T4, InnerClusterClusterAccountingDatabaseFactory> WithAccountingDatabase<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterClusterOrchestratorSlurmConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterAccountingDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccountingDatabase(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerClusterClusterOrchestratorSlurmConfigFactory, InnerClusterClusterAccountingDatabaseFactory> WithAccountingDatabase<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterClusterOrchestratorSlurmConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterAccountingDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccountingDatabase(combinedResult.T5, subFactoryAction).T2);
}
