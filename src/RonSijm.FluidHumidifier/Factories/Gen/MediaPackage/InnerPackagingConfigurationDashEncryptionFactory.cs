// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerPackagingConfigurationDashEncryptionFactory(Action<Humidifier.MediaPackage.PackagingConfigurationTypes.DashEncryption> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.PackagingConfigurationTypes.DashEncryption>
{

    internal InnerPackagingConfigurationSpekeKeyProviderFactory SpekeKeyProviderFactory { get; set; }

    protected override Humidifier.MediaPackage.PackagingConfigurationTypes.DashEncryption Create()
    {
        var dashEncryptionResult = CreateDashEncryption();
        factoryAction?.Invoke(dashEncryptionResult);

        return dashEncryptionResult;
    }

    private Humidifier.MediaPackage.PackagingConfigurationTypes.DashEncryption CreateDashEncryption()
    {
        var dashEncryptionResult = new Humidifier.MediaPackage.PackagingConfigurationTypes.DashEncryption();

        return dashEncryptionResult;
    }
    public override void CreateChildren(Humidifier.MediaPackage.PackagingConfigurationTypes.DashEncryption result)
    {
        base.CreateChildren(result);

        result.SpekeKeyProvider ??= SpekeKeyProviderFactory?.Build();
    }

} // End Of Class

public static class InnerPackagingConfigurationDashEncryptionFactoryExtensions
{
    public static CombinedResult<InnerPackagingConfigurationDashEncryptionFactory, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider(this InnerPackagingConfigurationDashEncryptionFactory parentFactory, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null)
    {
        parentFactory.SpekeKeyProviderFactory = new InnerPackagingConfigurationSpekeKeyProviderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpekeKeyProviderFactory);
    }

    public static CombinedResult<InnerPackagingConfigurationDashEncryptionFactory, T1, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1>(this CombinedResult<InnerPackagingConfigurationDashEncryptionFactory, T1> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationDashEncryptionFactory, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1>(this CombinedResult<T1, InnerPackagingConfigurationDashEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationDashEncryptionFactory, T1, T2, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<InnerPackagingConfigurationDashEncryptionFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationDashEncryptionFactory, T2, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<T1, InnerPackagingConfigurationDashEncryptionFactory, T2> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationDashEncryptionFactory, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<T1, T2, InnerPackagingConfigurationDashEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationDashEncryptionFactory, T1, T2, T3, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<InnerPackagingConfigurationDashEncryptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationDashEncryptionFactory, T2, T3, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, InnerPackagingConfigurationDashEncryptionFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationDashEncryptionFactory, T3, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, T2, InnerPackagingConfigurationDashEncryptionFactory, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPackagingConfigurationDashEncryptionFactory, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPackagingConfigurationDashEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationDashEncryptionFactory, T1, T2, T3, T4, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<InnerPackagingConfigurationDashEncryptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationDashEncryptionFactory, T2, T3, T4, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, InnerPackagingConfigurationDashEncryptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationDashEncryptionFactory, T3, T4, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPackagingConfigurationDashEncryptionFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPackagingConfigurationDashEncryptionFactory, T4, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPackagingConfigurationDashEncryptionFactory, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPackagingConfigurationDashEncryptionFactory, InnerPackagingConfigurationSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPackagingConfigurationDashEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T5, subFactoryAction));
}
