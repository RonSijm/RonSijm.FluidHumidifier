// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowEventBridgeDestinationPropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.EventBridgeDestinationProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.EventBridgeDestinationProperties>
{

    internal InnerFlowErrorHandlingConfigFactory ErrorHandlingConfigFactory { get; set; }

    protected override Humidifier.AppFlow.FlowTypes.EventBridgeDestinationProperties Create()
    {
        var eventBridgeDestinationPropertiesResult = CreateEventBridgeDestinationProperties();
        factoryAction?.Invoke(eventBridgeDestinationPropertiesResult);

        return eventBridgeDestinationPropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.EventBridgeDestinationProperties CreateEventBridgeDestinationProperties()
    {
        var eventBridgeDestinationPropertiesResult = new Humidifier.AppFlow.FlowTypes.EventBridgeDestinationProperties();

        return eventBridgeDestinationPropertiesResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.FlowTypes.EventBridgeDestinationProperties result)
    {
        base.CreateChildren(result);

        result.ErrorHandlingConfig ??= ErrorHandlingConfigFactory?.Build();
    }

} // End Of Class

public static class InnerFlowEventBridgeDestinationPropertiesFactoryExtensions
{
    public static CombinedResult<InnerFlowEventBridgeDestinationPropertiesFactory, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig(this InnerFlowEventBridgeDestinationPropertiesFactory parentFactory, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null)
    {
        parentFactory.ErrorHandlingConfigFactory = new InnerFlowErrorHandlingConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ErrorHandlingConfigFactory);
    }

    public static CombinedResult<InnerFlowEventBridgeDestinationPropertiesFactory, T1, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1>(this CombinedResult<InnerFlowEventBridgeDestinationPropertiesFactory, T1> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowEventBridgeDestinationPropertiesFactory, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1>(this CombinedResult<T1, InnerFlowEventBridgeDestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowEventBridgeDestinationPropertiesFactory, T1, T2, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2>(this CombinedResult<InnerFlowEventBridgeDestinationPropertiesFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowEventBridgeDestinationPropertiesFactory, T2, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2>(this CombinedResult<T1, InnerFlowEventBridgeDestinationPropertiesFactory, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowEventBridgeDestinationPropertiesFactory, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2>(this CombinedResult<T1, T2, InnerFlowEventBridgeDestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowEventBridgeDestinationPropertiesFactory, T1, T2, T3, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3>(this CombinedResult<InnerFlowEventBridgeDestinationPropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowEventBridgeDestinationPropertiesFactory, T2, T3, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3>(this CombinedResult<T1, InnerFlowEventBridgeDestinationPropertiesFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowEventBridgeDestinationPropertiesFactory, T3, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowEventBridgeDestinationPropertiesFactory, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowEventBridgeDestinationPropertiesFactory, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowEventBridgeDestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowEventBridgeDestinationPropertiesFactory, T1, T2, T3, T4, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3, T4>(this CombinedResult<InnerFlowEventBridgeDestinationPropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowEventBridgeDestinationPropertiesFactory, T2, T3, T4, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowEventBridgeDestinationPropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowEventBridgeDestinationPropertiesFactory, T3, T4, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowEventBridgeDestinationPropertiesFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowEventBridgeDestinationPropertiesFactory, T4, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowEventBridgeDestinationPropertiesFactory, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowEventBridgeDestinationPropertiesFactory, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowEventBridgeDestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T5, subFactoryAction));
}
