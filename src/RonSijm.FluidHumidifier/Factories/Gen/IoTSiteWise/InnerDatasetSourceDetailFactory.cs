// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerDatasetSourceDetailFactory(Action<Humidifier.IoTSiteWise.DatasetTypes.SourceDetail> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.DatasetTypes.SourceDetail>
{

    internal InnerDatasetKendraSourceDetailFactory KendraFactory { get; set; }

    protected override Humidifier.IoTSiteWise.DatasetTypes.SourceDetail Create()
    {
        var sourceDetailResult = CreateSourceDetail();
        factoryAction?.Invoke(sourceDetailResult);

        return sourceDetailResult;
    }

    private Humidifier.IoTSiteWise.DatasetTypes.SourceDetail CreateSourceDetail()
    {
        var sourceDetailResult = new Humidifier.IoTSiteWise.DatasetTypes.SourceDetail();

        return sourceDetailResult;
    }
    public override void CreateChildren(Humidifier.IoTSiteWise.DatasetTypes.SourceDetail result)
    {
        base.CreateChildren(result);

        result.Kendra ??= KendraFactory?.Build();
    }

} // End Of Class

public static class InnerDatasetSourceDetailFactoryExtensions
{
    public static CombinedResult<InnerDatasetSourceDetailFactory, InnerDatasetKendraSourceDetailFactory> WithKendra(this InnerDatasetSourceDetailFactory parentFactory, Action<Humidifier.IoTSiteWise.DatasetTypes.KendraSourceDetail> subFactoryAction = null)
    {
        parentFactory.KendraFactory = new InnerDatasetKendraSourceDetailFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.KendraFactory);
    }

    public static CombinedResult<InnerDatasetSourceDetailFactory, T1, InnerDatasetKendraSourceDetailFactory> WithKendra<T1>(this CombinedResult<InnerDatasetSourceDetailFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.KendraSourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, WithKendra(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDatasetSourceDetailFactory, InnerDatasetKendraSourceDetailFactory> WithKendra<T1>(this CombinedResult<T1, InnerDatasetSourceDetailFactory> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.KendraSourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, WithKendra(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDatasetSourceDetailFactory, T1, T2, InnerDatasetKendraSourceDetailFactory> WithKendra<T1, T2>(this CombinedResult<InnerDatasetSourceDetailFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.KendraSourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKendra(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDatasetSourceDetailFactory, T2, InnerDatasetKendraSourceDetailFactory> WithKendra<T1, T2>(this CombinedResult<T1, InnerDatasetSourceDetailFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.KendraSourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKendra(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDatasetSourceDetailFactory, InnerDatasetKendraSourceDetailFactory> WithKendra<T1, T2>(this CombinedResult<T1, T2, InnerDatasetSourceDetailFactory> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.KendraSourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKendra(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDatasetSourceDetailFactory, T1, T2, T3, InnerDatasetKendraSourceDetailFactory> WithKendra<T1, T2, T3>(this CombinedResult<InnerDatasetSourceDetailFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.KendraSourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKendra(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDatasetSourceDetailFactory, T2, T3, InnerDatasetKendraSourceDetailFactory> WithKendra<T1, T2, T3>(this CombinedResult<T1, InnerDatasetSourceDetailFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.KendraSourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKendra(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDatasetSourceDetailFactory, T3, InnerDatasetKendraSourceDetailFactory> WithKendra<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatasetSourceDetailFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.KendraSourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKendra(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDatasetSourceDetailFactory, InnerDatasetKendraSourceDetailFactory> WithKendra<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatasetSourceDetailFactory> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.KendraSourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKendra(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDatasetSourceDetailFactory, T1, T2, T3, T4, InnerDatasetKendraSourceDetailFactory> WithKendra<T1, T2, T3, T4>(this CombinedResult<InnerDatasetSourceDetailFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.KendraSourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKendra(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDatasetSourceDetailFactory, T2, T3, T4, InnerDatasetKendraSourceDetailFactory> WithKendra<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatasetSourceDetailFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.KendraSourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKendra(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDatasetSourceDetailFactory, T3, T4, InnerDatasetKendraSourceDetailFactory> WithKendra<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatasetSourceDetailFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.KendraSourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKendra(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDatasetSourceDetailFactory, T4, InnerDatasetKendraSourceDetailFactory> WithKendra<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatasetSourceDetailFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.KendraSourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKendra(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDatasetSourceDetailFactory, InnerDatasetKendraSourceDetailFactory> WithKendra<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatasetSourceDetailFactory> combinedResult, Action<Humidifier.IoTSiteWise.DatasetTypes.KendraSourceDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKendra(combinedResult.T5, subFactoryAction).T2);
}
