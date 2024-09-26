// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTemplateTemplateSourceAnalysisFactory(Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceAnalysis> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TemplateTypes.TemplateSourceAnalysis>
{

    protected override Humidifier.QuickSight.TemplateTypes.TemplateSourceAnalysis Create()
    {
        var templateSourceAnalysisResult = CreateTemplateSourceAnalysis();
        factoryAction?.Invoke(templateSourceAnalysisResult);

        return templateSourceAnalysisResult;
    }

    private Humidifier.QuickSight.TemplateTypes.TemplateSourceAnalysis CreateTemplateSourceAnalysis()
    {
        var templateSourceAnalysisResult = new Humidifier.QuickSight.TemplateTypes.TemplateSourceAnalysis();

        return templateSourceAnalysisResult;
    }

} // End Of Class

public static class InnerTemplateTemplateSourceAnalysisFactoryExtensions
{
}
