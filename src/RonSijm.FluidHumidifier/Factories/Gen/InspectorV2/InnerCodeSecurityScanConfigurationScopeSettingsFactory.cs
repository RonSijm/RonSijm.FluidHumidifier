// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.InspectorV2;

public class InnerCodeSecurityScanConfigurationScopeSettingsFactory(Action<Humidifier.InspectorV2.CodeSecurityScanConfigurationTypes.ScopeSettings> factoryAction = null) : SubResourceFactory<Humidifier.InspectorV2.CodeSecurityScanConfigurationTypes.ScopeSettings>
{

    protected override Humidifier.InspectorV2.CodeSecurityScanConfigurationTypes.ScopeSettings Create()
    {
        var scopeSettingsResult = CreateScopeSettings();
        factoryAction?.Invoke(scopeSettingsResult);

        return scopeSettingsResult;
    }

    private Humidifier.InspectorV2.CodeSecurityScanConfigurationTypes.ScopeSettings CreateScopeSettings()
    {
        var scopeSettingsResult = new Humidifier.InspectorV2.CodeSecurityScanConfigurationTypes.ScopeSettings();

        return scopeSettingsResult;
    }

} // End Of Class

public static class InnerCodeSecurityScanConfigurationScopeSettingsFactoryExtensions
{
}
