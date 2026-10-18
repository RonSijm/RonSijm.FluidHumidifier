// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolUserAttributeUpdateSettingsFactory(Action<Humidifier.Cognito.UserPoolTypes.UserAttributeUpdateSettings> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolTypes.UserAttributeUpdateSettings>
{

    protected override Humidifier.Cognito.UserPoolTypes.UserAttributeUpdateSettings Create()
    {
        var userAttributeUpdateSettingsResult = CreateUserAttributeUpdateSettings();
        factoryAction?.Invoke(userAttributeUpdateSettingsResult);

        return userAttributeUpdateSettingsResult;
    }

    private Humidifier.Cognito.UserPoolTypes.UserAttributeUpdateSettings CreateUserAttributeUpdateSettings()
    {
        var userAttributeUpdateSettingsResult = new Humidifier.Cognito.UserPoolTypes.UserAttributeUpdateSettings();

        return userAttributeUpdateSettingsResult;
    }

} // End Of Class

public static class InnerUserPoolUserAttributeUpdateSettingsFactoryExtensions
{
}
