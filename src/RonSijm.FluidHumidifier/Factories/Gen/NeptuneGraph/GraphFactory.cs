// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NeptuneGraph;

public class GraphFactory(string resourceName = null, Action<Humidifier.NeptuneGraph.Graph> factoryAction = null) : ResourceFactory<Humidifier.NeptuneGraph.Graph>(resourceName)
{

    internal InnerGraphVectorSearchConfigurationFactory VectorSearchConfigurationFactory { get; set; }

    protected override Humidifier.NeptuneGraph.Graph Create()
    {
        var graphResult = CreateGraph();
        factoryAction?.Invoke(graphResult);

        return graphResult;
    }

    private Humidifier.NeptuneGraph.Graph CreateGraph()
    {
        var graphResult = new Humidifier.NeptuneGraph.Graph
        {
            GivenName = InputResourceName,
        };

        return graphResult;
    }
    public override void CreateChildren(Humidifier.NeptuneGraph.Graph result)
    {
        base.CreateChildren(result);

        result.VectorSearchConfiguration ??= VectorSearchConfigurationFactory?.Build();
    }

} // End Of Class

public static class GraphFactoryExtensions
{
    public static CombinedResult<GraphFactory, InnerGraphVectorSearchConfigurationFactory> WithVectorSearchConfiguration(this GraphFactory parentFactory, Action<Humidifier.NeptuneGraph.GraphTypes.VectorSearchConfiguration> subFactoryAction = null)
    {
        parentFactory.VectorSearchConfigurationFactory = new InnerGraphVectorSearchConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VectorSearchConfigurationFactory);
    }

    public static CombinedResult<GraphFactory, T1, InnerGraphVectorSearchConfigurationFactory> WithVectorSearchConfiguration<T1>(this CombinedResult<GraphFactory, T1> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.VectorSearchConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVectorSearchConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GraphFactory, InnerGraphVectorSearchConfigurationFactory> WithVectorSearchConfiguration<T1>(this CombinedResult<T1, GraphFactory> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.VectorSearchConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVectorSearchConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<GraphFactory, T1, T2, InnerGraphVectorSearchConfigurationFactory> WithVectorSearchConfiguration<T1, T2>(this CombinedResult<GraphFactory, T1, T2> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.VectorSearchConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVectorSearchConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GraphFactory, T2, InnerGraphVectorSearchConfigurationFactory> WithVectorSearchConfiguration<T1, T2>(this CombinedResult<T1, GraphFactory, T2> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.VectorSearchConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVectorSearchConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GraphFactory, InnerGraphVectorSearchConfigurationFactory> WithVectorSearchConfiguration<T1, T2>(this CombinedResult<T1, T2, GraphFactory> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.VectorSearchConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVectorSearchConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<GraphFactory, T1, T2, T3, InnerGraphVectorSearchConfigurationFactory> WithVectorSearchConfiguration<T1, T2, T3>(this CombinedResult<GraphFactory, T1, T2, T3> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.VectorSearchConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVectorSearchConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GraphFactory, T2, T3, InnerGraphVectorSearchConfigurationFactory> WithVectorSearchConfiguration<T1, T2, T3>(this CombinedResult<T1, GraphFactory, T2, T3> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.VectorSearchConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVectorSearchConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GraphFactory, T3, InnerGraphVectorSearchConfigurationFactory> WithVectorSearchConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, GraphFactory, T3> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.VectorSearchConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVectorSearchConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GraphFactory, InnerGraphVectorSearchConfigurationFactory> WithVectorSearchConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, GraphFactory> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.VectorSearchConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVectorSearchConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<GraphFactory, T1, T2, T3, T4, InnerGraphVectorSearchConfigurationFactory> WithVectorSearchConfiguration<T1, T2, T3, T4>(this CombinedResult<GraphFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.VectorSearchConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVectorSearchConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GraphFactory, T2, T3, T4, InnerGraphVectorSearchConfigurationFactory> WithVectorSearchConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, GraphFactory, T2, T3, T4> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.VectorSearchConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVectorSearchConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GraphFactory, T3, T4, InnerGraphVectorSearchConfigurationFactory> WithVectorSearchConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, GraphFactory, T3, T4> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.VectorSearchConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVectorSearchConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GraphFactory, T4, InnerGraphVectorSearchConfigurationFactory> WithVectorSearchConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GraphFactory, T4> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.VectorSearchConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVectorSearchConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, GraphFactory, InnerGraphVectorSearchConfigurationFactory> WithVectorSearchConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GraphFactory> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.VectorSearchConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVectorSearchConfiguration(combinedResult.T5, subFactoryAction));
}
