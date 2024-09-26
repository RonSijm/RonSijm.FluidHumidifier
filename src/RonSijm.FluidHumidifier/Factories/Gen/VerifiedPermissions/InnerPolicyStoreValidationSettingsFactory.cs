// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VerifiedPermissions;

public class InnerPolicyStoreValidationSettingsFactory(Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.ValidationSettings> factoryAction = null) : SubResourceFactory<Humidifier.VerifiedPermissions.PolicyStoreTypes.ValidationSettings>
{

    protected override Humidifier.VerifiedPermissions.PolicyStoreTypes.ValidationSettings Create()
    {
        var validationSettingsResult = CreateValidationSettings();
        factoryAction?.Invoke(validationSettingsResult);

        return validationSettingsResult;
    }

    private Humidifier.VerifiedPermissions.PolicyStoreTypes.ValidationSettings CreateValidationSettings()
    {
        var validationSettingsResult = new Humidifier.VerifiedPermissions.PolicyStoreTypes.ValidationSettings();

        return validationSettingsResult;
    }

} // End Of Class

public static class InnerPolicyStoreValidationSettingsFactoryExtensions
{
}
