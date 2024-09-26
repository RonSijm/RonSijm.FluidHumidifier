// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Synthetics;

public class InnerCanaryArtifactConfigFactory(Action<Humidifier.Synthetics.CanaryTypes.ArtifactConfig> factoryAction = null) : SubResourceFactory<Humidifier.Synthetics.CanaryTypes.ArtifactConfig>
{

    internal InnerCanaryS3EncryptionFactory S3EncryptionFactory { get; set; }

    protected override Humidifier.Synthetics.CanaryTypes.ArtifactConfig Create()
    {
        var artifactConfigResult = CreateArtifactConfig();
        factoryAction?.Invoke(artifactConfigResult);

        return artifactConfigResult;
    }

    private Humidifier.Synthetics.CanaryTypes.ArtifactConfig CreateArtifactConfig()
    {
        var artifactConfigResult = new Humidifier.Synthetics.CanaryTypes.ArtifactConfig();

        return artifactConfigResult;
    }
    public override void CreateChildren(Humidifier.Synthetics.CanaryTypes.ArtifactConfig result)
    {
        base.CreateChildren(result);

        result.S3Encryption ??= S3EncryptionFactory?.Build();
    }

} // End Of Class

public static class InnerCanaryArtifactConfigFactoryExtensions
{
    public static CombinedResult<InnerCanaryArtifactConfigFactory, InnerCanaryS3EncryptionFactory> WithS3Encryption(this InnerCanaryArtifactConfigFactory parentFactory, Action<Humidifier.Synthetics.CanaryTypes.S3Encryption> subFactoryAction = null)
    {
        parentFactory.S3EncryptionFactory = new InnerCanaryS3EncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3EncryptionFactory);
    }

    public static CombinedResult<InnerCanaryArtifactConfigFactory, T1, InnerCanaryS3EncryptionFactory> WithS3Encryption<T1>(this CombinedResult<InnerCanaryArtifactConfigFactory, T1> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.S3Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Encryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCanaryArtifactConfigFactory, InnerCanaryS3EncryptionFactory> WithS3Encryption<T1>(this CombinedResult<T1, InnerCanaryArtifactConfigFactory> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.S3Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Encryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCanaryArtifactConfigFactory, T1, T2, InnerCanaryS3EncryptionFactory> WithS3Encryption<T1, T2>(this CombinedResult<InnerCanaryArtifactConfigFactory, T1, T2> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.S3Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Encryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCanaryArtifactConfigFactory, T2, InnerCanaryS3EncryptionFactory> WithS3Encryption<T1, T2>(this CombinedResult<T1, InnerCanaryArtifactConfigFactory, T2> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.S3Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Encryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCanaryArtifactConfigFactory, InnerCanaryS3EncryptionFactory> WithS3Encryption<T1, T2>(this CombinedResult<T1, T2, InnerCanaryArtifactConfigFactory> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.S3Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Encryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCanaryArtifactConfigFactory, T1, T2, T3, InnerCanaryS3EncryptionFactory> WithS3Encryption<T1, T2, T3>(this CombinedResult<InnerCanaryArtifactConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.S3Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Encryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCanaryArtifactConfigFactory, T2, T3, InnerCanaryS3EncryptionFactory> WithS3Encryption<T1, T2, T3>(this CombinedResult<T1, InnerCanaryArtifactConfigFactory, T2, T3> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.S3Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Encryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCanaryArtifactConfigFactory, T3, InnerCanaryS3EncryptionFactory> WithS3Encryption<T1, T2, T3>(this CombinedResult<T1, T2, InnerCanaryArtifactConfigFactory, T3> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.S3Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Encryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCanaryArtifactConfigFactory, InnerCanaryS3EncryptionFactory> WithS3Encryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCanaryArtifactConfigFactory> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.S3Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Encryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCanaryArtifactConfigFactory, T1, T2, T3, T4, InnerCanaryS3EncryptionFactory> WithS3Encryption<T1, T2, T3, T4>(this CombinedResult<InnerCanaryArtifactConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.S3Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Encryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCanaryArtifactConfigFactory, T2, T3, T4, InnerCanaryS3EncryptionFactory> WithS3Encryption<T1, T2, T3, T4>(this CombinedResult<T1, InnerCanaryArtifactConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.S3Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Encryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCanaryArtifactConfigFactory, T3, T4, InnerCanaryS3EncryptionFactory> WithS3Encryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCanaryArtifactConfigFactory, T3, T4> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.S3Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Encryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCanaryArtifactConfigFactory, T4, InnerCanaryS3EncryptionFactory> WithS3Encryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCanaryArtifactConfigFactory, T4> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.S3Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Encryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCanaryArtifactConfigFactory, InnerCanaryS3EncryptionFactory> WithS3Encryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCanaryArtifactConfigFactory> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.S3Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Encryption(combinedResult.T5, subFactoryAction));
}
