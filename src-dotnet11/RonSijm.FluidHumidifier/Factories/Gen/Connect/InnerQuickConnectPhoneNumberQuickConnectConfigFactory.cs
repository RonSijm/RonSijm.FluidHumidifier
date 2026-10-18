// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerQuickConnectPhoneNumberQuickConnectConfigFactory(Action<Humidifier.Connect.QuickConnectTypes.PhoneNumberQuickConnectConfig> factoryAction = null) : SubResourceFactory<Humidifier.Connect.QuickConnectTypes.PhoneNumberQuickConnectConfig>
{

    protected override Humidifier.Connect.QuickConnectTypes.PhoneNumberQuickConnectConfig Create()
    {
        var phoneNumberQuickConnectConfigResult = CreatePhoneNumberQuickConnectConfig();
        factoryAction?.Invoke(phoneNumberQuickConnectConfigResult);

        return phoneNumberQuickConnectConfigResult;
    }

    private Humidifier.Connect.QuickConnectTypes.PhoneNumberQuickConnectConfig CreatePhoneNumberQuickConnectConfig()
    {
        var phoneNumberQuickConnectConfigResult = new Humidifier.Connect.QuickConnectTypes.PhoneNumberQuickConnectConfig();

        return phoneNumberQuickConnectConfigResult;
    }

} // End Of Class

public static class InnerQuickConnectPhoneNumberQuickConnectConfigFactoryExtensions
{
}
