// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MGN;

public class ImportFactory(string resourceName = null, Action<Humidifier.MGN.Import> factoryAction = null) : ResourceFactory<Humidifier.MGN.Import>(resourceName)
{

    internal InnerImportS3BucketSourceFactory S3BucketSourceFactory { get; set; }

    protected override Humidifier.MGN.Import Create()
    {
        var importResult = CreateImport();
        factoryAction?.Invoke(importResult);

        return importResult;
    }

    private Humidifier.MGN.Import CreateImport()
    {
        var importResult = new Humidifier.MGN.Import
        {
            GivenName = InputResourceName,
        };

        return importResult;
    }
    public override void CreateChildren(Humidifier.MGN.Import result)
    {
        base.CreateChildren(result);

        result.S3BucketSource ??= S3BucketSourceFactory?.Build();
    }

} // End Of Class

public static class ImportFactoryExtensions
{
    public static CombinedResult<ImportFactory, InnerImportS3BucketSourceFactory> WithS3BucketSource(this ImportFactory parentFactory, Action<Humidifier.MGN.ImportTypes.S3BucketSource> subFactoryAction = null)
    {
        parentFactory.S3BucketSourceFactory = new InnerImportS3BucketSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3BucketSourceFactory);
    }

    public static CombinedResult<ImportFactory, T1, InnerImportS3BucketSourceFactory> WithS3BucketSource<T1>(this CombinedResult<ImportFactory, T1> combinedResult, Action<Humidifier.MGN.ImportTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3BucketSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ImportFactory, InnerImportS3BucketSourceFactory> WithS3BucketSource<T1>(this CombinedResult<T1, ImportFactory> combinedResult, Action<Humidifier.MGN.ImportTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3BucketSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ImportFactory, T1, T2, InnerImportS3BucketSourceFactory> WithS3BucketSource<T1, T2>(this CombinedResult<ImportFactory, T1, T2> combinedResult, Action<Humidifier.MGN.ImportTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3BucketSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ImportFactory, T2, InnerImportS3BucketSourceFactory> WithS3BucketSource<T1, T2>(this CombinedResult<T1, ImportFactory, T2> combinedResult, Action<Humidifier.MGN.ImportTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3BucketSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ImportFactory, InnerImportS3BucketSourceFactory> WithS3BucketSource<T1, T2>(this CombinedResult<T1, T2, ImportFactory> combinedResult, Action<Humidifier.MGN.ImportTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3BucketSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ImportFactory, T1, T2, T3, InnerImportS3BucketSourceFactory> WithS3BucketSource<T1, T2, T3>(this CombinedResult<ImportFactory, T1, T2, T3> combinedResult, Action<Humidifier.MGN.ImportTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ImportFactory, T2, T3, InnerImportS3BucketSourceFactory> WithS3BucketSource<T1, T2, T3>(this CombinedResult<T1, ImportFactory, T2, T3> combinedResult, Action<Humidifier.MGN.ImportTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ImportFactory, T3, InnerImportS3BucketSourceFactory> WithS3BucketSource<T1, T2, T3>(this CombinedResult<T1, T2, ImportFactory, T3> combinedResult, Action<Humidifier.MGN.ImportTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ImportFactory, InnerImportS3BucketSourceFactory> WithS3BucketSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, ImportFactory> combinedResult, Action<Humidifier.MGN.ImportTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ImportFactory, T1, T2, T3, T4, InnerImportS3BucketSourceFactory> WithS3BucketSource<T1, T2, T3, T4>(this CombinedResult<ImportFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MGN.ImportTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ImportFactory, T2, T3, T4, InnerImportS3BucketSourceFactory> WithS3BucketSource<T1, T2, T3, T4>(this CombinedResult<T1, ImportFactory, T2, T3, T4> combinedResult, Action<Humidifier.MGN.ImportTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ImportFactory, T3, T4, InnerImportS3BucketSourceFactory> WithS3BucketSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, ImportFactory, T3, T4> combinedResult, Action<Humidifier.MGN.ImportTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ImportFactory, T4, InnerImportS3BucketSourceFactory> WithS3BucketSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ImportFactory, T4> combinedResult, Action<Humidifier.MGN.ImportTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ImportFactory, InnerImportS3BucketSourceFactory> WithS3BucketSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ImportFactory> combinedResult, Action<Humidifier.MGN.ImportTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSource(combinedResult.T5, subFactoryAction).T2);
}
