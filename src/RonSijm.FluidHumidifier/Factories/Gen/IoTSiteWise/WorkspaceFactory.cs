// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class WorkspaceFactory(string resourceName = null, Action<Humidifier.IoTSiteWise.Workspace> factoryAction = null) : ResourceFactory<Humidifier.IoTSiteWise.Workspace>(resourceName)
{

    internal InnerWorkspaceEncryptionConfigurationFactory EncryptionConfigurationFactory { get; set; }

    protected override Humidifier.IoTSiteWise.Workspace Create()
    {
        var workspaceResult = CreateWorkspace();
        factoryAction?.Invoke(workspaceResult);

        return workspaceResult;
    }

    private Humidifier.IoTSiteWise.Workspace CreateWorkspace()
    {
        var workspaceResult = new Humidifier.IoTSiteWise.Workspace
        {
            GivenName = InputResourceName,
        };

        return workspaceResult;
    }
    public override void CreateChildren(Humidifier.IoTSiteWise.Workspace result)
    {
        base.CreateChildren(result);

        result.EncryptionConfiguration ??= EncryptionConfigurationFactory?.Build();
    }

} // End Of Class

public static class WorkspaceFactoryExtensions
{
    public static CombinedResult<WorkspaceFactory, InnerWorkspaceEncryptionConfigurationFactory> WithEncryptionConfiguration(this WorkspaceFactory parentFactory, Action<Humidifier.IoTSiteWise.WorkspaceTypes.EncryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionConfigurationFactory = new InnerWorkspaceEncryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionConfigurationFactory);
    }

    public static CombinedResult<WorkspaceFactory, T1, InnerWorkspaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<WorkspaceFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.WorkspaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceFactory, InnerWorkspaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<T1, WorkspaceFactory> combinedResult, Action<Humidifier.IoTSiteWise.WorkspaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<WorkspaceFactory, T1, T2, InnerWorkspaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<WorkspaceFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.WorkspaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceFactory, T2, InnerWorkspaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, WorkspaceFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.WorkspaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceFactory, InnerWorkspaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, T2, WorkspaceFactory> combinedResult, Action<Humidifier.IoTSiteWise.WorkspaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<WorkspaceFactory, T1, T2, T3, InnerWorkspaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<WorkspaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.WorkspaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceFactory, T2, T3, InnerWorkspaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, WorkspaceFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.WorkspaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceFactory, T3, InnerWorkspaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, WorkspaceFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.WorkspaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkspaceFactory, InnerWorkspaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkspaceFactory> combinedResult, Action<Humidifier.IoTSiteWise.WorkspaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<WorkspaceFactory, T1, T2, T3, T4, InnerWorkspaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<WorkspaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.WorkspaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceFactory, T2, T3, T4, InnerWorkspaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, WorkspaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.WorkspaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceFactory, T3, T4, InnerWorkspaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkspaceFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.WorkspaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkspaceFactory, T4, InnerWorkspaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkspaceFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.WorkspaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, WorkspaceFactory, InnerWorkspaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkspaceFactory> combinedResult, Action<Humidifier.IoTSiteWise.WorkspaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T5, subFactoryAction).T2);
}
