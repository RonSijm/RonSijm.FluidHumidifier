// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowCustomConnectorSourcePropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.CustomConnectorSourceProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.CustomConnectorSourceProperties>
{

    internal InnerFlowDataTransferApiFactory DataTransferApiFactory { get; set; }

    protected override Humidifier.AppFlow.FlowTypes.CustomConnectorSourceProperties Create()
    {
        var customConnectorSourcePropertiesResult = CreateCustomConnectorSourceProperties();
        factoryAction?.Invoke(customConnectorSourcePropertiesResult);

        return customConnectorSourcePropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.CustomConnectorSourceProperties CreateCustomConnectorSourceProperties()
    {
        var customConnectorSourcePropertiesResult = new Humidifier.AppFlow.FlowTypes.CustomConnectorSourceProperties();

        return customConnectorSourcePropertiesResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.FlowTypes.CustomConnectorSourceProperties result)
    {
        base.CreateChildren(result);

        result.DataTransferApi ??= DataTransferApiFactory?.Build();
    }

} // End Of Class

public static class InnerFlowCustomConnectorSourcePropertiesFactoryExtensions
{
    public static CombinedResult<InnerFlowCustomConnectorSourcePropertiesFactory, InnerFlowDataTransferApiFactory> WithDataTransferApi(this InnerFlowCustomConnectorSourcePropertiesFactory parentFactory, Action<Humidifier.AppFlow.FlowTypes.DataTransferApi> subFactoryAction = null)
    {
        parentFactory.DataTransferApiFactory = new InnerFlowDataTransferApiFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataTransferApiFactory);
    }

    public static CombinedResult<InnerFlowCustomConnectorSourcePropertiesFactory, T1, InnerFlowDataTransferApiFactory> WithDataTransferApi<T1>(this CombinedResult<InnerFlowCustomConnectorSourcePropertiesFactory, T1> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DataTransferApi> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataTransferApi(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowCustomConnectorSourcePropertiesFactory, InnerFlowDataTransferApiFactory> WithDataTransferApi<T1>(this CombinedResult<T1, InnerFlowCustomConnectorSourcePropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DataTransferApi> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataTransferApi(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowCustomConnectorSourcePropertiesFactory, T1, T2, InnerFlowDataTransferApiFactory> WithDataTransferApi<T1, T2>(this CombinedResult<InnerFlowCustomConnectorSourcePropertiesFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DataTransferApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataTransferApi(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowCustomConnectorSourcePropertiesFactory, T2, InnerFlowDataTransferApiFactory> WithDataTransferApi<T1, T2>(this CombinedResult<T1, InnerFlowCustomConnectorSourcePropertiesFactory, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DataTransferApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataTransferApi(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowCustomConnectorSourcePropertiesFactory, InnerFlowDataTransferApiFactory> WithDataTransferApi<T1, T2>(this CombinedResult<T1, T2, InnerFlowCustomConnectorSourcePropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DataTransferApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataTransferApi(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowCustomConnectorSourcePropertiesFactory, T1, T2, T3, InnerFlowDataTransferApiFactory> WithDataTransferApi<T1, T2, T3>(this CombinedResult<InnerFlowCustomConnectorSourcePropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DataTransferApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataTransferApi(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowCustomConnectorSourcePropertiesFactory, T2, T3, InnerFlowDataTransferApiFactory> WithDataTransferApi<T1, T2, T3>(this CombinedResult<T1, InnerFlowCustomConnectorSourcePropertiesFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DataTransferApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataTransferApi(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowCustomConnectorSourcePropertiesFactory, T3, InnerFlowDataTransferApiFactory> WithDataTransferApi<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowCustomConnectorSourcePropertiesFactory, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DataTransferApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataTransferApi(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowCustomConnectorSourcePropertiesFactory, InnerFlowDataTransferApiFactory> WithDataTransferApi<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowCustomConnectorSourcePropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DataTransferApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataTransferApi(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowCustomConnectorSourcePropertiesFactory, T1, T2, T3, T4, InnerFlowDataTransferApiFactory> WithDataTransferApi<T1, T2, T3, T4>(this CombinedResult<InnerFlowCustomConnectorSourcePropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DataTransferApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataTransferApi(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowCustomConnectorSourcePropertiesFactory, T2, T3, T4, InnerFlowDataTransferApiFactory> WithDataTransferApi<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowCustomConnectorSourcePropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DataTransferApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataTransferApi(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowCustomConnectorSourcePropertiesFactory, T3, T4, InnerFlowDataTransferApiFactory> WithDataTransferApi<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowCustomConnectorSourcePropertiesFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DataTransferApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataTransferApi(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowCustomConnectorSourcePropertiesFactory, T4, InnerFlowDataTransferApiFactory> WithDataTransferApi<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowCustomConnectorSourcePropertiesFactory, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DataTransferApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataTransferApi(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowCustomConnectorSourcePropertiesFactory, InnerFlowDataTransferApiFactory> WithDataTransferApi<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowCustomConnectorSourcePropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.DataTransferApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataTransferApi(combinedResult.T5, subFactoryAction));
}
