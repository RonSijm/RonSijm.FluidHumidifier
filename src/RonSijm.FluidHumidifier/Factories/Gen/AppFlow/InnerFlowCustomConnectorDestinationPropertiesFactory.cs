// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowCustomConnectorDestinationPropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.CustomConnectorDestinationProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.CustomConnectorDestinationProperties>
{

    internal InnerFlowErrorHandlingConfigFactory ErrorHandlingConfigFactory { get; set; }

    protected override Humidifier.AppFlow.FlowTypes.CustomConnectorDestinationProperties Create()
    {
        var customConnectorDestinationPropertiesResult = CreateCustomConnectorDestinationProperties();
        factoryAction?.Invoke(customConnectorDestinationPropertiesResult);

        return customConnectorDestinationPropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.CustomConnectorDestinationProperties CreateCustomConnectorDestinationProperties()
    {
        var customConnectorDestinationPropertiesResult = new Humidifier.AppFlow.FlowTypes.CustomConnectorDestinationProperties();

        return customConnectorDestinationPropertiesResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.FlowTypes.CustomConnectorDestinationProperties result)
    {
        base.CreateChildren(result);

        result.ErrorHandlingConfig ??= ErrorHandlingConfigFactory?.Build();
    }

} // End Of Class

public static class InnerFlowCustomConnectorDestinationPropertiesFactoryExtensions
{
    public static CombinedResult<InnerFlowCustomConnectorDestinationPropertiesFactory, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig(this InnerFlowCustomConnectorDestinationPropertiesFactory parentFactory, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null)
    {
        parentFactory.ErrorHandlingConfigFactory = new InnerFlowErrorHandlingConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ErrorHandlingConfigFactory);
    }

    public static CombinedResult<InnerFlowCustomConnectorDestinationPropertiesFactory, T1, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1>(this CombinedResult<InnerFlowCustomConnectorDestinationPropertiesFactory, T1> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowCustomConnectorDestinationPropertiesFactory, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1>(this CombinedResult<T1, InnerFlowCustomConnectorDestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowCustomConnectorDestinationPropertiesFactory, T1, T2, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2>(this CombinedResult<InnerFlowCustomConnectorDestinationPropertiesFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowCustomConnectorDestinationPropertiesFactory, T2, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2>(this CombinedResult<T1, InnerFlowCustomConnectorDestinationPropertiesFactory, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowCustomConnectorDestinationPropertiesFactory, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2>(this CombinedResult<T1, T2, InnerFlowCustomConnectorDestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowCustomConnectorDestinationPropertiesFactory, T1, T2, T3, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3>(this CombinedResult<InnerFlowCustomConnectorDestinationPropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowCustomConnectorDestinationPropertiesFactory, T2, T3, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3>(this CombinedResult<T1, InnerFlowCustomConnectorDestinationPropertiesFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowCustomConnectorDestinationPropertiesFactory, T3, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowCustomConnectorDestinationPropertiesFactory, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowCustomConnectorDestinationPropertiesFactory, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowCustomConnectorDestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowCustomConnectorDestinationPropertiesFactory, T1, T2, T3, T4, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3, T4>(this CombinedResult<InnerFlowCustomConnectorDestinationPropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowCustomConnectorDestinationPropertiesFactory, T2, T3, T4, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowCustomConnectorDestinationPropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowCustomConnectorDestinationPropertiesFactory, T3, T4, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowCustomConnectorDestinationPropertiesFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowCustomConnectorDestinationPropertiesFactory, T4, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowCustomConnectorDestinationPropertiesFactory, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowCustomConnectorDestinationPropertiesFactory, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowCustomConnectorDestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T5, subFactoryAction));
}
