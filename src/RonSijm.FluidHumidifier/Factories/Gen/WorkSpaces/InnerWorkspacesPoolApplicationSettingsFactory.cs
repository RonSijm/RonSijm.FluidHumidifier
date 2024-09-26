// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpaces;

public class InnerWorkspacesPoolApplicationSettingsFactory(Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.ApplicationSettings> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpaces.WorkspacesPoolTypes.ApplicationSettings>
{

    protected override Humidifier.WorkSpaces.WorkspacesPoolTypes.ApplicationSettings Create()
    {
        var applicationSettingsResult = CreateApplicationSettings();
        factoryAction?.Invoke(applicationSettingsResult);

        return applicationSettingsResult;
    }

    private Humidifier.WorkSpaces.WorkspacesPoolTypes.ApplicationSettings CreateApplicationSettings()
    {
        var applicationSettingsResult = new Humidifier.WorkSpaces.WorkspacesPoolTypes.ApplicationSettings();

        return applicationSettingsResult;
    }

} // End Of Class

public static class InnerWorkspacesPoolApplicationSettingsFactoryExtensions
{
}
