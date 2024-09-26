// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerTaskDestinationFactory(Action<Humidifier.DataSync.TaskTypes.Destination> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.TaskTypes.Destination>
{

    internal InnerTaskTaskReportConfigDestinationS3Factory S3Factory { get; set; }

    protected override Humidifier.DataSync.TaskTypes.Destination Create()
    {
        var destinationResult = CreateDestination();
        factoryAction?.Invoke(destinationResult);

        return destinationResult;
    }

    private Humidifier.DataSync.TaskTypes.Destination CreateDestination()
    {
        var destinationResult = new Humidifier.DataSync.TaskTypes.Destination();

        return destinationResult;
    }
    public override void CreateChildren(Humidifier.DataSync.TaskTypes.Destination result)
    {
        base.CreateChildren(result);

        result.S3 ??= S3Factory?.Build();
    }

} // End Of Class

public static class InnerTaskDestinationFactoryExtensions
{
    public static CombinedResult<InnerTaskDestinationFactory, InnerTaskTaskReportConfigDestinationS3Factory> WithS3(this InnerTaskDestinationFactory parentFactory, Action<Humidifier.DataSync.TaskTypes.TaskReportConfigDestinationS3> subFactoryAction = null)
    {
        parentFactory.S3Factory = new InnerTaskTaskReportConfigDestinationS3Factory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3Factory);
    }

    public static CombinedResult<InnerTaskDestinationFactory, T1, InnerTaskTaskReportConfigDestinationS3Factory> WithS3<T1>(this CombinedResult<InnerTaskDestinationFactory, T1> combinedResult, Action<Humidifier.DataSync.TaskTypes.TaskReportConfigDestinationS3> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskDestinationFactory, InnerTaskTaskReportConfigDestinationS3Factory> WithS3<T1>(this CombinedResult<T1, InnerTaskDestinationFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.TaskReportConfigDestinationS3> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTaskDestinationFactory, T1, T2, InnerTaskTaskReportConfigDestinationS3Factory> WithS3<T1, T2>(this CombinedResult<InnerTaskDestinationFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.TaskTypes.TaskReportConfigDestinationS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskDestinationFactory, T2, InnerTaskTaskReportConfigDestinationS3Factory> WithS3<T1, T2>(this CombinedResult<T1, InnerTaskDestinationFactory, T2> combinedResult, Action<Humidifier.DataSync.TaskTypes.TaskReportConfigDestinationS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskDestinationFactory, InnerTaskTaskReportConfigDestinationS3Factory> WithS3<T1, T2>(this CombinedResult<T1, T2, InnerTaskDestinationFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.TaskReportConfigDestinationS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTaskDestinationFactory, T1, T2, T3, InnerTaskTaskReportConfigDestinationS3Factory> WithS3<T1, T2, T3>(this CombinedResult<InnerTaskDestinationFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.TaskReportConfigDestinationS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskDestinationFactory, T2, T3, InnerTaskTaskReportConfigDestinationS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, InnerTaskDestinationFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.TaskReportConfigDestinationS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskDestinationFactory, T3, InnerTaskTaskReportConfigDestinationS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, InnerTaskDestinationFactory, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.TaskReportConfigDestinationS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskDestinationFactory, InnerTaskTaskReportConfigDestinationS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTaskDestinationFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.TaskReportConfigDestinationS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTaskDestinationFactory, T1, T2, T3, T4, InnerTaskTaskReportConfigDestinationS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<InnerTaskDestinationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.TaskReportConfigDestinationS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskDestinationFactory, T2, T3, T4, InnerTaskTaskReportConfigDestinationS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, InnerTaskDestinationFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.TaskReportConfigDestinationS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskDestinationFactory, T3, T4, InnerTaskTaskReportConfigDestinationS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTaskDestinationFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.TaskReportConfigDestinationS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskDestinationFactory, T4, InnerTaskTaskReportConfigDestinationS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTaskDestinationFactory, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.TaskReportConfigDestinationS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTaskDestinationFactory, InnerTaskTaskReportConfigDestinationS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTaskDestinationFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.TaskReportConfigDestinationS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T5, subFactoryAction));
}
