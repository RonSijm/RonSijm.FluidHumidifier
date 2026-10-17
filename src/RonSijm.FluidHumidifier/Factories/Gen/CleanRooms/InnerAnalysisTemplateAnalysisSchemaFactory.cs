// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerAnalysisTemplateAnalysisSchemaFactory(Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSchema> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSchema>
{

    protected override Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSchema Create()
    {
        var analysisSchemaResult = CreateAnalysisSchema();
        factoryAction?.Invoke(analysisSchemaResult);

        return analysisSchemaResult;
    }

    private Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSchema CreateAnalysisSchema()
    {
        var analysisSchemaResult = new Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSchema();

        return analysisSchemaResult;
    }

} // End Of Class

public static class InnerAnalysisTemplateAnalysisSchemaFactoryExtensions
{
}
