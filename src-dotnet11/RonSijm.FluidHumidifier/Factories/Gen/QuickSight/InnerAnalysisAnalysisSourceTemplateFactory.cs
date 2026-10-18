// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAnalysisAnalysisSourceTemplateFactory(Action<Humidifier.QuickSight.AnalysisTypes.AnalysisSourceTemplate> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AnalysisTypes.AnalysisSourceTemplate>
{

    protected override Humidifier.QuickSight.AnalysisTypes.AnalysisSourceTemplate Create()
    {
        var analysisSourceTemplateResult = CreateAnalysisSourceTemplate();
        factoryAction?.Invoke(analysisSourceTemplateResult);

        return analysisSourceTemplateResult;
    }

    private Humidifier.QuickSight.AnalysisTypes.AnalysisSourceTemplate CreateAnalysisSourceTemplate()
    {
        var analysisSourceTemplateResult = new Humidifier.QuickSight.AnalysisTypes.AnalysisSourceTemplate();

        return analysisSourceTemplateResult;
    }

} // End Of Class

public static class InnerAnalysisAnalysisSourceTemplateFactoryExtensions
{
}
