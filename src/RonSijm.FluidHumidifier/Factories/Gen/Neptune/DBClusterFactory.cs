// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Neptune;

public class DBClusterFactory(string resourceName = null, Action<Humidifier.Neptune.DBCluster> factoryAction = null) : ResourceFactory<Humidifier.Neptune.DBCluster>(resourceName)
{

    internal List<InnerDBClusterDBClusterRoleFactory> AssociatedRolesFactories { get; set; } = [];

    internal InnerDBClusterServerlessScalingConfigurationFactory ServerlessScalingConfigurationFactory { get; set; }

    protected override Humidifier.Neptune.DBCluster Create()
    {
        var dBClusterResult = CreateDBCluster();
        factoryAction?.Invoke(dBClusterResult);

        return dBClusterResult;
    }

    private Humidifier.Neptune.DBCluster CreateDBCluster()
    {
        var dBClusterResult = new Humidifier.Neptune.DBCluster
        {
            GivenName = InputResourceName,
        };

        return dBClusterResult;
    }
    public override void CreateChildren(Humidifier.Neptune.DBCluster result)
    {
        base.CreateChildren(result);

        result.AssociatedRoles = AssociatedRolesFactories.Any() ? AssociatedRolesFactories.Select(x => x.Build()).ToList() : null;
        result.ServerlessScalingConfiguration ??= ServerlessScalingConfigurationFactory?.Build();
    }

} // End Of Class

public static class DBClusterFactoryExtensions
{
    public static CombinedResult<DBClusterFactory, InnerDBClusterDBClusterRoleFactory> WithAssociatedRoles(this DBClusterFactory parentFactory, Action<Humidifier.Neptune.DBClusterTypes.DBClusterRole> subFactoryAction = null)
    {
        var factory = new InnerDBClusterDBClusterRoleFactory(subFactoryAction);
        parentFactory.AssociatedRolesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DBClusterFactory, InnerDBClusterServerlessScalingConfigurationFactory> WithServerlessScalingConfiguration(this DBClusterFactory parentFactory, Action<Humidifier.Neptune.DBClusterTypes.ServerlessScalingConfiguration> subFactoryAction = null)
    {
        parentFactory.ServerlessScalingConfigurationFactory = new InnerDBClusterServerlessScalingConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ServerlessScalingConfigurationFactory);
    }

