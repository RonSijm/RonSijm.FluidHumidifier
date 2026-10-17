// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VerifiedPermissions;

public class InnerPolicyStoreEncryptionSettingsFactory(Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.EncryptionSettings> factoryAction = null) : SubResourceFactory<Humidifier.VerifiedPermissions.PolicyStoreTypes.EncryptionSettings>
{

    internal InnerPolicyStoreKmsEncryptionSettingsFactory KmsEncryptionSettingsFactory { get; set; }

    protected override Humidifier.VerifiedPermissions.PolicyStoreTypes.EncryptionSettings Create()
    {
        var encryptionSettingsResult = CreateEncryptionSettings();
        factoryAction?.Invoke(encryptionSettingsResult);

        return encryptionSettingsResult;
    }

    private Humidifier.VerifiedPermissions.PolicyStoreTypes.EncryptionSettings CreateEncryptionSettings()
    {
        var encryptionSettingsResult = new Humidifier.VerifiedPermissions.PolicyStoreTypes.EncryptionSettings();

        return encryptionSettingsResult;
    }
    public override void CreateChildren(Humidifier.VerifiedPermissions.PolicyStoreTypes.EncryptionSettings result)
    {
        base.CreateChildren(result);

        result.KmsEncryptionSettings ??= KmsEncryptionSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerPolicyStoreEncryptionSettingsFactoryExtensions
{
    public static CombinedResult<InnerPolicyStoreEncryptionSettingsFactory, InnerPolicyStoreKmsEncryptionSettingsFactory> WithKmsEncryptionSettings(this InnerPolicyStoreEncryptionSettingsFactory parentFactory, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.KmsEncryptionSettings> subFactoryAction = null)
    {
        parentFactory.KmsEncryptionSettingsFactory = new InnerPolicyStoreKmsEncryptionSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.KmsEncryptionSettingsFactory);
    }

    public static CombinedResult<InnerPolicyStoreEncryptionSettingsFactory, T1, InnerPolicyStoreKmsEncryptionSettingsFactory> WithKmsEncryptionSettings<T1>(this CombinedResult<InnerPolicyStoreEncryptionSettingsFactory, T1> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.KmsEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithKmsEncryptionSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyStoreEncryptionSettingsFactory, InnerPolicyStoreKmsEncryptionSettingsFactory> WithKmsEncryptionSettings<T1>(this CombinedResult<T1, InnerPolicyStoreEncryptionSettingsFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.KmsEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithKmsEncryptionSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerPolicyStoreEncryptionSettingsFactory, T1, T2, InnerPolicyStoreKmsEncryptionSettingsFactory> WithKmsEncryptionSettings<T1, T2>(this CombinedResult<InnerPolicyStoreEncryptionSettingsFactory, T1, T2> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.KmsEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKmsEncryptionSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyStoreEncryptionSettingsFactory, T2, InnerPolicyStoreKmsEncryptionSettingsFactory> WithKmsEncryptionSettings<T1, T2>(this CombinedResult<T1, InnerPolicyStoreEncryptionSettingsFactory, T2> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.KmsEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKmsEncryptionSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPolicyStoreEncryptionSettingsFactory, InnerPolicyStoreKmsEncryptionSettingsFactory> WithKmsEncryptionSettings<T1, T2>(this CombinedResult<T1, T2, InnerPolicyStoreEncryptionSettingsFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.KmsEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKmsEncryptionSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerPolicyStoreEncryptionSettingsFactory, T1, T2, T3, InnerPolicyStoreKmsEncryptionSettingsFactory> WithKmsEncryptionSettings<T1, T2, T3>(this CombinedResult<InnerPolicyStoreEncryptionSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.KmsEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKmsEncryptionSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyStoreEncryptionSettingsFactory, T2, T3, InnerPolicyStoreKmsEncryptionSettingsFactory> WithKmsEncryptionSettings<T1, T2, T3>(this CombinedResult<T1, InnerPolicyStoreEncryptionSettingsFactory, T2, T3> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.KmsEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKmsEncryptionSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPolicyStoreEncryptionSettingsFactory, T3, InnerPolicyStoreKmsEncryptionSettingsFactory> WithKmsEncryptionSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerPolicyStoreEncryptionSettingsFactory, T3> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.KmsEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKmsEncryptionSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPolicyStoreEncryptionSettingsFactory, InnerPolicyStoreKmsEncryptionSettingsFactory> WithKmsEncryptionSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPolicyStoreEncryptionSettingsFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.KmsEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKmsEncryptionSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerPolicyStoreEncryptionSettingsFactory, T1, T2, T3, T4, InnerPolicyStoreKmsEncryptionSettingsFactory> WithKmsEncryptionSettings<T1, T2, T3, T4>(this CombinedResult<InnerPolicyStoreEncryptionSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.KmsEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKmsEncryptionSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyStoreEncryptionSettingsFactory, T2, T3, T4, InnerPolicyStoreKmsEncryptionSettingsFactory> WithKmsEncryptionSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerPolicyStoreEncryptionSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.KmsEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKmsEncryptionSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPolicyStoreEncryptionSettingsFactory, T3, T4, InnerPolicyStoreKmsEncryptionSettingsFactory> WithKmsEncryptionSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPolicyStoreEncryptionSettingsFactory, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.KmsEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKmsEncryptionSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPolicyStoreEncryptionSettingsFactory, T4, InnerPolicyStoreKmsEncryptionSettingsFactory> WithKmsEncryptionSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPolicyStoreEncryptionSettingsFactory, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.KmsEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKmsEncryptionSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerPolicyStoreEncryptionSettingsFactory, InnerPolicyStoreKmsEncryptionSettingsFactory> WithKmsEncryptionSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPolicyStoreEncryptionSettingsFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.KmsEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKmsEncryptionSettings(combinedResult.T5, subFactoryAction).T2);
}
