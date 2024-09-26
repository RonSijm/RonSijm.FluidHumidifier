// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowMarketoDestinationPropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.MarketoDestinationProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.MarketoDestinationProperties>
{

    internal InnerFlowErrorHandlingConfigFactory ErrorHandlingConfigFactory { get; set; }

    protected override Humidifier.AppFlow.FlowTypes.MarketoDestinationProperties Create()
    {
        var marketoDestinationPropertiesResult = CreateMarketoDestinationProperties();
        factoryAction?.Invoke(marketoDestinationPropertiesResult);

        return marketoDestinationPropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.MarketoDestinationProperties CreateMarketoDestinationProperties()
    {
        var marketoDestinationPropertiesResult = new Humidifier.AppFlow.FlowTypes.MarketoDestinationProperties();

        return marketoDestinationPropertiesResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.FlowTypes.MarketoDestinationProperties result)
    {
        base.CreateChildren(result);

        result.ErrorHandlingConfig ??= ErrorHandlingConfigFactory?.Build();
    }

} // End Of Class

public static class InnerFlowMarketoDestinationPropertiesFactoryExtensions
{
    public static CombinedResult<InnerFlowMarketoDestinationPropertiesFactory, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig(this InnerFlowMarketoDestinationPropertiesFactory parentFactory, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null)
    {
        parentFactory.ErrorHandlingConfigFactory = new InnerFlowErrorHandlingConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ErrorHandlingConfigFactory);
    }

    public static CombinedResult<InnerFlowMarketoDestinationPropertiesFactory, T1, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1>(this CombinedResult<InnerFlowMarketoDestinationPropertiesFactory, T1> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowMarketoDestinationPropertiesFactory, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1>(this CombinedResult<T1, InnerFlowMarketoDestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowMarketoDestinationPropertiesFactory, T1, T2, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2>(this CombinedResult<InnerFlowMarketoDestinationPropertiesFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowMarketoDestinationPropertiesFactory, T2, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2>(this CombinedResult<T1, InnerFlowMarketoDestinationPropertiesFactory, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowMarketoDestinationPropertiesFactory, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2>(this CombinedResult<T1, T2, InnerFlowMarketoDestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowMarketoDestinationPropertiesFactory, T1, T2, T3, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3>(this CombinedResult<InnerFlowMarketoDestinationPropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowMarketoDestinationPropertiesFactory, T2, T3, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3>(this CombinedResult<T1, InnerFlowMarketoDestinationPropertiesFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowMarketoDestinationPropertiesFactory, T3, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowMarketoDestinationPropertiesFactory, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowMarketoDestinationPropertiesFactory, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowMarketoDestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowMarketoDestinationPropertiesFactory, T1, T2, T3, T4, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3, T4>(this CombinedResult<InnerFlowMarketoDestinationPropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowMarketoDestinationPropertiesFactory, T2, T3, T4, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowMarketoDestinationPropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowMarketoDestinationPropertiesFactory, T3, T4, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowMarketoDestinationPropertiesFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowMarketoDestinationPropertiesFactory, T4, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowMarketoDestinationPropertiesFactory, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowMarketoDestinationPropertiesFactory, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowMarketoDestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T5, subFactoryAction));
}
