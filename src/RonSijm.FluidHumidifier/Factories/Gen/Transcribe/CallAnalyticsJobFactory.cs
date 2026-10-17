// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transcribe;

public class CallAnalyticsJobFactory(string resourceName = null, Action<Humidifier.Transcribe.CallAnalyticsJob> factoryAction = null) : ResourceFactory<Humidifier.Transcribe.CallAnalyticsJob>(resourceName)
{

    internal List<InnerCallAnalyticsJobChannelDefinitionFactory> ChannelDefinitionsFactories { get; set; } = [];

    internal InnerCallAnalyticsJobMediaFactory MediaFactory { get; set; }

    protected override Humidifier.Transcribe.CallAnalyticsJob Create()
    {
        var callAnalyticsJobResult = CreateCallAnalyticsJob();
        factoryAction?.Invoke(callAnalyticsJobResult);

        return callAnalyticsJobResult;
    }

    private Humidifier.Transcribe.CallAnalyticsJob CreateCallAnalyticsJob()
    {
        var callAnalyticsJobResult = new Humidifier.Transcribe.CallAnalyticsJob
        {
            GivenName = InputResourceName,
        };

        return callAnalyticsJobResult;
    }
    public override void CreateChildren(Humidifier.Transcribe.CallAnalyticsJob result)
    {
        base.CreateChildren(result);

        result.ChannelDefinitions = ChannelDefinitionsFactories.Any() ? ChannelDefinitionsFactories.Select(x => x.Build()).ToList() : null;
        result.Media ??= MediaFactory?.Build();
    }

} // End Of Class

public static class CallAnalyticsJobFactoryExtensions
{
    public static CombinedResult<CallAnalyticsJobFactory, InnerCallAnalyticsJobChannelDefinitionFactory> WithChannelDefinitions(this CallAnalyticsJobFactory parentFactory, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.ChannelDefinition> subFactoryAction = null)
    {
        var factory = new InnerCallAnalyticsJobChannelDefinitionFactory(subFactoryAction);
        parentFactory.ChannelDefinitionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<CallAnalyticsJobFactory, InnerCallAnalyticsJobMediaFactory> WithMedia(this CallAnalyticsJobFactory parentFactory, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.Media> subFactoryAction = null)
    {
        parentFactory.MediaFactory = new InnerCallAnalyticsJobMediaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MediaFactory);
    }

