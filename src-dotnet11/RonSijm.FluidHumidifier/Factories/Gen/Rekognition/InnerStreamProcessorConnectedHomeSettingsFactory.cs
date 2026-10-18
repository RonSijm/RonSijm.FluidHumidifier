// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Rekognition;

public class InnerStreamProcessorConnectedHomeSettingsFactory(Action<Humidifier.Rekognition.StreamProcessorTypes.ConnectedHomeSettings> factoryAction = null) : SubResourceFactory<Humidifier.Rekognition.StreamProcessorTypes.ConnectedHomeSettings>
{

    protected override Humidifier.Rekognition.StreamProcessorTypes.ConnectedHomeSettings Create()
    {
        var connectedHomeSettingsResult = CreateConnectedHomeSettings();
        factoryAction?.Invoke(connectedHomeSettingsResult);

        return connectedHomeSettingsResult;
    }

    private Humidifier.Rekognition.StreamProcessorTypes.ConnectedHomeSettings CreateConnectedHomeSettings()
    {
        var connectedHomeSettingsResult = new Humidifier.Rekognition.StreamProcessorTypes.ConnectedHomeSettings();

        return connectedHomeSettingsResult;
    }

} // End Of Class

public static class InnerStreamProcessorConnectedHomeSettingsFactoryExtensions
{
}
