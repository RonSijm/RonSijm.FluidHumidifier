// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerChannelFlowProcessorConfigurationFactory(Action<Humidifier.Chime.ChannelFlowTypes.ProcessorConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.ChannelFlowTypes.ProcessorConfiguration>
{

    internal InnerChannelFlowLambdaConfigurationFactory LambdaFactory { get; set; }

    protected override Humidifier.Chime.ChannelFlowTypes.ProcessorConfiguration Create()
    {
        var processorConfigurationResult = CreateProcessorConfiguration();
        factoryAction?.Invoke(processorConfigurationResult);

        return processorConfigurationResult;
    }

    private Humidifier.Chime.ChannelFlowTypes.ProcessorConfiguration CreateProcessorConfiguration()
    {
        var processorConfigurationResult = new Humidifier.Chime.ChannelFlowTypes.ProcessorConfiguration();

        return processorConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Chime.ChannelFlowTypes.ProcessorConfiguration result)
    {
        base.CreateChildren(result);

        result.Lambda ??= LambdaFactory?.Build();
    }

} // End Of Class

public static class InnerChannelFlowProcessorConfigurationFactoryExtensions
{
    public static CombinedResult<InnerChannelFlowProcessorConfigurationFactory, InnerChannelFlowLambdaConfigurationFactory> WithLambda(this InnerChannelFlowProcessorConfigurationFactory parentFactory, Action<Humidifier.Chime.ChannelFlowTypes.LambdaConfiguration> subFactoryAction = null)
    {
        parentFactory.LambdaFactory = new InnerChannelFlowLambdaConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LambdaFactory);
    }

    public static CombinedResult<InnerChannelFlowProcessorConfigurationFactory, T1, InnerChannelFlowLambdaConfigurationFactory> WithLambda<T1>(this CombinedResult<InnerChannelFlowProcessorConfigurationFactory, T1> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLambda(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelFlowProcessorConfigurationFactory, InnerChannelFlowLambdaConfigurationFactory> WithLambda<T1>(this CombinedResult<T1, InnerChannelFlowProcessorConfigurationFactory> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLambda(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerChannelFlowProcessorConfigurationFactory, T1, T2, InnerChannelFlowLambdaConfigurationFactory> WithLambda<T1, T2>(this CombinedResult<InnerChannelFlowProcessorConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelFlowProcessorConfigurationFactory, T2, InnerChannelFlowLambdaConfigurationFactory> WithLambda<T1, T2>(this CombinedResult<T1, InnerChannelFlowProcessorConfigurationFactory, T2> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelFlowProcessorConfigurationFactory, InnerChannelFlowLambdaConfigurationFactory> WithLambda<T1, T2>(this CombinedResult<T1, T2, InnerChannelFlowProcessorConfigurationFactory> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerChannelFlowProcessorConfigurationFactory, T1, T2, T3, InnerChannelFlowLambdaConfigurationFactory> WithLambda<T1, T2, T3>(this CombinedResult<InnerChannelFlowProcessorConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelFlowProcessorConfigurationFactory, T2, T3, InnerChannelFlowLambdaConfigurationFactory> WithLambda<T1, T2, T3>(this CombinedResult<T1, InnerChannelFlowProcessorConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelFlowProcessorConfigurationFactory, T3, InnerChannelFlowLambdaConfigurationFactory> WithLambda<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelFlowProcessorConfigurationFactory, T3> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelFlowProcessorConfigurationFactory, InnerChannelFlowLambdaConfigurationFactory> WithLambda<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelFlowProcessorConfigurationFactory> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerChannelFlowProcessorConfigurationFactory, T1, T2, T3, T4, InnerChannelFlowLambdaConfigurationFactory> WithLambda<T1, T2, T3, T4>(this CombinedResult<InnerChannelFlowProcessorConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelFlowProcessorConfigurationFactory, T2, T3, T4, InnerChannelFlowLambdaConfigurationFactory> WithLambda<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelFlowProcessorConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelFlowProcessorConfigurationFactory, T3, T4, InnerChannelFlowLambdaConfigurationFactory> WithLambda<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelFlowProcessorConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelFlowProcessorConfigurationFactory, T4, InnerChannelFlowLambdaConfigurationFactory> WithLambda<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelFlowProcessorConfigurationFactory, T4> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerChannelFlowProcessorConfigurationFactory, InnerChannelFlowLambdaConfigurationFactory> WithLambda<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelFlowProcessorConfigurationFactory> combinedResult, Action<Humidifier.Chime.ChannelFlowTypes.LambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T5, subFactoryAction).T2);
}
