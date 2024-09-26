// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class WorkflowFactory(string resourceName = null, Action<Humidifier.Transfer.Workflow> factoryAction = null) : ResourceFactory<Humidifier.Transfer.Workflow>(resourceName)
{

    internal List<InnerWorkflowWorkflowStepFactory> StepsFactories { get; set; } = [];

    internal List<InnerWorkflowWorkflowStepFactory> OnExceptionStepsFactories { get; set; } = [];

    protected override Humidifier.Transfer.Workflow Create()
    {
        var workflowResult = CreateWorkflow();
        factoryAction?.Invoke(workflowResult);

        return workflowResult;
    }

    private Humidifier.Transfer.Workflow CreateWorkflow()
    {
        var workflowResult = new Humidifier.Transfer.Workflow
        {
            GivenName = InputResourceName,
        };

        return workflowResult;
    }
    public override void CreateChildren(Humidifier.Transfer.Workflow result)
    {
        base.CreateChildren(result);

        result.Steps = StepsFactories.Any() ? StepsFactories.Select(x => x.Build()).ToList() : null;
        result.OnExceptionSteps = OnExceptionStepsFactories.Any() ? OnExceptionStepsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class WorkflowFactoryExtensions
{
    public static CombinedResult<WorkflowFactory, InnerWorkflowWorkflowStepFactory> WithSteps(this WorkflowFactory parentFactory, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null)
    {
        var factory = new InnerWorkflowWorkflowStepFactory(subFactoryAction);
        parentFactory.StepsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<WorkflowFactory, InnerWorkflowWorkflowStepFactory> WithOnExceptionSteps(this WorkflowFactory parentFactory, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null)
    {
        var factory = new InnerWorkflowWorkflowStepFactory(subFactoryAction);
        parentFactory.OnExceptionStepsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<WorkflowFactory, T1, InnerWorkflowWorkflowStepFactory> WithSteps<T1>(this CombinedResult<WorkflowFactory, T1> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, WithSteps(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkflowFactory, InnerWorkflowWorkflowStepFactory> WithSteps<T1>(this CombinedResult<T1, WorkflowFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, WithSteps(combinedResult.T2, subFactoryAction));
    public static CombinedResult<WorkflowFactory, T1, T2, InnerWorkflowWorkflowStepFactory> WithSteps<T1, T2>(this CombinedResult<WorkflowFactory, T1, T2> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkflowFactory, T2, InnerWorkflowWorkflowStepFactory> WithSteps<T1, T2>(this CombinedResult<T1, WorkflowFactory, T2> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkflowFactory, InnerWorkflowWorkflowStepFactory> WithSteps<T1, T2>(this CombinedResult<T1, T2, WorkflowFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T3, subFactoryAction));
    public static CombinedResult<WorkflowFactory, T1, T2, T3, InnerWorkflowWorkflowStepFactory> WithSteps<T1, T2, T3>(this CombinedResult<WorkflowFactory, T1, T2, T3> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkflowFactory, T2, T3, InnerWorkflowWorkflowStepFactory> WithSteps<T1, T2, T3>(this CombinedResult<T1, WorkflowFactory, T2, T3> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkflowFactory, T3, InnerWorkflowWorkflowStepFactory> WithSteps<T1, T2, T3>(this CombinedResult<T1, T2, WorkflowFactory, T3> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkflowFactory, InnerWorkflowWorkflowStepFactory> WithSteps<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkflowFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T4, subFactoryAction));
    public static CombinedResult<WorkflowFactory, T1, T2, T3, T4, InnerWorkflowWorkflowStepFactory> WithSteps<T1, T2, T3, T4>(this CombinedResult<WorkflowFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkflowFactory, T2, T3, T4, InnerWorkflowWorkflowStepFactory> WithSteps<T1, T2, T3, T4>(this CombinedResult<T1, WorkflowFactory, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkflowFactory, T3, T4, InnerWorkflowWorkflowStepFactory> WithSteps<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkflowFactory, T3, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkflowFactory, T4, InnerWorkflowWorkflowStepFactory> WithSteps<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkflowFactory, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, WorkflowFactory, InnerWorkflowWorkflowStepFactory> WithSteps<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkflowFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T5, subFactoryAction));
    public static CombinedResult<WorkflowFactory, T1, InnerWorkflowWorkflowStepFactory> WithOnExceptionSteps<T1>(this CombinedResult<WorkflowFactory, T1> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, WithOnExceptionSteps(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkflowFactory, InnerWorkflowWorkflowStepFactory> WithOnExceptionSteps<T1>(this CombinedResult<T1, WorkflowFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, WithOnExceptionSteps(combinedResult.T2, subFactoryAction));
    public static CombinedResult<WorkflowFactory, T1, T2, InnerWorkflowWorkflowStepFactory> WithOnExceptionSteps<T1, T2>(this CombinedResult<WorkflowFactory, T1, T2> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnExceptionSteps(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkflowFactory, T2, InnerWorkflowWorkflowStepFactory> WithOnExceptionSteps<T1, T2>(this CombinedResult<T1, WorkflowFactory, T2> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnExceptionSteps(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkflowFactory, InnerWorkflowWorkflowStepFactory> WithOnExceptionSteps<T1, T2>(this CombinedResult<T1, T2, WorkflowFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnExceptionSteps(combinedResult.T3, subFactoryAction));
    public static CombinedResult<WorkflowFactory, T1, T2, T3, InnerWorkflowWorkflowStepFactory> WithOnExceptionSteps<T1, T2, T3>(this CombinedResult<WorkflowFactory, T1, T2, T3> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnExceptionSteps(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkflowFactory, T2, T3, InnerWorkflowWorkflowStepFactory> WithOnExceptionSteps<T1, T2, T3>(this CombinedResult<T1, WorkflowFactory, T2, T3> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnExceptionSteps(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkflowFactory, T3, InnerWorkflowWorkflowStepFactory> WithOnExceptionSteps<T1, T2, T3>(this CombinedResult<T1, T2, WorkflowFactory, T3> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnExceptionSteps(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkflowFactory, InnerWorkflowWorkflowStepFactory> WithOnExceptionSteps<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkflowFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnExceptionSteps(combinedResult.T4, subFactoryAction));
    public static CombinedResult<WorkflowFactory, T1, T2, T3, T4, InnerWorkflowWorkflowStepFactory> WithOnExceptionSteps<T1, T2, T3, T4>(this CombinedResult<WorkflowFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnExceptionSteps(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkflowFactory, T2, T3, T4, InnerWorkflowWorkflowStepFactory> WithOnExceptionSteps<T1, T2, T3, T4>(this CombinedResult<T1, WorkflowFactory, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnExceptionSteps(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkflowFactory, T3, T4, InnerWorkflowWorkflowStepFactory> WithOnExceptionSteps<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkflowFactory, T3, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnExceptionSteps(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkflowFactory, T4, InnerWorkflowWorkflowStepFactory> WithOnExceptionSteps<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkflowFactory, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnExceptionSteps(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, WorkflowFactory, InnerWorkflowWorkflowStepFactory> WithOnExceptionSteps<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkflowFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.WorkflowStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnExceptionSteps(combinedResult.T5, subFactoryAction));
}
