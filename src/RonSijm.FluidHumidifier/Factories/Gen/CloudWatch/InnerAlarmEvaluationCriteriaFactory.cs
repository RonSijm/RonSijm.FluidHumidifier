// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerAlarmEvaluationCriteriaFactory(Action<Humidifier.CloudWatch.AlarmTypes.EvaluationCriteria> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.AlarmTypes.EvaluationCriteria>
{

    internal InnerAlarmAlarmPromQLCriteriaFactory PromQLCriteriaFactory { get; set; }

    protected override Humidifier.CloudWatch.AlarmTypes.EvaluationCriteria Create()
    {
        var evaluationCriteriaResult = CreateEvaluationCriteria();
        factoryAction?.Invoke(evaluationCriteriaResult);

        return evaluationCriteriaResult;
    }

    private Humidifier.CloudWatch.AlarmTypes.EvaluationCriteria CreateEvaluationCriteria()
    {
        var evaluationCriteriaResult = new Humidifier.CloudWatch.AlarmTypes.EvaluationCriteria();

        return evaluationCriteriaResult;
    }
    public override void CreateChildren(Humidifier.CloudWatch.AlarmTypes.EvaluationCriteria result)
    {
        base.CreateChildren(result);

        result.PromQLCriteria ??= PromQLCriteriaFactory?.Build();
    }

} // End Of Class

public static class InnerAlarmEvaluationCriteriaFactoryExtensions
{
    public static CombinedResult<InnerAlarmEvaluationCriteriaFactory, InnerAlarmAlarmPromQLCriteriaFactory> WithPromQLCriteria(this InnerAlarmEvaluationCriteriaFactory parentFactory, Action<Humidifier.CloudWatch.AlarmTypes.AlarmPromQLCriteria> subFactoryAction = null)
    {
        parentFactory.PromQLCriteriaFactory = new InnerAlarmAlarmPromQLCriteriaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PromQLCriteriaFactory);
    }

    public static CombinedResult<InnerAlarmEvaluationCriteriaFactory, T1, InnerAlarmAlarmPromQLCriteriaFactory> WithPromQLCriteria<T1>(this CombinedResult<InnerAlarmEvaluationCriteriaFactory, T1> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmPromQLCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithPromQLCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAlarmEvaluationCriteriaFactory, InnerAlarmAlarmPromQLCriteriaFactory> WithPromQLCriteria<T1>(this CombinedResult<T1, InnerAlarmEvaluationCriteriaFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmPromQLCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithPromQLCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAlarmEvaluationCriteriaFactory, T1, T2, InnerAlarmAlarmPromQLCriteriaFactory> WithPromQLCriteria<T1, T2>(this CombinedResult<InnerAlarmEvaluationCriteriaFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmPromQLCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPromQLCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAlarmEvaluationCriteriaFactory, T2, InnerAlarmAlarmPromQLCriteriaFactory> WithPromQLCriteria<T1, T2>(this CombinedResult<T1, InnerAlarmEvaluationCriteriaFactory, T2> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmPromQLCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPromQLCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAlarmEvaluationCriteriaFactory, InnerAlarmAlarmPromQLCriteriaFactory> WithPromQLCriteria<T1, T2>(this CombinedResult<T1, T2, InnerAlarmEvaluationCriteriaFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmPromQLCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPromQLCriteria(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAlarmEvaluationCriteriaFactory, T1, T2, T3, InnerAlarmAlarmPromQLCriteriaFactory> WithPromQLCriteria<T1, T2, T3>(this CombinedResult<InnerAlarmEvaluationCriteriaFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmPromQLCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPromQLCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAlarmEvaluationCriteriaFactory, T2, T3, InnerAlarmAlarmPromQLCriteriaFactory> WithPromQLCriteria<T1, T2, T3>(this CombinedResult<T1, InnerAlarmEvaluationCriteriaFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmPromQLCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPromQLCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAlarmEvaluationCriteriaFactory, T3, InnerAlarmAlarmPromQLCriteriaFactory> WithPromQLCriteria<T1, T2, T3>(this CombinedResult<T1, T2, InnerAlarmEvaluationCriteriaFactory, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmPromQLCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPromQLCriteria(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAlarmEvaluationCriteriaFactory, InnerAlarmAlarmPromQLCriteriaFactory> WithPromQLCriteria<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAlarmEvaluationCriteriaFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmPromQLCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPromQLCriteria(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAlarmEvaluationCriteriaFactory, T1, T2, T3, T4, InnerAlarmAlarmPromQLCriteriaFactory> WithPromQLCriteria<T1, T2, T3, T4>(this CombinedResult<InnerAlarmEvaluationCriteriaFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmPromQLCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPromQLCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAlarmEvaluationCriteriaFactory, T2, T3, T4, InnerAlarmAlarmPromQLCriteriaFactory> WithPromQLCriteria<T1, T2, T3, T4>(this CombinedResult<T1, InnerAlarmEvaluationCriteriaFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmPromQLCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPromQLCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAlarmEvaluationCriteriaFactory, T3, T4, InnerAlarmAlarmPromQLCriteriaFactory> WithPromQLCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAlarmEvaluationCriteriaFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmPromQLCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPromQLCriteria(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAlarmEvaluationCriteriaFactory, T4, InnerAlarmAlarmPromQLCriteriaFactory> WithPromQLCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAlarmEvaluationCriteriaFactory, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmPromQLCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPromQLCriteria(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAlarmEvaluationCriteriaFactory, InnerAlarmAlarmPromQLCriteriaFactory> WithPromQLCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAlarmEvaluationCriteriaFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmPromQLCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPromQLCriteria(combinedResult.T5, subFactoryAction).T2);
}