    public static CombinedResult<CallAnalyticsJobFactory, T1, InnerCallAnalyticsJobChannelDefinitionFactory> WithChannelDefinitions<T1>(this CombinedResult<CallAnalyticsJobFactory, T1> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.ChannelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithChannelDefinitions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CallAnalyticsJobFactory, InnerCallAnalyticsJobChannelDefinitionFactory> WithChannelDefinitions<T1>(this CombinedResult<T1, CallAnalyticsJobFactory> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.ChannelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithChannelDefinitions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CallAnalyticsJobFactory, T1, T2, InnerCallAnalyticsJobChannelDefinitionFactory> WithChannelDefinitions<T1, T2>(this CombinedResult<CallAnalyticsJobFactory, T1, T2> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.ChannelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithChannelDefinitions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CallAnalyticsJobFactory, T2, InnerCallAnalyticsJobChannelDefinitionFactory> WithChannelDefinitions<T1, T2>(this CombinedResult<T1, CallAnalyticsJobFactory, T2> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.ChannelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithChannelDefinitions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CallAnalyticsJobFactory, InnerCallAnalyticsJobChannelDefinitionFactory> WithChannelDefinitions<T1, T2>(this CombinedResult<T1, T2, CallAnalyticsJobFactory> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.ChannelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithChannelDefinitions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CallAnalyticsJobFactory, T1, T2, T3, InnerCallAnalyticsJobChannelDefinitionFactory> WithChannelDefinitions<T1, T2, T3>(this CombinedResult<CallAnalyticsJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.ChannelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithChannelDefinitions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CallAnalyticsJobFactory, T2, T3, InnerCallAnalyticsJobChannelDefinitionFactory> WithChannelDefinitions<T1, T2, T3>(this CombinedResult<T1, CallAnalyticsJobFactory, T2, T3> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.ChannelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithChannelDefinitions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CallAnalyticsJobFactory, T3, InnerCallAnalyticsJobChannelDefinitionFactory> WithChannelDefinitions<T1, T2, T3>(this CombinedResult<T1, T2, CallAnalyticsJobFactory, T3> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.ChannelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithChannelDefinitions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CallAnalyticsJobFactory, InnerCallAnalyticsJobChannelDefinitionFactory> WithChannelDefinitions<T1, T2, T3>(this CombinedResult<T1, T2, T3, CallAnalyticsJobFactory> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.ChannelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithChannelDefinitions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CallAnalyticsJobFactory, T1, T2, T3, T4, InnerCallAnalyticsJobChannelDefinitionFactory> WithChannelDefinitions<T1, T2, T3, T4>(this CombinedResult<CallAnalyticsJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.ChannelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithChannelDefinitions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CallAnalyticsJobFactory, T2, T3, T4, InnerCallAnalyticsJobChannelDefinitionFactory> WithChannelDefinitions<T1, T2, T3, T4>(this CombinedResult<T1, CallAnalyticsJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.ChannelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithChannelDefinitions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CallAnalyticsJobFactory, T3, T4, InnerCallAnalyticsJobChannelDefinitionFactory> WithChannelDefinitions<T1, T2, T3, T4>(this CombinedResult<T1, T2, CallAnalyticsJobFactory, T3, T4> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.ChannelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithChannelDefinitions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CallAnalyticsJobFactory, T4, InnerCallAnalyticsJobChannelDefinitionFactory> WithChannelDefinitions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CallAnalyticsJobFactory, T4> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.ChannelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithChannelDefinitions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CallAnalyticsJobFactory, InnerCallAnalyticsJobChannelDefinitionFactory> WithChannelDefinitions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CallAnalyticsJobFactory> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.ChannelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithChannelDefinitions(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<CallAnalyticsJobFactory, T1, InnerCallAnalyticsJobMediaFactory> WithMedia<T1>(this CombinedResult<CallAnalyticsJobFactory, T1> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, WithMedia(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CallAnalyticsJobFactory, InnerCallAnalyticsJobMediaFactory> WithMedia<T1>(this CombinedResult<T1, CallAnalyticsJobFactory> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, WithMedia(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CallAnalyticsJobFactory, T1, T2, InnerCallAnalyticsJobMediaFactory> WithMedia<T1, T2>(this CombinedResult<CallAnalyticsJobFactory, T1, T2> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CallAnalyticsJobFactory, T2, InnerCallAnalyticsJobMediaFactory> WithMedia<T1, T2>(this CombinedResult<T1, CallAnalyticsJobFactory, T2> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CallAnalyticsJobFactory, InnerCallAnalyticsJobMediaFactory> WithMedia<T1, T2>(this CombinedResult<T1, T2, CallAnalyticsJobFactory> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CallAnalyticsJobFactory, T1, T2, T3, InnerCallAnalyticsJobMediaFactory> WithMedia<T1, T2, T3>(this CombinedResult<CallAnalyticsJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CallAnalyticsJobFactory, T2, T3, InnerCallAnalyticsJobMediaFactory> WithMedia<T1, T2, T3>(this CombinedResult<T1, CallAnalyticsJobFactory, T2, T3> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CallAnalyticsJobFactory, T3, InnerCallAnalyticsJobMediaFactory> WithMedia<T1, T2, T3>(this CombinedResult<T1, T2, CallAnalyticsJobFactory, T3> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CallAnalyticsJobFactory, InnerCallAnalyticsJobMediaFactory> WithMedia<T1, T2, T3>(this CombinedResult<T1, T2, T3, CallAnalyticsJobFactory> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CallAnalyticsJobFactory, T1, T2, T3, T4, InnerCallAnalyticsJobMediaFactory> WithMedia<T1, T2, T3, T4>(this CombinedResult<CallAnalyticsJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CallAnalyticsJobFactory, T2, T3, T4, InnerCallAnalyticsJobMediaFactory> WithMedia<T1, T2, T3, T4>(this CombinedResult<T1, CallAnalyticsJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CallAnalyticsJobFactory, T3, T4, InnerCallAnalyticsJobMediaFactory> WithMedia<T1, T2, T3, T4>(this CombinedResult<T1, T2, CallAnalyticsJobFactory, T3, T4> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CallAnalyticsJobFactory, T4, InnerCallAnalyticsJobMediaFactory> WithMedia<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CallAnalyticsJobFactory, T4> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CallAnalyticsJobFactory, InnerCallAnalyticsJobMediaFactory> WithMedia<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CallAnalyticsJobFactory> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T5, subFactoryAction).T2);
}
