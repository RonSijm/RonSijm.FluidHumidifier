// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerWorkspaceFontFamilyFactory(Action<Humidifier.Connect.WorkspaceTypes.FontFamily> factoryAction = null) : SubResourceFactory<Humidifier.Connect.WorkspaceTypes.FontFamily>
{

    protected override Humidifier.Connect.WorkspaceTypes.FontFamily Create()
    {
        var fontFamilyResult = CreateFontFamily();
        factoryAction?.Invoke(fontFamilyResult);

        return fontFamilyResult;
    }

    private Humidifier.Connect.WorkspaceTypes.FontFamily CreateFontFamily()
    {
        var fontFamilyResult = new Humidifier.Connect.WorkspaceTypes.FontFamily();

        return fontFamilyResult;
    }

} // End Of Class

public static class InnerWorkspaceFontFamilyFactoryExtensions
{
}
