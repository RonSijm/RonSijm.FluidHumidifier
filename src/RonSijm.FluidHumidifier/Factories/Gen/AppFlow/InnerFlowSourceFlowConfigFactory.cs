// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowSourceFlowConfigFactory(Action<Humidifier.AppFlow.FlowTypes.SourceFlowConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.SourceFlowConfig>
{

    internal InnerFlowSourceConnectorPropertiesFactory SourceConnectorPropertiesFactory { get; set; }

    internal InnerFlowIncrementalPullConfigFactory IncrementalPullConfigFactory { get; set; }

    protected override Humidifier.AppFlow.FlowTypes.SourceFlowConfig Create()
    {
        var sourceFlowConfigResult = CreateSourceFlowConfig();
        factoryAction?.Invoke(sourceFlowConfigResult);

        return sourceFlowConfigResult;
    }

    private Humidifier.AppFlow.FlowTypes.SourceFlowConfig CreateSourceFlowConfig()
    {
        var sourceFlowConfigResult = new Humidifier.AppFlow.FlowTypes.SourceFlowConfig();

        return sourceFlowConfigResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.FlowTypes.SourceFlowConfig result)
    {
        base.CreateChildren(result);

        result.SourceConnectorProperties ??= SourceConnectorPropertiesFactory?.Build();
        result.IncrementalPullConfig ??= IncrementalPullConfigFactory?.Build();
    }

} // End Of Class

