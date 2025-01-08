// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCS;

public class InnerClusterSlurmConfigurationFactory(Action<Humidifier.PCS.ClusterTypes.SlurmConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.PCS.ClusterTypes.SlurmConfiguration>
{

    internal InnerClusterAuthKeyFactory AuthKeyFactory { get; set; }

    protected override Humidifier.PCS.ClusterTypes.SlurmConfiguration Create()
    {
        var slurmConfigurationResult = CreateSlurmConfiguration();
        factoryAction?.Invoke(slurmConfigurationResult);

        return slurmConfigurationResult;
    }

    private Humidifier.PCS.ClusterTypes.SlurmConfiguration CreateSlurmConfiguration()
    {
        var slurmConfigurationResult = new Humidifier.PCS.ClusterTypes.SlurmConfiguration();

        return slurmConfigurationResult;
    }
    public override void CreateChildren(Humidifier.PCS.ClusterTypes.SlurmConfiguration result)
    {
        base.CreateChildren(result);

        result.AuthKey ??= AuthKeyFactory?.Build();
    }

} // End Of Class

public static class InnerClusterSlurmConfigurationFactoryExtensions
{
    public static CombinedResult<InnerClusterSlurmConfigurationFactory, InnerClusterAuthKeyFactory> WithAuthKey(this InnerClusterSlurmConfigurationFactory parentFactory, Action<Humidifier.PCS.ClusterTypes.AuthKey> subFactoryAction = null)
    {
        parentFactory.AuthKeyFactory = new InnerClusterAuthKeyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthKeyFactory);
    }

    public static CombinedResult<InnerClusterSlurmConfigurationFactory, T1, InnerClusterAuthKeyFactory> WithAuthKey<T1>(this CombinedResult<InnerClusterSlurmConfigurationFactory, T1> combinedResult, Action<Humidifier.PCS.ClusterTypes.AuthKey> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthKey(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterSlurmConfigurationFactory, InnerClusterAuthKeyFactory> WithAuthKey<T1>(this CombinedResult<T1, InnerClusterSlurmConfigurationFactory> combinedResult, Action<Humidifier.PCS.ClusterTypes.AuthKey> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthKey(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterSlurmConfigurationFactory, T1, T2, InnerClusterAuthKeyFactory> WithAuthKey<T1, T2>(this CombinedResult<InnerClusterSlurmConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.PCS.ClusterTypes.AuthKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthKey(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterSlurmConfigurationFactory, T2, InnerClusterAuthKeyFactory> WithAuthKey<T1, T2>(this CombinedResult<T1, InnerClusterSlurmConfigurationFactory, T2> combinedResult, Action<Humidifier.PCS.ClusterTypes.AuthKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthKey(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterSlurmConfigurationFactory, InnerClusterAuthKeyFactory> WithAuthKey<T1, T2>(this CombinedResult<T1, T2, InnerClusterSlurmConfigurationFactory> combinedResult, Action<Humidifier.PCS.ClusterTypes.AuthKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthKey(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterSlurmConfigurationFactory, T1, T2, T3, InnerClusterAuthKeyFactory> WithAuthKey<T1, T2, T3>(this CombinedResult<InnerClusterSlurmConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.PCS.ClusterTypes.AuthKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthKey(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterSlurmConfigurationFactory, T2, T3, InnerClusterAuthKeyFactory> WithAuthKey<T1, T2, T3>(this CombinedResult<T1, InnerClusterSlurmConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.PCS.ClusterTypes.AuthKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthKey(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterSlurmConfigurationFactory, T3, InnerClusterAuthKeyFactory> WithAuthKey<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterSlurmConfigurationFactory, T3> combinedResult, Action<Humidifier.PCS.ClusterTypes.AuthKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthKey(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterSlurmConfigurationFactory, InnerClusterAuthKeyFactory> WithAuthKey<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterSlurmConfigurationFactory> combinedResult, Action<Humidifier.PCS.ClusterTypes.AuthKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthKey(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterSlurmConfigurationFactory, T1, T2, T3, T4, InnerClusterAuthKeyFactory> WithAuthKey<T1, T2, T3, T4>(this CombinedResult<InnerClusterSlurmConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PCS.ClusterTypes.AuthKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthKey(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterSlurmConfigurationFactory, T2, T3, T4, InnerClusterAuthKeyFactory> WithAuthKey<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterSlurmConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.PCS.ClusterTypes.AuthKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthKey(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterSlurmConfigurationFactory, T3, T4, InnerClusterAuthKeyFactory> WithAuthKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterSlurmConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.PCS.ClusterTypes.AuthKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthKey(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterSlurmConfigurationFactory, T4, InnerClusterAuthKeyFactory> WithAuthKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterSlurmConfigurationFactory, T4> combinedResult, Action<Humidifier.PCS.ClusterTypes.AuthKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthKey(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterSlurmConfigurationFactory, InnerClusterAuthKeyFactory> WithAuthKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterSlurmConfigurationFactory> combinedResult, Action<Humidifier.PCS.ClusterTypes.AuthKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthKey(combinedResult.T5, subFactoryAction));
}
