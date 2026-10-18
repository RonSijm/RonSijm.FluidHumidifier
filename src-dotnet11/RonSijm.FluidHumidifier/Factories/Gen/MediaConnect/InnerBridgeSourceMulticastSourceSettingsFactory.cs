// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerBridgeSourceMulticastSourceSettingsFactory(Action<Humidifier.MediaConnect.BridgeSourceTypes.MulticastSourceSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.BridgeSourceTypes.MulticastSourceSettings>
{

    protected override Humidifier.MediaConnect.BridgeSourceTypes.MulticastSourceSettings Create()
    {
        var multicastSourceSettingsResult = CreateMulticastSourceSettings();
        factoryAction?.Invoke(multicastSourceSettingsResult);

        return multicastSourceSettingsResult;
    }

    private Humidifier.MediaConnect.BridgeSourceTypes.MulticastSourceSettings CreateMulticastSourceSettings()
    {
        var multicastSourceSettingsResult = new Humidifier.MediaConnect.BridgeSourceTypes.MulticastSourceSettings();

        return multicastSourceSettingsResult;
    }

} // End Of Class

public static class InnerBridgeSourceMulticastSourceSettingsFactoryExtensions
{
}
