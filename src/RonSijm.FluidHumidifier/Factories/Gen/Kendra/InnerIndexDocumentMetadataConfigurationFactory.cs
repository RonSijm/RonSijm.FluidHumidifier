// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerIndexDocumentMetadataConfigurationFactory(Action<Humidifier.Kendra.IndexTypes.DocumentMetadataConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.IndexTypes.DocumentMetadataConfiguration>
{

    internal InnerIndexRelevanceFactory RelevanceFactory { get; set; }

    internal InnerIndexSearchFactory SearchFactory { get; set; }

    protected override Humidifier.Kendra.IndexTypes.DocumentMetadataConfiguration Create()
    {
        var documentMetadataConfigurationResult = CreateDocumentMetadataConfiguration();
        factoryAction?.Invoke(documentMetadataConfigurationResult);

        return documentMetadataConfigurationResult;
    }

    private Humidifier.Kendra.IndexTypes.DocumentMetadataConfiguration CreateDocumentMetadataConfiguration()
    {
        var documentMetadataConfigurationResult = new Humidifier.Kendra.IndexTypes.DocumentMetadataConfiguration();

        return documentMetadataConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Kendra.IndexTypes.DocumentMetadataConfiguration result)
    {
        base.CreateChildren(result);

        result.Relevance ??= RelevanceFactory?.Build();
        result.Search ??= SearchFactory?.Build();
    }

} // End Of Class

