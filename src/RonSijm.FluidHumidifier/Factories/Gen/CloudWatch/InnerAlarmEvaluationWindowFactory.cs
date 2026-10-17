// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerAlarmEvaluationWindowFactory(Action<Humidifier.CloudWatch.AlarmTypes.EvaluationWindow> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.AlarmTypes.EvaluationWindow>
{

    internal InnerAlarmWallClockWindowFactory WallClockWindowFactory { get; set; }

    protected override Humidifier.CloudWatch.AlarmTypes.EvaluationWindow Create()
    {
        var evaluationWindowResult = CreateEvaluationWindow();
        factoryAction?.Invoke(evaluationWindowResult);

        return evaluationWindowResult;
    }

    private Humidifier.CloudWatch.AlarmTypes.EvaluationWindow CreateEvaluationWindow()
    {
        var evaluationWindowResult = new Humidifier.CloudWatch.AlarmTypes.EvaluationWindow();

        return evaluationWindowResult;
    }
    public override void CreateChildren(Humidifier.CloudWatch.AlarmTypes.EvaluationWindow result)
    {
        base.CreateChildren(result);

        result.WallClockWindow ??= WallClockWindowFactory?.Build();
    }

} // End Of Class

public static class InnerAlarmEvaluationWindowFactoryExtensions
{
    public static CombinedResult<InnerAlarmEvaluationWindowFactory, InnerAlarmWallClockWindowFactory> WithWallClockWindow(this InnerAlarmEvaluationWindowFactory parentFactory, Action<Humidifier.CloudWatch.AlarmTypes.WallClockWindow> subFactoryAction = null)
    {
        parentFactory.WallClockWindowFactory = new InnerAlarmWallClockWindowFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.WallClockWindowFactory);
    }

    public static CombinedResult<InnerAlarmEvaluationWindowFactory, T1, InnerAlarmWallClockWindowFactory> WithWallClockWindow<T1>(this CombinedResult<InnerAlarmEvaluationWindowFactory, T1> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.WallClockWindow> subFactoryAction = null) => new (combinedResult, combinedResult, WithWallClockWindow(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAlarmEvaluationWindowFactory, InnerAlarmWallClockWindowFactory> WithWallClockWindow<T1>(this CombinedResult<T1, InnerAlarmEvaluationWindowFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.WallClockWindow> subFactoryAction = null) => new (combinedResult, combinedResult, WithWallClockWindow(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAlarmEvaluationWindowFactory, T1, T2, InnerAlarmWallClockWindowFactory> WithWallClockWindow<T1, T2>(this CombinedResult<InnerAlarmEvaluationWindowFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.WallClockWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWallClockWindow(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAlarmEvaluationWindowFactory, T2, InnerAlarmWallClockWindowFactory> WithWallClockWindow<T1, T2>(this CombinedResult<T1, InnerAlarmEvaluationWindowFactory, T2> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.WallClockWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWallClockWindow(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAlarmEvaluationWindowFactory, InnerAlarmWallClockWindowFactory> WithWallClockWindow<T1, T2>(this CombinedResult<T1, T2, InnerAlarmEvaluationWindowFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.WallClockWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWallClockWindow(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAlarmEvaluationWindowFactory, T1, T2, T3, InnerAlarmWallClockWindowFactory> WithWallClockWindow<T1, T2, T3>(this CombinedResult<InnerAlarmEvaluationWindowFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.WallClockWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWallClockWindow(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAlarmEvaluationWindowFactory, T2, T3, InnerAlarmWallClockWindowFactory> WithWallClockWindow<T1, T2, T3>(this CombinedResult<T1, InnerAlarmEvaluationWindowFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.WallClockWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWallClockWindow(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAlarmEvaluationWindowFactory, T3, InnerAlarmWallClockWindowFactory> WithWallClockWindow<T1, T2, T3>(this CombinedResult<T1, T2, InnerAlarmEvaluationWindowFactory, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.WallClockWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWallClockWindow(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAlarmEvaluationWindowFactory, InnerAlarmWallClockWindowFactory> WithWallClockWindow<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAlarmEvaluationWindowFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.WallClockWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWallClockWindow(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAlarmEvaluationWindowFactory, T1, T2, T3, T4, InnerAlarmWallClockWindowFactory> WithWallClockWindow<T1, T2, T3, T4>(this CombinedResult<InnerAlarmEvaluationWindowFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.WallClockWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWallClockWindow(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAlarmEvaluationWindowFactory, T2, T3, T4, InnerAlarmWallClockWindowFactory> WithWallClockWindow<T1, T2, T3, T4>(this CombinedResult<T1, InnerAlarmEvaluationWindowFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.WallClockWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWallClockWindow(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAlarmEvaluationWindowFactory, T3, T4, InnerAlarmWallClockWindowFactory> WithWallClockWindow<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAlarmEvaluationWindowFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.WallClockWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWallClockWindow(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAlarmEvaluationWindowFactory, T4, InnerAlarmWallClockWindowFactory> WithWallClockWindow<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAlarmEvaluationWindowFactory, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.WallClockWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWallClockWindow(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAlarmEvaluationWindowFactory, InnerAlarmWallClockWindowFactory> WithWallClockWindow<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAlarmEvaluationWindowFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.WallClockWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWallClockWindow(combinedResult.T5, subFactoryAction).T2);
}
