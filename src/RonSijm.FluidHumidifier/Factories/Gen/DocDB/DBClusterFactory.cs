// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DocDB;

public class DBClusterFactory(string resourceName = null, Action<Humidifier.DocDB.DBCluster> factoryAction = null) : ResourceFactory<Humidifier.DocDB.DBCluster>(resourceName)
{

    internal InnerDBClusterServerlessV2ScalingConfigurationFactory ServerlessV2ScalingConfigurationFactory { get; set; }

    protected override Humidifier.DocDB.DBCluster Create()
    {
        var dBClusterResult = CreateDBCluster();
        factoryAction?.Invoke(dBClusterResult);

        return dBClusterResult;
    }

    private Humidifier.DocDB.DBCluster CreateDBCluster()
    {
        var dBClusterResult = new Humidifier.DocDB.DBCluster
        {
            GivenName = InputResourceName,
        };

        return dBClusterResult;
    }
    public override void CreateChildren(Humidifier.DocDB.DBCluster result)
    {
        base.CreateChildren(result);

        result.ServerlessV2ScalingConfiguration ??= ServerlessV2ScalingConfigurationFactory?.Build();
    }

} // End Of Class

public static class DBClusterFactoryExtensions
{
    public static CombinedResult<DBClusterFactory, InnerDBClusterServerlessV2ScalingConfigurationFactory> WithServerlessV2ScalingConfiguration(this DBClusterFactory parentFactory, Action<Humidifier.DocDB.DBClusterTypes.ServerlessV2ScalingConfiguration> subFactoryAction = null)
    {
        parentFactory.ServerlessV2ScalingConfigurationFactory = new InnerDBClusterServerlessV2ScalingConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ServerlessV2ScalingConfigurationFactory);
    }

    public static CombinedResult<DBClusterFactory, T1, InnerDBClusterServerlessV2ScalingConfigurationFactory> WithServerlessV2ScalingConfiguration<T1>(this CombinedResult<DBClusterFactory, T1> combinedResult, Action<Humidifier.DocDB.DBClusterTypes.ServerlessV2ScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithServerlessV2ScalingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBClusterFactory, InnerDBClusterServerlessV2ScalingConfigurationFactory> WithServerlessV2ScalingConfiguration<T1>(this CombinedResult<T1, DBClusterFactory> combinedResult, Action<Humidifier.DocDB.DBClusterTypes.ServerlessV2ScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithServerlessV2ScalingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DBClusterFactory, T1, T2, InnerDBClusterServerlessV2ScalingConfigurationFactory> WithServerlessV2ScalingConfiguration<T1, T2>(this CombinedResult<DBClusterFactory, T1, T2> combinedResult, Action<Humidifier.DocDB.DBClusterTypes.ServerlessV2ScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerlessV2ScalingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBClusterFactory, T2, InnerDBClusterServerlessV2ScalingConfigurationFactory> WithServerlessV2ScalingConfiguration<T1, T2>(this CombinedResult<T1, DBClusterFactory, T2> combinedResult, Action<Humidifier.DocDB.DBClusterTypes.ServerlessV2ScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerlessV2ScalingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DBClusterFactory, InnerDBClusterServerlessV2ScalingConfigurationFactory> WithServerlessV2ScalingConfiguration<T1, T2>(this CombinedResult<T1, T2, DBClusterFactory> combinedResult, Action<Humidifier.DocDB.DBClusterTypes.ServerlessV2ScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerlessV2ScalingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DBClusterFactory, T1, T2, T3, InnerDBClusterServerlessV2ScalingConfigurationFactory> WithServerlessV2ScalingConfiguration<T1, T2, T3>(this CombinedResult<DBClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.DocDB.DBClusterTypes.ServerlessV2ScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessV2ScalingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBClusterFactory, T2, T3, InnerDBClusterServerlessV2ScalingConfigurationFactory> WithServerlessV2ScalingConfiguration<T1, T2, T3>(this CombinedResult<T1, DBClusterFactory, T2, T3> combinedResult, Action<Humidifier.DocDB.DBClusterTypes.ServerlessV2ScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessV2ScalingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DBClusterFactory, T3, InnerDBClusterServerlessV2ScalingConfigurationFactory> WithServerlessV2ScalingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, DBClusterFactory, T3> combinedResult, Action<Humidifier.DocDB.DBClusterTypes.ServerlessV2ScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessV2ScalingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DBClusterFactory, InnerDBClusterServerlessV2ScalingConfigurationFactory> WithServerlessV2ScalingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, DBClusterFactory> combinedResult, Action<Humidifier.DocDB.DBClusterTypes.ServerlessV2ScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessV2ScalingConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DBClusterFactory, T1, T2, T3, T4, InnerDBClusterServerlessV2ScalingConfigurationFactory> WithServerlessV2ScalingConfiguration<T1, T2, T3, T4>(this CombinedResult<DBClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DocDB.DBClusterTypes.ServerlessV2ScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessV2ScalingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBClusterFactory, T2, T3, T4, InnerDBClusterServerlessV2ScalingConfigurationFactory> WithServerlessV2ScalingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, DBClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.DocDB.DBClusterTypes.ServerlessV2ScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessV2ScalingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DBClusterFactory, T3, T4, InnerDBClusterServerlessV2ScalingConfigurationFactory> WithServerlessV2ScalingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, DBClusterFactory, T3, T4> combinedResult, Action<Humidifier.DocDB.DBClusterTypes.ServerlessV2ScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessV2ScalingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DBClusterFactory, T4, InnerDBClusterServerlessV2ScalingConfigurationFactory> WithServerlessV2ScalingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DBClusterFactory, T4> combinedResult, Action<Humidifier.DocDB.DBClusterTypes.ServerlessV2ScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessV2ScalingConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DBClusterFactory, InnerDBClusterServerlessV2ScalingConfigurationFactory> WithServerlessV2ScalingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DBClusterFactory> combinedResult, Action<Humidifier.DocDB.DBClusterTypes.ServerlessV2ScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessV2ScalingConfiguration(combinedResult.T5, subFactoryAction));
}
