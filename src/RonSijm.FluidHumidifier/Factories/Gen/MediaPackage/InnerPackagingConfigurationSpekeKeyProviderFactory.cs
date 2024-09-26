// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerPackagingConfigurationSpekeKeyProviderFactory(Action<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider>
{

    internal InnerPackagingConfigurationEncryptionContractConfigurationFactory EncryptionContractConfigurationFactory { get; set; }

    protected override Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider Create()
    {
        var spekeKeyProviderResult = CreateSpekeKeyProvider();
        factoryAction?.Invoke(spekeKeyProviderResult);

        return spekeKeyProviderResult;
    }

    private Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider CreateSpekeKeyProvider()
    {
        var spekeKeyProviderResult = new Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider();

        return spekeKeyProviderResult;
    }
    public override void CreateChildren(Humidifier.MediaPackage.PackagingConfigurationTypes.SpekeKeyProvider result)
    {
        base.CreateChildren(result);

        result.EncryptionContractConfiguration ??= EncryptionContractConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerPackagingConfigurationSpekeKeyProviderFactoryExtensions
{
    public static CombinedResult<InnerPackagingConfigurationSpekeKeyProviderFactory, InnerPackagingConfigurationEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration(this InnerPackagingConfigurationSpekeKeyProviderFactory parentFactory, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.EncryptionContractConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionContractConfigurationFactory = new InnerPackagingConfigurationEncryptionContractConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionContractConfigurationFactory);
    }

    public static CombinedResult<InnerPackagingConfigurationSpekeKeyProviderFactory, T1, InnerPackagingConfigurationEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1>(this CombinedResult<InnerPackagingConfigurationSpekeKeyProviderFactory, T1> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationSpekeKeyProviderFactory, InnerPackagingConfigurationEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1>(this CombinedResult<T1, InnerPackagingConfigurationSpekeKeyProviderFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationSpekeKeyProviderFactory, T1, T2, InnerPackagingConfigurationEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1, T2>(this CombinedResult<InnerPackagingConfigurationSpekeKeyProviderFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationSpekeKeyProviderFactory, T2, InnerPackagingConfigurationEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1, T2>(this CombinedResult<T1, InnerPackagingConfigurationSpekeKeyProviderFactory, T2> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationSpekeKeyProviderFactory, InnerPackagingConfigurationEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerPackagingConfigurationSpekeKeyProviderFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationSpekeKeyProviderFactory, T1, T2, T3, InnerPackagingConfigurationEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1, T2, T3>(this CombinedResult<InnerPackagingConfigurationSpekeKeyProviderFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationSpekeKeyProviderFactory, T2, T3, InnerPackagingConfigurationEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerPackagingConfigurationSpekeKeyProviderFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationSpekeKeyProviderFactory, T3, InnerPackagingConfigurationEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerPackagingConfigurationSpekeKeyProviderFactory, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPackagingConfigurationSpekeKeyProviderFactory, InnerPackagingConfigurationEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPackagingConfigurationSpekeKeyProviderFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationSpekeKeyProviderFactory, T1, T2, T3, T4, InnerPackagingConfigurationEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerPackagingConfigurationSpekeKeyProviderFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationSpekeKeyProviderFactory, T2, T3, T4, InnerPackagingConfigurationEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerPackagingConfigurationSpekeKeyProviderFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationSpekeKeyProviderFactory, T3, T4, InnerPackagingConfigurationEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPackagingConfigurationSpekeKeyProviderFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPackagingConfigurationSpekeKeyProviderFactory, T4, InnerPackagingConfigurationEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPackagingConfigurationSpekeKeyProviderFactory, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPackagingConfigurationSpekeKeyProviderFactory, InnerPackagingConfigurationEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPackagingConfigurationSpekeKeyProviderFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T5, subFactoryAction));
}
