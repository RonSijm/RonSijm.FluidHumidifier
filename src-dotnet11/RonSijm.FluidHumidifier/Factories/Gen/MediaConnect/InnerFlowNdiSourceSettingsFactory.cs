// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowNdiSourceSettingsFactory(Action<Humidifier.MediaConnect.FlowTypes.NdiSourceSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowTypes.NdiSourceSettings>
{

    protected override Humidifier.MediaConnect.FlowTypes.NdiSourceSettings Create()
    {
        var ndiSourceSettingsResult = CreateNdiSourceSettings();
        factoryAction?.Invoke(ndiSourceSettingsResult);

        return ndiSourceSettingsResult;
    }

    private Humidifier.MediaConnect.FlowTypes.NdiSourceSettings CreateNdiSourceSettings()
    {
        var ndiSourceSettingsResult = new Humidifier.MediaConnect.FlowTypes.NdiSourceSettings();

        return ndiSourceSettingsResult;
    }

} // End Of Class

public static class InnerFlowNdiSourceSettingsFactoryExtensions
{
}
