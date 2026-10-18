// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ARCRegionSwitch;

public class PlanFactory(string resourceName = null, Action<Humidifier.ARCRegionSwitch.Plan> factoryAction = null) : ResourceFactory<Humidifier.ARCRegionSwitch.Plan>(resourceName)
{

    internal List<InnerPlanWorkflowFactory> WorkflowsFactories { get; set; } = [];

    internal List<InnerPlanTriggerFactory> TriggersFactories { get; set; } = [];

    internal InnerPlanReportConfigurationFactory ReportConfigurationFactory { get; set; }

    protected override Humidifier.ARCRegionSwitch.Plan Create()
    {
        var planResult = CreatePlan();
        factoryAction?.Invoke(planResult);

        return planResult;
    }

    private Humidifier.ARCRegionSwitch.Plan CreatePlan()
    {
        var planResult = new Humidifier.ARCRegionSwitch.Plan
        {
            GivenName = InputResourceName,
        };

        return planResult;
    }
    public override void CreateChildren(Humidifier.ARCRegionSwitch.Plan result)
    {
        base.CreateChildren(result);

        result.Workflows = WorkflowsFactories.Any() ? WorkflowsFactories.Select(x => x.Build()).ToList() : null;
        result.Triggers = TriggersFactories.Any() ? TriggersFactories.Select(x => x.Build()).ToList() : null;
        result.ReportConfiguration ??= ReportConfigurationFactory?.Build();
    }

} // End Of Class

