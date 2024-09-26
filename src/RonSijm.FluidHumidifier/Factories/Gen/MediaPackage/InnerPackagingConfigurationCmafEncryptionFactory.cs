// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerPackagingConfigurationCmafEncryptionFactory(Action<Humidifier.MediaPackage.PackagingConfigurationTypes.CmafEncryption> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.PackagingConfigurationTypes.CmafEncryption>
{

    internal InnerPackagingConfigurationSpekeKeyProviderFactory SpekeKeyProviderFactory { get; set; }

    protected override Humidifier.MediaPackage.PackagingConfigurationTypes.CmafEncryption Create()
    {
        var cmafEncryptionResult = CreateCmafEncryption();
        factoryAction?.Invoke(cmafEncryptionResult);

        return cmafEncryptionResult;
    }

    private Humidifier.MediaPackage.PackagingConfigurationTypes.CmafEncryption CreateCmafEncryption()
    {
        var cmafEncryptionResult = new Humidifier.MediaPackage.PackagingConfigurationTypes.CmafEncryption();

        return cmafEncryptionResult;
    }
    public override void CreateChildren(Humidifier.MediaPackage.PackagingConfigurationTypes.CmafEncryption result)
    {
        base.CreateChildren(result);

        result.SpekeKeyProvider ??= SpekeKeyProviderFactory?.Build();
    }

} // End Of Class

public static class InnerPackagingConfigurationCmafEncryptionFactoryExtensions
{
    public static CombinedResult<InnerPackagingConfigurationCmafEncryptionFactory, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider(this InnerPackagingConfigurationCmafEncryptionFactory parentFactory, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null)
    {
        parentFactory.SpekeKeyProviderFactory = new InnerPackagingConfigurationSpekeKeyProviderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpekeKeyProviderFactory);
    }

    public static CombinedResult<InnerPackagingConfigurationCmafEncryptionFactory, T1, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1>(this CombinedResult<InnerPackagingConfigurationCmafEncryptionFactory, T1> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationCmafEncryptionFactory, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1>(this CombinedResult<T1, InnerPackagingConfigurationCmafEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationCmafEncryptionFactory, T1, T2, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<InnerPackagingConfigurationCmafEncryptionFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationCmafEncryptionFactory, T2, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<T1, InnerPackagingConfigurationCmafEncryptionFactory, T2> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationCmafEncryptionFactory, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<T1, T2, InnerPackagingConfigurationCmafEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationCmafEncryptionFactory, T1, T2, T3, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<InnerPackagingConfigurationCmafEncryptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationCmafEncryptionFactory, T2, T3, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, InnerPackagingConfigurationCmafEncryptionFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationCmafEncryptionFactory, T3, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, T2, InnerPackagingConfigurationCmafEncryptionFactory, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPackagingConfigurationCmafEncryptionFactory, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPackagingConfigurationCmafEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationCmafEncryptionFactory, T1, T2, T3, T4, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<InnerPackagingConfigurationCmafEncryptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationCmafEncryptionFactory, T2, T3, T4, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, InnerPackagingConfigurationCmafEncryptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationCmafEncryptionFactory, T3, T4, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPackagingConfigurationCmafEncryptionFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPackagingConfigurationCmafEncryptionFactory, T4, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPackagingConfigurationCmafEncryptionFactory, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPackagingConfigurationCmafEncryptionFactory, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPackagingConfigurationCmafEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T5, subFactoryAction));
}
