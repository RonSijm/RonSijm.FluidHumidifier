// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class QuerySuggestionsBlockListFactory(string resourceName = null, Action<Humidifier.Kendra.QuerySuggestionsBlockList> factoryAction = null) : ResourceFactory<Humidifier.Kendra.QuerySuggestionsBlockList>(resourceName)
{

    internal InnerQuerySuggestionsBlockListS3PathFactory SourceS3PathFactory { get; set; }

    protected override Humidifier.Kendra.QuerySuggestionsBlockList Create()
    {
        var querySuggestionsBlockListResult = CreateQuerySuggestionsBlockList();
        factoryAction?.Invoke(querySuggestionsBlockListResult);

        return querySuggestionsBlockListResult;
    }

    private Humidifier.Kendra.QuerySuggestionsBlockList CreateQuerySuggestionsBlockList()
    {
        var querySuggestionsBlockListResult = new Humidifier.Kendra.QuerySuggestionsBlockList
        {
            GivenName = InputResourceName,
        };

        return querySuggestionsBlockListResult;
    }
    public override void CreateChildren(Humidifier.Kendra.QuerySuggestionsBlockList result)
    {
        base.CreateChildren(result);

        result.SourceS3Path ??= SourceS3PathFactory?.Build();
    }

} // End Of Class

public static class QuerySuggestionsBlockListFactoryExtensions
{
    public static CombinedResult<QuerySuggestionsBlockListFactory, InnerQuerySuggestionsBlockListS3PathFactory> WithSourceS3Path(this QuerySuggestionsBlockListFactory parentFactory, Action<Humidifier.Kendra.QuerySuggestionsBlockListTypes.S3Path> subFactoryAction = null)
    {
        parentFactory.SourceS3PathFactory = new InnerQuerySuggestionsBlockListS3PathFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceS3PathFactory);
    }

    public static CombinedResult<QuerySuggestionsBlockListFactory, T1, InnerQuerySuggestionsBlockListS3PathFactory> WithSourceS3Path<T1>(this CombinedResult<QuerySuggestionsBlockListFactory, T1> combinedResult, Action<Humidifier.Kendra.QuerySuggestionsBlockListTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceS3Path(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, QuerySuggestionsBlockListFactory, InnerQuerySuggestionsBlockListS3PathFactory> WithSourceS3Path<T1>(this CombinedResult<T1, QuerySuggestionsBlockListFactory> combinedResult, Action<Humidifier.Kendra.QuerySuggestionsBlockListTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceS3Path(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<QuerySuggestionsBlockListFactory, T1, T2, InnerQuerySuggestionsBlockListS3PathFactory> WithSourceS3Path<T1, T2>(this CombinedResult<QuerySuggestionsBlockListFactory, T1, T2> combinedResult, Action<Humidifier.Kendra.QuerySuggestionsBlockListTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceS3Path(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, QuerySuggestionsBlockListFactory, T2, InnerQuerySuggestionsBlockListS3PathFactory> WithSourceS3Path<T1, T2>(this CombinedResult<T1, QuerySuggestionsBlockListFactory, T2> combinedResult, Action<Humidifier.Kendra.QuerySuggestionsBlockListTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceS3Path(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, QuerySuggestionsBlockListFactory, InnerQuerySuggestionsBlockListS3PathFactory> WithSourceS3Path<T1, T2>(this CombinedResult<T1, T2, QuerySuggestionsBlockListFactory> combinedResult, Action<Humidifier.Kendra.QuerySuggestionsBlockListTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceS3Path(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<QuerySuggestionsBlockListFactory, T1, T2, T3, InnerQuerySuggestionsBlockListS3PathFactory> WithSourceS3Path<T1, T2, T3>(this CombinedResult<QuerySuggestionsBlockListFactory, T1, T2, T3> combinedResult, Action<Humidifier.Kendra.QuerySuggestionsBlockListTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Path(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, QuerySuggestionsBlockListFactory, T2, T3, InnerQuerySuggestionsBlockListS3PathFactory> WithSourceS3Path<T1, T2, T3>(this CombinedResult<T1, QuerySuggestionsBlockListFactory, T2, T3> combinedResult, Action<Humidifier.Kendra.QuerySuggestionsBlockListTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Path(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, QuerySuggestionsBlockListFactory, T3, InnerQuerySuggestionsBlockListS3PathFactory> WithSourceS3Path<T1, T2, T3>(this CombinedResult<T1, T2, QuerySuggestionsBlockListFactory, T3> combinedResult, Action<Humidifier.Kendra.QuerySuggestionsBlockListTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Path(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, QuerySuggestionsBlockListFactory, InnerQuerySuggestionsBlockListS3PathFactory> WithSourceS3Path<T1, T2, T3>(this CombinedResult<T1, T2, T3, QuerySuggestionsBlockListFactory> combinedResult, Action<Humidifier.Kendra.QuerySuggestionsBlockListTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Path(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<QuerySuggestionsBlockListFactory, T1, T2, T3, T4, InnerQuerySuggestionsBlockListS3PathFactory> WithSourceS3Path<T1, T2, T3, T4>(this CombinedResult<QuerySuggestionsBlockListFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.QuerySuggestionsBlockListTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Path(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, QuerySuggestionsBlockListFactory, T2, T3, T4, InnerQuerySuggestionsBlockListS3PathFactory> WithSourceS3Path<T1, T2, T3, T4>(this CombinedResult<T1, QuerySuggestionsBlockListFactory, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.QuerySuggestionsBlockListTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Path(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, QuerySuggestionsBlockListFactory, T3, T4, InnerQuerySuggestionsBlockListS3PathFactory> WithSourceS3Path<T1, T2, T3, T4>(this CombinedResult<T1, T2, QuerySuggestionsBlockListFactory, T3, T4> combinedResult, Action<Humidifier.Kendra.QuerySuggestionsBlockListTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Path(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, QuerySuggestionsBlockListFactory, T4, InnerQuerySuggestionsBlockListS3PathFactory> WithSourceS3Path<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, QuerySuggestionsBlockListFactory, T4> combinedResult, Action<Humidifier.Kendra.QuerySuggestionsBlockListTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Path(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, QuerySuggestionsBlockListFactory, InnerQuerySuggestionsBlockListS3PathFactory> WithSourceS3Path<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, QuerySuggestionsBlockListFactory> combinedResult, Action<Humidifier.Kendra.QuerySuggestionsBlockListTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Path(combinedResult.T5, subFactoryAction).T2);
}
