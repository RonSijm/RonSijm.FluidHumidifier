// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AWSExternalAnthropic;

public class WorkspaceFactory(string resourceName = null, Action<Humidifier.AWSExternalAnthropic.Workspace> factoryAction = null) : ResourceFactory<Humidifier.AWSExternalAnthropic.Workspace>(resourceName)
{

    internal InnerWorkspaceDataResidencyFactory DataResidencyFactory { get; set; }

    protected override Humidifier.AWSExternalAnthropic.Workspace Create()
    {
        var workspaceResult = CreateWorkspace();
        factoryAction?.Invoke(workspaceResult);

        return workspaceResult;
    }

    private Humidifier.AWSExternalAnthropic.Workspace CreateWorkspace()
    {
        var workspaceResult = new Humidifier.AWSExternalAnthropic.Workspace
        {
            GivenName = InputResourceName,
        };

        return workspaceResult;
    }
    public override void CreateChildren(Humidifier.AWSExternalAnthropic.Workspace result)
    {
        base.CreateChildren(result);

        result.DataResidency ??= DataResidencyFactory?.Build();
    }

} // End Of Class

public static class WorkspaceFactoryExtensions
{
    public static CombinedResult<WorkspaceFactory, InnerWorkspaceDataResidencyFactory> WithDataResidency(this WorkspaceFactory parentFactory, Action<Humidifier.AWSExternalAnthropic.WorkspaceTypes.DataResidency> subFactoryAction = null)
    {
        parentFactory.DataResidencyFactory = new InnerWorkspaceDataResidencyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataResidencyFactory);
    }

    public static CombinedResult<WorkspaceFactory, T1, InnerWorkspaceDataResidencyFactory> WithDataResidency<T1>(this CombinedResult<WorkspaceFactory, T1> combinedResult, Action<Humidifier.AWSExternalAnthropic.WorkspaceTypes.DataResidency> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataResidency(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceFactory, InnerWorkspaceDataResidencyFactory> WithDataResidency<T1>(this CombinedResult<T1, WorkspaceFactory> combinedResult, Action<Humidifier.AWSExternalAnthropic.WorkspaceTypes.DataResidency> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataResidency(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<WorkspaceFactory, T1, T2, InnerWorkspaceDataResidencyFactory> WithDataResidency<T1, T2>(this CombinedResult<WorkspaceFactory, T1, T2> combinedResult, Action<Humidifier.AWSExternalAnthropic.WorkspaceTypes.DataResidency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataResidency(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceFactory, T2, InnerWorkspaceDataResidencyFactory> WithDataResidency<T1, T2>(this CombinedResult<T1, WorkspaceFactory, T2> combinedResult, Action<Humidifier.AWSExternalAnthropic.WorkspaceTypes.DataResidency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataResidency(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceFactory, InnerWorkspaceDataResidencyFactory> WithDataResidency<T1, T2>(this CombinedResult<T1, T2, WorkspaceFactory> combinedResult, Action<Humidifier.AWSExternalAnthropic.WorkspaceTypes.DataResidency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataResidency(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<WorkspaceFactory, T1, T2, T3, InnerWorkspaceDataResidencyFactory> WithDataResidency<T1, T2, T3>(this CombinedResult<WorkspaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.AWSExternalAnthropic.WorkspaceTypes.DataResidency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataResidency(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceFactory, T2, T3, InnerWorkspaceDataResidencyFactory> WithDataResidency<T1, T2, T3>(this CombinedResult<T1, WorkspaceFactory, T2, T3> combinedResult, Action<Humidifier.AWSExternalAnthropic.WorkspaceTypes.DataResidency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataResidency(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceFactory, T3, InnerWorkspaceDataResidencyFactory> WithDataResidency<T1, T2, T3>(this CombinedResult<T1, T2, WorkspaceFactory, T3> combinedResult, Action<Humidifier.AWSExternalAnthropic.WorkspaceTypes.DataResidency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataResidency(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkspaceFactory, InnerWorkspaceDataResidencyFactory> WithDataResidency<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkspaceFactory> combinedResult, Action<Humidifier.AWSExternalAnthropic.WorkspaceTypes.DataResidency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataResidency(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<WorkspaceFactory, T1, T2, T3, T4, InnerWorkspaceDataResidencyFactory> WithDataResidency<T1, T2, T3, T4>(this CombinedResult<WorkspaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AWSExternalAnthropic.WorkspaceTypes.DataResidency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataResidency(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceFactory, T2, T3, T4, InnerWorkspaceDataResidencyFactory> WithDataResidency<T1, T2, T3, T4>(this CombinedResult<T1, WorkspaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.AWSExternalAnthropic.WorkspaceTypes.DataResidency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataResidency(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceFactory, T3, T4, InnerWorkspaceDataResidencyFactory> WithDataResidency<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkspaceFactory, T3, T4> combinedResult, Action<Humidifier.AWSExternalAnthropic.WorkspaceTypes.DataResidency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataResidency(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkspaceFactory, T4, InnerWorkspaceDataResidencyFactory> WithDataResidency<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkspaceFactory, T4> combinedResult, Action<Humidifier.AWSExternalAnthropic.WorkspaceTypes.DataResidency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataResidency(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, WorkspaceFactory, InnerWorkspaceDataResidencyFactory> WithDataResidency<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkspaceFactory> combinedResult, Action<Humidifier.AWSExternalAnthropic.WorkspaceTypes.DataResidency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataResidency(combinedResult.T5, subFactoryAction).T2);
}
