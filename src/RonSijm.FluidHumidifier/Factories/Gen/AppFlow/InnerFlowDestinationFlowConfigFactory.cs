// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowDestinationFlowConfigFactory(Action<Humidifier.AppFlow.FlowTypes.DestinationFlowConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.DestinationFlowConfig>
{

    internal InnerFlowDestinationConnectorPropertiesFactory DestinationConnectorPropertiesFactory { get; set; }

    protected override Humidifier.AppFlow.FlowTypes.DestinationFlowConfig Create()
    {
        var destinationFlowConfigResult = CreateDestinationFlowConfig();
        factoryAction?.Invoke(destinationFlowConfigResult);

        return destinationFlowConfigResult;
    }

    private Humidifier.AppFlow.FlowTypes.DestinationFlowConfig CreateDestinationFlowConfig()
    {
        var destinationFlowConfigResult = new Humidifier.AppFlow.FlowTypes.DestinationFlowConfig();

        return destinationFlowConfigResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.FlowTypes.DestinationFlowConfig result)
    {
        base.CreateChildren(result);

        result.DestinationConnectorProperties ??= DestinationConnectorPropertiesFactory?.Build();
    }

} // End Of Class

public static class InnerFlowDestinationFlowConfigFactoryExtensions
{
    public static CombinedResult<InnerFlowDestinationFlowConfigFactory, InnerFlowDestinationConnectorPropertiesFactory> WithDestinationConnectorProperties(this InnerFlowDestinationFlowConfigFactory parentFactory, Action<Humidifier.AppFlow.FlowTypes.DestinationConnectorProperties> subFactoryAction = null)
    {
        parentFactory.DestinationConnectorPropertiesFactory = new InnerFlowDestinationConnectorPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationConnectorPropertiesFactory);
    }

    public static CombinedResult<InnerFlowDestinationFlowConfigFactory, T1, InnerFlowDestinationConnectorPropertiesFactory> WithDestinationConnectorProperties<T1>(this CombinedResult<InnerFlowDestinationFlowConfigFactory, T1> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DestinationConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationConnectorProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowDestinationFlowConfigFactory, InnerFlowDestinationConnectorPropertiesFactory> WithDestinationConnectorProperties<T1>(this CombinedResult<T1, InnerFlowDestinationFlowConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DestinationConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationConnectorProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowDestinationFlowConfigFactory, T1, T2, InnerFlowDestinationConnectorPropertiesFactory> WithDestinationConnectorProperties<T1, T2>(this CombinedResult<InnerFlowDestinationFlowConfigFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DestinationConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationConnectorProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowDestinationFlowConfigFactory, T2, InnerFlowDestinationConnectorPropertiesFactory> WithDestinationConnectorProperties<T1, T2>(this CombinedResult<T1, InnerFlowDestinationFlowConfigFactory, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DestinationConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationConnectorProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowDestinationFlowConfigFactory, InnerFlowDestinationConnectorPropertiesFactory> WithDestinationConnectorProperties<T1, T2>(this CombinedResult<T1, T2, InnerFlowDestinationFlowConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DestinationConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationConnectorProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowDestinationFlowConfigFactory, T1, T2, T3, InnerFlowDestinationConnectorPropertiesFactory> WithDestinationConnectorProperties<T1, T2, T3>(this CombinedResult<InnerFlowDestinationFlowConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DestinationConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConnectorProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowDestinationFlowConfigFactory, T2, T3, InnerFlowDestinationConnectorPropertiesFactory> WithDestinationConnectorProperties<T1, T2, T3>(this CombinedResult<T1, InnerFlowDestinationFlowConfigFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DestinationConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConnectorProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowDestinationFlowConfigFactory, T3, InnerFlowDestinationConnectorPropertiesFactory> WithDestinationConnectorProperties<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowDestinationFlowConfigFactory, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DestinationConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConnectorProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowDestinationFlowConfigFactory, InnerFlowDestinationConnectorPropertiesFactory> WithDestinationConnectorProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowDestinationFlowConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DestinationConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConnectorProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowDestinationFlowConfigFactory, T1, T2, T3, T4, InnerFlowDestinationConnectorPropertiesFactory> WithDestinationConnectorProperties<T1, T2, T3, T4>(this CombinedResult<InnerFlowDestinationFlowConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DestinationConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConnectorProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowDestinationFlowConfigFactory, T2, T3, T4, InnerFlowDestinationConnectorPropertiesFactory> WithDestinationConnectorProperties<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowDestinationFlowConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DestinationConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConnectorProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowDestinationFlowConfigFactory, T3, T4, InnerFlowDestinationConnectorPropertiesFactory> WithDestinationConnectorProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowDestinationFlowConfigFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DestinationConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConnectorProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowDestinationFlowConfigFactory, T4, InnerFlowDestinationConnectorPropertiesFactory> WithDestinationConnectorProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowDestinationFlowConfigFactory, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DestinationConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConnectorProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowDestinationFlowConfigFactory, InnerFlowDestinationConnectorPropertiesFactory> WithDestinationConnectorProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowDestinationFlowConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DestinationConnectorProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConnectorProperties(combinedResult.T5, subFactoryAction));
}
