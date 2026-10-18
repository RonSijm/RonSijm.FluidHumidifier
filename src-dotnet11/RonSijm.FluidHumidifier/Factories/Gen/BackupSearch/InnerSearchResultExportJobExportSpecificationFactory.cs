// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BackupSearch;

public class InnerSearchResultExportJobExportSpecificationFactory(Action<Humidifier.BackupSearch.SearchResultExportJobTypes.ExportSpecification> factoryAction = null) : SubResourceFactory<Humidifier.BackupSearch.SearchResultExportJobTypes.ExportSpecification>
{

    internal InnerSearchResultExportJobS3ExportSpecificationFactory S3ExportSpecificationFactory { get; set; }

    protected override Humidifier.BackupSearch.SearchResultExportJobTypes.ExportSpecification Create()
    {
        var exportSpecificationResult = CreateExportSpecification();
        factoryAction?.Invoke(exportSpecificationResult);

        return exportSpecificationResult;
    }

    private Humidifier.BackupSearch.SearchResultExportJobTypes.ExportSpecification CreateExportSpecification()
    {
        var exportSpecificationResult = new Humidifier.BackupSearch.SearchResultExportJobTypes.ExportSpecification();

        return exportSpecificationResult;
    }
    public override void CreateChildren(Humidifier.BackupSearch.SearchResultExportJobTypes.ExportSpecification result)
    {
        base.CreateChildren(result);

        result.S3ExportSpecification ??= S3ExportSpecificationFactory?.Build();
    }

} // End Of Class

public static class InnerSearchResultExportJobExportSpecificationFactoryExtensions
{
    public static CombinedResult<InnerSearchResultExportJobExportSpecificationFactory, InnerSearchResultExportJobS3ExportSpecificationFactory> WithS3ExportSpecification(this InnerSearchResultExportJobExportSpecificationFactory parentFactory, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.S3ExportSpecification> subFactoryAction = null)
    {
        parentFactory.S3ExportSpecificationFactory = new InnerSearchResultExportJobS3ExportSpecificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3ExportSpecificationFactory);
    }

    public static CombinedResult<InnerSearchResultExportJobExportSpecificationFactory, T1, InnerSearchResultExportJobS3ExportSpecificationFactory> WithS3ExportSpecification<T1>(this CombinedResult<InnerSearchResultExportJobExportSpecificationFactory, T1> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.S3ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3ExportSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSearchResultExportJobExportSpecificationFactory, InnerSearchResultExportJobS3ExportSpecificationFactory> WithS3ExportSpecification<T1>(this CombinedResult<T1, InnerSearchResultExportJobExportSpecificationFactory> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.S3ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3ExportSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerSearchResultExportJobExportSpecificationFactory, T1, T2, InnerSearchResultExportJobS3ExportSpecificationFactory> WithS3ExportSpecification<T1, T2>(this CombinedResult<InnerSearchResultExportJobExportSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.S3ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3ExportSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSearchResultExportJobExportSpecificationFactory, T2, InnerSearchResultExportJobS3ExportSpecificationFactory> WithS3ExportSpecification<T1, T2>(this CombinedResult<T1, InnerSearchResultExportJobExportSpecificationFactory, T2> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.S3ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3ExportSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSearchResultExportJobExportSpecificationFactory, InnerSearchResultExportJobS3ExportSpecificationFactory> WithS3ExportSpecification<T1, T2>(this CombinedResult<T1, T2, InnerSearchResultExportJobExportSpecificationFactory> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.S3ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3ExportSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerSearchResultExportJobExportSpecificationFactory, T1, T2, T3, InnerSearchResultExportJobS3ExportSpecificationFactory> WithS3ExportSpecification<T1, T2, T3>(this CombinedResult<InnerSearchResultExportJobExportSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.S3ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3ExportSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSearchResultExportJobExportSpecificationFactory, T2, T3, InnerSearchResultExportJobS3ExportSpecificationFactory> WithS3ExportSpecification<T1, T2, T3>(this CombinedResult<T1, InnerSearchResultExportJobExportSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.S3ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3ExportSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSearchResultExportJobExportSpecificationFactory, T3, InnerSearchResultExportJobS3ExportSpecificationFactory> WithS3ExportSpecification<T1, T2, T3>(this CombinedResult<T1, T2, InnerSearchResultExportJobExportSpecificationFactory, T3> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.S3ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3ExportSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSearchResultExportJobExportSpecificationFactory, InnerSearchResultExportJobS3ExportSpecificationFactory> WithS3ExportSpecification<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSearchResultExportJobExportSpecificationFactory> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.S3ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3ExportSpecification(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerSearchResultExportJobExportSpecificationFactory, T1, T2, T3, T4, InnerSearchResultExportJobS3ExportSpecificationFactory> WithS3ExportSpecification<T1, T2, T3, T4>(this CombinedResult<InnerSearchResultExportJobExportSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.S3ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3ExportSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSearchResultExportJobExportSpecificationFactory, T2, T3, T4, InnerSearchResultExportJobS3ExportSpecificationFactory> WithS3ExportSpecification<T1, T2, T3, T4>(this CombinedResult<T1, InnerSearchResultExportJobExportSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.S3ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3ExportSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSearchResultExportJobExportSpecificationFactory, T3, T4, InnerSearchResultExportJobS3ExportSpecificationFactory> WithS3ExportSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSearchResultExportJobExportSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.S3ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3ExportSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSearchResultExportJobExportSpecificationFactory, T4, InnerSearchResultExportJobS3ExportSpecificationFactory> WithS3ExportSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSearchResultExportJobExportSpecificationFactory, T4> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.S3ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3ExportSpecification(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerSearchResultExportJobExportSpecificationFactory, InnerSearchResultExportJobS3ExportSpecificationFactory> WithS3ExportSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSearchResultExportJobExportSpecificationFactory> combinedResult, Action<Humidifier.BackupSearch.SearchResultExportJobTypes.S3ExportSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3ExportSpecification(combinedResult.T5, subFactoryAction).T2);
}
