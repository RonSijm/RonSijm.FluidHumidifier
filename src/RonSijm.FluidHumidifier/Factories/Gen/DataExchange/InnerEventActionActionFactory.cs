// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataExchange;

public class InnerEventActionActionFactory(Action<Humidifier.DataExchange.EventActionTypes.Action> factoryAction = null) : SubResourceFactory<Humidifier.DataExchange.EventActionTypes.Action>
{

    internal InnerEventActionAutoExportRevisionToS3RequestDetailsFactory ExportRevisionToS3Factory { get; set; }

    protected override Humidifier.DataExchange.EventActionTypes.Action Create()
    {
        var actionResult = CreateAction();
        factoryAction?.Invoke(actionResult);

        return actionResult;
    }

    private Humidifier.DataExchange.EventActionTypes.Action CreateAction()
    {
        var actionResult = new Humidifier.DataExchange.EventActionTypes.Action();

        return actionResult;
    }
    public override void CreateChildren(Humidifier.DataExchange.EventActionTypes.Action result)
    {
        base.CreateChildren(result);

        result.ExportRevisionToS3 ??= ExportRevisionToS3Factory?.Build();
    }

} // End Of Class

public static class InnerEventActionActionFactoryExtensions
{
    public static CombinedResult<InnerEventActionActionFactory, InnerEventActionAutoExportRevisionToS3RequestDetailsFactory> WithExportRevisionToS3(this InnerEventActionActionFactory parentFactory, Action<Humidifier.DataExchange.EventActionTypes.AutoExportRevisionToS3RequestDetails> subFactoryAction = null)
    {
        parentFactory.ExportRevisionToS3Factory = new InnerEventActionAutoExportRevisionToS3RequestDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExportRevisionToS3Factory);
    }

    public static CombinedResult<InnerEventActionActionFactory, T1, InnerEventActionAutoExportRevisionToS3RequestDetailsFactory> WithExportRevisionToS3<T1>(this CombinedResult<InnerEventActionActionFactory, T1> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.AutoExportRevisionToS3RequestDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithExportRevisionToS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEventActionActionFactory, InnerEventActionAutoExportRevisionToS3RequestDetailsFactory> WithExportRevisionToS3<T1>(this CombinedResult<T1, InnerEventActionActionFactory> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.AutoExportRevisionToS3RequestDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithExportRevisionToS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerEventActionActionFactory, T1, T2, InnerEventActionAutoExportRevisionToS3RequestDetailsFactory> WithExportRevisionToS3<T1, T2>(this CombinedResult<InnerEventActionActionFactory, T1, T2> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.AutoExportRevisionToS3RequestDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExportRevisionToS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEventActionActionFactory, T2, InnerEventActionAutoExportRevisionToS3RequestDetailsFactory> WithExportRevisionToS3<T1, T2>(this CombinedResult<T1, InnerEventActionActionFactory, T2> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.AutoExportRevisionToS3RequestDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExportRevisionToS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEventActionActionFactory, InnerEventActionAutoExportRevisionToS3RequestDetailsFactory> WithExportRevisionToS3<T1, T2>(this CombinedResult<T1, T2, InnerEventActionActionFactory> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.AutoExportRevisionToS3RequestDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExportRevisionToS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerEventActionActionFactory, T1, T2, T3, InnerEventActionAutoExportRevisionToS3RequestDetailsFactory> WithExportRevisionToS3<T1, T2, T3>(this CombinedResult<InnerEventActionActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.AutoExportRevisionToS3RequestDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportRevisionToS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEventActionActionFactory, T2, T3, InnerEventActionAutoExportRevisionToS3RequestDetailsFactory> WithExportRevisionToS3<T1, T2, T3>(this CombinedResult<T1, InnerEventActionActionFactory, T2, T3> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.AutoExportRevisionToS3RequestDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportRevisionToS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEventActionActionFactory, T3, InnerEventActionAutoExportRevisionToS3RequestDetailsFactory> WithExportRevisionToS3<T1, T2, T3>(this CombinedResult<T1, T2, InnerEventActionActionFactory, T3> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.AutoExportRevisionToS3RequestDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportRevisionToS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEventActionActionFactory, InnerEventActionAutoExportRevisionToS3RequestDetailsFactory> WithExportRevisionToS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEventActionActionFactory> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.AutoExportRevisionToS3RequestDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportRevisionToS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerEventActionActionFactory, T1, T2, T3, T4, InnerEventActionAutoExportRevisionToS3RequestDetailsFactory> WithExportRevisionToS3<T1, T2, T3, T4>(this CombinedResult<InnerEventActionActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.AutoExportRevisionToS3RequestDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportRevisionToS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEventActionActionFactory, T2, T3, T4, InnerEventActionAutoExportRevisionToS3RequestDetailsFactory> WithExportRevisionToS3<T1, T2, T3, T4>(this CombinedResult<T1, InnerEventActionActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.AutoExportRevisionToS3RequestDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportRevisionToS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEventActionActionFactory, T3, T4, InnerEventActionAutoExportRevisionToS3RequestDetailsFactory> WithExportRevisionToS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEventActionActionFactory, T3, T4> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.AutoExportRevisionToS3RequestDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportRevisionToS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEventActionActionFactory, T4, InnerEventActionAutoExportRevisionToS3RequestDetailsFactory> WithExportRevisionToS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEventActionActionFactory, T4> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.AutoExportRevisionToS3RequestDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportRevisionToS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerEventActionActionFactory, InnerEventActionAutoExportRevisionToS3RequestDetailsFactory> WithExportRevisionToS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEventActionActionFactory> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.AutoExportRevisionToS3RequestDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportRevisionToS3(combinedResult.T5, subFactoryAction).T2);
}
