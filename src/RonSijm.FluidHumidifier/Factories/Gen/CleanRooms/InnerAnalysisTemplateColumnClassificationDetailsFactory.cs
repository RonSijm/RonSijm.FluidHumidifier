// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerAnalysisTemplateColumnClassificationDetailsFactory(Action<Humidifier.CleanRooms.AnalysisTemplateTypes.ColumnClassificationDetails> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.AnalysisTemplateTypes.ColumnClassificationDetails>
{

    protected override Humidifier.CleanRooms.AnalysisTemplateTypes.ColumnClassificationDetails Create()
    {
        var columnClassificationDetailsResult = CreateColumnClassificationDetails();
        factoryAction?.Invoke(columnClassificationDetailsResult);

        return columnClassificationDetailsResult;
    }

    private Humidifier.CleanRooms.AnalysisTemplateTypes.ColumnClassificationDetails CreateColumnClassificationDetails()
    {
        var columnClassificationDetailsResult = new Humidifier.CleanRooms.AnalysisTemplateTypes.ColumnClassificationDetails();

        return columnClassificationDetailsResult;
    }

} // End Of Class

public static class InnerAnalysisTemplateColumnClassificationDetailsFactoryExtensions
{
}
