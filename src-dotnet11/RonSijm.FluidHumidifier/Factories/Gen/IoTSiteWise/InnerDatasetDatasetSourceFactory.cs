// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerDatasetDatasetSourceFactory(Action<Humidifier.IoTSiteWise.DatasetTypes.DatasetSource> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.DatasetTypes.DatasetSource>
{

    internal InnerDatasetSourceDetailFactory SourceDetailFactory { get; set; }

    protected override Humidifier.IoTSiteWise.DatasetTypes.DatasetSource Create()
    {
        var datasetSourceResult = CreateDatasetSource();
        factoryAction?.Invoke(datasetSourceResult);

        return datasetSourceResult;
    }

    private Humidifier.IoTSiteWise.DatasetTypes.DatasetSource CreateDatasetSource()
    {
        var datasetSourceResult = new Humidifier.IoTSiteWise.DatasetTypes.DatasetSource();

        return datasetSourceResult;
    }
    public override void CreateChildren(Humidifier.IoTSiteWise.DatasetTypes.DatasetSource result)
    {
        base.CreateChildren(result);

        result.SourceDetail ??= SourceDetailFactory?.Build();
    }

} // End Of Class

public static class InnerDatasetDatasetSourceFactoryExtensions
{
    public static CombinedResult<InnerDatasetDatasetSourceFactory, InnerDatasetSourceDetailFactory> WithSourceDetail(this InnerDatasetDatasetSourceFactory parentFactory, Action<Humidifier.IoTSiteWise.DatasetTypes.SourceDetail> subFactoryAction = null)
    {
        parentFactory.SourceDetailFactory = new InnerDatasetSourceDetailFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceDetailFactory);
    }

    public static CombinedResult<InnerDatasetDatasetSourceFactory, T1, InnerDatasetSourceDetailFactory> WithSourceDetail<T1>(this CombinedResult<InnerDatasetDatasetSourceFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceDetail(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDatasetDatasetSourceFactory, InnerDatasetSourceDetailFactory> WithSourceDetail<T1>(this CombinedResult<T1, InnerDatasetDatasetSourceFactory> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceDetail(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDatasetDatasetSourceFactory, T1, T2, InnerDatasetSourceDetailFactory> WithSourceDetail<T1, T2>(this CombinedResult<InnerDatasetDatasetSourceFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceDetail(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDatasetDatasetSourceFactory, T2, InnerDatasetSourceDetailFactory> WithSourceDetail<T1, T2>(this CombinedResult<T1, InnerDatasetDatasetSourceFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceDetail(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDatasetDatasetSourceFactory, InnerDatasetSourceDetailFactory> WithSourceDetail<T1, T2>(this CombinedResult<T1, T2, InnerDatasetDatasetSourceFactory> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceDetail(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDatasetDatasetSourceFactory, T1, T2, T3, InnerDatasetSourceDetailFactory> WithSourceDetail<T1, T2, T3>(this CombinedResult<InnerDatasetDatasetSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDetail(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDatasetDatasetSourceFactory, T2, T3, InnerDatasetSourceDetailFactory> WithSourceDetail<T1, T2, T3>(this CombinedResult<T1, InnerDatasetDatasetSourceFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDetail(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDatasetDatasetSourceFactory, T3, InnerDatasetSourceDetailFactory> WithSourceDetail<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatasetDatasetSourceFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDetail(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDatasetDatasetSourceFactory, InnerDatasetSourceDetailFactory> WithSourceDetail<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatasetDatasetSourceFactory> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDetail(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDatasetDatasetSourceFactory, T1, T2, T3, T4, InnerDatasetSourceDetailFactory> WithSourceDetail<T1, T2, T3, T4>(this CombinedResult<InnerDatasetDatasetSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDetail(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDatasetDatasetSourceFactory, T2, T3, T4, InnerDatasetSourceDetailFactory> WithSourceDetail<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatasetDatasetSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDetail(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDatasetDatasetSourceFactory, T3, T4, InnerDatasetSourceDetailFactory> WithSourceDetail<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatasetDatasetSourceFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDetail(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDatasetDatasetSourceFactory, T4, InnerDatasetSourceDetailFactory> WithSourceDetail<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatasetDatasetSourceFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDetail(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDatasetDatasetSourceFactory, InnerDatasetSourceDetailFactory> WithSourceDetail<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatasetDatasetSourceFactory> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.SourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDetail(combinedResult.T5, subFactoryAction).T2);
}
