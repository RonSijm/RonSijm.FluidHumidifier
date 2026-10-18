// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerInputRouterSettingsFactory(Action<Humidifier.MediaLive.InputTypes.RouterSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.InputTypes.RouterSettings>
{

    protected override Humidifier.MediaLive.InputTypes.RouterSettings Create()
    {
        var routerSettingsResult = CreateRouterSettings();
        factoryAction?.Invoke(routerSettingsResult);

        return routerSettingsResult;
    }

    private Humidifier.MediaLive.InputTypes.RouterSettings CreateRouterSettings()
    {
        var routerSettingsResult = new Humidifier.MediaLive.InputTypes.RouterSettings();

        return routerSettingsResult;
    }

} // End Of Class

public static class InnerInputRouterSettingsFactoryExtensions
{
}
