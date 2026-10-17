// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ODB;

public class CloudVmClusterFactory(string resourceName = null, Action<Humidifier.ODB.CloudVmCluster> factoryAction = null) : ResourceFactory<Humidifier.ODB.CloudVmCluster>(resourceName)
{

    internal List<InnerCloudVmClusterIamRoleFactory> IamRolesFactories { get; set; } = [];

    internal List<InnerCloudVmClusterDbNodeFactory> DbNodesFactories { get; set; } = [];

    internal InnerCloudVmClusterDataCollectionOptionsFactory DataCollectionOptionsFactory { get; set; }

    protected override Humidifier.ODB.CloudVmCluster Create()
    {
        var cloudVmClusterResult = CreateCloudVmCluster();
        factoryAction?.Invoke(cloudVmClusterResult);

        return cloudVmClusterResult;
    }

    private Humidifier.ODB.CloudVmCluster CreateCloudVmCluster()
    {
        var cloudVmClusterResult = new Humidifier.ODB.CloudVmCluster
        {
            GivenName = InputResourceName,
        };

        return cloudVmClusterResult;
    }
    public override void CreateChildren(Humidifier.ODB.CloudVmCluster result)
    {
        base.CreateChildren(result);

        result.IamRoles = IamRolesFactories.Any() ? IamRolesFactories.Select(x => x.Build()).ToList() : null;
        result.DbNodes = DbNodesFactories.Any() ? DbNodesFactories.Select(x => x.Build()).ToList() : null;
        result.DataCollectionOptions ??= DataCollectionOptionsFactory?.Build();
    }

} // End Of Class

