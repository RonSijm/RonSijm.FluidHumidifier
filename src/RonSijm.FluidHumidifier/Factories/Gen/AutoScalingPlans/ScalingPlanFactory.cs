// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScalingPlans;

public class ScalingPlanFactory(string resourceName = null, Action<Humidifier.AutoScalingPlans.ScalingPlan> factoryAction = null) : ResourceFactory<Humidifier.AutoScalingPlans.ScalingPlan>(resourceName)
{

    internal List<InnerScalingPlanScalingInstructionFactory> ScalingInstructionsFactories { get; set; } = [];

    internal InnerScalingPlanApplicationSourceFactory ApplicationSourceFactory { get; set; }

    protected override Humidifier.AutoScalingPlans.ScalingPlan Create()
    {
        var scalingPlanResult = CreateScalingPlan();
        factoryAction?.Invoke(scalingPlanResult);

        return scalingPlanResult;
    }

    private Humidifier.AutoScalingPlans.ScalingPlan CreateScalingPlan()
    {
        var scalingPlanResult = new Humidifier.AutoScalingPlans.ScalingPlan
        {
            GivenName = InputResourceName,
        };

        return scalingPlanResult;
    }
    public override void CreateChildren(Humidifier.AutoScalingPlans.ScalingPlan result)
    {
        base.CreateChildren(result);

        result.ScalingInstructions = ScalingInstructionsFactories.Any() ? ScalingInstructionsFactories.Select(x => x.Build()).ToList() : null;
        result.ApplicationSource ??= ApplicationSourceFactory?.Build();
    }

} // End Of Class

public static class ScalingPlanFactoryExtensions
{
    public static CombinedResult<ScalingPlanFactory, InnerScalingPlanScalingInstructionFactory> WithScalingInstructions(this ScalingPlanFactory parentFactory, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ScalingInstruction> subFactoryAction = null)
    {
        var factory = new InnerScalingPlanScalingInstructionFactory(subFactoryAction);
        parentFactory.ScalingInstructionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ScalingPlanFactory, InnerScalingPlanApplicationSourceFactory> WithApplicationSource(this ScalingPlanFactory parentFactory, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ApplicationSource> subFactoryAction = null)
    {
        parentFactory.ApplicationSourceFactory = new InnerScalingPlanApplicationSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ApplicationSourceFactory);
    }

