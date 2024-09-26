// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KendraRanking;

public class ExecutionPlanFactory(string resourceName = null, Action<Humidifier.KendraRanking.ExecutionPlan> factoryAction = null) : ResourceFactory<Humidifier.KendraRanking.ExecutionPlan>(resourceName)
{

    internal InnerExecutionPlanCapacityUnitsConfigurationFactory CapacityUnitsFactory { get; set; }

    protected override Humidifier.KendraRanking.ExecutionPlan Create()
    {
        var executionPlanResult = CreateExecutionPlan();
        factoryAction?.Invoke(executionPlanResult);

        return executionPlanResult;
    }

    private Humidifier.KendraRanking.ExecutionPlan CreateExecutionPlan()
    {
        var executionPlanResult = new Humidifier.KendraRanking.ExecutionPlan
        {
            GivenName = InputResourceName,
        };

        return executionPlanResult;
    }
    public override void CreateChildren(Humidifier.KendraRanking.ExecutionPlan result)
    {
        base.CreateChildren(result);

        result.CapacityUnits ??= CapacityUnitsFactory?.Build();
    }

} // End Of Class

public static class ExecutionPlanFactoryExtensions
{
    public static CombinedResult<ExecutionPlanFactory, InnerExecutionPlanCapacityUnitsConfigurationFactory> WithCapacityUnits(this ExecutionPlanFactory parentFactory, Action<Humidifier.KendraRanking.ExecutionPlanTypes.CapacityUnitsConfiguration> subFactoryAction = null)
    {
        parentFactory.CapacityUnitsFactory = new InnerExecutionPlanCapacityUnitsConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CapacityUnitsFactory);
    }

    public static CombinedResult<ExecutionPlanFactory, T1, InnerExecutionPlanCapacityUnitsConfigurationFactory> WithCapacityUnits<T1>(this CombinedResult<ExecutionPlanFactory, T1> combinedResult, Action<Humidifier.KendraRanking.ExecutionPlanTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityUnits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExecutionPlanFactory, InnerExecutionPlanCapacityUnitsConfigurationFactory> WithCapacityUnits<T1>(this CombinedResult<T1, ExecutionPlanFactory> combinedResult, Action<Humidifier.KendraRanking.ExecutionPlanTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityUnits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ExecutionPlanFactory, T1, T2, InnerExecutionPlanCapacityUnitsConfigurationFactory> WithCapacityUnits<T1, T2>(this CombinedResult<ExecutionPlanFactory, T1, T2> combinedResult, Action<Humidifier.KendraRanking.ExecutionPlanTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityUnits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExecutionPlanFactory, T2, InnerExecutionPlanCapacityUnitsConfigurationFactory> WithCapacityUnits<T1, T2>(this CombinedResult<T1, ExecutionPlanFactory, T2> combinedResult, Action<Humidifier.KendraRanking.ExecutionPlanTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityUnits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ExecutionPlanFactory, InnerExecutionPlanCapacityUnitsConfigurationFactory> WithCapacityUnits<T1, T2>(this CombinedResult<T1, T2, ExecutionPlanFactory> combinedResult, Action<Humidifier.KendraRanking.ExecutionPlanTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityUnits(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ExecutionPlanFactory, T1, T2, T3, InnerExecutionPlanCapacityUnitsConfigurationFactory> WithCapacityUnits<T1, T2, T3>(this CombinedResult<ExecutionPlanFactory, T1, T2, T3> combinedResult, Action<Humidifier.KendraRanking.ExecutionPlanTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityUnits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExecutionPlanFactory, T2, T3, InnerExecutionPlanCapacityUnitsConfigurationFactory> WithCapacityUnits<T1, T2, T3>(this CombinedResult<T1, ExecutionPlanFactory, T2, T3> combinedResult, Action<Humidifier.KendraRanking.ExecutionPlanTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityUnits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ExecutionPlanFactory, T3, InnerExecutionPlanCapacityUnitsConfigurationFactory> WithCapacityUnits<T1, T2, T3>(this CombinedResult<T1, T2, ExecutionPlanFactory, T3> combinedResult, Action<Humidifier.KendraRanking.ExecutionPlanTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityUnits(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ExecutionPlanFactory, InnerExecutionPlanCapacityUnitsConfigurationFactory> WithCapacityUnits<T1, T2, T3>(this CombinedResult<T1, T2, T3, ExecutionPlanFactory> combinedResult, Action<Humidifier.KendraRanking.ExecutionPlanTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityUnits(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ExecutionPlanFactory, T1, T2, T3, T4, InnerExecutionPlanCapacityUnitsConfigurationFactory> WithCapacityUnits<T1, T2, T3, T4>(this CombinedResult<ExecutionPlanFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KendraRanking.ExecutionPlanTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityUnits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExecutionPlanFactory, T2, T3, T4, InnerExecutionPlanCapacityUnitsConfigurationFactory> WithCapacityUnits<T1, T2, T3, T4>(this CombinedResult<T1, ExecutionPlanFactory, T2, T3, T4> combinedResult, Action<Humidifier.KendraRanking.ExecutionPlanTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityUnits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ExecutionPlanFactory, T3, T4, InnerExecutionPlanCapacityUnitsConfigurationFactory> WithCapacityUnits<T1, T2, T3, T4>(this CombinedResult<T1, T2, ExecutionPlanFactory, T3, T4> combinedResult, Action<Humidifier.KendraRanking.ExecutionPlanTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityUnits(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ExecutionPlanFactory, T4, InnerExecutionPlanCapacityUnitsConfigurationFactory> WithCapacityUnits<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ExecutionPlanFactory, T4> combinedResult, Action<Humidifier.KendraRanking.ExecutionPlanTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityUnits(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ExecutionPlanFactory, InnerExecutionPlanCapacityUnitsConfigurationFactory> WithCapacityUnits<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ExecutionPlanFactory> combinedResult, Action<Humidifier.KendraRanking.ExecutionPlanTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityUnits(combinedResult.T5, subFactoryAction));
}
