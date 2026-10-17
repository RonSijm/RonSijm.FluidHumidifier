// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerStorageLensStorageLensTableDestinationFactory(Action<Humidifier.S3.StorageLensTypes.StorageLensTableDestination> factoryAction = null) : SubResourceFactory<Humidifier.S3.StorageLensTypes.StorageLensTableDestination>
{

    internal InnerStorageLensEncryptionFactory EncryptionFactory { get; set; }

    protected override Humidifier.S3.StorageLensTypes.StorageLensTableDestination Create()
    {
        var storageLensTableDestinationResult = CreateStorageLensTableDestination();
        factoryAction?.Invoke(storageLensTableDestinationResult);

        return storageLensTableDestinationResult;
    }

    private Humidifier.S3.StorageLensTypes.StorageLensTableDestination CreateStorageLensTableDestination()
    {
        var storageLensTableDestinationResult = new Humidifier.S3.StorageLensTypes.StorageLensTableDestination();

        return storageLensTableDestinationResult;
    }
    public override void CreateChildren(Humidifier.S3.StorageLensTypes.StorageLensTableDestination result)
    {
        base.CreateChildren(result);

        result.Encryption ??= EncryptionFactory?.Build();
    }

} // End Of Class

public static class InnerStorageLensStorageLensTableDestinationFactoryExtensions
{
    public static CombinedResult<InnerStorageLensStorageLensTableDestinationFactory, InnerStorageLensEncryptionFactory> WithEncryption(this InnerStorageLensStorageLensTableDestinationFactory parentFactory, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null)
    {
        parentFactory.EncryptionFactory = new InnerStorageLensEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionFactory);
    }

    public static CombinedResult<InnerStorageLensStorageLensTableDestinationFactory, T1, InnerStorageLensEncryptionFactory> WithEncryption<T1>(this CombinedResult<InnerStorageLensStorageLensTableDestinationFactory, T1> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerStorageLensStorageLensTableDestinationFactory, InnerStorageLensEncryptionFactory> WithEncryption<T1>(this CombinedResult<T1, InnerStorageLensStorageLensTableDestinationFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerStorageLensStorageLensTableDestinationFactory, T1, T2, InnerStorageLensEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<InnerStorageLensStorageLensTableDestinationFactory, T1, T2> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerStorageLensStorageLensTableDestinationFactory, T2, InnerStorageLensEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<T1, InnerStorageLensStorageLensTableDestinationFactory, T2> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerStorageLensStorageLensTableDestinationFactory, InnerStorageLensEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<T1, T2, InnerStorageLensStorageLensTableDestinationFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerStorageLensStorageLensTableDestinationFactory, T1, T2, T3, InnerStorageLensEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<InnerStorageLensStorageLensTableDestinationFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerStorageLensStorageLensTableDestinationFactory, T2, T3, InnerStorageLensEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, InnerStorageLensStorageLensTableDestinationFactory, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerStorageLensStorageLensTableDestinationFactory, T3, InnerStorageLensEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, InnerStorageLensStorageLensTableDestinationFactory, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerStorageLensStorageLensTableDestinationFactory, InnerStorageLensEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerStorageLensStorageLensTableDestinationFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerStorageLensStorageLensTableDestinationFactory, T1, T2, T3, T4, InnerStorageLensEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<InnerStorageLensStorageLensTableDestinationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerStorageLensStorageLensTableDestinationFactory, T2, T3, T4, InnerStorageLensEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, InnerStorageLensStorageLensTableDestinationFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerStorageLensStorageLensTableDestinationFactory, T3, T4, InnerStorageLensEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerStorageLensStorageLensTableDestinationFactory, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerStorageLensStorageLensTableDestinationFactory, T4, InnerStorageLensEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerStorageLensStorageLensTableDestinationFactory, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerStorageLensStorageLensTableDestinationFactory, InnerStorageLensEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerStorageLensStorageLensTableDestinationFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T5, subFactoryAction).T2);
}
