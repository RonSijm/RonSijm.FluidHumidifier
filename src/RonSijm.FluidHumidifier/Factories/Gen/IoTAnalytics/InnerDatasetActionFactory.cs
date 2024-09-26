// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerDatasetActionFactory(Action<Humidifier.IoTAnalytics.DatasetTypes.Action> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.DatasetTypes.Action>
{

    internal InnerDatasetContainerActionFactory ContainerActionFactory { get; set; }

    internal InnerDatasetQueryActionFactory QueryActionFactory { get; set; }

    protected override Humidifier.IoTAnalytics.DatasetTypes.Action Create()
    {
        var actionResult = CreateAction();
        factoryAction?.Invoke(actionResult);

        return actionResult;
    }

    private Humidifier.IoTAnalytics.DatasetTypes.Action CreateAction()
    {
        var actionResult = new Humidifier.IoTAnalytics.DatasetTypes.Action();

        return actionResult;
    }
    public override void CreateChildren(Humidifier.IoTAnalytics.DatasetTypes.Action result)
    {
        base.CreateChildren(result);

        result.ContainerAction ??= ContainerActionFactory?.Build();
        result.QueryAction ??= QueryActionFactory?.Build();
    }

} // End Of Class

public static class InnerDatasetActionFactoryExtensions
{
    public static CombinedResult<InnerDatasetActionFactory, InnerDatasetContainerActionFactory> WithContainerAction(this InnerDatasetActionFactory parentFactory, Action<Humidifier.IoTAnalytics.DatasetTypes.ContainerAction> subFactoryAction = null)
    {
        parentFactory.ContainerActionFactory = new InnerDatasetContainerActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ContainerActionFactory);
    }

    public static CombinedResult<InnerDatasetActionFactory, InnerDatasetQueryActionFactory> WithQueryAction(this InnerDatasetActionFactory parentFactory, Action<Humidifier.IoTAnalytics.DatasetTypes.QueryAction> subFactoryAction = null)
    {
        parentFactory.QueryActionFactory = new InnerDatasetQueryActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.QueryActionFactory);
    }

    public static CombinedResult<InnerDatasetActionFactory, T1, InnerDatasetContainerActionFactory> WithContainerAction<T1>(this CombinedResult<InnerDatasetActionFactory, T1> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ContainerAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetActionFactory, InnerDatasetContainerActionFactory> WithContainerAction<T1>(this CombinedResult<T1, InnerDatasetActionFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ContainerAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDatasetActionFactory, T1, T2, InnerDatasetContainerActionFactory> WithContainerAction<T1, T2>(this CombinedResult<InnerDatasetActionFactory, T1, T2> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ContainerAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetActionFactory, T2, InnerDatasetContainerActionFactory> WithContainerAction<T1, T2>(this CombinedResult<T1, InnerDatasetActionFactory, T2> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ContainerAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetActionFactory, InnerDatasetContainerActionFactory> WithContainerAction<T1, T2>(this CombinedResult<T1, T2, InnerDatasetActionFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ContainerAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDatasetActionFactory, T1, T2, T3, InnerDatasetContainerActionFactory> WithContainerAction<T1, T2, T3>(this CombinedResult<InnerDatasetActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ContainerAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetActionFactory, T2, T3, InnerDatasetContainerActionFactory> WithContainerAction<T1, T2, T3>(this CombinedResult<T1, InnerDatasetActionFactory, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ContainerAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetActionFactory, T3, InnerDatasetContainerActionFactory> WithContainerAction<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatasetActionFactory, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ContainerAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetActionFactory, InnerDatasetContainerActionFactory> WithContainerAction<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatasetActionFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ContainerAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDatasetActionFactory, T1, T2, T3, T4, InnerDatasetContainerActionFactory> WithContainerAction<T1, T2, T3, T4>(this CombinedResult<InnerDatasetActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ContainerAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetActionFactory, T2, T3, T4, InnerDatasetContainerActionFactory> WithContainerAction<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatasetActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ContainerAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetActionFactory, T3, T4, InnerDatasetContainerActionFactory> WithContainerAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatasetActionFactory, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ContainerAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetActionFactory, T4, InnerDatasetContainerActionFactory> WithContainerAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatasetActionFactory, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ContainerAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDatasetActionFactory, InnerDatasetContainerActionFactory> WithContainerAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatasetActionFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ContainerAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerAction(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerDatasetActionFactory, T1, InnerDatasetQueryActionFactory> WithQueryAction<T1>(this CombinedResult<InnerDatasetActionFactory, T1> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.QueryAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithQueryAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetActionFactory, InnerDatasetQueryActionFactory> WithQueryAction<T1>(this CombinedResult<T1, InnerDatasetActionFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.QueryAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithQueryAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDatasetActionFactory, T1, T2, InnerDatasetQueryActionFactory> WithQueryAction<T1, T2>(this CombinedResult<InnerDatasetActionFactory, T1, T2> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.QueryAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQueryAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetActionFactory, T2, InnerDatasetQueryActionFactory> WithQueryAction<T1, T2>(this CombinedResult<T1, InnerDatasetActionFactory, T2> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.QueryAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQueryAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetActionFactory, InnerDatasetQueryActionFactory> WithQueryAction<T1, T2>(this CombinedResult<T1, T2, InnerDatasetActionFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.QueryAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQueryAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDatasetActionFactory, T1, T2, T3, InnerDatasetQueryActionFactory> WithQueryAction<T1, T2, T3>(this CombinedResult<InnerDatasetActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.QueryAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueryAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetActionFactory, T2, T3, InnerDatasetQueryActionFactory> WithQueryAction<T1, T2, T3>(this CombinedResult<T1, InnerDatasetActionFactory, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.QueryAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueryAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetActionFactory, T3, InnerDatasetQueryActionFactory> WithQueryAction<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatasetActionFactory, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.QueryAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueryAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetActionFactory, InnerDatasetQueryActionFactory> WithQueryAction<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatasetActionFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.QueryAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueryAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDatasetActionFactory, T1, T2, T3, T4, InnerDatasetQueryActionFactory> WithQueryAction<T1, T2, T3, T4>(this CombinedResult<InnerDatasetActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.QueryAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueryAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetActionFactory, T2, T3, T4, InnerDatasetQueryActionFactory> WithQueryAction<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatasetActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.QueryAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueryAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetActionFactory, T3, T4, InnerDatasetQueryActionFactory> WithQueryAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatasetActionFactory, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.QueryAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueryAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetActionFactory, T4, InnerDatasetQueryActionFactory> WithQueryAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatasetActionFactory, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.QueryAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueryAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDatasetActionFactory, InnerDatasetQueryActionFactory> WithQueryAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatasetActionFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.QueryAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueryAction(combinedResult.T5, subFactoryAction));
}
