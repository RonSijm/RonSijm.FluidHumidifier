// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BackupSearch;

public class InnerSearchResultExportJobS3ExportSpecificationFactory(Action<Humidifier.BackupSearch.SearchResultExportJobTypes.S3ExportSpecification> factoryAction = null) : SubResourceFactory<Humidifier.BackupSearch.SearchResultExportJobTypes.S3ExportSpecification>
{

    protected override Humidifier.BackupSearch.SearchResultExportJobTypes.S3ExportSpecification Create()
    {
        var s3ExportSpecificationResult = CreateS3ExportSpecification();
        factoryAction?.Invoke(s3ExportSpecificationResult);

        return s3ExportSpecificationResult;
    }

    private Humidifier.BackupSearch.SearchResultExportJobTypes.S3ExportSpecification CreateS3ExportSpecification()
    {
        var s3ExportSpecificationResult = new Humidifier.BackupSearch.SearchResultExportJobTypes.S3ExportSpecification();

        return s3ExportSpecificationResult;
    }

} // End Of Class

public static class InnerSearchResultExportJobS3ExportSpecificationFactoryExtensions
{
}
