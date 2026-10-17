// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ODB;

public class CloudAutonomousVmClusterFactory(string resourceName = null, Action<Humidifier.ODB.CloudAutonomousVmCluster> factoryAction = null) : ResourceFactory<Humidifier.ODB.CloudAutonomousVmCluster>(resourceName)
{

    internal List<InnerCloudAutonomousVmClusterIamRoleFactory> IamRolesFactories { get; set; } = [];

    internal InnerCloudAutonomousVmClusterMaintenanceWindowFactory MaintenanceWindowFactory { get; set; }

    protected override Humidifier.ODB.CloudAutonomousVmCluster Create()
    {
        var cloudAutonomousVmClusterResult = CreateCloudAutonomousVmCluster();
        factoryAction?.Invoke(cloudAutonomousVmClusterResult);

        return cloudAutonomousVmClusterResult;
    }

    private Humidifier.ODB.CloudAutonomousVmCluster CreateCloudAutonomousVmCluster()
    {
        var cloudAutonomousVmClusterResult = new Humidifier.ODB.CloudAutonomousVmCluster
        {
            GivenName = InputResourceName,
        };

        return cloudAutonomousVmClusterResult;
    }
    public override void CreateChildren(Humidifier.ODB.CloudAutonomousVmCluster result)
    {
        base.CreateChildren(result);

        result.IamRoles = IamRolesFactories.Any() ? IamRolesFactories.Select(x => x.Build()).ToList() : null;
        result.MaintenanceWindow ??= MaintenanceWindowFactory?.Build();
    }

} // End Of Class

public static class CloudAutonomousVmClusterFactoryExtensions
{
    public static CombinedResult<CloudAutonomousVmClusterFactory, InnerCloudAutonomousVmClusterIamRoleFactory> WithIamRoles(this CloudAutonomousVmClusterFactory parentFactory, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.IamRole> subFactoryAction = null)
    {
        var factory = new InnerCloudAutonomousVmClusterIamRoleFactory(subFactoryAction);
        parentFactory.IamRolesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<CloudAutonomousVmClusterFactory, InnerCloudAutonomousVmClusterMaintenanceWindowFactory> WithMaintenanceWindow(this CloudAutonomousVmClusterFactory parentFactory, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.MaintenanceWindow> subFactoryAction = null)
    {
        parentFactory.MaintenanceWindowFactory = new InnerCloudAutonomousVmClusterMaintenanceWindowFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MaintenanceWindowFactory);
    }