public static class PlanFactoryExtensions
{
    public static CombinedResult<PlanFactory, InnerPlanWorkflowFactory> WithWorkflows(this PlanFactory parentFactory, Action<Humidifier.ARCRegionSwitch.PlanTypes.Workflow> subFactoryAction = null)
    {
        var factory = new InnerPlanWorkflowFactory(subFactoryAction);
        parentFactory.WorkflowsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<PlanFactory, InnerPlanTriggerFactory> WithTriggers(this PlanFactory parentFactory, Action<Humidifier.ARCRegionSwitch.PlanTypes.Trigger> subFactoryAction = null)
    {
        var factory = new InnerPlanTriggerFactory(subFactoryAction);
        parentFactory.TriggersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<PlanFactory, InnerPlanReportConfigurationFactory> WithReportConfiguration(this PlanFactory parentFactory, Action<Humidifier.ARCRegionSwitch.PlanTypes.ReportConfiguration> subFactoryAction = null)
    {
        parentFactory.ReportConfigurationFactory = new InnerPlanReportConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ReportConfigurationFactory);
    }

    public static CombinedResult<PlanFactory, T1, InnerPlanWorkflowFactory> WithWorkflows<T1>(this CombinedResult<PlanFactory, T1> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Workflow> subFactoryAction = null) => new (combinedResult, combinedResult, WithWorkflows(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PlanFactory, InnerPlanWorkflowFactory> WithWorkflows<T1>(this CombinedResult<T1, PlanFactory> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Workflow> subFactoryAction = null) => new (combinedResult, combinedResult, WithWorkflows(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PlanFactory, T1, T2, InnerPlanWorkflowFactory> WithWorkflows<T1, T2>(this CombinedResult<PlanFactory, T1, T2> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Workflow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWorkflows(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PlanFactory, T2, InnerPlanWorkflowFactory> WithWorkflows<T1, T2>(this CombinedResult<T1, PlanFactory, T2> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Workflow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWorkflows(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PlanFactory, InnerPlanWorkflowFactory> WithWorkflows<T1, T2>(this CombinedResult<T1, T2, PlanFactory> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Workflow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWorkflows(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PlanFactory, T1, T2, T3, InnerPlanWorkflowFactory> WithWorkflows<T1, T2, T3>(this CombinedResult<PlanFactory, T1, T2, T3> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Workflow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkflows(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PlanFactory, T2, T3, InnerPlanWorkflowFactory> WithWorkflows<T1, T2, T3>(this CombinedResult<T1, PlanFactory, T2, T3> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Workflow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkflows(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PlanFactory, T3, InnerPlanWorkflowFactory> WithWorkflows<T1, T2, T3>(this CombinedResult<T1, T2, PlanFactory, T3> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Workflow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkflows(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PlanFactory, InnerPlanWorkflowFactory> WithWorkflows<T1, T2, T3>(this CombinedResult<T1, T2, T3, PlanFactory> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Workflow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkflows(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PlanFactory, T1, T2, T3, T4, InnerPlanWorkflowFactory> WithWorkflows<T1, T2, T3, T4>(this CombinedResult<PlanFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Workflow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkflows(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PlanFactory, T2, T3, T4, InnerPlanWorkflowFactory> WithWorkflows<T1, T2, T3, T4>(this CombinedResult<T1, PlanFactory, T2, T3, T4> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Workflow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkflows(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PlanFactory, T3, T4, InnerPlanWorkflowFactory> WithWorkflows<T1, T2, T3, T4>(this CombinedResult<T1, T2, PlanFactory, T3, T4> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Workflow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkflows(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PlanFactory, T4, InnerPlanWorkflowFactory> WithWorkflows<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PlanFactory, T4> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Workflow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkflows(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PlanFactory, InnerPlanWorkflowFactory> WithWorkflows<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PlanFactory> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Workflow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkflows(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<PlanFactory, T1, InnerPlanTriggerFactory> WithTriggers<T1>(this CombinedResult<PlanFactory, T1> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Trigger> subFactoryAction = null) => new (combinedResult, combinedResult, WithTriggers(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PlanFactory, InnerPlanTriggerFactory> WithTriggers<T1>(this CombinedResult<T1, PlanFactory> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Trigger> subFactoryAction = null) => new (combinedResult, combinedResult, WithTriggers(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PlanFactory, T1, T2, InnerPlanTriggerFactory> WithTriggers<T1, T2>(this CombinedResult<PlanFactory, T1, T2> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Trigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTriggers(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PlanFactory, T2, InnerPlanTriggerFactory> WithTriggers<T1, T2>(this CombinedResult<T1, PlanFactory, T2> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Trigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTriggers(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PlanFactory, InnerPlanTriggerFactory> WithTriggers<T1, T2>(this CombinedResult<T1, T2, PlanFactory> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Trigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTriggers(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PlanFactory, T1, T2, T3, InnerPlanTriggerFactory> WithTriggers<T1, T2, T3>(this CombinedResult<PlanFactory, T1, T2, T3> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Trigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggers(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PlanFactory, T2, T3, InnerPlanTriggerFactory> WithTriggers<T1, T2, T3>(this CombinedResult<T1, PlanFactory, T2, T3> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Trigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggers(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PlanFactory, T3, InnerPlanTriggerFactory> WithTriggers<T1, T2, T3>(this CombinedResult<T1, T2, PlanFactory, T3> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Trigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggers(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PlanFactory, InnerPlanTriggerFactory> WithTriggers<T1, T2, T3>(this CombinedResult<T1, T2, T3, PlanFactory> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Trigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggers(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PlanFactory, T1, T2, T3, T4, InnerPlanTriggerFactory> WithTriggers<T1, T2, T3, T4>(this CombinedResult<PlanFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Trigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggers(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PlanFactory, T2, T3, T4, InnerPlanTriggerFactory> WithTriggers<T1, T2, T3, T4>(this CombinedResult<T1, PlanFactory, T2, T3, T4> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Trigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggers(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PlanFactory, T3, T4, InnerPlanTriggerFactory> WithTriggers<T1, T2, T3, T4>(this CombinedResult<T1, T2, PlanFactory, T3, T4> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Trigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggers(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PlanFactory, T4, InnerPlanTriggerFactory> WithTriggers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PlanFactory, T4> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Trigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggers(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PlanFactory, InnerPlanTriggerFactory> WithTriggers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PlanFactory> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.Trigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggers(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<PlanFactory, T1, InnerPlanReportConfigurationFactory> WithReportConfiguration<T1>(this CombinedResult<PlanFactory, T1> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.ReportConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithReportConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PlanFactory, InnerPlanReportConfigurationFactory> WithReportConfiguration<T1>(this CombinedResult<T1, PlanFactory> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.ReportConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithReportConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PlanFactory, T1, T2, InnerPlanReportConfigurationFactory> WithReportConfiguration<T1, T2>(this CombinedResult<PlanFactory, T1, T2> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.ReportConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReportConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PlanFactory, T2, InnerPlanReportConfigurationFactory> WithReportConfiguration<T1, T2>(this CombinedResult<T1, PlanFactory, T2> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.ReportConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReportConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PlanFactory, InnerPlanReportConfigurationFactory> WithReportConfiguration<T1, T2>(this CombinedResult<T1, T2, PlanFactory> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.ReportConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReportConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PlanFactory, T1, T2, T3, InnerPlanReportConfigurationFactory> WithReportConfiguration<T1, T2, T3>(this CombinedResult<PlanFactory, T1, T2, T3> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.ReportConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReportConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PlanFactory, T2, T3, InnerPlanReportConfigurationFactory> WithReportConfiguration<T1, T2, T3>(this CombinedResult<T1, PlanFactory, T2, T3> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.ReportConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReportConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PlanFactory, T3, InnerPlanReportConfigurationFactory> WithReportConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, PlanFactory, T3> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.ReportConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReportConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PlanFactory, InnerPlanReportConfigurationFactory> WithReportConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, PlanFactory> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.ReportConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReportConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PlanFactory, T1, T2, T3, T4, InnerPlanReportConfigurationFactory> WithReportConfiguration<T1, T2, T3, T4>(this CombinedResult<PlanFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.ReportConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReportConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PlanFactory, T2, T3, T4, InnerPlanReportConfigurationFactory> WithReportConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, PlanFactory, T2, T3, T4> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.ReportConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReportConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PlanFactory, T3, T4, InnerPlanReportConfigurationFactory> WithReportConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, PlanFactory, T3, T4> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.ReportConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReportConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PlanFactory, T4, InnerPlanReportConfigurationFactory> WithReportConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PlanFactory, T4> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.ReportConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReportConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PlanFactory, InnerPlanReportConfigurationFactory> WithReportConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PlanFactory> combinedResult, Action<Humidifier.ARCRegionSwitch.PlanTypes.ReportConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReportConfiguration(combinedResult.T5, subFactoryAction).T2);
}