public static class CloudVmClusterFactoryExtensions
{
    public static CombinedResult<CloudVmClusterFactory, InnerCloudVmClusterIamRoleFactory> WithIamRoles(this CloudVmClusterFactory parentFactory, Action<Humidifier.ODB.CloudVmClusterTypes.IamRole> subFactoryAction = null)
    {
        var factory = new InnerCloudVmClusterIamRoleFactory(subFactoryAction);
        parentFactory.IamRolesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<CloudVmClusterFactory, InnerCloudVmClusterDbNodeFactory> WithDbNodes(this CloudVmClusterFactory parentFactory, Action<Humidifier.ODB.CloudVmClusterTypes.DbNode> subFactoryAction = null)
    {
        var factory = new InnerCloudVmClusterDbNodeFactory(subFactoryAction);
        parentFactory.DbNodesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<CloudVmClusterFactory, InnerCloudVmClusterDataCollectionOptionsFactory> WithDataCollectionOptions(this CloudVmClusterFactory parentFactory, Action<Humidifier.ODB.CloudVmClusterTypes.DataCollectionOptions> subFactoryAction = null)
    {
        parentFactory.DataCollectionOptionsFactory = new InnerCloudVmClusterDataCollectionOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataCollectionOptionsFactory);
    }

    public static CombinedResult<CloudVmClusterFactory, T1, InnerCloudVmClusterIamRoleFactory> WithIamRoles<T1>(this CombinedResult<CloudVmClusterFactory, T1> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, WithIamRoles(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudVmClusterFactory, InnerCloudVmClusterIamRoleFactory> WithIamRoles<T1>(this CombinedResult<T1, CloudVmClusterFactory> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, WithIamRoles(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CloudVmClusterFactory, T1, T2, InnerCloudVmClusterIamRoleFactory> WithIamRoles<T1, T2>(this CombinedResult<CloudVmClusterFactory, T1, T2> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIamRoles(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudVmClusterFactory, T2, InnerCloudVmClusterIamRoleFactory> WithIamRoles<T1, T2>(this CombinedResult<T1, CloudVmClusterFactory, T2> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIamRoles(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CloudVmClusterFactory, InnerCloudVmClusterIamRoleFactory> WithIamRoles<T1, T2>(this CombinedResult<T1, T2, CloudVmClusterFactory> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIamRoles(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CloudVmClusterFactory, T1, T2, T3, InnerCloudVmClusterIamRoleFactory> WithIamRoles<T1, T2, T3>(this CombinedResult<CloudVmClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIamRoles(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudVmClusterFactory, T2, T3, InnerCloudVmClusterIamRoleFactory> WithIamRoles<T1, T2, T3>(this CombinedResult<T1, CloudVmClusterFactory, T2, T3> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIamRoles(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CloudVmClusterFactory, T3, InnerCloudVmClusterIamRoleFactory> WithIamRoles<T1, T2, T3>(this CombinedResult<T1, T2, CloudVmClusterFactory, T3> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIamRoles(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CloudVmClusterFactory, InnerCloudVmClusterIamRoleFactory> WithIamRoles<T1, T2, T3>(this CombinedResult<T1, T2, T3, CloudVmClusterFactory> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIamRoles(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CloudVmClusterFactory, T1, T2, T3, T4, InnerCloudVmClusterIamRoleFactory> WithIamRoles<T1, T2, T3, T4>(this CombinedResult<CloudVmClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamRoles(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudVmClusterFactory, T2, T3, T4, InnerCloudVmClusterIamRoleFactory> WithIamRoles<T1, T2, T3, T4>(this CombinedResult<T1, CloudVmClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamRoles(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CloudVmClusterFactory, T3, T4, InnerCloudVmClusterIamRoleFactory> WithIamRoles<T1, T2, T3, T4>(this CombinedResult<T1, T2, CloudVmClusterFactory, T3, T4> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamRoles(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CloudVmClusterFactory, T4, InnerCloudVmClusterIamRoleFactory> WithIamRoles<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CloudVmClusterFactory, T4> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamRoles(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CloudVmClusterFactory, InnerCloudVmClusterIamRoleFactory> WithIamRoles<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CloudVmClusterFactory> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamRoles(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<CloudVmClusterFactory, T1, InnerCloudVmClusterDbNodeFactory> WithDbNodes<T1>(this CombinedResult<CloudVmClusterFactory, T1> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DbNode> subFactoryAction = null) => new (combinedResult, combinedResult, WithDbNodes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudVmClusterFactory, InnerCloudVmClusterDbNodeFactory> WithDbNodes<T1>(this CombinedResult<T1, CloudVmClusterFactory> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DbNode> subFactoryAction = null) => new (combinedResult, combinedResult, WithDbNodes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CloudVmClusterFactory, T1, T2, InnerCloudVmClusterDbNodeFactory> WithDbNodes<T1, T2>(this CombinedResult<CloudVmClusterFactory, T1, T2> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DbNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDbNodes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudVmClusterFactory, T2, InnerCloudVmClusterDbNodeFactory> WithDbNodes<T1, T2>(this CombinedResult<T1, CloudVmClusterFactory, T2> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DbNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDbNodes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CloudVmClusterFactory, InnerCloudVmClusterDbNodeFactory> WithDbNodes<T1, T2>(this CombinedResult<T1, T2, CloudVmClusterFactory> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DbNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDbNodes(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CloudVmClusterFactory, T1, T2, T3, InnerCloudVmClusterDbNodeFactory> WithDbNodes<T1, T2, T3>(this CombinedResult<CloudVmClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DbNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDbNodes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudVmClusterFactory, T2, T3, InnerCloudVmClusterDbNodeFactory> WithDbNodes<T1, T2, T3>(this CombinedResult<T1, CloudVmClusterFactory, T2, T3> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DbNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDbNodes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CloudVmClusterFactory, T3, InnerCloudVmClusterDbNodeFactory> WithDbNodes<T1, T2, T3>(this CombinedResult<T1, T2, CloudVmClusterFactory, T3> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DbNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDbNodes(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CloudVmClusterFactory, InnerCloudVmClusterDbNodeFactory> WithDbNodes<T1, T2, T3>(this CombinedResult<T1, T2, T3, CloudVmClusterFactory> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DbNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDbNodes(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CloudVmClusterFactory, T1, T2, T3, T4, InnerCloudVmClusterDbNodeFactory> WithDbNodes<T1, T2, T3, T4>(this CombinedResult<CloudVmClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DbNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDbNodes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudVmClusterFactory, T2, T3, T4, InnerCloudVmClusterDbNodeFactory> WithDbNodes<T1, T2, T3, T4>(this CombinedResult<T1, CloudVmClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DbNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDbNodes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CloudVmClusterFactory, T3, T4, InnerCloudVmClusterDbNodeFactory> WithDbNodes<T1, T2, T3, T4>(this CombinedResult<T1, T2, CloudVmClusterFactory, T3, T4> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DbNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDbNodes(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CloudVmClusterFactory, T4, InnerCloudVmClusterDbNodeFactory> WithDbNodes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CloudVmClusterFactory, T4> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DbNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDbNodes(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CloudVmClusterFactory, InnerCloudVmClusterDbNodeFactory> WithDbNodes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CloudVmClusterFactory> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DbNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDbNodes(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<CloudVmClusterFactory, T1, InnerCloudVmClusterDataCollectionOptionsFactory> WithDataCollectionOptions<T1>(this CombinedResult<CloudVmClusterFactory, T1> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DataCollectionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataCollectionOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudVmClusterFactory, InnerCloudVmClusterDataCollectionOptionsFactory> WithDataCollectionOptions<T1>(this CombinedResult<T1, CloudVmClusterFactory> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DataCollectionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataCollectionOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CloudVmClusterFactory, T1, T2, InnerCloudVmClusterDataCollectionOptionsFactory> WithDataCollectionOptions<T1, T2>(this CombinedResult<CloudVmClusterFactory, T1, T2> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DataCollectionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataCollectionOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudVmClusterFactory, T2, InnerCloudVmClusterDataCollectionOptionsFactory> WithDataCollectionOptions<T1, T2>(this CombinedResult<T1, CloudVmClusterFactory, T2> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DataCollectionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataCollectionOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CloudVmClusterFactory, InnerCloudVmClusterDataCollectionOptionsFactory> WithDataCollectionOptions<T1, T2>(this CombinedResult<T1, T2, CloudVmClusterFactory> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DataCollectionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataCollectionOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CloudVmClusterFactory, T1, T2, T3, InnerCloudVmClusterDataCollectionOptionsFactory> WithDataCollectionOptions<T1, T2, T3>(this CombinedResult<CloudVmClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DataCollectionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataCollectionOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudVmClusterFactory, T2, T3, InnerCloudVmClusterDataCollectionOptionsFactory> WithDataCollectionOptions<T1, T2, T3>(this CombinedResult<T1, CloudVmClusterFactory, T2, T3> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DataCollectionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataCollectionOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CloudVmClusterFactory, T3, InnerCloudVmClusterDataCollectionOptionsFactory> WithDataCollectionOptions<T1, T2, T3>(this CombinedResult<T1, T2, CloudVmClusterFactory, T3> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DataCollectionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataCollectionOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CloudVmClusterFactory, InnerCloudVmClusterDataCollectionOptionsFactory> WithDataCollectionOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, CloudVmClusterFactory> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DataCollectionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataCollectionOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CloudVmClusterFactory, T1, T2, T3, T4, InnerCloudVmClusterDataCollectionOptionsFactory> WithDataCollectionOptions<T1, T2, T3, T4>(this CombinedResult<CloudVmClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DataCollectionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataCollectionOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudVmClusterFactory, T2, T3, T4, InnerCloudVmClusterDataCollectionOptionsFactory> WithDataCollectionOptions<T1, T2, T3, T4>(this CombinedResult<T1, CloudVmClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DataCollectionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataCollectionOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CloudVmClusterFactory, T3, T4, InnerCloudVmClusterDataCollectionOptionsFactory> WithDataCollectionOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, CloudVmClusterFactory, T3, T4> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DataCollectionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataCollectionOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CloudVmClusterFactory, T4, InnerCloudVmClusterDataCollectionOptionsFactory> WithDataCollectionOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CloudVmClusterFactory, T4> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DataCollectionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataCollectionOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CloudVmClusterFactory, InnerCloudVmClusterDataCollectionOptionsFactory> WithDataCollectionOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CloudVmClusterFactory> combinedResult, Action<Humidifier.ODB.CloudVmClusterTypes.DataCollectionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataCollectionOptions(combinedResult.T5, subFactoryAction).T2);
}
