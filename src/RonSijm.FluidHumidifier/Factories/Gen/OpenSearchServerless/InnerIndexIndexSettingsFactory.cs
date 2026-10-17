// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchServerless;

public class InnerIndexIndexSettingsFactory(Action<Humidifier.OpenSearchServerless.IndexTypes.IndexSettings> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchServerless.IndexTypes.IndexSettings>
{

    internal InnerIndexAnalysisFactory AnalysisFactory { get; set; }

    internal InnerIndexIndexFactory IndexFactory { get; set; }

    protected override Humidifier.OpenSearchServerless.IndexTypes.IndexSettings Create()
    {
        var indexSettingsResult = CreateIndexSettings();
        factoryAction?.Invoke(indexSettingsResult);

        return indexSettingsResult;
    }

    private Humidifier.OpenSearchServerless.IndexTypes.IndexSettings CreateIndexSettings()
    {
        var indexSettingsResult = new Humidifier.OpenSearchServerless.IndexTypes.IndexSettings();

        return indexSettingsResult;
    }
    public override void CreateChildren(Humidifier.OpenSearchServerless.IndexTypes.IndexSettings result)
    {
        base.CreateChildren(result);

        result.Analysis ??= AnalysisFactory?.Build();
        result.Index ??= IndexFactory?.Build();
    }

} // End Of Class

public static class InnerIndexIndexSettingsFactoryExtensions
{
    public static CombinedResult<InnerIndexIndexSettingsFactory, InnerIndexAnalysisFactory> WithAnalysis(this InnerIndexIndexSettingsFactory parentFactory, Action<Humidifier.OpenSearchServerless.IndexTypes.Analysis> subFactoryAction = null)
    {
        parentFactory.AnalysisFactory = new InnerIndexAnalysisFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AnalysisFactory);
    }

    public static CombinedResult<InnerIndexIndexSettingsFactory, InnerIndexIndexFactory> WithIndex(this InnerIndexIndexSettingsFactory parentFactory, Action<Humidifier.OpenSearchServerless.IndexTypes.Index> subFactoryAction = null)
    {
        parentFactory.IndexFactory = new InnerIndexIndexFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IndexFactory);
    }

    public static CombinedResult<InnerIndexIndexSettingsFactory, T1, InnerIndexAnalysisFactory> WithAnalysis<T1>(this CombinedResult<InnerIndexIndexSettingsFactory, T1> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Analysis> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnalysis(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIndexIndexSettingsFactory, InnerIndexAnalysisFactory> WithAnalysis<T1>(this CombinedResult<T1, InnerIndexIndexSettingsFactory> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Analysis> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnalysis(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerIndexIndexSettingsFactory, T1, T2, InnerIndexAnalysisFactory> WithAnalysis<T1, T2>(this CombinedResult<InnerIndexIndexSettingsFactory, T1, T2> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Analysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnalysis(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIndexIndexSettingsFactory, T2, InnerIndexAnalysisFactory> WithAnalysis<T1, T2>(this CombinedResult<T1, InnerIndexIndexSettingsFactory, T2> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Analysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnalysis(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIndexIndexSettingsFactory, InnerIndexAnalysisFactory> WithAnalysis<T1, T2>(this CombinedResult<T1, T2, InnerIndexIndexSettingsFactory> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Analysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnalysis(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerIndexIndexSettingsFactory, T1, T2, T3, InnerIndexAnalysisFactory> WithAnalysis<T1, T2, T3>(this CombinedResult<InnerIndexIndexSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Analysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysis(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIndexIndexSettingsFactory, T2, T3, InnerIndexAnalysisFactory> WithAnalysis<T1, T2, T3>(this CombinedResult<T1, InnerIndexIndexSettingsFactory, T2, T3> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Analysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysis(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIndexIndexSettingsFactory, T3, InnerIndexAnalysisFactory> WithAnalysis<T1, T2, T3>(this CombinedResult<T1, T2, InnerIndexIndexSettingsFactory, T3> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Analysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysis(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIndexIndexSettingsFactory, InnerIndexAnalysisFactory> WithAnalysis<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerIndexIndexSettingsFactory> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Analysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysis(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerIndexIndexSettingsFactory, T1, T2, T3, T4, InnerIndexAnalysisFactory> WithAnalysis<T1, T2, T3, T4>(this CombinedResult<InnerIndexIndexSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Analysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysis(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIndexIndexSettingsFactory, T2, T3, T4, InnerIndexAnalysisFactory> WithAnalysis<T1, T2, T3, T4>(this CombinedResult<T1, InnerIndexIndexSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Analysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysis(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIndexIndexSettingsFactory, T3, T4, InnerIndexAnalysisFactory> WithAnalysis<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerIndexIndexSettingsFactory, T3, T4> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Analysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysis(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIndexIndexSettingsFactory, T4, InnerIndexAnalysisFactory> WithAnalysis<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerIndexIndexSettingsFactory, T4> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Analysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysis(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerIndexIndexSettingsFactory, InnerIndexAnalysisFactory> WithAnalysis<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerIndexIndexSettingsFactory> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Analysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysis(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerIndexIndexSettingsFactory, T1, InnerIndexIndexFactory> WithIndex<T1>(this CombinedResult<InnerIndexIndexSettingsFactory, T1> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Index> subFactoryAction = null) => new (combinedResult, combinedResult, WithIndex(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIndexIndexSettingsFactory, InnerIndexIndexFactory> WithIndex<T1>(this CombinedResult<T1, InnerIndexIndexSettingsFactory> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Index> subFactoryAction = null) => new (combinedResult, combinedResult, WithIndex(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerIndexIndexSettingsFactory, T1, T2, InnerIndexIndexFactory> WithIndex<T1, T2>(this CombinedResult<InnerIndexIndexSettingsFactory, T1, T2> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Index> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIndex(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIndexIndexSettingsFactory, T2, InnerIndexIndexFactory> WithIndex<T1, T2>(this CombinedResult<T1, InnerIndexIndexSettingsFactory, T2> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Index> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIndex(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIndexIndexSettingsFactory, InnerIndexIndexFactory> WithIndex<T1, T2>(this CombinedResult<T1, T2, InnerIndexIndexSettingsFactory> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Index> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIndex(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerIndexIndexSettingsFactory, T1, T2, T3, InnerIndexIndexFactory> WithIndex<T1, T2, T3>(this CombinedResult<InnerIndexIndexSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Index> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIndex(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIndexIndexSettingsFactory, T2, T3, InnerIndexIndexFactory> WithIndex<T1, T2, T3>(this CombinedResult<T1, InnerIndexIndexSettingsFactory, T2, T3> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Index> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIndex(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIndexIndexSettingsFactory, T3, InnerIndexIndexFactory> WithIndex<T1, T2, T3>(this CombinedResult<T1, T2, InnerIndexIndexSettingsFactory, T3> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Index> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIndex(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIndexIndexSettingsFactory, InnerIndexIndexFactory> WithIndex<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerIndexIndexSettingsFactory> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Index> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIndex(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerIndexIndexSettingsFactory, T1, T2, T3, T4, InnerIndexIndexFactory> WithIndex<T1, T2, T3, T4>(this CombinedResult<InnerIndexIndexSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Index> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIndex(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIndexIndexSettingsFactory, T2, T3, T4, InnerIndexIndexFactory> WithIndex<T1, T2, T3, T4>(this CombinedResult<T1, InnerIndexIndexSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Index> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIndex(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIndexIndexSettingsFactory, T3, T4, InnerIndexIndexFactory> WithIndex<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerIndexIndexSettingsFactory, T3, T4> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Index> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIndex(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIndexIndexSettingsFactory, T4, InnerIndexIndexFactory> WithIndex<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerIndexIndexSettingsFactory, T4> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Index> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIndex(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerIndexIndexSettingsFactory, InnerIndexIndexFactory> WithIndex<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerIndexIndexSettingsFactory> combinedResult, Action<Humidifier.OpenSearchServerless.IndexTypes.Index> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIndex(combinedResult.T5, subFactoryAction).T2);
}
