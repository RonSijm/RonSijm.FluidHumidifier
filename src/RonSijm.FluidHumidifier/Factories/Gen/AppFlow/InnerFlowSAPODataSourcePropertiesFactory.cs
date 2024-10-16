// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowSAPODataSourcePropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.SAPODataSourceProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.SAPODataSourceProperties>
{

    internal InnerFlowSAPODataPaginationConfigFactory paginationConfigFactory { get; set; }

    internal InnerFlowSAPODataParallelismConfigFactory parallelismConfigFactory { get; set; }

    protected override Humidifier.AppFlow.FlowTypes.SAPODataSourceProperties Create()
    {
        var sAPODataSourcePropertiesResult = CreateSAPODataSourceProperties();
        factoryAction?.Invoke(sAPODataSourcePropertiesResult);

        return sAPODataSourcePropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.SAPODataSourceProperties CreateSAPODataSourceProperties()
    {
        var sAPODataSourcePropertiesResult = new Humidifier.AppFlow.FlowTypes.SAPODataSourceProperties();

        return sAPODataSourcePropertiesResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.FlowTypes.SAPODataSourceProperties result)
    {
        base.CreateChildren(result);

        result.paginationConfig ??= paginationConfigFactory?.Build();
        result.parallelismConfig ??= parallelismConfigFactory?.Build();
    }

} // End Of Class

public static class InnerFlowSAPODataSourcePropertiesFactoryExtensions
{
    public static CombinedResult<InnerFlowSAPODataSourcePropertiesFactory, InnerFlowSAPODataPaginationConfigFactory> WithpaginationConfig(this InnerFlowSAPODataSourcePropertiesFactory parentFactory, Action<Humidifier.AppFlow.FlowTypes.SAPODataPaginationConfig> subFactoryAction = null)
    {
        parentFactory.paginationConfigFactory = new InnerFlowSAPODataPaginationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.paginationConfigFactory);
    }

    public static CombinedResult<InnerFlowSAPODataSourcePropertiesFactory, InnerFlowSAPODataParallelismConfigFactory> WithparallelismConfig(this InnerFlowSAPODataSourcePropertiesFactory parentFactory, Action<Humidifier.AppFlow.FlowTypes.SAPODataParallelismConfig> subFactoryAction = null)
    {
        parentFactory.parallelismConfigFactory = new InnerFlowSAPODataParallelismConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.parallelismConfigFactory);
    }

    public static CombinedResult<InnerFlowSAPODataSourcePropertiesFactory, T1, InnerFlowSAPODataPaginationConfigFactory> WithpaginationConfig<T1>(this CombinedResult<InnerFlowSAPODataSourcePropertiesFactory, T1> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataPaginationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithpaginationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSAPODataSourcePropertiesFactory, InnerFlowSAPODataPaginationConfigFactory> WithpaginationConfig<T1>(this CombinedResult<T1, InnerFlowSAPODataSourcePropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataPaginationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithpaginationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowSAPODataSourcePropertiesFactory, T1, T2, InnerFlowSAPODataPaginationConfigFactory> WithpaginationConfig<T1, T2>(this CombinedResult<InnerFlowSAPODataSourcePropertiesFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataPaginationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithpaginationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSAPODataSourcePropertiesFactory, T2, InnerFlowSAPODataPaginationConfigFactory> WithpaginationConfig<T1, T2>(this CombinedResult<T1, InnerFlowSAPODataSourcePropertiesFactory, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataPaginationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithpaginationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowSAPODataSourcePropertiesFactory, InnerFlowSAPODataPaginationConfigFactory> WithpaginationConfig<T1, T2>(this CombinedResult<T1, T2, InnerFlowSAPODataSourcePropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataPaginationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithpaginationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowSAPODataSourcePropertiesFactory, T1, T2, T3, InnerFlowSAPODataPaginationConfigFactory> WithpaginationConfig<T1, T2, T3>(this CombinedResult<InnerFlowSAPODataSourcePropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataPaginationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithpaginationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSAPODataSourcePropertiesFactory, T2, T3, InnerFlowSAPODataPaginationConfigFactory> WithpaginationConfig<T1, T2, T3>(this CombinedResult<T1, InnerFlowSAPODataSourcePropertiesFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataPaginationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithpaginationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowSAPODataSourcePropertiesFactory, T3, InnerFlowSAPODataPaginationConfigFactory> WithpaginationConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowSAPODataSourcePropertiesFactory, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataPaginationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithpaginationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowSAPODataSourcePropertiesFactory, InnerFlowSAPODataPaginationConfigFactory> WithpaginationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowSAPODataSourcePropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataPaginationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithpaginationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowSAPODataSourcePropertiesFactory, T1, T2, T3, T4, InnerFlowSAPODataPaginationConfigFactory> WithpaginationConfig<T1, T2, T3, T4>(this CombinedResult<InnerFlowSAPODataSourcePropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataPaginationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithpaginationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSAPODataSourcePropertiesFactory, T2, T3, T4, InnerFlowSAPODataPaginationConfigFactory> WithpaginationConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowSAPODataSourcePropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataPaginationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithpaginationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowSAPODataSourcePropertiesFactory, T3, T4, InnerFlowSAPODataPaginationConfigFactory> WithpaginationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowSAPODataSourcePropertiesFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataPaginationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithpaginationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowSAPODataSourcePropertiesFactory, T4, InnerFlowSAPODataPaginationConfigFactory> WithpaginationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowSAPODataSourcePropertiesFactory, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataPaginationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithpaginationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowSAPODataSourcePropertiesFactory, InnerFlowSAPODataPaginationConfigFactory> WithpaginationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowSAPODataSourcePropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataPaginationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithpaginationConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerFlowSAPODataSourcePropertiesFactory, T1, InnerFlowSAPODataParallelismConfigFactory> WithparallelismConfig<T1>(this CombinedResult<InnerFlowSAPODataSourcePropertiesFactory, T1> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataParallelismConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithparallelismConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSAPODataSourcePropertiesFactory, InnerFlowSAPODataParallelismConfigFactory> WithparallelismConfig<T1>(this CombinedResult<T1, InnerFlowSAPODataSourcePropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataParallelismConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithparallelismConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowSAPODataSourcePropertiesFactory, T1, T2, InnerFlowSAPODataParallelismConfigFactory> WithparallelismConfig<T1, T2>(this CombinedResult<InnerFlowSAPODataSourcePropertiesFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataParallelismConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithparallelismConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSAPODataSourcePropertiesFactory, T2, InnerFlowSAPODataParallelismConfigFactory> WithparallelismConfig<T1, T2>(this CombinedResult<T1, InnerFlowSAPODataSourcePropertiesFactory, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataParallelismConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithparallelismConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowSAPODataSourcePropertiesFactory, InnerFlowSAPODataParallelismConfigFactory> WithparallelismConfig<T1, T2>(this CombinedResult<T1, T2, InnerFlowSAPODataSourcePropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataParallelismConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithparallelismConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowSAPODataSourcePropertiesFactory, T1, T2, T3, InnerFlowSAPODataParallelismConfigFactory> WithparallelismConfig<T1, T2, T3>(this CombinedResult<InnerFlowSAPODataSourcePropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataParallelismConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithparallelismConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSAPODataSourcePropertiesFactory, T2, T3, InnerFlowSAPODataParallelismConfigFactory> WithparallelismConfig<T1, T2, T3>(this CombinedResult<T1, InnerFlowSAPODataSourcePropertiesFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataParallelismConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithparallelismConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowSAPODataSourcePropertiesFactory, T3, InnerFlowSAPODataParallelismConfigFactory> WithparallelismConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowSAPODataSourcePropertiesFactory, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataParallelismConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithparallelismConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowSAPODataSourcePropertiesFactory, InnerFlowSAPODataParallelismConfigFactory> WithparallelismConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowSAPODataSourcePropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataParallelismConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithparallelismConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowSAPODataSourcePropertiesFactory, T1, T2, T3, T4, InnerFlowSAPODataParallelismConfigFactory> WithparallelismConfig<T1, T2, T3, T4>(this CombinedResult<InnerFlowSAPODataSourcePropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataParallelismConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithparallelismConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSAPODataSourcePropertiesFactory, T2, T3, T4, InnerFlowSAPODataParallelismConfigFactory> WithparallelismConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowSAPODataSourcePropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataParallelismConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithparallelismConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowSAPODataSourcePropertiesFactory, T3, T4, InnerFlowSAPODataParallelismConfigFactory> WithparallelismConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowSAPODataSourcePropertiesFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataParallelismConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithparallelismConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowSAPODataSourcePropertiesFactory, T4, InnerFlowSAPODataParallelismConfigFactory> WithparallelismConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowSAPODataSourcePropertiesFactory, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataParallelismConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithparallelismConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowSAPODataSourcePropertiesFactory, InnerFlowSAPODataParallelismConfigFactory> WithparallelismConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowSAPODataSourcePropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.SAPODataParallelismConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithparallelismConfig(combinedResult.T5, subFactoryAction));
}
