// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerUserUserPhoneConfigFactory(Action<Humidifier.Connect.UserTypes.UserPhoneConfig> factoryAction = null) : SubResourceFactory<Humidifier.Connect.UserTypes.UserPhoneConfig>
{

    protected override Humidifier.Connect.UserTypes.UserPhoneConfig Create()
    {
        var userPhoneConfigResult = CreateUserPhoneConfig();
        factoryAction?.Invoke(userPhoneConfigResult);

        return userPhoneConfigResult;
    }

    private Humidifier.Connect.UserTypes.UserPhoneConfig CreateUserPhoneConfig()
    {
        var userPhoneConfigResult = new Humidifier.Connect.UserTypes.UserPhoneConfig();

        return userPhoneConfigResult;
    }

} // End Of Class

public static class InnerUserUserPhoneConfigFactoryExtensions
{
}
