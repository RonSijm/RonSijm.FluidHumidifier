// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class ChannelFlowFactory(string resourceName = null, Action<Humidifier.Chime.ChannelFlow> factoryAction = null) : ResourceFactory<Humidifier.Chime.ChannelFlow>(resourceName)
{

    internal List<InnerChannelFlowProcessorFactory> ProcessorsFactories { get; set; } = [];

    protected override Humidifier.Chime.ChannelFlow Create()
    {
        var channelFlowResult = CreateChannelFlow();
        factoryAction?.Invoke(channelFlowResult);

        return channelFlowResult;
    }

    private Humidifier.Chime.ChannelFlow CreateChannelFlow()
    {
        var channelFlowResult = new Humidifier.Chime.ChannelFlow
        {
            GivenName = InputResourceName,
        };

        return channelFlowResult;
    }
    public override void CreateChildren(Humidifier.Chime.ChannelFlow result)
    {
        base.CreateChildren(result);

        result.Processors = ProcessorsFactories.Any() ? ProcessorsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ChannelFlowFactoryExtensions
{
    public static CombinedResult<ChannelFlowFactory, InnerChannelFlowProcessorFactory> WithProcessors(this ChannelFlowFactory parentFactory, Action<Humidifier.Chime.ChannelFlowTypes.Processor> subFactoryAction = null)
    {
        var factory = new InnerChannelFlowProcessorFactory(subFactoryAction);
        parentFactory.ProcessorsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ChannelFlowFactory, T1, InnerChannelFlowProcessorFactory> WithProcessors<T1>(this CombinedResult<ChannelFlowFactory, T1> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, WithProcessors(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ChannelFlowFactory, InnerChannelFlowProcessorFactory> WithProcessors<T1>(this CombinedResult<T1, ChannelFlowFactory> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, WithProcessors(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ChannelFlowFactory, T1, T2, InnerChannelFlowProcessorFactory> WithProcessors<T1, T2>(this CombinedResult<ChannelFlowFactory, T1, T2> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProcessors(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ChannelFlowFactory, T2, InnerChannelFlowProcessorFactory> WithProcessors<T1, T2>(this CombinedResult<T1, ChannelFlowFactory, T2> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProcessors(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ChannelFlowFactory, InnerChannelFlowProcessorFactory> WithProcessors<T1, T2>(this CombinedResult<T1, T2, ChannelFlowFactory> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProcessors(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ChannelFlowFactory, T1, T2, T3, InnerChannelFlowProcessorFactory> WithProcessors<T1, T2, T3>(this CombinedResult<ChannelFlowFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProcessors(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ChannelFlowFactory, T2, T3, InnerChannelFlowProcessorFactory> WithProcessors<T1, T2, T3>(this CombinedResult<T1, ChannelFlowFactory, T2, T3> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProcessors(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ChannelFlowFactory, T3, InnerChannelFlowProcessorFactory> WithProcessors<T1, T2, T3>(this CombinedResult<T1, T2, ChannelFlowFactory, T3> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProcessors(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ChannelFlowFactory, InnerChannelFlowProcessorFactory> WithProcessors<T1, T2, T3>(this CombinedResult<T1, T2, T3, ChannelFlowFactory> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProcessors(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ChannelFlowFactory, T1, T2, T3, T4, InnerChannelFlowProcessorFactory> WithProcessors<T1, T2, T3, T4>(this CombinedResult<ChannelFlowFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProcessors(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ChannelFlowFactory, T2, T3, T4, InnerChannelFlowProcessorFactory> WithProcessors<T1, T2, T3, T4>(this CombinedResult<T1, ChannelFlowFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProcessors(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ChannelFlowFactory, T3, T4, InnerChannelFlowProcessorFactory> WithProcessors<T1, T2, T3, T4>(this CombinedResult<T1, T2, ChannelFlowFactory, T3, T4> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProcessors(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ChannelFlowFactory, T4, InnerChannelFlowProcessorFactory> WithProcessors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ChannelFlowFactory, T4> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProcessors(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ChannelFlowFactory, InnerChannelFlowProcessorFactory> WithProcessors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ChannelFlowFactory> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProcessors(combinedResult.T5, subFactoryAction).T2);
}
