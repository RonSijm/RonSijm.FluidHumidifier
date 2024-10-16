// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerStorageLensEncryptionFactory(Action<Humidifier.S3.StorageLensTypes.Encryption> factoryAction = null) : SubResourceFactory<Humidifier.S3.StorageLensTypes.Encryption>
{

    internal InnerStorageLensSSEKMSFactory SSEKMSFactory { get; set; }

    protected override Humidifier.S3.StorageLensTypes.Encryption Create()
    {
        var encryptionResult = CreateEncryption();
        factoryAction?.Invoke(encryptionResult);

        return encryptionResult;
    }

    private Humidifier.S3.StorageLensTypes.Encryption CreateEncryption()
    {
        var encryptionResult = new Humidifier.S3.StorageLensTypes.Encryption();

        return encryptionResult;
    }
    public override void CreateChildren(Humidifier.S3.StorageLensTypes.Encryption result)
    {
        base.CreateChildren(result);

        result.SSEKMS ??= SSEKMSFactory?.Build();
    }

} // End Of Class

public static class InnerStorageLensEncryptionFactoryExtensions
{
    public static CombinedResult<InnerStorageLensEncryptionFactory, InnerStorageLensSSEKMSFactory> WithSSEKMS(this InnerStorageLensEncryptionFactory parentFactory, Action<Humidifier.S3.StorageLensTypes.SSEKMS> subFactoryAction = null)
    {
        parentFactory.SSEKMSFactory = new InnerStorageLensSSEKMSFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SSEKMSFactory);
    }

    public static CombinedResult<InnerStorageLensEncryptionFactory, T1, InnerStorageLensSSEKMSFactory> WithSSEKMS<T1>(this CombinedResult<InnerStorageLensEncryptionFactory, T1> combinedResult, Action<Humidifier.S3.StorageLensTypes.SSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, WithSSEKMS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensEncryptionFactory, InnerStorageLensSSEKMSFactory> WithSSEKMS<T1>(this CombinedResult<T1, InnerStorageLensEncryptionFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.SSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, WithSSEKMS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerStorageLensEncryptionFactory, T1, T2, InnerStorageLensSSEKMSFactory> WithSSEKMS<T1, T2>(this CombinedResult<InnerStorageLensEncryptionFactory, T1, T2> combinedResult, Action<Humidifier.S3.StorageLensTypes.SSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensEncryptionFactory, T2, InnerStorageLensSSEKMSFactory> WithSSEKMS<T1, T2>(this CombinedResult<T1, InnerStorageLensEncryptionFactory, T2> combinedResult, Action<Humidifier.S3.StorageLensTypes.SSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensEncryptionFactory, InnerStorageLensSSEKMSFactory> WithSSEKMS<T1, T2>(this CombinedResult<T1, T2, InnerStorageLensEncryptionFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.SSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerStorageLensEncryptionFactory, T1, T2, T3, InnerStorageLensSSEKMSFactory> WithSSEKMS<T1, T2, T3>(this CombinedResult<InnerStorageLensEncryptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.SSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensEncryptionFactory, T2, T3, InnerStorageLensSSEKMSFactory> WithSSEKMS<T1, T2, T3>(this CombinedResult<T1, InnerStorageLensEncryptionFactory, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.SSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensEncryptionFactory, T3, InnerStorageLensSSEKMSFactory> WithSSEKMS<T1, T2, T3>(this CombinedResult<T1, T2, InnerStorageLensEncryptionFactory, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.SSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStorageLensEncryptionFactory, InnerStorageLensSSEKMSFactory> WithSSEKMS<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerStorageLensEncryptionFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.SSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerStorageLensEncryptionFactory, T1, T2, T3, T4, InnerStorageLensSSEKMSFactory> WithSSEKMS<T1, T2, T3, T4>(this CombinedResult<InnerStorageLensEncryptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.SSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensEncryptionFactory, T2, T3, T4, InnerStorageLensSSEKMSFactory> WithSSEKMS<T1, T2, T3, T4>(this CombinedResult<T1, InnerStorageLensEncryptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.SSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensEncryptionFactory, T3, T4, InnerStorageLensSSEKMSFactory> WithSSEKMS<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerStorageLensEncryptionFactory, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.SSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStorageLensEncryptionFactory, T4, InnerStorageLensSSEKMSFactory> WithSSEKMS<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerStorageLensEncryptionFactory, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.SSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerStorageLensEncryptionFactory, InnerStorageLensSSEKMSFactory> WithSSEKMS<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerStorageLensEncryptionFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.SSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T5, subFactoryAction));
}
