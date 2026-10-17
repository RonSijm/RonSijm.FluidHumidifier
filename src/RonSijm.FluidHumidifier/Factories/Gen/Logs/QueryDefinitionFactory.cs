// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class QueryDefinitionFactory(string resourceName = null, Action<Humidifier.Logs.QueryDefinition> factoryAction = null) : ResourceFactory<Humidifier.Logs.QueryDefinition>(resourceName)
{

    internal List<InnerQueryDefinitionQueryParameterFactory> ParametersFactories { get; set; } = [];

    protected override Humidifier.Logs.QueryDefinition Create()
    {
        var queryDefinitionResult = CreateQueryDefinition();
        factoryAction?.Invoke(queryDefinitionResult);

        return queryDefinitionResult;
    }

    private Humidifier.Logs.QueryDefinition CreateQueryDefinition()
    {
        var queryDefinitionResult = new Humidifier.Logs.QueryDefinition
        {
            GivenName = InputResourceName,
        };

        return queryDefinitionResult;
    }
    public override void CreateChildren(Humidifier.Logs.QueryDefinition result)
    {
        base.CreateChildren(result);

        result.Parameters = ParametersFactories.Any() ? ParametersFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class QueryDefinitionFactoryExtensions
{
    public static CombinedResult<QueryDefinitionFactory, InnerQueryDefinitionQueryParameterFactory> WithParameters(this QueryDefinitionFactory parentFactory, Action<Humidifier.Logs.QueryDefinitionTypes.QueryParameter> subFactoryAction = null)
    {
        var factory = new InnerQueryDefinitionQueryParameterFactory(subFactoryAction);
        parentFactory.ParametersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<QueryDefinitionFactory, T1, InnerQueryDefinitionQueryParameterFactory> WithParameters<T1>(this CombinedResult<QueryDefinitionFactory, T1> combinedResult, Action<Humidifier.Logs.QueryDefinitionTypes.QueryParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, QueryDefinitionFactory, InnerQueryDefinitionQueryParameterFactory> WithParameters<T1>(this CombinedResult<T1, QueryDefinitionFactory> combinedResult, Action<Humidifier.Logs.QueryDefinitionTypes.QueryParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<QueryDefinitionFactory, T1, T2, InnerQueryDefinitionQueryParameterFactory> WithParameters<T1, T2>(this CombinedResult<QueryDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.Logs.QueryDefinitionTypes.QueryParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, QueryDefinitionFactory, T2, InnerQueryDefinitionQueryParameterFactory> WithParameters<T1, T2>(this CombinedResult<T1, QueryDefinitionFactory, T2> combinedResult, Action<Humidifier.Logs.QueryDefinitionTypes.QueryParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, QueryDefinitionFactory, InnerQueryDefinitionQueryParameterFactory> WithParameters<T1, T2>(this CombinedResult<T1, T2, QueryDefinitionFactory> combinedResult, Action<Humidifier.Logs.QueryDefinitionTypes.QueryParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<QueryDefinitionFactory, T1, T2, T3, InnerQueryDefinitionQueryParameterFactory> WithParameters<T1, T2, T3>(this CombinedResult<QueryDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Logs.QueryDefinitionTypes.QueryParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, QueryDefinitionFactory, T2, T3, InnerQueryDefinitionQueryParameterFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, QueryDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.Logs.QueryDefinitionTypes.QueryParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, QueryDefinitionFactory, T3, InnerQueryDefinitionQueryParameterFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, T2, QueryDefinitionFactory, T3> combinedResult, Action<Humidifier.Logs.QueryDefinitionTypes.QueryParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, QueryDefinitionFactory, InnerQueryDefinitionQueryParameterFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, QueryDefinitionFactory> combinedResult, Action<Humidifier.Logs.QueryDefinitionTypes.QueryParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<QueryDefinitionFactory, T1, T2, T3, T4, InnerQueryDefinitionQueryParameterFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<QueryDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Logs.QueryDefinitionTypes.QueryParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, QueryDefinitionFactory, T2, T3, T4, InnerQueryDefinitionQueryParameterFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, QueryDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Logs.QueryDefinitionTypes.QueryParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, QueryDefinitionFactory, T3, T4, InnerQueryDefinitionQueryParameterFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, QueryDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.Logs.QueryDefinitionTypes.QueryParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, QueryDefinitionFactory, T4, InnerQueryDefinitionQueryParameterFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, QueryDefinitionFactory, T4> combinedResult, Action<Humidifier.Logs.QueryDefinitionTypes.QueryParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, QueryDefinitionFactory, InnerQueryDefinitionQueryParameterFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, QueryDefinitionFactory> combinedResult, Action<Humidifier.Logs.QueryDefinitionTypes.QueryParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T5, subFactoryAction).T2);
}
