// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerWorkspacePaletteCanvasFactory(Action<Humidifier.Connect.WorkspaceTypes.PaletteCanvas> factoryAction = null) : SubResourceFactory<Humidifier.Connect.WorkspaceTypes.PaletteCanvas>
{

    protected override Humidifier.Connect.WorkspaceTypes.PaletteCanvas Create()
    {
        var paletteCanvasResult = CreatePaletteCanvas();
        factoryAction?.Invoke(paletteCanvasResult);

        return paletteCanvasResult;
    }

    private Humidifier.Connect.WorkspaceTypes.PaletteCanvas CreatePaletteCanvas()
    {
        var paletteCanvasResult = new Humidifier.Connect.WorkspaceTypes.PaletteCanvas();

        return paletteCanvasResult;
    }

} // End Of Class

public static class InnerWorkspacePaletteCanvasFactoryExtensions
{
}
