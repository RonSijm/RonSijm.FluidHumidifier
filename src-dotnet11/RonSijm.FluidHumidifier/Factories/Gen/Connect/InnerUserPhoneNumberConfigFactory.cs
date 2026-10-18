// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerUserPhoneNumberConfigFactory(Action<Humidifier.Connect.UserTypes.PhoneNumberConfig> factoryAction = null) : SubResourceFactory<Humidifier.Connect.UserTypes.PhoneNumberConfig>
{

    protected override Humidifier.Connect.UserTypes.PhoneNumberConfig Create()
    {
        var phoneNumberConfigResult = CreatePhoneNumberConfig();
        factoryAction?.Invoke(phoneNumberConfigResult);

        return phoneNumberConfigResult;
    }

    private Humidifier.Connect.UserTypes.PhoneNumberConfig CreatePhoneNumberConfig()
    {
        var phoneNumberConfigResult = new Humidifier.Connect.UserTypes.PhoneNumberConfig();

        return phoneNumberConfigResult;
    }

} // End Of Class

public static class InnerUserPhoneNumberConfigFactoryExtensions
{
}
