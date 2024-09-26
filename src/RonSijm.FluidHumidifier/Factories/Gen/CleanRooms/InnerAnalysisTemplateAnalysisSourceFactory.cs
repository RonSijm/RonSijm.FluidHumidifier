// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerAnalysisTemplateAnalysisSourceFactory(Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource>
{

    protected override Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource Create()
    {
        var analysisSourceResult = CreateAnalysisSource();
        factoryAction?.Invoke(analysisSourceResult);

        return analysisSourceResult;
    }

    private Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource CreateAnalysisSource()
    {
        var analysisSourceResult = new Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource();

        return analysisSourceResult;
    }

} // End Of Class

public static class InnerAnalysisTemplateAnalysisSourceFactoryExtensions
{
}
