// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class FeaturedResultsSetFactory(string resourceName = null, Action<Humidifier.Kendra.FeaturedResultsSet> factoryAction = null) : ResourceFactory<Humidifier.Kendra.FeaturedResultsSet>(resourceName)
{

    internal List<InnerFeaturedResultsSetFeaturedDocumentFactory> FeaturedDocumentsFactories { get; set; } = [];

    protected override Humidifier.Kendra.FeaturedResultsSet Create()
    {
        var featuredResultsSetResult = CreateFeaturedResultsSet();
        factoryAction?.Invoke(featuredResultsSetResult);

        return featuredResultsSetResult;
    }

    private Humidifier.Kendra.FeaturedResultsSet CreateFeaturedResultsSet()
    {
        var featuredResultsSetResult = new Humidifier.Kendra.FeaturedResultsSet
        {
            GivenName = InputResourceName,
        };

        return featuredResultsSetResult;
    }
    public override void CreateChildren(Humidifier.Kendra.FeaturedResultsSet result)
    {
        base.CreateChildren(result);

        result.FeaturedDocuments = FeaturedDocumentsFactories.Any() ? FeaturedDocumentsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class FeaturedResultsSetFactoryExtensions
{
    public static CombinedResult<FeaturedResultsSetFactory, InnerFeaturedResultsSetFeaturedDocumentFactory> WithFeaturedDocuments(this FeaturedResultsSetFactory parentFactory, Action<Humidifier.Kendra.FeaturedResultsSetTypes.FeaturedDocument> subFactoryAction = null)
    {
        var factory = new InnerFeaturedResultsSetFeaturedDocumentFactory(subFactoryAction);
        parentFactory.FeaturedDocumentsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<FeaturedResultsSetFactory, T1, InnerFeaturedResultsSetFeaturedDocumentFactory> WithFeaturedDocuments<T1>(this CombinedResult<FeaturedResultsSetFactory, T1> combinedResult, Action<Humidifier.Kendra.FeaturedResultsSetTypes.FeaturedDocument> subFactoryAction = null) => new (combinedResult, combinedResult, WithFeaturedDocuments(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FeaturedResultsSetFactory, InnerFeaturedResultsSetFeaturedDocumentFactory> WithFeaturedDocuments<T1>(this CombinedResult<T1, FeaturedResultsSetFactory> combinedResult, Action<Humidifier.Kendra.FeaturedResultsSetTypes.FeaturedDocument> subFactoryAction = null) => new (combinedResult, combinedResult, WithFeaturedDocuments(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<FeaturedResultsSetFactory, T1, T2, InnerFeaturedResultsSetFeaturedDocumentFactory> WithFeaturedDocuments<T1, T2>(this CombinedResult<FeaturedResultsSetFactory, T1, T2> combinedResult, Action<Humidifier.Kendra.FeaturedResultsSetTypes.FeaturedDocument> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFeaturedDocuments(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FeaturedResultsSetFactory, T2, InnerFeaturedResultsSetFeaturedDocumentFactory> WithFeaturedDocuments<T1, T2>(this CombinedResult<T1, FeaturedResultsSetFactory, T2> combinedResult, Action<Humidifier.Kendra.FeaturedResultsSetTypes.FeaturedDocument> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFeaturedDocuments(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FeaturedResultsSetFactory, InnerFeaturedResultsSetFeaturedDocumentFactory> WithFeaturedDocuments<T1, T2>(this CombinedResult<T1, T2, FeaturedResultsSetFactory> combinedResult, Action<Humidifier.Kendra.FeaturedResultsSetTypes.FeaturedDocument> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFeaturedDocuments(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<FeaturedResultsSetFactory, T1, T2, T3, InnerFeaturedResultsSetFeaturedDocumentFactory> WithFeaturedDocuments<T1, T2, T3>(this CombinedResult<FeaturedResultsSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.Kendra.FeaturedResultsSetTypes.FeaturedDocument> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFeaturedDocuments(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FeaturedResultsSetFactory, T2, T3, InnerFeaturedResultsSetFeaturedDocumentFactory> WithFeaturedDocuments<T1, T2, T3>(this CombinedResult<T1, FeaturedResultsSetFactory, T2, T3> combinedResult, Action<Humidifier.Kendra.FeaturedResultsSetTypes.FeaturedDocument> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFeaturedDocuments(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FeaturedResultsSetFactory, T3, InnerFeaturedResultsSetFeaturedDocumentFactory> WithFeaturedDocuments<T1, T2, T3>(this CombinedResult<T1, T2, FeaturedResultsSetFactory, T3> combinedResult, Action<Humidifier.Kendra.FeaturedResultsSetTypes.FeaturedDocument> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFeaturedDocuments(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, FeaturedResultsSetFactory, InnerFeaturedResultsSetFeaturedDocumentFactory> WithFeaturedDocuments<T1, T2, T3>(this CombinedResult<T1, T2, T3, FeaturedResultsSetFactory> combinedResult, Action<Humidifier.Kendra.FeaturedResultsSetTypes.FeaturedDocument> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFeaturedDocuments(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<FeaturedResultsSetFactory, T1, T2, T3, T4, InnerFeaturedResultsSetFeaturedDocumentFactory> WithFeaturedDocuments<T1, T2, T3, T4>(this CombinedResult<FeaturedResultsSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.FeaturedResultsSetTypes.FeaturedDocument> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFeaturedDocuments(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FeaturedResultsSetFactory, T2, T3, T4, InnerFeaturedResultsSetFeaturedDocumentFactory> WithFeaturedDocuments<T1, T2, T3, T4>(this CombinedResult<T1, FeaturedResultsSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.FeaturedResultsSetTypes.FeaturedDocument> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFeaturedDocuments(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FeaturedResultsSetFactory, T3, T4, InnerFeaturedResultsSetFeaturedDocumentFactory> WithFeaturedDocuments<T1, T2, T3, T4>(this CombinedResult<T1, T2, FeaturedResultsSetFactory, T3, T4> combinedResult, Action<Humidifier.Kendra.FeaturedResultsSetTypes.FeaturedDocument> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFeaturedDocuments(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, FeaturedResultsSetFactory, T4, InnerFeaturedResultsSetFeaturedDocumentFactory> WithFeaturedDocuments<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FeaturedResultsSetFactory, T4> combinedResult, Action<Humidifier.Kendra.FeaturedResultsSetTypes.FeaturedDocument> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFeaturedDocuments(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, FeaturedResultsSetFactory, InnerFeaturedResultsSetFeaturedDocumentFactory> WithFeaturedDocuments<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FeaturedResultsSetFactory> combinedResult, Action<Humidifier.Kendra.FeaturedResultsSetTypes.FeaturedDocument> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFeaturedDocuments(combinedResult.T5, subFactoryAction).T2);
}
