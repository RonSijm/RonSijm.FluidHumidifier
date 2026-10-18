// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodePipeline;

public class InnerCustomActionTypeSettingsFactory(Action<Humidifier.CodePipeline.CustomActionTypeTypes.Settings> factoryAction = null) : SubResourceFactory<Humidifier.CodePipeline.CustomActionTypeTypes.Settings>
{

    protected override Humidifier.CodePipeline.CustomActionTypeTypes.Settings Create()
    {
        var settingsResult = CreateSettings();
        factoryAction?.Invoke(settingsResult);

        return settingsResult;
    }

    private Humidifier.CodePipeline.CustomActionTypeTypes.Settings CreateSettings()
    {
        var settingsResult = new Humidifier.CodePipeline.CustomActionTypeTypes.Settings();

        return settingsResult;
    }

} // End Of Class

public static class InnerCustomActionTypeSettingsFactoryExtensions
{
}