    public static CombinedResult<ScalingPlanFactory, T1, InnerScalingPlanScalingInstructionFactory> WithScalingInstructions<T1>(this CombinedResult<ScalingPlanFactory, T1> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ScalingInstruction> subFactoryAction = null) => new (combinedResult, combinedResult, WithScalingInstructions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScalingPlanFactory, InnerScalingPlanScalingInstructionFactory> WithScalingInstructions<T1>(this CombinedResult<T1, ScalingPlanFactory> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ScalingInstruction> subFactoryAction = null) => new (combinedResult, combinedResult, WithScalingInstructions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ScalingPlanFactory, T1, T2, InnerScalingPlanScalingInstructionFactory> WithScalingInstructions<T1, T2>(this CombinedResult<ScalingPlanFactory, T1, T2> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ScalingInstruction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScalingInstructions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScalingPlanFactory, T2, InnerScalingPlanScalingInstructionFactory> WithScalingInstructions<T1, T2>(this CombinedResult<T1, ScalingPlanFactory, T2> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ScalingInstruction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScalingInstructions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScalingPlanFactory, InnerScalingPlanScalingInstructionFactory> WithScalingInstructions<T1, T2>(this CombinedResult<T1, T2, ScalingPlanFactory> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ScalingInstruction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScalingInstructions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ScalingPlanFactory, T1, T2, T3, InnerScalingPlanScalingInstructionFactory> WithScalingInstructions<T1, T2, T3>(this CombinedResult<ScalingPlanFactory, T1, T2, T3> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ScalingInstruction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScalingInstructions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScalingPlanFactory, T2, T3, InnerScalingPlanScalingInstructionFactory> WithScalingInstructions<T1, T2, T3>(this CombinedResult<T1, ScalingPlanFactory, T2, T3> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ScalingInstruction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScalingInstructions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScalingPlanFactory, T3, InnerScalingPlanScalingInstructionFactory> WithScalingInstructions<T1, T2, T3>(this CombinedResult<T1, T2, ScalingPlanFactory, T3> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ScalingInstruction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScalingInstructions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ScalingPlanFactory, InnerScalingPlanScalingInstructionFactory> WithScalingInstructions<T1, T2, T3>(this CombinedResult<T1, T2, T3, ScalingPlanFactory> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ScalingInstruction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScalingInstructions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ScalingPlanFactory, T1, T2, T3, T4, InnerScalingPlanScalingInstructionFactory> WithScalingInstructions<T1, T2, T3, T4>(this CombinedResult<ScalingPlanFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ScalingInstruction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScalingInstructions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScalingPlanFactory, T2, T3, T4, InnerScalingPlanScalingInstructionFactory> WithScalingInstructions<T1, T2, T3, T4>(this CombinedResult<T1, ScalingPlanFactory, T2, T3, T4> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ScalingInstruction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScalingInstructions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScalingPlanFactory, T3, T4, InnerScalingPlanScalingInstructionFactory> WithScalingInstructions<T1, T2, T3, T4>(this CombinedResult<T1, T2, ScalingPlanFactory, T3, T4> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ScalingInstruction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScalingInstructions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ScalingPlanFactory, T4, InnerScalingPlanScalingInstructionFactory> WithScalingInstructions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ScalingPlanFactory, T4> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ScalingInstruction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScalingInstructions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ScalingPlanFactory, InnerScalingPlanScalingInstructionFactory> WithScalingInstructions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ScalingPlanFactory> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ScalingInstruction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScalingInstructions(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ScalingPlanFactory, T1, InnerScalingPlanApplicationSourceFactory> WithApplicationSource<T1>(this CombinedResult<ScalingPlanFactory, T1> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ApplicationSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplicationSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScalingPlanFactory, InnerScalingPlanApplicationSourceFactory> WithApplicationSource<T1>(this CombinedResult<T1, ScalingPlanFactory> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ApplicationSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplicationSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ScalingPlanFactory, T1, T2, InnerScalingPlanApplicationSourceFactory> WithApplicationSource<T1, T2>(this CombinedResult<ScalingPlanFactory, T1, T2> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ApplicationSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScalingPlanFactory, T2, InnerScalingPlanApplicationSourceFactory> WithApplicationSource<T1, T2>(this CombinedResult<T1, ScalingPlanFactory, T2> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ApplicationSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScalingPlanFactory, InnerScalingPlanApplicationSourceFactory> WithApplicationSource<T1, T2>(this CombinedResult<T1, T2, ScalingPlanFactory> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ApplicationSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ScalingPlanFactory, T1, T2, T3, InnerScalingPlanApplicationSourceFactory> WithApplicationSource<T1, T2, T3>(this CombinedResult<ScalingPlanFactory, T1, T2, T3> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ApplicationSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScalingPlanFactory, T2, T3, InnerScalingPlanApplicationSourceFactory> WithApplicationSource<T1, T2, T3>(this CombinedResult<T1, ScalingPlanFactory, T2, T3> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ApplicationSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScalingPlanFactory, T3, InnerScalingPlanApplicationSourceFactory> WithApplicationSource<T1, T2, T3>(this CombinedResult<T1, T2, ScalingPlanFactory, T3> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ApplicationSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ScalingPlanFactory, InnerScalingPlanApplicationSourceFactory> WithApplicationSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, ScalingPlanFactory> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ApplicationSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ScalingPlanFactory, T1, T2, T3, T4, InnerScalingPlanApplicationSourceFactory> WithApplicationSource<T1, T2, T3, T4>(this CombinedResult<ScalingPlanFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ApplicationSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScalingPlanFactory, T2, T3, T4, InnerScalingPlanApplicationSourceFactory> WithApplicationSource<T1, T2, T3, T4>(this CombinedResult<T1, ScalingPlanFactory, T2, T3, T4> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ApplicationSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScalingPlanFactory, T3, T4, InnerScalingPlanApplicationSourceFactory> WithApplicationSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, ScalingPlanFactory, T3, T4> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ApplicationSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ScalingPlanFactory, T4, InnerScalingPlanApplicationSourceFactory> WithApplicationSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ScalingPlanFactory, T4> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ApplicationSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ScalingPlanFactory, InnerScalingPlanApplicationSourceFactory> WithApplicationSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ScalingPlanFactory> combinedResult, Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ApplicationSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSource(combinedResult.T5, subFactoryAction));
}
