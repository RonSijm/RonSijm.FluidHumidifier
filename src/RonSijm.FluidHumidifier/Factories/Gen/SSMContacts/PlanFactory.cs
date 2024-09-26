// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSMContacts;

public class PlanFactory(string resourceName = null, Action<Humidifier.SSMContacts.Plan> factoryAction = null) : ResourceFactory<Humidifier.SSMContacts.Plan>(resourceName)
{

    internal List<InnerPlanStageFactory> StagesFactories { get; set; } = [];

    protected override Humidifier.SSMContacts.Plan Create()
    {
        var planResult = CreatePlan();
        factoryAction?.Invoke(planResult);

        return planResult;
    }

    private Humidifier.SSMContacts.Plan CreatePlan()
    {
        var planResult = new Humidifier.SSMContacts.Plan
        {
            GivenName = InputResourceName,
        };

        return planResult;
    }
    public override void CreateChildren(Humidifier.SSMContacts.Plan result)
    {
        base.CreateChildren(result);

        result.Stages = StagesFactories.Any() ? StagesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class PlanFactoryExtensions
{
    public static CombinedResult<PlanFactory, InnerPlanStageFactory> WithStages(this PlanFactory parentFactory, Action<Humidifier.SSMContacts.PlanTypes.Stage> subFactoryAction = null)
    {
        var factory = new InnerPlanStageFactory(subFactoryAction);
        parentFactory.StagesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<PlanFactory, T1, InnerPlanStageFactory> WithStages<T1>(this CombinedResult<PlanFactory, T1> combinedResult, Action<Humidifier.SSMContacts.PlanTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, WithStages(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PlanFactory, InnerPlanStageFactory> WithStages<T1>(this CombinedResult<T1, PlanFactory> combinedResult, Action<Humidifier.SSMContacts.PlanTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, WithStages(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PlanFactory, T1, T2, InnerPlanStageFactory> WithStages<T1, T2>(this CombinedResult<PlanFactory, T1, T2> combinedResult, Action<Humidifier.SSMContacts.PlanTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStages(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PlanFactory, T2, InnerPlanStageFactory> WithStages<T1, T2>(this CombinedResult<T1, PlanFactory, T2> combinedResult, Action<Humidifier.SSMContacts.PlanTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStages(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PlanFactory, InnerPlanStageFactory> WithStages<T1, T2>(this CombinedResult<T1, T2, PlanFactory> combinedResult, Action<Humidifier.SSMContacts.PlanTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStages(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PlanFactory, T1, T2, T3, InnerPlanStageFactory> WithStages<T1, T2, T3>(this CombinedResult<PlanFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSMContacts.PlanTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStages(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PlanFactory, T2, T3, InnerPlanStageFactory> WithStages<T1, T2, T3>(this CombinedResult<T1, PlanFactory, T2, T3> combinedResult, Action<Humidifier.SSMContacts.PlanTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStages(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PlanFactory, T3, InnerPlanStageFactory> WithStages<T1, T2, T3>(this CombinedResult<T1, T2, PlanFactory, T3> combinedResult, Action<Humidifier.SSMContacts.PlanTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStages(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PlanFactory, InnerPlanStageFactory> WithStages<T1, T2, T3>(this CombinedResult<T1, T2, T3, PlanFactory> combinedResult, Action<Humidifier.SSMContacts.PlanTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStages(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PlanFactory, T1, T2, T3, T4, InnerPlanStageFactory> WithStages<T1, T2, T3, T4>(this CombinedResult<PlanFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSMContacts.PlanTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStages(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PlanFactory, T2, T3, T4, InnerPlanStageFactory> WithStages<T1, T2, T3, T4>(this CombinedResult<T1, PlanFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSMContacts.PlanTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStages(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PlanFactory, T3, T4, InnerPlanStageFactory> WithStages<T1, T2, T3, T4>(this CombinedResult<T1, T2, PlanFactory, T3, T4> combinedResult, Action<Humidifier.SSMContacts.PlanTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStages(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PlanFactory, T4, InnerPlanStageFactory> WithStages<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PlanFactory, T4> combinedResult, Action<Humidifier.SSMContacts.PlanTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStages(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PlanFactory, InnerPlanStageFactory> WithStages<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PlanFactory> combinedResult, Action<Humidifier.SSMContacts.PlanTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStages(combinedResult.T5, subFactoryAction));
}
