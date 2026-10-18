// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerWorkspacePaletteNavigationFactory(Action<Humidifier.Connect.WorkspaceTypes.PaletteNavigation> factoryAction = null) : SubResourceFactory<Humidifier.Connect.WorkspaceTypes.PaletteNavigation>
{

    protected override Humidifier.Connect.WorkspaceTypes.PaletteNavigation Create()
    {
        var paletteNavigationResult = CreatePaletteNavigation();
        factoryAction?.Invoke(paletteNavigationResult);

        return paletteNavigationResult;
    }

    private Humidifier.Connect.WorkspaceTypes.PaletteNavigation CreatePaletteNavigation()
    {
        var paletteNavigationResult = new Humidifier.Connect.WorkspaceTypes.PaletteNavigation();

        return paletteNavigationResult;
    }

} // End Of Class

public static class InnerWorkspacePaletteNavigationFactoryExtensions
{
}
