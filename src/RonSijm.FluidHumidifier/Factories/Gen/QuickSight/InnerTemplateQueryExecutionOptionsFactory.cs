// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTemplateQueryExecutionOptionsFactory(Action<Humidifier.QuickSight.TemplateTypes.QueryExecutionOptions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TemplateTypes.QueryExecutionOptions>
{

    protected override Humidifier.QuickSight.TemplateTypes.QueryExecutionOptions Create()
    {
        var queryExecutionOptionsResult = CreateQueryExecutionOptions();
        factoryAction?.Invoke(queryExecutionOptionsResult);

        return queryExecutionOptionsResult;
    }

    private Humidifier.QuickSight.TemplateTypes.QueryExecutionOptions CreateQueryExecutionOptions()
    {
        var queryExecutionOptionsResult = new Humidifier.QuickSight.TemplateTypes.QueryExecutionOptions();

        return queryExecutionOptionsResult;
    }

} // End Of Class

public static class InnerTemplateQueryExecutionOptionsFactoryExtensions
{
}
