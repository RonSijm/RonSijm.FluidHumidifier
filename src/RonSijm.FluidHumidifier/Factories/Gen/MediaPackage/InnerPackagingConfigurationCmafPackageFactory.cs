// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerPackagingConfigurationCmafPackageFactory(Action<Humidifier.MediaPackage.PackagingConfigurationTypes.CmafPackage> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.PackagingConfigurationTypes.CmafPackage>
{

    internal InnerPackagingConfigurationCmafEncryptionFactory EncryptionFactory { get; set; }

    protected override Humidifier.MediaPackage.PackagingConfigurationTypes.CmafPackage Create()
    {
        var cmafPackageResult = CreateCmafPackage();
        factoryAction?.Invoke(cmafPackageResult);

        return cmafPackageResult;
    }

    private Humidifier.MediaPackage.PackagingConfigurationTypes.CmafPackage CreateCmafPackage()
    {
        var cmafPackageResult = new Humidifier.MediaPackage.PackagingConfigurationTypes.CmafPackage();

        return cmafPackageResult;
    }
    public override void CreateChildren(Humidifier.MediaPackage.PackagingConfigurationTypes.CmafPackage result)
    {
        base.CreateChildren(result);

        result.Encryption ??= EncryptionFactory?.Build();
    }

} // End Of Class

public static class InnerPackagingConfigurationCmafPackageFactoryExtensions
{
    public static CombinedResult<InnerPackagingConfigurationCmafPackageFactory, InnerPackagingConfigurationCmafEncryptionFactory> WithEncryption(this InnerPackagingConfigurationCmafPackageFactory parentFactory, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.CmafEncryption> subFactoryAction = null)
    {
        parentFactory.EncryptionFactory = new InnerPackagingConfigurationCmafEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionFactory);
    }

    public static CombinedResult<InnerPackagingConfigurationCmafPackageFactory, T1, InnerPackagingConfigurationCmafEncryptionFactory> WithEncryption<T1>(this CombinedResult<InnerPackagingConfigurationCmafPackageFactory, T1> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationCmafPackageFactory, InnerPackagingConfigurationCmafEncryptionFactory> WithEncryption<T1>(this CombinedResult<T1, InnerPackagingConfigurationCmafPackageFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationCmafPackageFactory, T1, T2, InnerPackagingConfigurationCmafEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<InnerPackagingConfigurationCmafPackageFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationCmafPackageFactory, T2, InnerPackagingConfigurationCmafEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<T1, InnerPackagingConfigurationCmafPackageFactory, T2> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationCmafPackageFactory, InnerPackagingConfigurationCmafEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<T1, T2, InnerPackagingConfigurationCmafPackageFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationCmafPackageFactory, T1, T2, T3, InnerPackagingConfigurationCmafEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<InnerPackagingConfigurationCmafPackageFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationCmafPackageFactory, T2, T3, InnerPackagingConfigurationCmafEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, InnerPackagingConfigurationCmafPackageFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationCmafPackageFactory, T3, InnerPackagingConfigurationCmafEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, InnerPackagingConfigurationCmafPackageFactory, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPackagingConfigurationCmafPackageFactory, InnerPackagingConfigurationCmafEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPackagingConfigurationCmafPackageFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationCmafPackageFactory, T1, T2, T3, T4, InnerPackagingConfigurationCmafEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<InnerPackagingConfigurationCmafPackageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationCmafPackageFactory, T2, T3, T4, InnerPackagingConfigurationCmafEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, InnerPackagingConfigurationCmafPackageFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationCmafPackageFactory, T3, T4, InnerPackagingConfigurationCmafEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPackagingConfigurationCmafPackageFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPackagingConfigurationCmafPackageFactory, T4, InnerPackagingConfigurationCmafEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPackagingConfigurationCmafPackageFactory, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPackagingConfigurationCmafPackageFactory, InnerPackagingConfigurationCmafEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPackagingConfigurationCmafPackageFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T5, subFactoryAction));
}
