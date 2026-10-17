// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpacesWeb;

public class InnerDataProtectionSettingsInlineRedactionConfigurationFactory(Action<Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.InlineRedactionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.InlineRedactionConfiguration>
{

    protected override Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.InlineRedactionConfiguration Create()
    {
        var inlineRedactionConfigurationResult = CreateInlineRedactionConfiguration();
        factoryAction?.Invoke(inlineRedactionConfigurationResult);

        return inlineRedactionConfigurationResult;
    }

    private Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.InlineRedactionConfiguration CreateInlineRedactionConfiguration()
    {
        var inlineRedactionConfigurationResult = new Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.InlineRedactionConfiguration();

        return inlineRedactionConfigurationResult;
    }

} // End Of Class

public static class InnerDataProtectionSettingsInlineRedactionConfigurationFactoryExtensions
{
}
