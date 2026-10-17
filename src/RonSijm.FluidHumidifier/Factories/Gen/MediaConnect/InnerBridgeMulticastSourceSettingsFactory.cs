// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerBridgeMulticastSourceSettingsFactory(Action<Humidifier.MediaConnect.BridgeTypes.MulticastSourceSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.BridgeTypes.MulticastSourceSettings>
{

    protected override Humidifier.MediaConnect.BridgeTypes.MulticastSourceSettings Create()
    {
        var multicastSourceSettingsResult = CreateMulticastSourceSettings();
        factoryAction?.Invoke(multicastSourceSettingsResult);

        return multicastSourceSettingsResult;
    }

    private Humidifier.MediaConnect.BridgeTypes.MulticastSourceSettings CreateMulticastSourceSettings()
    {
        var multicastSourceSettingsResult = new Humidifier.MediaConnect.BridgeTypes.MulticastSourceSettings();

        return multicastSourceSettingsResult;
    }

} // End Of Class

public static class InnerBridgeMulticastSourceSettingsFactoryExtensions
{
}
