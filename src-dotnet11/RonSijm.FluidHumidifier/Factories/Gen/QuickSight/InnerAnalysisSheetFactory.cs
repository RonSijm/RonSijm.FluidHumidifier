// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAnalysisSheetFactory(Action<Humidifier.QuickSight.AnalysisTypes.Sheet> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AnalysisTypes.Sheet>
{

    protected override Humidifier.QuickSight.AnalysisTypes.Sheet Create()
    {
        var sheetResult = CreateSheet();
        factoryAction?.Invoke(sheetResult);

        return sheetResult;
    }

    private Humidifier.QuickSight.AnalysisTypes.Sheet CreateSheet()
    {
        var sheetResult = new Humidifier.QuickSight.AnalysisTypes.Sheet();

        return sheetResult;
    }

} // End Of Class

public static class InnerAnalysisSheetFactoryExtensions
{
}