public static class InnerFlowSourceFlowConfigFactoryExtensions
{
    public static CombinedResult<InnerFlowSourceFlowConfigFactory, InnerFlowSourceConnectorPropertiesFactory> WithSourceConnectorProperties(this InnerFlowSourceFlowConfigFactory parentFactory, Action<Humidifier.AppFlow.FlowTypes.SourceConnectorProperties> subFactoryAction = null)
    {
        parentFactory.SourceConnectorPropertiesFactory = new InnerFlowSourceConnectorPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceConnectorPropertiesFactory);
    }

    public static CombinedResult<InnerFlowSourceFlowConfigFactory, InnerFlowIncrementalPullConfigFactory> WithIncrementalPullConfig(this InnerFlowSourceFlowConfigFactory parentFactory, Action<Humidifier.AppFlow.FlowTypes.IncrementalPullConfig> subFactoryAction = null)
    {
        parentFactory.IncrementalPullConfigFactory = new InnerFlowIncrementalPullConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IncrementalPullConfigFactory);
    }

    public static CombinedResult<InnerFlowSourceFlowConfigFactory, T1, InnerFlowSourceConnectorPropertiesFactory> WithSourceConnectorProperties<T1>(this CombinedResult<InnerFlowSourceFlowConfigFactory, T1> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SourceConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceConnectorProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSourceFlowConfigFactory, InnerFlowSourceConnectorPropertiesFactory> WithSourceConnectorProperties<T1>(this CombinedResult<T1, InnerFlowSourceFlowConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SourceConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceConnectorProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowSourceFlowConfigFactory, T1, T2, InnerFlowSourceConnectorPropertiesFactory> WithSourceConnectorProperties<T1, T2>(this CombinedResult<InnerFlowSourceFlowConfigFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SourceConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceConnectorProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSourceFlowConfigFactory, T2, InnerFlowSourceConnectorPropertiesFactory> WithSourceConnectorProperties<T1, T2>(this CombinedResult<T1, InnerFlowSourceFlowConfigFactory, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SourceConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceConnectorProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowSourceFlowConfigFactory, InnerFlowSourceConnectorPropertiesFactory> WithSourceConnectorProperties<T1, T2>(this CombinedResult<T1, T2, InnerFlowSourceFlowConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SourceConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceConnectorProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowSourceFlowConfigFactory, T1, T2, T3, InnerFlowSourceConnectorPropertiesFactory> WithSourceConnectorProperties<T1, T2, T3>(this CombinedResult<InnerFlowSourceFlowConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SourceConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceConnectorProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSourceFlowConfigFactory, T2, T3, InnerFlowSourceConnectorPropertiesFactory> WithSourceConnectorProperties<T1, T2, T3>(this CombinedResult<T1, InnerFlowSourceFlowConfigFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SourceConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceConnectorProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowSourceFlowConfigFactory, T3, InnerFlowSourceConnectorPropertiesFactory> WithSourceConnectorProperties<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowSourceFlowConfigFactory, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SourceConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceConnectorProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowSourceFlowConfigFactory, InnerFlowSourceConnectorPropertiesFactory> WithSourceConnectorProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowSourceFlowConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SourceConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceConnectorProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowSourceFlowConfigFactory, T1, T2, T3, T4, InnerFlowSourceConnectorPropertiesFactory> WithSourceConnectorProperties<T1, T2, T3, T4>(this CombinedResult<InnerFlowSourceFlowConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SourceConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceConnectorProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSourceFlowConfigFactory, T2, T3, T4, InnerFlowSourceConnectorPropertiesFactory> WithSourceConnectorProperties<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowSourceFlowConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SourceConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceConnectorProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowSourceFlowConfigFactory, T3, T4, InnerFlowSourceConnectorPropertiesFactory> WithSourceConnectorProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowSourceFlowConfigFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SourceConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceConnectorProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowSourceFlowConfigFactory, T4, InnerFlowSourceConnectorPropertiesFactory> WithSourceConnectorProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowSourceFlowConfigFactory, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SourceConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceConnectorProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowSourceFlowConfigFactory, InnerFlowSourceConnectorPropertiesFactory> WithSourceConnectorProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowSourceFlowConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SourceConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceConnectorProperties(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerFlowSourceFlowConfigFactory, T1, InnerFlowIncrementalPullConfigFactory> WithIncrementalPullConfig<T1>(this CombinedResult<InnerFlowSourceFlowConfigFactory, T1> combinedResult, Action<Humidifier.AppFlow.FlowTypes.IncrementalPullConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithIncrementalPullConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSourceFlowConfigFactory, InnerFlowIncrementalPullConfigFactory> WithIncrementalPullConfig<T1>(this CombinedResult<T1, InnerFlowSourceFlowConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.IncrementalPullConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithIncrementalPullConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowSourceFlowConfigFactory, T1, T2, InnerFlowIncrementalPullConfigFactory> WithIncrementalPullConfig<T1, T2>(this CombinedResult<InnerFlowSourceFlowConfigFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.IncrementalPullConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIncrementalPullConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSourceFlowConfigFactory, T2, InnerFlowIncrementalPullConfigFactory> WithIncrementalPullConfig<T1, T2>(this CombinedResult<T1, InnerFlowSourceFlowConfigFactory, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.IncrementalPullConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIncrementalPullConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowSourceFlowConfigFactory, InnerFlowIncrementalPullConfigFactory> WithIncrementalPullConfig<T1, T2>(this CombinedResult<T1, T2, InnerFlowSourceFlowConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.IncrementalPullConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIncrementalPullConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowSourceFlowConfigFactory, T1, T2, T3, InnerFlowIncrementalPullConfigFactory> WithIncrementalPullConfig<T1, T2, T3>(this CombinedResult<InnerFlowSourceFlowConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.IncrementalPullConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncrementalPullConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSourceFlowConfigFactory, T2, T3, InnerFlowIncrementalPullConfigFactory> WithIncrementalPullConfig<T1, T2, T3>(this CombinedResult<T1, InnerFlowSourceFlowConfigFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.IncrementalPullConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncrementalPullConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowSourceFlowConfigFactory, T3, InnerFlowIncrementalPullConfigFactory> WithIncrementalPullConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowSourceFlowConfigFactory, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.IncrementalPullConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncrementalPullConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowSourceFlowConfigFactory, InnerFlowIncrementalPullConfigFactory> WithIncrementalPullConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowSourceFlowConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.IncrementalPullConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncrementalPullConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowSourceFlowConfigFactory, T1, T2, T3, T4, InnerFlowIncrementalPullConfigFactory> WithIncrementalPullConfig<T1, T2, T3, T4>(this CombinedResult<InnerFlowSourceFlowConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.IncrementalPullConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncrementalPullConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSourceFlowConfigFactory, T2, T3, T4, InnerFlowIncrementalPullConfigFactory> WithIncrementalPullConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowSourceFlowConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.IncrementalPullConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncrementalPullConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowSourceFlowConfigFactory, T3, T4, InnerFlowIncrementalPullConfigFactory> WithIncrementalPullConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowSourceFlowConfigFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.IncrementalPullConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncrementalPullConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowSourceFlowConfigFactory, T4, InnerFlowIncrementalPullConfigFactory> WithIncrementalPullConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowSourceFlowConfigFactory, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.IncrementalPullConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncrementalPullConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowSourceFlowConfigFactory, InnerFlowIncrementalPullConfigFactory> WithIncrementalPullConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowSourceFlowConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.IncrementalPullConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncrementalPullConfig(combinedResult.T5, subFactoryAction));
}
