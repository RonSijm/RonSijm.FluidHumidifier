// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.APS;

public class WorkspaceFactory(string resourceName = null, Action<Humidifier.APS.Workspace> factoryAction = null) : ResourceFactory<Humidifier.APS.Workspace>(resourceName)
{

    internal InnerWorkspaceLoggingConfigurationFactory LoggingConfigurationFactory { get; set; }

    protected override Humidifier.APS.Workspace Create()
    {
        var workspaceResult = CreateWorkspace();
        factoryAction?.Invoke(workspaceResult);

        return workspaceResult;
    }

    private Humidifier.APS.Workspace CreateWorkspace()
    {
        var workspaceResult = new Humidifier.APS.Workspace
        {
            GivenName = InputResourceName,
        };

        return workspaceResult;
    }
    public override void CreateChildren(Humidifier.APS.Workspace result)
    {
        base.CreateChildren(result);

        result.LoggingConfiguration ??= LoggingConfigurationFactory?.Build();
    }

} // End Of Class

public static class WorkspaceFactoryExtensions
{
    public static CombinedResult<WorkspaceFactory, InnerWorkspaceLoggingConfigurationFactory> WithLoggingConfiguration(this WorkspaceFactory parentFactory, Action<Humidifier.APS.WorkspaceTypes.LoggingConfiguration> subFactoryAction = null)
    {
        parentFactory.LoggingConfigurationFactory = new InnerWorkspaceLoggingConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LoggingConfigurationFactory);
    }

    public static CombinedResult<WorkspaceFactory, T1, InnerWorkspaceLoggingConfigurationFactory> WithLoggingConfiguration<T1>(this CombinedResult<WorkspaceFactory, T1> combinedResult, Action<Humidifier.APS.WorkspaceTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspaceFactory, InnerWorkspaceLoggingConfigurationFactory> WithLoggingConfiguration<T1>(this CombinedResult<T1, WorkspaceFactory> combinedResult, Action<Humidifier.APS.WorkspaceTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<WorkspaceFactory, T1, T2, InnerWorkspaceLoggingConfigurationFactory> WithLoggingConfiguration<T1, T2>(this CombinedResult<WorkspaceFactory, T1, T2> combinedResult, Action<Humidifier.APS.WorkspaceTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspaceFactory, T2, InnerWorkspaceLoggingConfigurationFactory> WithLoggingConfiguration<T1, T2>(this CombinedResult<T1, WorkspaceFactory, T2> combinedResult, Action<Humidifier.APS.WorkspaceTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkspaceFactory, InnerWorkspaceLoggingConfigurationFactory> WithLoggingConfiguration<T1, T2>(this CombinedResult<T1, T2, WorkspaceFactory> combinedResult, Action<Humidifier.APS.WorkspaceTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<WorkspaceFactory, T1, T2, T3, InnerWorkspaceLoggingConfigurationFactory> WithLoggingConfiguration<T1, T2, T3>(this CombinedResult<WorkspaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.APS.WorkspaceTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspaceFactory, T2, T3, InnerWorkspaceLoggingConfigurationFactory> WithLoggingConfiguration<T1, T2, T3>(this CombinedResult<T1, WorkspaceFactory, T2, T3> combinedResult, Action<Humidifier.APS.WorkspaceTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkspaceFactory, T3, InnerWorkspaceLoggingConfigurationFactory> WithLoggingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, WorkspaceFactory, T3> combinedResult, Action<Humidifier.APS.WorkspaceTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkspaceFactory, InnerWorkspaceLoggingConfigurationFactory> WithLoggingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkspaceFactory> combinedResult, Action<Humidifier.APS.WorkspaceTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<WorkspaceFactory, T1, T2, T3, T4, InnerWorkspaceLoggingConfigurationFactory> WithLoggingConfiguration<T1, T2, T3, T4>(this CombinedResult<WorkspaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.APS.WorkspaceTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspaceFactory, T2, T3, T4, InnerWorkspaceLoggingConfigurationFactory> WithLoggingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, WorkspaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.APS.WorkspaceTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkspaceFactory, T3, T4, InnerWorkspaceLoggingConfigurationFactory> WithLoggingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkspaceFactory, T3, T4> combinedResult, Action<Humidifier.APS.WorkspaceTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkspaceFactory, T4, InnerWorkspaceLoggingConfigurationFactory> WithLoggingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkspaceFactory, T4> combinedResult, Action<Humidifier.APS.WorkspaceTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, WorkspaceFactory, InnerWorkspaceLoggingConfigurationFactory> WithLoggingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkspaceFactory> combinedResult, Action<Humidifier.APS.WorkspaceTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T5, subFactoryAction));
}
