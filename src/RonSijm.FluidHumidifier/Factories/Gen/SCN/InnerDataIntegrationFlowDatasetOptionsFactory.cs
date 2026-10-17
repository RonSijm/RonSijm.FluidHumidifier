// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SCN;

public class InnerDataIntegrationFlowDatasetOptionsFactory(Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> factoryAction = null) : SubResourceFactory<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions>
{

    internal InnerDataIntegrationFlowDedupeStrategyFactory DedupeStrategyFactory { get; set; }

    protected override Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions Create()
    {
        var datasetOptionsResult = CreateDatasetOptions();
        factoryAction?.Invoke(datasetOptionsResult);

        return datasetOptionsResult;
    }

    private Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions CreateDatasetOptions()
    {
        var datasetOptionsResult = new Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions();

        return datasetOptionsResult;
    }
    public override void CreateChildren(Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions result)
    {
        base.CreateChildren(result);

        result.DedupeStrategy ??= DedupeStrategyFactory?.Build();
    }

} // End Of Class

public static class InnerDataIntegrationFlowDatasetOptionsFactoryExtensions
{
    public static CombinedResult<InnerDataIntegrationFlowDatasetOptionsFactory, InnerDataIntegrationFlowDedupeStrategyFactory> WithDedupeStrategy(this InnerDataIntegrationFlowDatasetOptionsFactory parentFactory, Action<Humidifier.SCN.DataIntegrationFlowTypes.DedupeStrategy> subFactoryAction = null)
    {
        parentFactory.DedupeStrategyFactory = new InnerDataIntegrationFlowDedupeStrategyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DedupeStrategyFactory);
    }

    public static CombinedResult<InnerDataIntegrationFlowDatasetOptionsFactory, T1, InnerDataIntegrationFlowDedupeStrategyFactory> WithDedupeStrategy<T1>(this CombinedResult<InnerDataIntegrationFlowDatasetOptionsFactory, T1> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DedupeStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, WithDedupeStrategy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowDatasetOptionsFactory, InnerDataIntegrationFlowDedupeStrategyFactory> WithDedupeStrategy<T1>(this CombinedResult<T1, InnerDataIntegrationFlowDatasetOptionsFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DedupeStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, WithDedupeStrategy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataIntegrationFlowDatasetOptionsFactory, T1, T2, InnerDataIntegrationFlowDedupeStrategyFactory> WithDedupeStrategy<T1, T2>(this CombinedResult<InnerDataIntegrationFlowDatasetOptionsFactory, T1, T2> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DedupeStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDedupeStrategy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowDatasetOptionsFactory, T2, InnerDataIntegrationFlowDedupeStrategyFactory> WithDedupeStrategy<T1, T2>(this CombinedResult<T1, InnerDataIntegrationFlowDatasetOptionsFactory, T2> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DedupeStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDedupeStrategy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataIntegrationFlowDatasetOptionsFactory, InnerDataIntegrationFlowDedupeStrategyFactory> WithDedupeStrategy<T1, T2>(this CombinedResult<T1, T2, InnerDataIntegrationFlowDatasetOptionsFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DedupeStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDedupeStrategy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataIntegrationFlowDatasetOptionsFactory, T1, T2, T3, InnerDataIntegrationFlowDedupeStrategyFactory> WithDedupeStrategy<T1, T2, T3>(this CombinedResult<InnerDataIntegrationFlowDatasetOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DedupeStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDedupeStrategy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowDatasetOptionsFactory, T2, T3, InnerDataIntegrationFlowDedupeStrategyFactory> WithDedupeStrategy<T1, T2, T3>(this CombinedResult<T1, InnerDataIntegrationFlowDatasetOptionsFactory, T2, T3> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DedupeStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDedupeStrategy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataIntegrationFlowDatasetOptionsFactory, T3, InnerDataIntegrationFlowDedupeStrategyFactory> WithDedupeStrategy<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataIntegrationFlowDatasetOptionsFactory, T3> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DedupeStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDedupeStrategy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataIntegrationFlowDatasetOptionsFactory, InnerDataIntegrationFlowDedupeStrategyFactory> WithDedupeStrategy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataIntegrationFlowDatasetOptionsFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DedupeStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDedupeStrategy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataIntegrationFlowDatasetOptionsFactory, T1, T2, T3, T4, InnerDataIntegrationFlowDedupeStrategyFactory> WithDedupeStrategy<T1, T2, T3, T4>(this CombinedResult<InnerDataIntegrationFlowDatasetOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DedupeStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDedupeStrategy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowDatasetOptionsFactory, T2, T3, T4, InnerDataIntegrationFlowDedupeStrategyFactory> WithDedupeStrategy<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataIntegrationFlowDatasetOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DedupeStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDedupeStrategy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataIntegrationFlowDatasetOptionsFactory, T3, T4, InnerDataIntegrationFlowDedupeStrategyFactory> WithDedupeStrategy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataIntegrationFlowDatasetOptionsFactory, T3, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DedupeStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDedupeStrategy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataIntegrationFlowDatasetOptionsFactory, T4, InnerDataIntegrationFlowDedupeStrategyFactory> WithDedupeStrategy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataIntegrationFlowDatasetOptionsFactory, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DedupeStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDedupeStrategy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataIntegrationFlowDatasetOptionsFactory, InnerDataIntegrationFlowDedupeStrategyFactory> WithDedupeStrategy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataIntegrationFlowDatasetOptionsFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DedupeStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDedupeStrategy(combinedResult.T5, subFactoryAction).T2);
}
