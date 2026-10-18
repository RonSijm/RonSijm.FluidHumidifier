// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpaces;

public class InnerDirectoryWorkspaceAccessPropertiesFactory(Action<Humidifier.WorkSpaces.DirectoryTypes.WorkspaceAccessProperties> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpaces.DirectoryTypes.WorkspaceAccessProperties>
{

    internal InnerDirectoryAccessEndpointConfigFactory AccessEndpointConfigFactory { get; set; }

    protected override Humidifier.WorkSpaces.DirectoryTypes.WorkspaceAccessProperties Create()
    {
        var workspaceAccessPropertiesResult = CreateWorkspaceAccessProperties();
        factoryAction?.Invoke(workspaceAccessPropertiesResult);

        return workspaceAccessPropertiesResult;
    }

    private Humidifier.WorkSpaces.DirectoryTypes.WorkspaceAccessProperties CreateWorkspaceAccessProperties()
    {
        var workspaceAccessPropertiesResult = new Humidifier.WorkSpaces.DirectoryTypes.WorkspaceAccessProperties();

        return workspaceAccessPropertiesResult;
    }
    public override void CreateChildren(Humidifier.WorkSpaces.DirectoryTypes.WorkspaceAccessProperties result)
    {
        base.CreateChildren(result);

        result.AccessEndpointConfig ??= AccessEndpointConfigFactory?.Build();
    }

} // End Of Class

public static class InnerDirectoryWorkspaceAccessPropertiesFactoryExtensions
{
    public static CombinedResult<InnerDirectoryWorkspaceAccessPropertiesFactory, InnerDirectoryAccessEndpointConfigFactory> WithAccessEndpointConfig(this InnerDirectoryWorkspaceAccessPropertiesFactory parentFactory, Action<Humidifier.WorkSpaces.DirectoryTypes.AccessEndpointConfig> subFactoryAction = null)
    {
        parentFactory.AccessEndpointConfigFactory = new InnerDirectoryAccessEndpointConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AccessEndpointConfigFactory);
    }

    public static CombinedResult<InnerDirectoryWorkspaceAccessPropertiesFactory, T1, InnerDirectoryAccessEndpointConfigFactory> WithAccessEndpointConfig<T1>(this CombinedResult<InnerDirectoryWorkspaceAccessPropertiesFactory, T1> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.AccessEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessEndpointConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDirectoryWorkspaceAccessPropertiesFactory, InnerDirectoryAccessEndpointConfigFactory> WithAccessEndpointConfig<T1>(this CombinedResult<T1, InnerDirectoryWorkspaceAccessPropertiesFactory> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.AccessEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessEndpointConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDirectoryWorkspaceAccessPropertiesFactory, T1, T2, InnerDirectoryAccessEndpointConfigFactory> WithAccessEndpointConfig<T1, T2>(this CombinedResult<InnerDirectoryWorkspaceAccessPropertiesFactory, T1, T2> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.AccessEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessEndpointConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDirectoryWorkspaceAccessPropertiesFactory, T2, InnerDirectoryAccessEndpointConfigFactory> WithAccessEndpointConfig<T1, T2>(this CombinedResult<T1, InnerDirectoryWorkspaceAccessPropertiesFactory, T2> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.AccessEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessEndpointConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDirectoryWorkspaceAccessPropertiesFactory, InnerDirectoryAccessEndpointConfigFactory> WithAccessEndpointConfig<T1, T2>(this CombinedResult<T1, T2, InnerDirectoryWorkspaceAccessPropertiesFactory> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.AccessEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessEndpointConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDirectoryWorkspaceAccessPropertiesFactory, T1, T2, T3, InnerDirectoryAccessEndpointConfigFactory> WithAccessEndpointConfig<T1, T2, T3>(this CombinedResult<InnerDirectoryWorkspaceAccessPropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.AccessEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpointConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDirectoryWorkspaceAccessPropertiesFactory, T2, T3, InnerDirectoryAccessEndpointConfigFactory> WithAccessEndpointConfig<T1, T2, T3>(this CombinedResult<T1, InnerDirectoryWorkspaceAccessPropertiesFactory, T2, T3> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.AccessEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpointConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDirectoryWorkspaceAccessPropertiesFactory, T3, InnerDirectoryAccessEndpointConfigFactory> WithAccessEndpointConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerDirectoryWorkspaceAccessPropertiesFactory, T3> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.AccessEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpointConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDirectoryWorkspaceAccessPropertiesFactory, InnerDirectoryAccessEndpointConfigFactory> WithAccessEndpointConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDirectoryWorkspaceAccessPropertiesFactory> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.AccessEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpointConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDirectoryWorkspaceAccessPropertiesFactory, T1, T2, T3, T4, InnerDirectoryAccessEndpointConfigFactory> WithAccessEndpointConfig<T1, T2, T3, T4>(this CombinedResult<InnerDirectoryWorkspaceAccessPropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.AccessEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpointConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDirectoryWorkspaceAccessPropertiesFactory, T2, T3, T4, InnerDirectoryAccessEndpointConfigFactory> WithAccessEndpointConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerDirectoryWorkspaceAccessPropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.AccessEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpointConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDirectoryWorkspaceAccessPropertiesFactory, T3, T4, InnerDirectoryAccessEndpointConfigFactory> WithAccessEndpointConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDirectoryWorkspaceAccessPropertiesFactory, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.AccessEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpointConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDirectoryWorkspaceAccessPropertiesFactory, T4, InnerDirectoryAccessEndpointConfigFactory> WithAccessEndpointConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDirectoryWorkspaceAccessPropertiesFactory, T4> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.AccessEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpointConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDirectoryWorkspaceAccessPropertiesFactory, InnerDirectoryAccessEndpointConfigFactory> WithAccessEndpointConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDirectoryWorkspaceAccessPropertiesFactory> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.AccessEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpointConfig(combinedResult.T5, subFactoryAction).T2);
}
