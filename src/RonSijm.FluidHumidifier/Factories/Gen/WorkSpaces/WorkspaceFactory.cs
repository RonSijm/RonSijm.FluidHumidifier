// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpaces;

public class WorkspaceFactory(string resourceName = null, Action<Humidifier.WorkSpaces.Workspace> factoryAction = null) : ResourceFactory<Humidifier.WorkSpaces.Workspace>(resourceName)
{

    internal InnerWorkspaceWorkspacePropertiesFactory WorkspacePropertiesFactory { get; set; }

    protected override Humidifier.WorkSpaces.Workspace Create()
    {
        var workspaceResult = CreateWorkspace();
        factoryAction?.Invoke(workspaceResult);

        return workspaceResult;
    }

    private Humidifier.WorkSpaces.Workspace CreateWorkspace()
    {
        var workspaceResult = new Humidifier.WorkSpaces.Workspace
        {
            GivenName = InputResourceName,
        };

        return workspaceResult;
    }
    public override void CreateChildren(Humidifier.WorkSpaces.Workspace result)
    {
        base.CreateChildren(result);

        result.WorkspaceProperties ??= WorkspacePropertiesFactory?.Build();
    }

} // End Of Class

public static class WorkspaceFactoryExtensions
{
    public static CombinedResult<WorkspaceFactory, InnerWorkspaceWorkspacePropertiesFactory> WithWorkspaceProperties(this WorkspaceFactory parentFactory, Action<Humidifier.WorkSpaces.WorkspaceTypes.WorkspaceProperties> subFactoryAction = null)
    {
        parentFactory.WorkspacePropertiesFactory = new InnerWorkspaceWorkspacePropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.WorkspacePropertiesFactory);
    }

    public static CombinedResult<WorkspaceFactory, T1, InnerWorkspaceWorkspacePropertiesFactory> WithWorkspaceProperties<T1>(this CombinedResult<WorkspaceFactory, T1> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceTypes.WorkspaceProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithWorkspaceProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspaceFactory, InnerWorkspaceWorkspacePropertiesFactory> WithWorkspaceProperties<T1>(this CombinedResult<T1, WorkspaceFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceTypes.WorkspaceProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithWorkspaceProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<WorkspaceFactory, T1, T2, InnerWorkspaceWorkspacePropertiesFactory> WithWorkspaceProperties<T1, T2>(this CombinedResult<WorkspaceFactory, T1, T2> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceTypes.WorkspaceProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWorkspaceProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspaceFactory, T2, InnerWorkspaceWorkspacePropertiesFactory> WithWorkspaceProperties<T1, T2>(this CombinedResult<T1, WorkspaceFactory, T2> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceTypes.WorkspaceProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWorkspaceProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkspaceFactory, InnerWorkspaceWorkspacePropertiesFactory> WithWorkspaceProperties<T1, T2>(this CombinedResult<T1, T2, WorkspaceFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceTypes.WorkspaceProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWorkspaceProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<WorkspaceFactory, T1, T2, T3, InnerWorkspaceWorkspacePropertiesFactory> WithWorkspaceProperties<T1, T2, T3>(this CombinedResult<WorkspaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceTypes.WorkspaceProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkspaceProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspaceFactory, T2, T3, InnerWorkspaceWorkspacePropertiesFactory> WithWorkspaceProperties<T1, T2, T3>(this CombinedResult<T1, WorkspaceFactory, T2, T3> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceTypes.WorkspaceProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkspaceProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkspaceFactory, T3, InnerWorkspaceWorkspacePropertiesFactory> WithWorkspaceProperties<T1, T2, T3>(this CombinedResult<T1, T2, WorkspaceFactory, T3> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceTypes.WorkspaceProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkspaceProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkspaceFactory, InnerWorkspaceWorkspacePropertiesFactory> WithWorkspaceProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkspaceFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceTypes.WorkspaceProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkspaceProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<WorkspaceFactory, T1, T2, T3, T4, InnerWorkspaceWorkspacePropertiesFactory> WithWorkspaceProperties<T1, T2, T3, T4>(this CombinedResult<WorkspaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceTypes.WorkspaceProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkspaceProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspaceFactory, T2, T3, T4, InnerWorkspaceWorkspacePropertiesFactory> WithWorkspaceProperties<T1, T2, T3, T4>(this CombinedResult<T1, WorkspaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceTypes.WorkspaceProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkspaceProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkspaceFactory, T3, T4, InnerWorkspaceWorkspacePropertiesFactory> WithWorkspaceProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkspaceFactory, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceTypes.WorkspaceProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkspaceProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkspaceFactory, T4, InnerWorkspaceWorkspacePropertiesFactory> WithWorkspaceProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkspaceFactory, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceTypes.WorkspaceProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkspaceProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, WorkspaceFactory, InnerWorkspaceWorkspacePropertiesFactory> WithWorkspaceProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkspaceFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceTypes.WorkspaceProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkspaceProperties(combinedResult.T5, subFactoryAction));
}
