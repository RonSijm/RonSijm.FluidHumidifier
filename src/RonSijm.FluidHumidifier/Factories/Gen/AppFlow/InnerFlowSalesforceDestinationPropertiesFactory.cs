// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowSalesforceDestinationPropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.SalesforceDestinationProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.SalesforceDestinationProperties>
{

    internal InnerFlowErrorHandlingConfigFactory ErrorHandlingConfigFactory { get; set; }

    protected override Humidifier.AppFlow.FlowTypes.SalesforceDestinationProperties Create()
    {
        var salesforceDestinationPropertiesResult = CreateSalesforceDestinationProperties();
        factoryAction?.Invoke(salesforceDestinationPropertiesResult);

        return salesforceDestinationPropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.SalesforceDestinationProperties CreateSalesforceDestinationProperties()
    {
        var salesforceDestinationPropertiesResult = new Humidifier.AppFlow.FlowTypes.SalesforceDestinationProperties();

        return salesforceDestinationPropertiesResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.FlowTypes.SalesforceDestinationProperties result)
    {
        base.CreateChildren(result);

        result.ErrorHandlingConfig ??= ErrorHandlingConfigFactory?.Build();
    }

} // End Of Class

public static class InnerFlowSalesforceDestinationPropertiesFactoryExtensions
{
    public static CombinedResult<InnerFlowSalesforceDestinationPropertiesFactory, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig(this InnerFlowSalesforceDestinationPropertiesFactory parentFactory, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null)
    {
        parentFactory.ErrorHandlingConfigFactory = new InnerFlowErrorHandlingConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ErrorHandlingConfigFactory);
    }

    public static CombinedResult<InnerFlowSalesforceDestinationPropertiesFactory, T1, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1>(this CombinedResult<InnerFlowSalesforceDestinationPropertiesFactory, T1> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSalesforceDestinationPropertiesFactory, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1>(this CombinedResult<T1, InnerFlowSalesforceDestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowSalesforceDestinationPropertiesFactory, T1, T2, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2>(this CombinedResult<InnerFlowSalesforceDestinationPropertiesFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSalesforceDestinationPropertiesFactory, T2, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2>(this CombinedResult<T1, InnerFlowSalesforceDestinationPropertiesFactory, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowSalesforceDestinationPropertiesFactory, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2>(this CombinedResult<T1, T2, InnerFlowSalesforceDestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowSalesforceDestinationPropertiesFactory, T1, T2, T3, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3>(this CombinedResult<InnerFlowSalesforceDestinationPropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSalesforceDestinationPropertiesFactory, T2, T3, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3>(this CombinedResult<T1, InnerFlowSalesforceDestinationPropertiesFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowSalesforceDestinationPropertiesFactory, T3, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowSalesforceDestinationPropertiesFactory, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowSalesforceDestinationPropertiesFactory, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowSalesforceDestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowSalesforceDestinationPropertiesFactory, T1, T2, T3, T4, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3, T4>(this CombinedResult<InnerFlowSalesforceDestinationPropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSalesforceDestinationPropertiesFactory, T2, T3, T4, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowSalesforceDestinationPropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowSalesforceDestinationPropertiesFactory, T3, T4, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowSalesforceDestinationPropertiesFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowSalesforceDestinationPropertiesFactory, T4, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowSalesforceDestinationPropertiesFactory, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowSalesforceDestinationPropertiesFactory, InnerFlowErrorHandlingConfigFactory> WithErrorHandlingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowSalesforceDestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorHandlingConfig(combinedResult.T5, subFactoryAction));
}
