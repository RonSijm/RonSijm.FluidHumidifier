// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NimbleStudio;

public class InnerStudioComponentStudioComponentInitializationScriptFactory(Action<Humidifier.NimbleStudio.StudioComponentTypes.StudioComponentInitializationScript> factoryAction = null) : SubResourceFactory<Humidifier.NimbleStudio.StudioComponentTypes.StudioComponentInitializationScript>
{

    protected override Humidifier.NimbleStudio.StudioComponentTypes.StudioComponentInitializationScript Create()
    {
        var studioComponentInitializationScriptResult = CreateStudioComponentInitializationScript();
        factoryAction?.Invoke(studioComponentInitializationScriptResult);

        return studioComponentInitializationScriptResult;
    }

    private Humidifier.NimbleStudio.StudioComponentTypes.StudioComponentInitializationScript CreateStudioComponentInitializationScript()
    {
        var studioComponentInitializationScriptResult = new Humidifier.NimbleStudio.StudioComponentTypes.StudioComponentInitializationScript();

        return studioComponentInitializationScriptResult;
    }

} // End Of Class

public static class InnerStudioComponentStudioComponentInitializationScriptFactoryExtensions
{
}
