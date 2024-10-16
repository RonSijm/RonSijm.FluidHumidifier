// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerPackagingConfigurationDashPackageFactory(Action<Humidifier.MediaPackage.PackagingConfigurationTypes.DashPackage> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.PackagingConfigurationTypes.DashPackage>
{

    internal InnerPackagingConfigurationDashEncryptionFactory EncryptionFactory { get; set; }

    protected override Humidifier.MediaPackage.PackagingConfigurationTypes.DashPackage Create()
    {
        var dashPackageResult = CreateDashPackage();
        factoryAction?.Invoke(dashPackageResult);

        return dashPackageResult;
    }

    private Humidifier.MediaPackage.PackagingConfigurationTypes.DashPackage CreateDashPackage()
    {
        var dashPackageResult = new Humidifier.MediaPackage.PackagingConfigurationTypes.DashPackage();

        return dashPackageResult;
    }
    public override void CreateChildren(Humidifier.MediaPackage.PackagingConfigurationTypes.DashPackage result)
    {
        base.CreateChildren(result);

        result.Encryption ??= EncryptionFactory?.Build();
    }

} // End Of Class

public static class InnerPackagingConfigurationDashPackageFactoryExtensions
{
    public static CombinedResult<InnerPackagingConfigurationDashPackageFactory, InnerPackagingConfigurationDashEncryptionFactory> WithEncryption(this InnerPackagingConfigurationDashPackageFactory parentFactory, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.DashEncryption> subFactoryAction = null)
    {
        parentFactory.EncryptionFactory = new InnerPackagingConfigurationDashEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionFactory);
    }

    public static CombinedResult<InnerPackagingConfigurationDashPackageFactory, T1, InnerPackagingConfigurationDashEncryptionFactory> WithEncryption<T1>(this CombinedResult<InnerPackagingConfigurationDashPackageFactory, T1> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationDashPackageFactory, InnerPackagingConfigurationDashEncryptionFactory> WithEncryption<T1>(this CombinedResult<T1, InnerPackagingConfigurationDashPackageFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationDashPackageFactory, T1, T2, InnerPackagingConfigurationDashEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<InnerPackagingConfigurationDashPackageFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationDashPackageFactory, T2, InnerPackagingConfigurationDashEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<T1, InnerPackagingConfigurationDashPackageFactory, T2> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationDashPackageFactory, InnerPackagingConfigurationDashEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<T1, T2, InnerPackagingConfigurationDashPackageFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationDashPackageFactory, T1, T2, T3, InnerPackagingConfigurationDashEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<InnerPackagingConfigurationDashPackageFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationDashPackageFactory, T2, T3, InnerPackagingConfigurationDashEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, InnerPackagingConfigurationDashPackageFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationDashPackageFactory, T3, InnerPackagingConfigurationDashEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, InnerPackagingConfigurationDashPackageFactory, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPackagingConfigurationDashPackageFactory, InnerPackagingConfigurationDashEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPackagingConfigurationDashPackageFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPackagingConfigurationDashPackageFactory, T1, T2, T3, T4, InnerPackagingConfigurationDashEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<InnerPackagingConfigurationDashPackageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackagingConfigurationDashPackageFactory, T2, T3, T4, InnerPackagingConfigurationDashEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, InnerPackagingConfigurationDashPackageFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackagingConfigurationDashPackageFactory, T3, T4, InnerPackagingConfigurationDashEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPackagingConfigurationDashPackageFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPackagingConfigurationDashPackageFactory, T4, InnerPackagingConfigurationDashEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPackagingConfigurationDashPackageFactory, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPackagingConfigurationDashPackageFactory, InnerPackagingConfigurationDashEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPackagingConfigurationDashPackageFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingConfigurationTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T5, subFactoryAction));
}
