// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowZendeskDestinationPropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.ZendeskDestinationProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.ZendeskDestinationProperties>
{

    internal InnerFlowErrorHandlingConfigFactory ErrorHandlingConfigFactory { get; set; }

    protected override Humidifier.AppFlow.FlowTypes.ZendeskDestinationProperties Create()
    {
        var zendeskDestinationPropertiesResult = CreateZendeskDestinationProperties();
        factoryAction?.Invoke(zendeskDestinationPropertiesResult);

        return zendeskDestinationPropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.ZendeskDestinationProperties CreateZendeskDestinationProperties()
    {
        var zendeskDestinationPropertiesResult = new Humidifier.AppFlow.FlowTypes.ZendeskDestinationProperties();

        return zendeskDestinationPropertiesResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.FlowTypes.ZendeskDestinationProperties result)
    {
        base.CreateChildren(result);

        result.ErrorHandlingConfig ??= ErrorHandlingConfigFactory?.Build();
    }

} // End Of Class

public static class InnerFlowZendeskDestinationPropertiesFactoryExtensions
{
    public static CombinedResult<InnerFlowZendeskDestinationPropertiesFactory, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig(this InnerFlowZendeskDestinationPropertiesFactory parentFactory, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null)
    {
        parentFactory.ErrorHandlingConfigFactory = new InnerFlowErrorHandlingConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ErrorHandlingConfigFactory);
    }

    public static CombinedResult<InnerFlowZendeskDestinationPropertiesFactory, T1, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1>(this CombinedResult<InnerFlowZendeskDestinationPropertiesFactory, T1> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowZendeskDestinationPropertiesFactory, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1>(this CombinedResult<T1, InnerFlowZendeskDestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowZendeskDestinationPropertiesFactory, T1, T2, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2>(this CombinedResult<InnerFlowZendeskDestinationPropertiesFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowZendeskDestinationPropertiesFactory, T2, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2>(this CombinedResult<T1, InnerFlowZendeskDestinationPropertiesFactory, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowZendeskDestinationPropertiesFactory, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2>(this CombinedResult<T1, T2, InnerFlowZendeskDestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowZendeskDestinationPropertiesFactory, T1, T2, T3, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3>(this CombinedResult<InnerFlowZendeskDestinationPropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowZendeskDestinationPropertiesFactory, T2, T3, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3>(this CombinedResult<T1, InnerFlowZendeskDestinationPropertiesFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowZendeskDestinationPropertiesFactory, T3, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowZendeskDestinationPropertiesFactory, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowZendeskDestinationPropertiesFactory, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowZendeskDestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowZendeskDestinationPropertiesFactory, T1, T2, T3, T4, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3, T4>(this CombinedResult<InnerFlowZendeskDestinationPropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowZendeskDestinationPropertiesFactory, T2, T3, T4, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowZendeskDestinationPropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowZendeskDestinationPropertiesFactory, T3, T4, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowZendeskDestinationPropertiesFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowZendeskDestinationPropertiesFactory, T4, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowZendeskDestinationPropertiesFactory, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowZendeskDestinationPropertiesFactory, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowZendeskDestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T5, subFactoryAction));
}
