// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowOutputMediaStreamOutputConfigurationFactory(Action<Humidifier.MediaConnect.FlowOutputTypes.MediaStreamOutputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowOutputTypes.MediaStreamOutputConfiguration>
{

    internal InnerFlowOutputEncodingParametersFactory EncodingParametersFactory { get; set; }

    protected override Humidifier.MediaConnect.FlowOutputTypes.MediaStreamOutputConfiguration Create()
    {
        var mediaStreamOutputConfigurationResult = CreateMediaStreamOutputConfiguration();
        factoryAction?.Invoke(mediaStreamOutputConfigurationResult);

        return mediaStreamOutputConfigurationResult;
    }

    private Humidifier.MediaConnect.FlowOutputTypes.MediaStreamOutputConfiguration CreateMediaStreamOutputConfiguration()
    {
        var mediaStreamOutputConfigurationResult = new Humidifier.MediaConnect.FlowOutputTypes.MediaStreamOutputConfiguration();

        return mediaStreamOutputConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.FlowOutputTypes.MediaStreamOutputConfiguration result)
    {
        base.CreateChildren(result);

        result.EncodingParameters ??= EncodingParametersFactory?.Build();
    }

} // End Of Class

public static class InnerFlowOutputMediaStreamOutputConfigurationFactoryExtensions
{
    public static CombinedResult<InnerFlowOutputMediaStreamOutputConfigurationFactory, InnerFlowOutputEncodingParametersFactory> WithEncodingParameters(this InnerFlowOutputMediaStreamOutputConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.FlowOutputTypes.EncodingParameters> subFactoryAction = null)
    {
        parentFactory.EncodingParametersFactory = new InnerFlowOutputEncodingParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncodingParametersFactory);
    }

    public static CombinedResult<InnerFlowOutputMediaStreamOutputConfigurationFactory, T1, InnerFlowOutputEncodingParametersFactory> WithEncodingParameters<T1>(this CombinedResult<InnerFlowOutputMediaStreamOutputConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.EncodingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncodingParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowOutputMediaStreamOutputConfigurationFactory, InnerFlowOutputEncodingParametersFactory> WithEncodingParameters<T1>(this CombinedResult<T1, InnerFlowOutputMediaStreamOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.EncodingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncodingParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowOutputMediaStreamOutputConfigurationFactory, T1, T2, InnerFlowOutputEncodingParametersFactory> WithEncodingParameters<T1, T2>(this CombinedResult<InnerFlowOutputMediaStreamOutputConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.EncodingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncodingParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowOutputMediaStreamOutputConfigurationFactory, T2, InnerFlowOutputEncodingParametersFactory> WithEncodingParameters<T1, T2>(this CombinedResult<T1, InnerFlowOutputMediaStreamOutputConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.EncodingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncodingParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowOutputMediaStreamOutputConfigurationFactory, InnerFlowOutputEncodingParametersFactory> WithEncodingParameters<T1, T2>(this CombinedResult<T1, T2, InnerFlowOutputMediaStreamOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.EncodingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncodingParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowOutputMediaStreamOutputConfigurationFactory, T1, T2, T3, InnerFlowOutputEncodingParametersFactory> WithEncodingParameters<T1, T2, T3>(this CombinedResult<InnerFlowOutputMediaStreamOutputConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.EncodingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncodingParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowOutputMediaStreamOutputConfigurationFactory, T2, T3, InnerFlowOutputEncodingParametersFactory> WithEncodingParameters<T1, T2, T3>(this CombinedResult<T1, InnerFlowOutputMediaStreamOutputConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.EncodingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncodingParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowOutputMediaStreamOutputConfigurationFactory, T3, InnerFlowOutputEncodingParametersFactory> WithEncodingParameters<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowOutputMediaStreamOutputConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.EncodingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncodingParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowOutputMediaStreamOutputConfigurationFactory, InnerFlowOutputEncodingParametersFactory> WithEncodingParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowOutputMediaStreamOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.EncodingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncodingParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowOutputMediaStreamOutputConfigurationFactory, T1, T2, T3, T4, InnerFlowOutputEncodingParametersFactory> WithEncodingParameters<T1, T2, T3, T4>(this CombinedResult<InnerFlowOutputMediaStreamOutputConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.EncodingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncodingParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowOutputMediaStreamOutputConfigurationFactory, T2, T3, T4, InnerFlowOutputEncodingParametersFactory> WithEncodingParameters<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowOutputMediaStreamOutputConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.EncodingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncodingParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowOutputMediaStreamOutputConfigurationFactory, T3, T4, InnerFlowOutputEncodingParametersFactory> WithEncodingParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowOutputMediaStreamOutputConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.EncodingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncodingParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowOutputMediaStreamOutputConfigurationFactory, T4, InnerFlowOutputEncodingParametersFactory> WithEncodingParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowOutputMediaStreamOutputConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.EncodingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncodingParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowOutputMediaStreamOutputConfigurationFactory, InnerFlowOutputEncodingParametersFactory> WithEncodingParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowOutputMediaStreamOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.EncodingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncodingParameters(combinedResult.T5, subFactoryAction));
}
