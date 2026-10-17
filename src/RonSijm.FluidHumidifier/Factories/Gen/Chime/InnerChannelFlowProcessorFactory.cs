// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerChannelFlowProcessorFactory(Action<Humidifier.Chime.ChannelFlowTypes.Processor> factoryAction = null) : SubResourceFactory<Humidifier.Chime.ChannelFlowTypes.Processor>
{

    internal InnerChannelFlowProcessorConfigurationFactory ConfigurationFactory { get; set; }

    protected override Humidifier.Chime.ChannelFlowTypes.Processor Create()
    {
        var processorResult = CreateProcessor();
        factoryAction?.Invoke(processorResult);

        return processorResult;
    }

    private Humidifier.Chime.ChannelFlowTypes.Processor CreateProcessor()
    {
        var processorResult = new Humidifier.Chime.ChannelFlowTypes.Processor();

        return processorResult;
    }
    public override void CreateChildren(Humidifier.Chime.ChannelFlowTypes.Processor result)
    {
        base.CreateChildren(result);

        result.Configuration ??= ConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerChannelFlowProcessorFactoryExtensions
{
    public static CombinedResult<InnerChannelFlowProcessorFactory, InnerChannelFlowProcessorConfigurationFactory> WithConfiguration(this InnerChannelFlowProcessorFactory parentFactory, Action<Humidifier.Chime.ChannelFlowTypes.ProcessorConfiguration> subFactoryAction = null)
    {
        parentFactory.ConfigurationFactory = new InnerChannelFlowProcessorConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationFactory);
    }

    public static CombinedResult<InnerChannelFlowProcessorFactory, T1, InnerChannelFlowProcessorConfigurationFactory> WithConfiguration<T1>(this CombinedResult<InnerChannelFlowProcessorFactory, T1> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.ProcessorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelFlowProcessorFactory, InnerChannelFlowProcessorConfigurationFactory> WithConfiguration<T1>(this CombinedResult<T1, InnerChannelFlowProcessorFactory> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.ProcessorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerChannelFlowProcessorFactory, T1, T2, InnerChannelFlowProcessorConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<InnerChannelFlowProcessorFactory, T1, T2> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.ProcessorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelFlowProcessorFactory, T2, InnerChannelFlowProcessorConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, InnerChannelFlowProcessorFactory, T2> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.ProcessorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelFlowProcessorFactory, InnerChannelFlowProcessorConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerChannelFlowProcessorFactory> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.ProcessorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerChannelFlowProcessorFactory, T1, T2, T3, InnerChannelFlowProcessorConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<InnerChannelFlowProcessorFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.ProcessorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelFlowProcessorFactory, T2, T3, InnerChannelFlowProcessorConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerChannelFlowProcessorFactory, T2, T3> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.ProcessorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelFlowProcessorFactory, T3, InnerChannelFlowProcessorConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelFlowProcessorFactory, T3> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.ProcessorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelFlowProcessorFactory, InnerChannelFlowProcessorConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelFlowProcessorFactory> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.ProcessorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerChannelFlowProcessorFactory, T1, T2, T3, T4, InnerChannelFlowProcessorConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerChannelFlowProcessorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.ProcessorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelFlowProcessorFactory, T2, T3, T4, InnerChannelFlowProcessorConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelFlowProcessorFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.ProcessorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelFlowProcessorFactory, T3, T4, InnerChannelFlowProcessorConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelFlowProcessorFactory, T3, T4> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.ProcessorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelFlowProcessorFactory, T4, InnerChannelFlowProcessorConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelFlowProcessorFactory, T4> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.ProcessorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerChannelFlowProcessorFactory, InnerChannelFlowProcessorConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelFlowProcessorFactory> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.ProcessorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction).T2);
}