public static class InnerIndexDocumentMetadataConfigurationFactoryExtensions
{
    public static CombinedResult<InnerIndexDocumentMetadataConfigurationFactory, InnerIndexRelevanceFactory> WithRelevance(this InnerIndexDocumentMetadataConfigurationFactory parentFactory, Action<Humidifier.Kendra.IndexTypes.Relevance> subFactoryAction = null)
    {
        parentFactory.RelevanceFactory = new InnerIndexRelevanceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RelevanceFactory);
    }

    public static CombinedResult<InnerIndexDocumentMetadataConfigurationFactory, InnerIndexSearchFactory> WithSearch(this InnerIndexDocumentMetadataConfigurationFactory parentFactory, Action<Humidifier.Kendra.IndexTypes.Search> subFactoryAction = null)
    {
        parentFactory.SearchFactory = new InnerIndexSearchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SearchFactory);
    }

    public static CombinedResult<InnerIndexDocumentMetadataConfigurationFactory, T1, InnerIndexRelevanceFactory> WithRelevance<T1>(this CombinedResult<InnerIndexDocumentMetadataConfigurationFactory, T1> combinedResult, Action<Humidifier.Kendra.IndexTypes.Relevance> subFactoryAction = null) => new (combinedResult, combinedResult, WithRelevance(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIndexDocumentMetadataConfigurationFactory, InnerIndexRelevanceFactory> WithRelevance<T1>(this CombinedResult<T1, InnerIndexDocumentMetadataConfigurationFactory> combinedResult, Action<Humidifier.Kendra.IndexTypes.Relevance> subFactoryAction = null) => new (combinedResult, combinedResult, WithRelevance(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerIndexDocumentMetadataConfigurationFactory, T1, T2, InnerIndexRelevanceFactory> WithRelevance<T1, T2>(this CombinedResult<InnerIndexDocumentMetadataConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Kendra.IndexTypes.Relevance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRelevance(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIndexDocumentMetadataConfigurationFactory, T2, InnerIndexRelevanceFactory> WithRelevance<T1, T2>(this CombinedResult<T1, InnerIndexDocumentMetadataConfigurationFactory, T2> combinedResult, Action<Humidifier.Kendra.IndexTypes.Relevance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRelevance(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIndexDocumentMetadataConfigurationFactory, InnerIndexRelevanceFactory> WithRelevance<T1, T2>(this CombinedResult<T1, T2, InnerIndexDocumentMetadataConfigurationFactory> combinedResult, Action<Humidifier.Kendra.IndexTypes.Relevance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRelevance(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerIndexDocumentMetadataConfigurationFactory, T1, T2, T3, InnerIndexRelevanceFactory> WithRelevance<T1, T2, T3>(this CombinedResult<InnerIndexDocumentMetadataConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Kendra.IndexTypes.Relevance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRelevance(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIndexDocumentMetadataConfigurationFactory, T2, T3, InnerIndexRelevanceFactory> WithRelevance<T1, T2, T3>(this CombinedResult<T1, InnerIndexDocumentMetadataConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Kendra.IndexTypes.Relevance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRelevance(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIndexDocumentMetadataConfigurationFactory, T3, InnerIndexRelevanceFactory> WithRelevance<T1, T2, T3>(this CombinedResult<T1, T2, InnerIndexDocumentMetadataConfigurationFactory, T3> combinedResult, Action<Humidifier.Kendra.IndexTypes.Relevance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRelevance(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerIndexDocumentMetadataConfigurationFactory, InnerIndexRelevanceFactory> WithRelevance<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerIndexDocumentMetadataConfigurationFactory> combinedResult, Action<Humidifier.Kendra.IndexTypes.Relevance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRelevance(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerIndexDocumentMetadataConfigurationFactory, T1, T2, T3, T4, InnerIndexRelevanceFactory> WithRelevance<T1, T2, T3, T4>(this CombinedResult<InnerIndexDocumentMetadataConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.IndexTypes.Relevance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRelevance(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIndexDocumentMetadataConfigurationFactory, T2, T3, T4, InnerIndexRelevanceFactory> WithRelevance<T1, T2, T3, T4>(this CombinedResult<T1, InnerIndexDocumentMetadataConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.IndexTypes.Relevance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRelevance(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIndexDocumentMetadataConfigurationFactory, T3, T4, InnerIndexRelevanceFactory> WithRelevance<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerIndexDocumentMetadataConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Kendra.IndexTypes.Relevance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRelevance(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerIndexDocumentMetadataConfigurationFactory, T4, InnerIndexRelevanceFactory> WithRelevance<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerIndexDocumentMetadataConfigurationFactory, T4> combinedResult, Action<Humidifier.Kendra.IndexTypes.Relevance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRelevance(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerIndexDocumentMetadataConfigurationFactory, InnerIndexRelevanceFactory> WithRelevance<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerIndexDocumentMetadataConfigurationFactory> combinedResult, Action<Humidifier.Kendra.IndexTypes.Relevance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRelevance(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerIndexDocumentMetadataConfigurationFactory, T1, InnerIndexSearchFactory> WithSearch<T1>(this CombinedResult<InnerIndexDocumentMetadataConfigurationFactory, T1> combinedResult, Action<Humidifier.Kendra.IndexTypes.Search> subFactoryAction = null) => new (combinedResult, combinedResult, WithSearch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIndexDocumentMetadataConfigurationFactory, InnerIndexSearchFactory> WithSearch<T1>(this CombinedResult<T1, InnerIndexDocumentMetadataConfigurationFactory> combinedResult, Action<Humidifier.Kendra.IndexTypes.Search> subFactoryAction = null) => new (combinedResult, combinedResult, WithSearch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerIndexDocumentMetadataConfigurationFactory, T1, T2, InnerIndexSearchFactory> WithSearch<T1, T2>(this CombinedResult<InnerIndexDocumentMetadataConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Kendra.IndexTypes.Search> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSearch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIndexDocumentMetadataConfigurationFactory, T2, InnerIndexSearchFactory> WithSearch<T1, T2>(this CombinedResult<T1, InnerIndexDocumentMetadataConfigurationFactory, T2> combinedResult, Action<Humidifier.Kendra.IndexTypes.Search> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSearch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIndexDocumentMetadataConfigurationFactory, InnerIndexSearchFactory> WithSearch<T1, T2>(this CombinedResult<T1, T2, InnerIndexDocumentMetadataConfigurationFactory> combinedResult, Action<Humidifier.Kendra.IndexTypes.Search> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSearch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerIndexDocumentMetadataConfigurationFactory, T1, T2, T3, InnerIndexSearchFactory> WithSearch<T1, T2, T3>(this CombinedResult<InnerIndexDocumentMetadataConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Kendra.IndexTypes.Search> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSearch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIndexDocumentMetadataConfigurationFactory, T2, T3, InnerIndexSearchFactory> WithSearch<T1, T2, T3>(this CombinedResult<T1, InnerIndexDocumentMetadataConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Kendra.IndexTypes.Search> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSearch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIndexDocumentMetadataConfigurationFactory, T3, InnerIndexSearchFactory> WithSearch<T1, T2, T3>(this CombinedResult<T1, T2, InnerIndexDocumentMetadataConfigurationFactory, T3> combinedResult, Action<Humidifier.Kendra.IndexTypes.Search> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSearch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerIndexDocumentMetadataConfigurationFactory, InnerIndexSearchFactory> WithSearch<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerIndexDocumentMetadataConfigurationFactory> combinedResult, Action<Humidifier.Kendra.IndexTypes.Search> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSearch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerIndexDocumentMetadataConfigurationFactory, T1, T2, T3, T4, InnerIndexSearchFactory> WithSearch<T1, T2, T3, T4>(this CombinedResult<InnerIndexDocumentMetadataConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.IndexTypes.Search> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSearch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIndexDocumentMetadataConfigurationFactory, T2, T3, T4, InnerIndexSearchFactory> WithSearch<T1, T2, T3, T4>(this CombinedResult<T1, InnerIndexDocumentMetadataConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.IndexTypes.Search> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSearch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIndexDocumentMetadataConfigurationFactory, T3, T4, InnerIndexSearchFactory> WithSearch<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerIndexDocumentMetadataConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Kendra.IndexTypes.Search> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSearch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerIndexDocumentMetadataConfigurationFactory, T4, InnerIndexSearchFactory> WithSearch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerIndexDocumentMetadataConfigurationFactory, T4> combinedResult, Action<Humidifier.Kendra.IndexTypes.Search> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSearch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerIndexDocumentMetadataConfigurationFactory, InnerIndexSearchFactory> WithSearch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerIndexDocumentMetadataConfigurationFactory> combinedResult, Action<Humidifier.Kendra.IndexTypes.Search> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSearch(combinedResult.T5, subFactoryAction));
}
