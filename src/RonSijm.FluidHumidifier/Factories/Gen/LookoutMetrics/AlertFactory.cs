// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LookoutMetrics;

public class AlertFactory(string resourceName = null, Action<Humidifier.LookoutMetrics.Alert> factoryAction = null) : ResourceFactory<Humidifier.LookoutMetrics.Alert>(resourceName)
{

    internal InnerAlertActionFactory ActionFactory { get; set; }

    protected override Humidifier.LookoutMetrics.Alert Create()
    {
        var alertResult = CreateAlert();
        factoryAction?.Invoke(alertResult);

        return alertResult;
    }

    private Humidifier.LookoutMetrics.Alert CreateAlert()
    {
        var alertResult = new Humidifier.LookoutMetrics.Alert
        {
            GivenName = InputResourceName,
        };

        return alertResult;
    }
    public override void CreateChildren(Humidifier.LookoutMetrics.Alert result)
    {
        base.CreateChildren(result);

        result.Action ??= ActionFactory?.Build();
    }

} // End Of Class

public static class AlertFactoryExtensions
{
    public static CombinedResult<AlertFactory, InnerAlertActionFactory> WithAction(this AlertFactory parentFactory, Action<Humidifier.LookoutMetrics.AlertTypes.Action> subFactoryAction = null)
    {
        parentFactory.ActionFactory = new InnerAlertActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ActionFactory);
    }

    public static CombinedResult<AlertFactory, T1, InnerAlertActionFactory> WithAction<T1>(this CombinedResult<AlertFactory, T1> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AlertFactory, InnerAlertActionFactory> WithAction<T1>(this CombinedResult<T1, AlertFactory> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AlertFactory, T1, T2, InnerAlertActionFactory> WithAction<T1, T2>(this CombinedResult<AlertFactory, T1, T2> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AlertFactory, T2, InnerAlertActionFactory> WithAction<T1, T2>(this CombinedResult<T1, AlertFactory, T2> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AlertFactory, InnerAlertActionFactory> WithAction<T1, T2>(this CombinedResult<T1, T2, AlertFactory> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AlertFactory, T1, T2, T3, InnerAlertActionFactory> WithAction<T1, T2, T3>(this CombinedResult<AlertFactory, T1, T2, T3> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AlertFactory, T2, T3, InnerAlertActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, AlertFactory, T2, T3> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AlertFactory, T3, InnerAlertActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, AlertFactory, T3> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AlertFactory, InnerAlertActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, T3, AlertFactory> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AlertFactory, T1, T2, T3, T4, InnerAlertActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<AlertFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AlertFactory, T2, T3, T4, InnerAlertActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, AlertFactory, T2, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AlertFactory, T3, T4, InnerAlertActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, AlertFactory, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AlertFactory, T4, InnerAlertActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AlertFactory, T4> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AlertFactory, InnerAlertActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AlertFactory> combinedResult, Action<Humidifier.LookoutMetrics.AlertTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T5, subFactoryAction));
}
