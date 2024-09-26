// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerPackagingConfigurationMssPackageFactory(Action<Humidifier.MediaPackage.PackagingConfigurationTypes.MssPackage> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.PackagingConfigurationTypes.MssPackage>
{

    internal InnerPackagingConfigurationMssEncryptionFactory EncryptionFactory { get; set; }

    protected override Humidifier.MediaPackage.PackagingConfigurationTypes.MssPackage Create()
    {
        var mssPackageResult = CreateMssPackage();
        factoryAction?.Invoke(mssPackageResult);

        return mssPackageResult;
    }

    private Humidifier.MediaPackage.PackagingConfigurationTypes.MssPackage CreateMssPackage()
    {
        var mssPackageResult = new Humidifier.MediaPackage.PackagingConfigurationTypes.MssPackage();

        return mssPackageResult;
    }
    public override void CreateChildren(Humidifier.MediaPackage.PackagingConfigurationTypes.MssPackage result)
    {
        base.CreateChildren(result);

        result.Encryption ??= EncryptionFactory?.Build();
    }

} // End Of Class

public static class InnerPackagingConfigurationMssPackageFactoryExtensions
{
    public static CombinedResult<InnerPackagingConfigurationMssPackageFactory, InnerPackagingConfigurationMssEncryptionFactory> WithEncryption(this InnerPackagingConfigurationMssPackageFactory parentFactory, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.MssEncryption> subFactoryAction = null)
    {
        parentFactory.EncryptionFactory = new InnerPackagingConfigurationMssEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionFactory);
    }

    public static CombinedResult<InnerPackagingConfigurationMssPackageFactory, T1, InnerPackagingConfigurationMssEncryptionFactory> WithEncryption<T1>(this CombinedResult<InnerPackagingConfigurationMssPackageFactory, T1> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationMssPackageFactory, InnerPackagingConfigurationMssEncryptionFactory> WithEncryption<T1>(this CombinedResult<T1, InnerPackagingConfigurationMssPackageFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationMssPackageFactory, T1, T2, InnerPackagingConfigurationMssEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<InnerPackagingConfigurationMssPackageFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationMssPackageFactory, T2, InnerPackagingConfigurationMssEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<T1, InnerPackagingConfigurationMssPackageFactory, T2> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationMssPackageFactory, InnerPackagingConfigurationMssEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<T1, T2, InnerPackagingConfigurationMssPackageFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationMssPackageFactory, T1, T2, T3, InnerPackagingConfigurationMssEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<InnerPackagingConfigurationMssPackageFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationMssPackageFactory, T2, T3, InnerPackagingConfigurationMssEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, InnerPackagingConfigurationMssPackageFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationMssPackageFactory, T3, InnerPackagingConfigurationMssEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, InnerPackagingConfigurationMssPackageFactory, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPackagingConfigurationMssPackageFactory, InnerPackagingConfigurationMssEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPackagingConfigurationMssPackageFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationMssPackageFactory, T1, T2, T3, T4, InnerPackagingConfigurationMssEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<InnerPackagingConfigurationMssPackageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationMssPackageFactory, T2, T3, T4, InnerPackagingConfigurationMssEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, InnerPackagingConfigurationMssPackageFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationMssPackageFactory, T3, T4, InnerPackagingConfigurationMssEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPackagingConfigurationMssPackageFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPackagingConfigurationMssPackageFactory, T4, InnerPackagingConfigurationMssEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPackagingConfigurationMssPackageFactory, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPackagingConfigurationMssPackageFactory, InnerPackagingConfigurationMssEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPackagingConfigurationMssPackageFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.MssEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T5, subFactoryAction));
}
