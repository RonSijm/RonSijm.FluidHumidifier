// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerQuickConnectUserQuickConnectConfigFactory(Action<Humidifier.Connect.QuickConnectTypes.UserQuickConnectConfig> factoryAction = null) : SubResourceFactory<Humidifier.Connect.QuickConnectTypes.UserQuickConnectConfig>
{

    protected override Humidifier.Connect.QuickConnectTypes.UserQuickConnectConfig Create()
    {
        var userQuickConnectConfigResult = CreateUserQuickConnectConfig();
        factoryAction?.Invoke(userQuickConnectConfigResult);

        return userQuickConnectConfigResult;
    }

    private Humidifier.Connect.QuickConnectTypes.UserQuickConnectConfig CreateUserQuickConnectConfig()
    {
        var userQuickConnectConfigResult = new Humidifier.Connect.QuickConnectTypes.UserQuickConnectConfig();

        return userQuickConnectConfigResult;
    }

} // End Of Class

public static class InnerQuickConnectUserQuickConnectConfigFactoryExtensions
{
}
