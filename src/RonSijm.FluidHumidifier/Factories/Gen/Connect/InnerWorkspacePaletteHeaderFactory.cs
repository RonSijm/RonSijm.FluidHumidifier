// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerWorkspacePaletteHeaderFactory(Action<Humidifier.Connect.WorkspaceTypes.PaletteHeader> factoryAction = null) : SubResourceFactory<Humidifier.Connect.WorkspaceTypes.PaletteHeader>
{

    protected override Humidifier.Connect.WorkspaceTypes.PaletteHeader Create()
    {
        var paletteHeaderResult = CreatePaletteHeader();
        factoryAction?.Invoke(paletteHeaderResult);

        return paletteHeaderResult;
    }

    private Humidifier.Connect.WorkspaceTypes.PaletteHeader CreatePaletteHeader()
    {
        var paletteHeaderResult = new Humidifier.Connect.WorkspaceTypes.PaletteHeader();

        return paletteHeaderResult;
    }

} // End Of Class

public static class InnerWorkspacePaletteHeaderFactoryExtensions
{
}
