// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowTaskFactory(Action<Humidifier.AppFlow.FlowTypes.Task> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.Task>
{

    internal InnerFlowConnectorOperatorFactory ConnectorOperatorFactory { get; set; }

    protected override Humidifier.AppFlow.FlowTypes.Task Create()
    {
        var taskResult = CreateTask();
        factoryAction?.Invoke(taskResult);

        return taskResult;
    }

    private Humidifier.AppFlow.FlowTypes.Task CreateTask()
    {
        var taskResult = new Humidifier.AppFlow.FlowTypes.Task();

        return taskResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.FlowTypes.Task result)
    {
        base.CreateChildren(result);

        result.ConnectorOperator ??= ConnectorOperatorFactory?.Build();
    }

} // End Of Class

public static class InnerFlowTaskFactoryExtensions
{
    public static CombinedResult<InnerFlowTaskFactory, InnerFlowConnectorOperatorFactory> WithConnectorOperator(this InnerFlowTaskFactory parentFactory, Action<Humidifier.AppFlow.FlowTypes.ConnectorOperator> subFactoryAction = null)
    {
        parentFactory.ConnectorOperatorFactory = new InnerFlowConnectorOperatorFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConnectorOperatorFactory);
    }

    public static CombinedResult<InnerFlowTaskFactory, T1, InnerFlowConnectorOperatorFactory> WithConnectorOperator<T1>(this CombinedResult<InnerFlowTaskFactory, T1> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ConnectorOperator> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectorOperator(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowTaskFactory, InnerFlowConnectorOperatorFactory> WithConnectorOperator<T1>(this CombinedResult<T1, InnerFlowTaskFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ConnectorOperator> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectorOperator(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowTaskFactory, T1, T2, InnerFlowConnectorOperatorFactory> WithConnectorOperator<T1, T2>(this CombinedResult<InnerFlowTaskFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ConnectorOperator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorOperator(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowTaskFactory, T2, InnerFlowConnectorOperatorFactory> WithConnectorOperator<T1, T2>(this CombinedResult<T1, InnerFlowTaskFactory, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ConnectorOperator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorOperator(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowTaskFactory, InnerFlowConnectorOperatorFactory> WithConnectorOperator<T1, T2>(this CombinedResult<T1, T2, InnerFlowTaskFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ConnectorOperator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorOperator(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowTaskFactory, T1, T2, T3, InnerFlowConnectorOperatorFactory> WithConnectorOperator<T1, T2, T3>(this CombinedResult<InnerFlowTaskFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ConnectorOperator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOperator(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowTaskFactory, T2, T3, InnerFlowConnectorOperatorFactory> WithConnectorOperator<T1, T2, T3>(this CombinedResult<T1, InnerFlowTaskFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ConnectorOperator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOperator(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowTaskFactory, T3, InnerFlowConnectorOperatorFactory> WithConnectorOperator<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowTaskFactory, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ConnectorOperator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOperator(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowTaskFactory, InnerFlowConnectorOperatorFactory> WithConnectorOperator<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowTaskFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ConnectorOperator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOperator(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowTaskFactory, T1, T2, T3, T4, InnerFlowConnectorOperatorFactory> WithConnectorOperator<T1, T2, T3, T4>(this CombinedResult<InnerFlowTaskFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ConnectorOperator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOperator(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowTaskFactory, T2, T3, T4, InnerFlowConnectorOperatorFactory> WithConnectorOperator<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowTaskFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ConnectorOperator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOperator(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowTaskFactory, T3, T4, InnerFlowConnectorOperatorFactory> WithConnectorOperator<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowTaskFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ConnectorOperator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOperator(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowTaskFactory, T4, InnerFlowConnectorOperatorFactory> WithConnectorOperator<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowTaskFactory, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ConnectorOperator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOperator(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowTaskFactory, InnerFlowConnectorOperatorFactory> WithConnectorOperator<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowTaskFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ConnectorOperator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOperator(combinedResult.T5, subFactoryAction));
}
