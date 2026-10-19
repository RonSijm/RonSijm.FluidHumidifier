// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerBrandPaletteFactory(Action<Humidifier.QuickSight.BrandTypes.Palette> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.BrandTypes.Palette>
{

    protected override Humidifier.QuickSight.BrandTypes.Palette Create()
    {
        var paletteResult = CreatePalette();
        factoryAction?.Invoke(paletteResult);

        return paletteResult;
    }

    private Humidifier.QuickSight.BrandTypes.Palette CreatePalette()
    {
        var paletteResult = new Humidifier.QuickSight.BrandTypes.Palette();

        return paletteResult;
    }

} // End Of Class

public static class InnerBrandPaletteFactoryExtensions
{
}
