// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerQueryDefinitionQueryParameterFactory(Action<Humidifier.Logs.QueryDefinitionTypes.QueryParameter> factoryAction = null) : SubResourceFactory<Humidifier.Logs.QueryDefinitionTypes.QueryParameter>
{

    protected override Humidifier.Logs.QueryDefinitionTypes.QueryParameter Create()
    {
        var queryParameterResult = CreateQueryParameter();
        factoryAction?.Invoke(queryParameterResult);

        return queryParameterResult;
    }

    private Humidifier.Logs.QueryDefinitionTypes.QueryParameter CreateQueryParameter()
    {
        var queryParameterResult = new Humidifier.Logs.QueryDefinitionTypes.QueryParameter();

        return queryParameterResult;
    }

} // End Of Class

public static class InnerQueryDefinitionQueryParameterFactoryExtensions
{
}
