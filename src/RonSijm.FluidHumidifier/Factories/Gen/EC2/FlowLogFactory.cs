// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class FlowLogFactory(string resourceName = null, Action<Humidifier.EC2.FlowLog> factoryAction = null) : ResourceFactory<Humidifier.EC2.FlowLog>(resourceName)
{

    internal InnerFlowLogDestinationOptionsFactory DestinationOptionsFactory { get; set; }

    protected override Humidifier.EC2.FlowLog Create()
    {
        var flowLogResult = CreateFlowLog();
        factoryAction?.Invoke(flowLogResult);

        return flowLogResult;
    }

    private Humidifier.EC2.FlowLog CreateFlowLog()
    {
        var flowLogResult = new Humidifier.EC2.FlowLog
        {
            GivenName = InputResourceName,
        };

        return flowLogResult;
    }
    public override void CreateChildren(Humidifier.EC2.FlowLog result)
    {
        base.CreateChildren(result);

        result.DestinationOptions ??= DestinationOptionsFactory?.Build();
    }

} // End Of Class

public static class FlowLogFactoryExtensions
{
    public static CombinedResult<FlowLogFactory, InnerFlowLogDestinationOptionsFactory> WithDestinationOptions(this FlowLogFactory parentFactory, Action<Humidifier.EC2.FlowLogTypes.DestinationOptions> subFactoryAction = null)
    {
        parentFactory.DestinationOptionsFactory = new InnerFlowLogDestinationOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationOptionsFactory);
    }

    public static CombinedResult<FlowLogFactory, T1, InnerFlowLogDestinationOptionsFactory> WithDestinationOptions<T1>(this CombinedResult<FlowLogFactory, T1> combinedResult, Action<Humidifier.EC2.FlowLogTypes.DestinationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowLogFactory, InnerFlowLogDestinationOptionsFactory> WithDestinationOptions<T1>(this CombinedResult<T1, FlowLogFactory> combinedResult, Action<Humidifier.EC2.FlowLogTypes.DestinationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FlowLogFactory, T1, T2, InnerFlowLogDestinationOptionsFactory> WithDestinationOptions<T1, T2>(this CombinedResult<FlowLogFactory, T1, T2> combinedResult, Action<Humidifier.EC2.FlowLogTypes.DestinationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowLogFactory, T2, InnerFlowLogDestinationOptionsFactory> WithDestinationOptions<T1, T2>(this CombinedResult<T1, FlowLogFactory, T2> combinedResult, Action<Humidifier.EC2.FlowLogTypes.DestinationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlowLogFactory, InnerFlowLogDestinationOptionsFactory> WithDestinationOptions<T1, T2>(this CombinedResult<T1, T2, FlowLogFactory> combinedResult, Action<Humidifier.EC2.FlowLogTypes.DestinationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FlowLogFactory, T1, T2, T3, InnerFlowLogDestinationOptionsFactory> WithDestinationOptions<T1, T2, T3>(this CombinedResult<FlowLogFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.FlowLogTypes.DestinationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowLogFactory, T2, T3, InnerFlowLogDestinationOptionsFactory> WithDestinationOptions<T1, T2, T3>(this CombinedResult<T1, FlowLogFactory, T2, T3> combinedResult, Action<Humidifier.EC2.FlowLogTypes.DestinationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlowLogFactory, T3, InnerFlowLogDestinationOptionsFactory> WithDestinationOptions<T1, T2, T3>(this CombinedResult<T1, T2, FlowLogFactory, T3> combinedResult, Action<Humidifier.EC2.FlowLogTypes.DestinationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FlowLogFactory, InnerFlowLogDestinationOptionsFactory> WithDestinationOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, FlowLogFactory> combinedResult, Action<Humidifier.EC2.FlowLogTypes.DestinationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FlowLogFactory, T1, T2, T3, T4, InnerFlowLogDestinationOptionsFactory> WithDestinationOptions<T1, T2, T3, T4>(this CombinedResult<FlowLogFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.FlowLogTypes.DestinationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowLogFactory, T2, T3, T4, InnerFlowLogDestinationOptionsFactory> WithDestinationOptions<T1, T2, T3, T4>(this CombinedResult<T1, FlowLogFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.FlowLogTypes.DestinationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlowLogFactory, T3, T4, InnerFlowLogDestinationOptionsFactory> WithDestinationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, FlowLogFactory, T3, T4> combinedResult, Action<Humidifier.EC2.FlowLogTypes.DestinationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FlowLogFactory, T4, InnerFlowLogDestinationOptionsFactory> WithDestinationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FlowLogFactory, T4> combinedResult, Action<Humidifier.EC2.FlowLogTypes.DestinationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FlowLogFactory, InnerFlowLogDestinationOptionsFactory> WithDestinationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FlowLogFactory> combinedResult, Action<Humidifier.EC2.FlowLogTypes.DestinationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationOptions(combinedResult.T5, subFactoryAction));
}
