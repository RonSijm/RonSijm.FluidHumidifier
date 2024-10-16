// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpaces;

public class InnerWorkspacesPoolTimeoutSettingsFactory(Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.TimeoutSettings> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpaces.WorkspacesPoolTypes.TimeoutSettings>
{

    protected override Humidifier.WorkSpaces.WorkspacesPoolTypes.TimeoutSettings Create()
    {
        var timeoutSettingsResult = CreateTimeoutSettings();
        factoryAction?.Invoke(timeoutSettingsResult);

        return timeoutSettingsResult;
    }

    private Humidifier.WorkSpaces.WorkspacesPoolTypes.TimeoutSettings CreateTimeoutSettings()
    {
        var timeoutSettingsResult = new Humidifier.WorkSpaces.WorkspacesPoolTypes.TimeoutSettings();

        return timeoutSettingsResult;
    }

} // End Of Class

public static class InnerWorkspacesPoolTimeoutSettingsFactoryExtensions
{
}
