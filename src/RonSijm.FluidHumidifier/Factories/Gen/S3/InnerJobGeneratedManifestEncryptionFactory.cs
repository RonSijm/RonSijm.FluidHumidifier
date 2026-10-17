// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobGeneratedManifestEncryptionFactory(Action<Humidifier.S3.JobTypes.GeneratedManifestEncryption> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.GeneratedManifestEncryption>
{

    internal InnerJobSSEKMSEncryptionFactory SSEKMSFactory { get; set; }

    protected override Humidifier.S3.JobTypes.GeneratedManifestEncryption Create()
    {
        var generatedManifestEncryptionResult = CreateGeneratedManifestEncryption();
        factoryAction?.Invoke(generatedManifestEncryptionResult);

        return generatedManifestEncryptionResult;
    }

    private Humidifier.S3.JobTypes.GeneratedManifestEncryption CreateGeneratedManifestEncryption()
    {
        var generatedManifestEncryptionResult = new Humidifier.S3.JobTypes.GeneratedManifestEncryption();

        return generatedManifestEncryptionResult;
    }
    public override void CreateChildren(Humidifier.S3.JobTypes.GeneratedManifestEncryption result)
    {
        base.CreateChildren(result);

        result.SSEKMS ??= SSEKMSFactory?.Build();
    }

} // End Of Class

public static class InnerJobGeneratedManifestEncryptionFactoryExtensions
{
    public static CombinedResult<InnerJobGeneratedManifestEncryptionFactory, InnerJobSSEKMSEncryptionFactory> WithSSEKMS(this InnerJobGeneratedManifestEncryptionFactory parentFactory, Action<Humidifier.S3.JobTypes.SSEKMSEncryption> subFactoryAction = null)
    {
        parentFactory.SSEKMSFactory = new InnerJobSSEKMSEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SSEKMSFactory);
    }

    public static CombinedResult<InnerJobGeneratedManifestEncryptionFactory, T1, InnerJobSSEKMSEncryptionFactory> WithSSEKMS<T1>(this CombinedResult<InnerJobGeneratedManifestEncryptionFactory, T1> combinedResult, Action<Humidifier.S3.JobTypes.SSEKMSEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithSSEKMS(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobGeneratedManifestEncryptionFactory, InnerJobSSEKMSEncryptionFactory> WithSSEKMS<T1>(this CombinedResult<T1, InnerJobGeneratedManifestEncryptionFactory> combinedResult, Action<Humidifier.S3.JobTypes.SSEKMSEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithSSEKMS(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobGeneratedManifestEncryptionFactory, T1, T2, InnerJobSSEKMSEncryptionFactory> WithSSEKMS<T1, T2>(this CombinedResult<InnerJobGeneratedManifestEncryptionFactory, T1, T2> combinedResult, Action<Humidifier.S3.JobTypes.SSEKMSEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobGeneratedManifestEncryptionFactory, T2, InnerJobSSEKMSEncryptionFactory> WithSSEKMS<T1, T2>(this CombinedResult<T1, InnerJobGeneratedManifestEncryptionFactory, T2> combinedResult, Action<Humidifier.S3.JobTypes.SSEKMSEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobGeneratedManifestEncryptionFactory, InnerJobSSEKMSEncryptionFactory> WithSSEKMS<T1, T2>(this CombinedResult<T1, T2, InnerJobGeneratedManifestEncryptionFactory> combinedResult, Action<Humidifier.S3.JobTypes.SSEKMSEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobGeneratedManifestEncryptionFactory, T1, T2, T3, InnerJobSSEKMSEncryptionFactory> WithSSEKMS<T1, T2, T3>(this CombinedResult<InnerJobGeneratedManifestEncryptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.SSEKMSEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobGeneratedManifestEncryptionFactory, T2, T3, InnerJobSSEKMSEncryptionFactory> WithSSEKMS<T1, T2, T3>(this CombinedResult<T1, InnerJobGeneratedManifestEncryptionFactory, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.SSEKMSEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobGeneratedManifestEncryptionFactory, T3, InnerJobSSEKMSEncryptionFactory> WithSSEKMS<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobGeneratedManifestEncryptionFactory, T3> combinedResult, Action<Humidifier.S3.JobTypes.SSEKMSEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobGeneratedManifestEncryptionFactory, InnerJobSSEKMSEncryptionFactory> WithSSEKMS<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobGeneratedManifestEncryptionFactory> combinedResult, Action<Humidifier.S3.JobTypes.SSEKMSEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobGeneratedManifestEncryptionFactory, T1, T2, T3, T4, InnerJobSSEKMSEncryptionFactory> WithSSEKMS<T1, T2, T3, T4>(this CombinedResult<InnerJobGeneratedManifestEncryptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.SSEKMSEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobGeneratedManifestEncryptionFactory, T2, T3, T4, InnerJobSSEKMSEncryptionFactory> WithSSEKMS<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobGeneratedManifestEncryptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.SSEKMSEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobGeneratedManifestEncryptionFactory, T3, T4, InnerJobSSEKMSEncryptionFactory> WithSSEKMS<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobGeneratedManifestEncryptionFactory, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.SSEKMSEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobGeneratedManifestEncryptionFactory, T4, InnerJobSSEKMSEncryptionFactory> WithSSEKMS<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobGeneratedManifestEncryptionFactory, T4> combinedResult, Action<Humidifier.S3.JobTypes.SSEKMSEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobGeneratedManifestEncryptionFactory, InnerJobSSEKMSEncryptionFactory> WithSSEKMS<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobGeneratedManifestEncryptionFactory> combinedResult, Action<Humidifier.S3.JobTypes.SSEKMSEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T5, subFactoryAction).T2);
}
