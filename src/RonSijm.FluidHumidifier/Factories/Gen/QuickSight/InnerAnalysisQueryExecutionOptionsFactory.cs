// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAnalysisQueryExecutionOptionsFactory(Action<Humidifier.QuickSight.AnalysisTypes.QueryExecutionOptions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AnalysisTypes.QueryExecutionOptions>
{

    protected override Humidifier.QuickSight.AnalysisTypes.QueryExecutionOptions Create()
    {
        var queryExecutionOptionsResult = CreateQueryExecutionOptions();
        factoryAction?.Invoke(queryExecutionOptionsResult);

        return queryExecutionOptionsResult;
    }

    private Humidifier.QuickSight.AnalysisTypes.QueryExecutionOptions CreateQueryExecutionOptions()
    {
        var queryExecutionOptionsResult = new Humidifier.QuickSight.AnalysisTypes.QueryExecutionOptions();

        return queryExecutionOptionsResult;
    }

} // End Of Class

public static class InnerAnalysisQueryExecutionOptionsFactoryExtensions
{
}
