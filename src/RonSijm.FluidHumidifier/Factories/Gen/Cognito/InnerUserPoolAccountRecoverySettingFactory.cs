// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolAccountRecoverySettingFactory(Action<Humidifier.Cognito.UserPoolTypes.AccountRecoverySetting> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolTypes.AccountRecoverySetting>
{

    protected override Humidifier.Cognito.UserPoolTypes.AccountRecoverySetting Create()
    {
        var accountRecoverySettingResult = CreateAccountRecoverySetting();
        factoryAction?.Invoke(accountRecoverySettingResult);

        return accountRecoverySettingResult;
    }

    private Humidifier.Cognito.UserPoolTypes.AccountRecoverySetting CreateAccountRecoverySetting()
    {
        var accountRecoverySettingResult = new Humidifier.Cognito.UserPoolTypes.AccountRecoverySetting();

        return accountRecoverySettingResult;
    }

} // End Of Class

public static class InnerUserPoolAccountRecoverySettingFactoryExtensions
{
}