    public static CombinedResult<DBClusterFactory, T1, InnerDBClusterDBClusterRoleFactory> WithAssociatedRoles<T1>(this CombinedResult<DBClusterFactory, T1> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.DBClusterRole> subFactoryAction = null) => new (combinedResult, combinedResult, WithAssociatedRoles(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBClusterFactory, InnerDBClusterDBClusterRoleFactory> WithAssociatedRoles<T1>(this CombinedResult<T1, DBClusterFactory> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.DBClusterRole> subFactoryAction = null) => new (combinedResult, combinedResult, WithAssociatedRoles(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DBClusterFactory, T1, T2, InnerDBClusterDBClusterRoleFactory> WithAssociatedRoles<T1, T2>(this CombinedResult<DBClusterFactory, T1, T2> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.DBClusterRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssociatedRoles(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBClusterFactory, T2, InnerDBClusterDBClusterRoleFactory> WithAssociatedRoles<T1, T2>(this CombinedResult<T1, DBClusterFactory, T2> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.DBClusterRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssociatedRoles(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DBClusterFactory, InnerDBClusterDBClusterRoleFactory> WithAssociatedRoles<T1, T2>(this CombinedResult<T1, T2, DBClusterFactory> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.DBClusterRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssociatedRoles(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DBClusterFactory, T1, T2, T3, InnerDBClusterDBClusterRoleFactory> WithAssociatedRoles<T1, T2, T3>(this CombinedResult<DBClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.DBClusterRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedRoles(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBClusterFactory, T2, T3, InnerDBClusterDBClusterRoleFactory> WithAssociatedRoles<T1, T2, T3>(this CombinedResult<T1, DBClusterFactory, T2, T3> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.DBClusterRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedRoles(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DBClusterFactory, T3, InnerDBClusterDBClusterRoleFactory> WithAssociatedRoles<T1, T2, T3>(this CombinedResult<T1, T2, DBClusterFactory, T3> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.DBClusterRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedRoles(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DBClusterFactory, InnerDBClusterDBClusterRoleFactory> WithAssociatedRoles<T1, T2, T3>(this CombinedResult<T1, T2, T3, DBClusterFactory> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.DBClusterRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedRoles(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DBClusterFactory, T1, T2, T3, T4, InnerDBClusterDBClusterRoleFactory> WithAssociatedRoles<T1, T2, T3, T4>(this CombinedResult<DBClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.DBClusterRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedRoles(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBClusterFactory, T2, T3, T4, InnerDBClusterDBClusterRoleFactory> WithAssociatedRoles<T1, T2, T3, T4>(this CombinedResult<T1, DBClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.DBClusterRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedRoles(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DBClusterFactory, T3, T4, InnerDBClusterDBClusterRoleFactory> WithAssociatedRoles<T1, T2, T3, T4>(this CombinedResult<T1, T2, DBClusterFactory, T3, T4> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.DBClusterRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedRoles(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DBClusterFactory, T4, InnerDBClusterDBClusterRoleFactory> WithAssociatedRoles<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DBClusterFactory, T4> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.DBClusterRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedRoles(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DBClusterFactory, InnerDBClusterDBClusterRoleFactory> WithAssociatedRoles<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DBClusterFactory> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.DBClusterRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedRoles(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DBClusterFactory, T1, InnerDBClusterServerlessScalingConfigurationFactory> WithServerlessScalingConfiguration<T1>(this CombinedResult<DBClusterFactory, T1> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.ServerlessScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithServerlessScalingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBClusterFactory, InnerDBClusterServerlessScalingConfigurationFactory> WithServerlessScalingConfiguration<T1>(this CombinedResult<T1, DBClusterFactory> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.ServerlessScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithServerlessScalingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DBClusterFactory, T1, T2, InnerDBClusterServerlessScalingConfigurationFactory> WithServerlessScalingConfiguration<T1, T2>(this CombinedResult<DBClusterFactory, T1, T2> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.ServerlessScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerlessScalingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBClusterFactory, T2, InnerDBClusterServerlessScalingConfigurationFactory> WithServerlessScalingConfiguration<T1, T2>(this CombinedResult<T1, DBClusterFactory, T2> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.ServerlessScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerlessScalingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DBClusterFactory, InnerDBClusterServerlessScalingConfigurationFactory> WithServerlessScalingConfiguration<T1, T2>(this CombinedResult<T1, T2, DBClusterFactory> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.ServerlessScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerlessScalingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DBClusterFactory, T1, T2, T3, InnerDBClusterServerlessScalingConfigurationFactory> WithServerlessScalingConfiguration<T1, T2, T3>(this CombinedResult<DBClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.ServerlessScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessScalingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBClusterFactory, T2, T3, InnerDBClusterServerlessScalingConfigurationFactory> WithServerlessScalingConfiguration<T1, T2, T3>(this CombinedResult<T1, DBClusterFactory, T2, T3> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.ServerlessScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessScalingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DBClusterFactory, T3, InnerDBClusterServerlessScalingConfigurationFactory> WithServerlessScalingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, DBClusterFactory, T3> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.ServerlessScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessScalingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DBClusterFactory, InnerDBClusterServerlessScalingConfigurationFactory> WithServerlessScalingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, DBClusterFactory> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.ServerlessScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessScalingConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DBClusterFactory, T1, T2, T3, T4, InnerDBClusterServerlessScalingConfigurationFactory> WithServerlessScalingConfiguration<T1, T2, T3, T4>(this CombinedResult<DBClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.ServerlessScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessScalingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBClusterFactory, T2, T3, T4, InnerDBClusterServerlessScalingConfigurationFactory> WithServerlessScalingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, DBClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.ServerlessScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessScalingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DBClusterFactory, T3, T4, InnerDBClusterServerlessScalingConfigurationFactory> WithServerlessScalingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, DBClusterFactory, T3, T4> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.ServerlessScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessScalingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DBClusterFactory, T4, InnerDBClusterServerlessScalingConfigurationFactory> WithServerlessScalingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DBClusterFactory, T4> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.ServerlessScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessScalingConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DBClusterFactory, InnerDBClusterServerlessScalingConfigurationFactory> WithServerlessScalingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DBClusterFactory> combinedResult, Action<Humidifier.Neptune.DBClusterTypes.ServerlessScalingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessScalingConfiguration(combinedResult.T5, subFactoryAction));
}
