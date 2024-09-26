// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTemplateSpacingFactory(Action<Humidifier.QuickSight.TemplateTypes.Spacing> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TemplateTypes.Spacing>
{

    protected override Humidifier.QuickSight.TemplateTypes.Spacing Create()
    {
        var spacingResult = CreateSpacing();
        factoryAction?.Invoke(spacingResult);

        return spacingResult;
    }

    private Humidifier.QuickSight.TemplateTypes.Spacing CreateSpacing()
    {
        var spacingResult = new Humidifier.QuickSight.TemplateTypes.Spacing();

        return spacingResult;
    }

} // End Of Class

public static class InnerTemplateSpacingFactoryExtensions
{
}
