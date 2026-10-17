// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerWorkspacePalettePrimaryFactory(Action<Humidifier.Connect.WorkspaceTypes.PalettePrimary> factoryAction = null) : SubResourceFactory<Humidifier.Connect.WorkspaceTypes.PalettePrimary>
{

    protected override Humidifier.Connect.WorkspaceTypes.PalettePrimary Create()
    {
        var palettePrimaryResult = CreatePalettePrimary();
        factoryAction?.Invoke(palettePrimaryResult);

        return palettePrimaryResult;
    }

    private Humidifier.Connect.WorkspaceTypes.PalettePrimary CreatePalettePrimary()
    {
        var palettePrimaryResult = new Humidifier.Connect.WorkspaceTypes.PalettePrimary();

        return palettePrimaryResult;
    }

} // End Of Class

public static class InnerWorkspacePalettePrimaryFactoryExtensions
{
}
