// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerPackagingConfigurationMssEncryptionFactory(Action<Humidifier.MediaPackage.PackagingConfigurationTypes.MssEncryption> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.PackagingConfigurationTypes.MssEncryption>
{

    internal InnerPackagingConfigurationSpekeKeyProviderFactory SpekeKeyProviderFactory { get; set; }

    protected override Humidifier.MediaPackage.PackagingConfigurationTypes.MssEncryption Create()
    {
        var mssEncryptionResult = CreateMssEncryption();
        factoryAction?.Invoke(mssEncryptionResult);

        return mssEncryptionResult;
    }

    private Humidifier.MediaPackage.PackagingConfigurationTypes.MssEncryption CreateMssEncryption()
    {
        var mssEncryptionResult = new Humidifier.MediaPackage.PackagingConfigurationTypes.MssEncryption();

        return mssEncryptionResult;
    }
    public override void CreateChildren(Humidifier.MediaPackage.PackagingConfigurationTypes.MssEncryption result)
    {
        base.CreateChildren(result);

        result.SpekeKeyProvider ??= SpekeKeyProviderFactory?.Build();
    }

} // End Of Class

public static class InnerPackagingConfigurationMssEncryptionFactoryExtensions
{
    public static CombinedResult<InnerPackagingConfigurationMssEncryptionFactory, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider(this InnerPackagingConfigurationMssEncryptionFactory parentFactory, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null)
    {
        parentFactory.SpekeKeyProviderFactory = new InnerPackagingConfigurationSpekeKeyProviderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpekeKeyProviderFactory);
    }

    public static CombinedResult<InnerPackagingConfigurationMssEncryptionFactory, T1, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1>(this CombinedResult<InnerPackagingConfigurationMssEncryptionFactory, T1> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationMssEncryptionFactory, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1>(this CombinedResult<T1, InnerPackagingConfigurationMssEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationMssEncryptionFactory, T1, T2, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<InnerPackagingConfigurationMssEncryptionFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationMssEncryptionFactory, T2, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<T1, InnerPackagingConfigurationMssEncryptionFactory, T2> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationMssEncryptionFactory, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<T1, T2, InnerPackagingConfigurationMssEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationMssEncryptionFactory, T1, T2, T3, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<InnerPackagingConfigurationMssEncryptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationMssEncryptionFactory, T2, T3, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, InnerPackagingConfigurationMssEncryptionFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationMssEncryptionFactory, T3, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, T2, InnerPackagingConfigurationMssEncryptionFactory, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPackagingConfigurationMssEncryptionFactory, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPackagingConfigurationMssEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationMssEncryptionFactory, T1, T2, T3, T4, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<InnerPackagingConfigurationMssEncryptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationMssEncryptionFactory, T2, T3, T4, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, InnerPackagingConfigurationMssEncryptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationMssEncryptionFactory, T3, T4, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPackagingConfigurationMssEncryptionFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPackagingConfigurationMssEncryptionFactory, T4, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPackagingConfigurationMssEncryptionFactory, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPackagingConfigurationMssEncryptionFactory, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPackagingConfigurationMssEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T5, subFactoryAction));
}
