// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerPackagingConfigurationHlsEncryptionFactory(Action<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsEncryption> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.PackagingConfigurationTypes.HlsEncryption>
{

    internal InnerPackagingConfigurationSpekeKeyProviderFactory SpekeKeyProviderFactory { get; set; }

    protected override Humidifier.MediaPackage.PackagingConfigurationTypes.HlsEncryption Create()
    {
        var hlsEncryptionResult = CreateHlsEncryption();
        factoryAction?.Invoke(hlsEncryptionResult);

        return hlsEncryptionResult;
    }

    private Humidifier.MediaPackage.PackagingConfigurationTypes.HlsEncryption CreateHlsEncryption()
    {
        var hlsEncryptionResult = new Humidifier.MediaPackage.PackagingConfigurationTypes.HlsEncryption();

        return hlsEncryptionResult;
    }
    public override void CreateChildren(Humidifier.MediaPackage.PackagingConfigurationTypes.HlsEncryption result)
    {
        base.CreateChildren(result);

        result.SpekeKeyProvider ??= SpekeKeyProviderFactory?.Build();
    }

} // End Of Class

public static class InnerPackagingConfigurationHlsEncryptionFactoryExtensions
{
    public static CombinedResult<InnerPackagingConfigurationHlsEncryptionFactory, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider(this InnerPackagingConfigurationHlsEncryptionFactory parentFactory, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null)
    {
        parentFactory.SpekeKeyProviderFactory = new InnerPackagingConfigurationSpekeKeyProviderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpekeKeyProviderFactory);
    }

    public static CombinedResult<InnerPackagingConfigurationHlsEncryptionFactory, T1, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1>(this CombinedResult<InnerPackagingConfigurationHlsEncryptionFactory, T1> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationHlsEncryptionFactory, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1>(this CombinedResult<T1, InnerPackagingConfigurationHlsEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationHlsEncryptionFactory, T1, T2, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<InnerPackagingConfigurationHlsEncryptionFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationHlsEncryptionFactory, T2, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<T1, InnerPackagingConfigurationHlsEncryptionFactory, T2> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationHlsEncryptionFactory, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<T1, T2, InnerPackagingConfigurationHlsEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationHlsEncryptionFactory, T1, T2, T3, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<InnerPackagingConfigurationHlsEncryptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationHlsEncryptionFactory, T2, T3, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, InnerPackagingConfigurationHlsEncryptionFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationHlsEncryptionFactory, T3, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, T2, InnerPackagingConfigurationHlsEncryptionFactory, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPackagingConfigurationHlsEncryptionFactory, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPackagingConfigurationHlsEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationHlsEncryptionFactory, T1, T2, T3, T4, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<InnerPackagingConfigurationHlsEncryptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationHlsEncryptionFactory, T2, T3, T4, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, InnerPackagingConfigurationHlsEncryptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationHlsEncryptionFactory, T3, T4, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPackagingConfigurationHlsEncryptionFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPackagingConfigurationHlsEncryptionFactory, T4, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPackagingConfigurationHlsEncryptionFactory, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPackagingConfigurationHlsEncryptionFactory, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPackagingConfigurationHlsEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T5, subFactoryAction));
}
