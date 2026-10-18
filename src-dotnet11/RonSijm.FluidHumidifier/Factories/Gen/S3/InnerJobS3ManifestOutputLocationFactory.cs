// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobS3ManifestOutputLocationFactory(Action<Humidifier.S3.JobTypes.S3ManifestOutputLocation> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.S3ManifestOutputLocation>
{

    internal InnerJobGeneratedManifestEncryptionFactory ManifestEncryptionFactory { get; set; }

    protected override Humidifier.S3.JobTypes.S3ManifestOutputLocation Create()
    {
        var s3ManifestOutputLocationResult = CreateS3ManifestOutputLocation();
        factoryAction?.Invoke(s3ManifestOutputLocationResult);

        return s3ManifestOutputLocationResult;
    }

    private Humidifier.S3.JobTypes.S3ManifestOutputLocation CreateS3ManifestOutputLocation()
    {
        var s3ManifestOutputLocationResult = new Humidifier.S3.JobTypes.S3ManifestOutputLocation();

        return s3ManifestOutputLocationResult;
    }
    public override void CreateChildren(Humidifier.S3.JobTypes.S3ManifestOutputLocation result)
    {
        base.CreateChildren(result);

        result.ManifestEncryption ??= ManifestEncryptionFactory?.Build();
    }

} // End Of Class

public static class InnerJobS3ManifestOutputLocationFactoryExtensions
{
    public static CombinedResult<InnerJobS3ManifestOutputLocationFactory, InnerJobGeneratedManifestEncryptionFactory> WithManifestEncryption(this InnerJobS3ManifestOutputLocationFactory parentFactory, Action<Humidifier.S3.JobTypes.GeneratedManifestEncryption> subFactoryAction = null)
    {
        parentFactory.ManifestEncryptionFactory = new InnerJobGeneratedManifestEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ManifestEncryptionFactory);
    }

    public static CombinedResult<InnerJobS3ManifestOutputLocationFactory, T1, InnerJobGeneratedManifestEncryptionFactory> WithManifestEncryption<T1>(this CombinedResult<InnerJobS3ManifestOutputLocationFactory, T1> combinedResult, Action<Humidifier.S3.JobTypes.GeneratedManifestEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithManifestEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3ManifestOutputLocationFactory, InnerJobGeneratedManifestEncryptionFactory> WithManifestEncryption<T1>(this CombinedResult<T1, InnerJobS3ManifestOutputLocationFactory> combinedResult, Action<Humidifier.S3.JobTypes.GeneratedManifestEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithManifestEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3ManifestOutputLocationFactory, T1, T2, InnerJobGeneratedManifestEncryptionFactory> WithManifestEncryption<T1, T2>(this CombinedResult<InnerJobS3ManifestOutputLocationFactory, T1, T2> combinedResult, Action<Humidifier.S3.JobTypes.GeneratedManifestEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManifestEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3ManifestOutputLocationFactory, T2, InnerJobGeneratedManifestEncryptionFactory> WithManifestEncryption<T1, T2>(this CombinedResult<T1, InnerJobS3ManifestOutputLocationFactory, T2> combinedResult, Action<Humidifier.S3.JobTypes.GeneratedManifestEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManifestEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3ManifestOutputLocationFactory, InnerJobGeneratedManifestEncryptionFactory> WithManifestEncryption<T1, T2>(this CombinedResult<T1, T2, InnerJobS3ManifestOutputLocationFactory> combinedResult, Action<Humidifier.S3.JobTypes.GeneratedManifestEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManifestEncryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3ManifestOutputLocationFactory, T1, T2, T3, InnerJobGeneratedManifestEncryptionFactory> WithManifestEncryption<T1, T2, T3>(this CombinedResult<InnerJobS3ManifestOutputLocationFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.GeneratedManifestEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifestEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3ManifestOutputLocationFactory, T2, T3, InnerJobGeneratedManifestEncryptionFactory> WithManifestEncryption<T1, T2, T3>(this CombinedResult<T1, InnerJobS3ManifestOutputLocationFactory, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.GeneratedManifestEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifestEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3ManifestOutputLocationFactory, T3, InnerJobGeneratedManifestEncryptionFactory> WithManifestEncryption<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobS3ManifestOutputLocationFactory, T3> combinedResult, Action<Humidifier.S3.JobTypes.GeneratedManifestEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifestEncryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobS3ManifestOutputLocationFactory, InnerJobGeneratedManifestEncryptionFactory> WithManifestEncryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobS3ManifestOutputLocationFactory> combinedResult, Action<Humidifier.S3.JobTypes.GeneratedManifestEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifestEncryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3ManifestOutputLocationFactory, T1, T2, T3, T4, InnerJobGeneratedManifestEncryptionFactory> WithManifestEncryption<T1, T2, T3, T4>(this CombinedResult<InnerJobS3ManifestOutputLocationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.GeneratedManifestEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3ManifestOutputLocationFactory, T2, T3, T4, InnerJobGeneratedManifestEncryptionFactory> WithManifestEncryption<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobS3ManifestOutputLocationFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.GeneratedManifestEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3ManifestOutputLocationFactory, T3, T4, InnerJobGeneratedManifestEncryptionFactory> WithManifestEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobS3ManifestOutputLocationFactory, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.GeneratedManifestEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestEncryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobS3ManifestOutputLocationFactory, T4, InnerJobGeneratedManifestEncryptionFactory> WithManifestEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobS3ManifestOutputLocationFactory, T4> combinedResult, Action<Humidifier.S3.JobTypes.GeneratedManifestEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestEncryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobS3ManifestOutputLocationFactory, InnerJobGeneratedManifestEncryptionFactory> WithManifestEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobS3ManifestOutputLocationFactory> combinedResult, Action<Humidifier.S3.JobTypes.GeneratedManifestEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestEncryption(combinedResult.T5, subFactoryAction).T2);
}
