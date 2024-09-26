// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowFailoverConfigFactory(Action<Humidifier.MediaConnect.FlowTypes.FailoverConfig> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowTypes.FailoverConfig>
{

    internal InnerFlowSourcePriorityFactory SourcePriorityFactory { get; set; }

    protected override Humidifier.MediaConnect.FlowTypes.FailoverConfig Create()
    {
        var failoverConfigResult = CreateFailoverConfig();
        factoryAction?.Invoke(failoverConfigResult);

        return failoverConfigResult;
    }

    private Humidifier.MediaConnect.FlowTypes.FailoverConfig CreateFailoverConfig()
    {
        var failoverConfigResult = new Humidifier.MediaConnect.FlowTypes.FailoverConfig();

        return failoverConfigResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.FlowTypes.FailoverConfig result)
    {
        base.CreateChildren(result);

        result.SourcePriority ??= SourcePriorityFactory?.Build();
    }

} // End Of Class

public static class InnerFlowFailoverConfigFactoryExtensions
{
    public static CombinedResult<InnerFlowFailoverConfigFactory, InnerFlowSourcePriorityFactory> WithSourcePriority(this InnerFlowFailoverConfigFactory parentFactory, Action<Humidifier.MediaConnect.FlowTypes.SourcePriority> subFactoryAction = null)
    {
        parentFactory.SourcePriorityFactory = new InnerFlowSourcePriorityFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourcePriorityFactory);
    }

    public static CombinedResult<InnerFlowFailoverConfigFactory, T1, InnerFlowSourcePriorityFactory> WithSourcePriority<T1>(this CombinedResult<InnerFlowFailoverConfigFactory, T1> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourcePriority(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowFailoverConfigFactory, InnerFlowSourcePriorityFactory> WithSourcePriority<T1>(this CombinedResult<T1, InnerFlowFailoverConfigFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourcePriority(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowFailoverConfigFactory, T1, T2, InnerFlowSourcePriorityFactory> WithSourcePriority<T1, T2>(this CombinedResult<InnerFlowFailoverConfigFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourcePriority(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowFailoverConfigFactory, T2, InnerFlowSourcePriorityFactory> WithSourcePriority<T1, T2>(this CombinedResult<T1, InnerFlowFailoverConfigFactory, T2> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourcePriority(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowFailoverConfigFactory, InnerFlowSourcePriorityFactory> WithSourcePriority<T1, T2>(this CombinedResult<T1, T2, InnerFlowFailoverConfigFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourcePriority(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowFailoverConfigFactory, T1, T2, T3, InnerFlowSourcePriorityFactory> WithSourcePriority<T1, T2, T3>(this CombinedResult<InnerFlowFailoverConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePriority(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowFailoverConfigFactory, T2, T3, InnerFlowSourcePriorityFactory> WithSourcePriority<T1, T2, T3>(this CombinedResult<T1, InnerFlowFailoverConfigFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePriority(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowFailoverConfigFactory, T3, InnerFlowSourcePriorityFactory> WithSourcePriority<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowFailoverConfigFactory, T3> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePriority(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowFailoverConfigFactory, InnerFlowSourcePriorityFactory> WithSourcePriority<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowFailoverConfigFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePriority(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowFailoverConfigFactory, T1, T2, T3, T4, InnerFlowSourcePriorityFactory> WithSourcePriority<T1, T2, T3, T4>(this CombinedResult<InnerFlowFailoverConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePriority(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowFailoverConfigFactory, T2, T3, T4, InnerFlowSourcePriorityFactory> WithSourcePriority<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowFailoverConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePriority(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowFailoverConfigFactory, T3, T4, InnerFlowSourcePriorityFactory> WithSourcePriority<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowFailoverConfigFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePriority(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowFailoverConfigFactory, T4, InnerFlowSourcePriorityFactory> WithSourcePriority<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowFailoverConfigFactory, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePriority(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowFailoverConfigFactory, InnerFlowSourcePriorityFactory> WithSourcePriority<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowFailoverConfigFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePriority(combinedResult.T5, subFactoryAction));
}
