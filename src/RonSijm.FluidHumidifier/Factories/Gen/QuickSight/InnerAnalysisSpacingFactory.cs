// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAnalysisSpacingFactory(Action<Humidifier.QuickSight.AnalysisTypes.Spacing> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AnalysisTypes.Spacing>
{

    protected override Humidifier.QuickSight.AnalysisTypes.Spacing Create()
    {
        var spacingResult = CreateSpacing();
        factoryAction?.Invoke(spacingResult);

        return spacingResult;
    }

    private Humidifier.QuickSight.AnalysisTypes.Spacing CreateSpacing()
    {
        var spacingResult = new Humidifier.QuickSight.AnalysisTypes.Spacing();

        return spacingResult;
    }

} // End Of Class

public static class InnerAnalysisSpacingFactoryExtensions
{
}