    public static CombinedResult<CloudAutonomousVmClusterFactory, T1, InnerCloudAutonomousVmClusterIamRoleFactory> WithIamRoles<T1>(this CombinedResult<CloudAutonomousVmClusterFactory, T1> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, WithIamRoles(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudAutonomousVmClusterFactory, InnerCloudAutonomousVmClusterIamRoleFactory> WithIamRoles<T1>(this CombinedResult<T1, CloudAutonomousVmClusterFactory> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, WithIamRoles(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CloudAutonomousVmClusterFactory, T1, T2, InnerCloudAutonomousVmClusterIamRoleFactory> WithIamRoles<T1, T2>(this CombinedResult<CloudAutonomousVmClusterFactory, T1, T2> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIamRoles(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudAutonomousVmClusterFactory, T2, InnerCloudAutonomousVmClusterIamRoleFactory> WithIamRoles<T1, T2>(this CombinedResult<T1, CloudAutonomousVmClusterFactory, T2> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIamRoles(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CloudAutonomousVmClusterFactory, InnerCloudAutonomousVmClusterIamRoleFactory> WithIamRoles<T1, T2>(this CombinedResult<T1, T2, CloudAutonomousVmClusterFactory> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIamRoles(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CloudAutonomousVmClusterFactory, T1, T2, T3, InnerCloudAutonomousVmClusterIamRoleFactory> WithIamRoles<T1, T2, T3>(this CombinedResult<CloudAutonomousVmClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIamRoles(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudAutonomousVmClusterFactory, T2, T3, InnerCloudAutonomousVmClusterIamRoleFactory> WithIamRoles<T1, T2, T3>(this CombinedResult<T1, CloudAutonomousVmClusterFactory, T2, T3> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIamRoles(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CloudAutonomousVmClusterFactory, T3, InnerCloudAutonomousVmClusterIamRoleFactory> WithIamRoles<T1, T2, T3>(this CombinedResult<T1, T2, CloudAutonomousVmClusterFactory, T3> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIamRoles(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CloudAutonomousVmClusterFactory, InnerCloudAutonomousVmClusterIamRoleFactory> WithIamRoles<T1, T2, T3>(this CombinedResult<T1, T2, T3, CloudAutonomousVmClusterFactory> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIamRoles(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CloudAutonomousVmClusterFactory, T1, T2, T3, T4, InnerCloudAutonomousVmClusterIamRoleFactory> WithIamRoles<T1, T2, T3, T4>(this CombinedResult<CloudAutonomousVmClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamRoles(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudAutonomousVmClusterFactory, T2, T3, T4, InnerCloudAutonomousVmClusterIamRoleFactory> WithIamRoles<T1, T2, T3, T4>(this CombinedResult<T1, CloudAutonomousVmClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamRoles(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CloudAutonomousVmClusterFactory, T3, T4, InnerCloudAutonomousVmClusterIamRoleFactory> WithIamRoles<T1, T2, T3, T4>(this CombinedResult<T1, T2, CloudAutonomousVmClusterFactory, T3, T4> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamRoles(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CloudAutonomousVmClusterFactory, T4, InnerCloudAutonomousVmClusterIamRoleFactory> WithIamRoles<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CloudAutonomousVmClusterFactory, T4> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamRoles(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CloudAutonomousVmClusterFactory, InnerCloudAutonomousVmClusterIamRoleFactory> WithIamRoles<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CloudAutonomousVmClusterFactory> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamRoles(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<CloudAutonomousVmClusterFactory, T1, InnerCloudAutonomousVmClusterMaintenanceWindowFactory> WithMaintenanceWindow<T1>(this CombinedResult<CloudAutonomousVmClusterFactory, T1> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudAutonomousVmClusterFactory, InnerCloudAutonomousVmClusterMaintenanceWindowFactory> WithMaintenanceWindow<T1>(this CombinedResult<T1, CloudAutonomousVmClusterFactory> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CloudAutonomousVmClusterFactory, T1, T2, InnerCloudAutonomousVmClusterMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2>(this CombinedResult<CloudAutonomousVmClusterFactory, T1, T2> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudAutonomousVmClusterFactory, T2, InnerCloudAutonomousVmClusterMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2>(this CombinedResult<T1, CloudAutonomousVmClusterFactory, T2> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CloudAutonomousVmClusterFactory, InnerCloudAutonomousVmClusterMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2>(this CombinedResult<T1, T2, CloudAutonomousVmClusterFactory> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CloudAutonomousVmClusterFactory, T1, T2, T3, InnerCloudAutonomousVmClusterMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3>(this CombinedResult<CloudAutonomousVmClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudAutonomousVmClusterFactory, T2, T3, InnerCloudAutonomousVmClusterMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3>(this CombinedResult<T1, CloudAutonomousVmClusterFactory, T2, T3> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CloudAutonomousVmClusterFactory, T3, InnerCloudAutonomousVmClusterMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3>(this CombinedResult<T1, T2, CloudAutonomousVmClusterFactory, T3> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CloudAutonomousVmClusterFactory, InnerCloudAutonomousVmClusterMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3>(this CombinedResult<T1, T2, T3, CloudAutonomousVmClusterFactory> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CloudAutonomousVmClusterFactory, T1, T2, T3, T4, InnerCloudAutonomousVmClusterMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3, T4>(this CombinedResult<CloudAutonomousVmClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudAutonomousVmClusterFactory, T2, T3, T4, InnerCloudAutonomousVmClusterMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3, T4>(this CombinedResult<T1, CloudAutonomousVmClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CloudAutonomousVmClusterFactory, T3, T4, InnerCloudAutonomousVmClusterMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3, T4>(this CombinedResult<T1, T2, CloudAutonomousVmClusterFactory, T3, T4> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CloudAutonomousVmClusterFactory, T4, InnerCloudAutonomousVmClusterMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CloudAutonomousVmClusterFactory, T4> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CloudAutonomousVmClusterFactory, InnerCloudAutonomousVmClusterMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CloudAutonomousVmClusterFactory> combinedResult, Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T5, subFactoryAction).T2);
}
