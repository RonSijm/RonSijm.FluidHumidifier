// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerAnalysisTemplateAnalysisParameterFactory(Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisParameter> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisParameter>
{

    protected override Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisParameter Create()
    {
        var analysisParameterResult = CreateAnalysisParameter();
        factoryAction?.Invoke(analysisParameterResult);

        return analysisParameterResult;
    }

    private Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisParameter CreateAnalysisParameter()
    {
        var analysisParameterResult = new Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisParameter();

        return analysisParameterResult;
    }

} // End Of Class

public static class InnerAnalysisTemplateAnalysisParameterFactoryExtensions
{
}
