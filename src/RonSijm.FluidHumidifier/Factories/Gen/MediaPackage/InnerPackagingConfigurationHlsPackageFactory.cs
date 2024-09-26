// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerPackagingConfigurationHlsPackageFactory(Action<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsPackage> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsPackage>
{

    internal InnerPackagingConfigurationHlsEncryptionFactory EncryptionFactory { get; set; }

    protected override Humidifier.MediaPackage.PackagingConfigurationTypes.HlsPackage Create()
    {
        var hlsPackageResult = CreateHlsPackage();
        factoryAction?.Invoke(hlsPackageResult);

        return hlsPackageResult;
    }

    private Humidifier.MediaPackage.PackagingConfigurationTypes.HlsPackage CreateHlsPackage()
    {
        var hlsPackageResult = new Humidifier.MediaPackage.PackagingConfigurationTypes.HlsPackage();

        return hlsPackageResult;
    }
    public override void CreateChildren(Humidifier.MediaPackage.PackagingConfigurationTypes.HlsPackage result)
    {
        base.CreateChildren(result);

        result.Encryption ??= EncryptionFactory?.Build();
    }

} // End Of Class

public static class InnerPackagingConfigurationHlsPackageFactoryExtensions
{
    public static CombinedResult<InnerPackagingConfigurationHlsPackageFactory, InnerPackagingConfigurationHlsEncryptionFactory> WithEncryption(this InnerPackagingConfigurationHlsPackageFactory parentFactory, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsEncryption> subFactoryAction = null)
    {
        parentFactory.EncryptionFactory = new InnerPackagingConfigurationHlsEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionFactory);
    }

    public static CombinedResult<InnerPackagingConfigurationHlsPackageFactory, T1, InnerPackagingConfigurationHlsEncryptionFactory> WithEncryption<T1>(this CombinedResult<InnerPackagingConfigurationHlsPackageFactory, T1> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationHlsPackageFactory, InnerPackagingConfigurationHlsEncryptionFactory> WithEncryption<T1>(this CombinedResult<T1, InnerPackagingConfigurationHlsPackageFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationHlsPackageFactory, T1, T2, InnerPackagingConfigurationHlsEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<InnerPackagingConfigurationHlsPackageFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationHlsPackageFactory, T2, InnerPackagingConfigurationHlsEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<T1, InnerPackagingConfigurationHlsPackageFactory, T2> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationHlsPackageFactory, InnerPackagingConfigurationHlsEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<T1, T2, InnerPackagingConfigurationHlsPackageFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationHlsPackageFactory, T1, T2, T3, InnerPackagingConfigurationHlsEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<InnerPackagingConfigurationHlsPackageFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationHlsPackageFactory, T2, T3, InnerPackagingConfigurationHlsEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, InnerPackagingConfigurationHlsPackageFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationHlsPackageFactory, T3, InnerPackagingConfigurationHlsEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, InnerPackagingConfigurationHlsPackageFactory, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPackagingConfigurationHlsPackageFactory, InnerPackagingConfigurationHlsEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPackagingConfigurationHlsPackageFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationHlsPackageFactory, T1, T2, T3, T4, InnerPackagingConfigurationHlsEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<InnerPackagingConfigurationHlsPackageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationHlsPackageFactory, T2, T3, T4, InnerPackagingConfigurationHlsEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, InnerPackagingConfigurationHlsPackageFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationHlsPackageFactory, T3, T4, InnerPackagingConfigurationHlsEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPackagingConfigurationHlsPackageFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPackagingConfigurationHlsPackageFactory, T4, InnerPackagingConfigurationHlsEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPackagingConfigurationHlsPackageFactory, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPackagingConfigurationHlsPackageFactory, InnerPackagingConfigurationHlsEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPackagingConfigurationHlsPackageFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T5, subFactoryAction));
}
