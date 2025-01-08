// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerChannelNamespaceAuthModeFactory(Action<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode>
{

    protected override Humidifier.AppSync.ChannelNamespaceTypes.AuthMode Create()
    {
        var authModeResult = CreateAuthMode();
        factoryAction?.Invoke(authModeResult);

        return authModeResult;
    }

    private Humidifier.AppSync.ChannelNamespaceTypes.AuthMode CreateAuthMode()
    {
        var authModeResult = new Humidifier.AppSync.ChannelNamespaceTypes.AuthMode();

        return authModeResult;
    }

} // End Of Class

public static class InnerChannelNamespaceAuthModeFactoryExtensions
{
}
