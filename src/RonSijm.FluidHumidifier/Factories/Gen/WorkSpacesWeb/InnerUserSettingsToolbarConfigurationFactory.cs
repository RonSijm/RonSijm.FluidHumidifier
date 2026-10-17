// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpacesWeb;

public class InnerUserSettingsToolbarConfigurationFactory(Action<Humidifier.WorkSpacesWeb.UserSettingsTypes.ToolbarConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpacesWeb.UserSettingsTypes.ToolbarConfiguration>
{

    protected override Humidifier.WorkSpacesWeb.UserSettingsTypes.ToolbarConfiguration Create()
    {
        var toolbarConfigurationResult = CreateToolbarConfiguration();
        factoryAction?.Invoke(toolbarConfigurationResult);

        return toolbarConfigurationResult;
    }

    private Humidifier.WorkSpacesWeb.UserSettingsTypes.ToolbarConfiguration CreateToolbarConfiguration()
    {
        var toolbarConfigurationResult = new Humidifier.WorkSpacesWeb.UserSettingsTypes.ToolbarConfiguration();

        return toolbarConfigurationResult;
    }

} // End Of Class

public static class InnerUserSettingsToolbarConfigurationFactoryExtensions
{
}
