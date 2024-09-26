// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowTriggerConfigFactory(Action<Humidifier.AppFlow.FlowTypes.TriggerConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.TriggerConfig>
{

    internal InnerFlowScheduledTriggerPropertiesFactory TriggerPropertiesFactory { get; set; }

    protected override Humidifier.AppFlow.FlowTypes.TriggerConfig Create()
    {
        var triggerConfigResult = CreateTriggerConfig();
        factoryAction?.Invoke(triggerConfigResult);

        return triggerConfigResult;
    }

    private Humidifier.AppFlow.FlowTypes.TriggerConfig CreateTriggerConfig()
    {
        var triggerConfigResult = new Humidifier.AppFlow.FlowTypes.TriggerConfig();

        return triggerConfigResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.FlowTypes.TriggerConfig result)
    {
        base.CreateChildren(result);

        result.TriggerProperties ??= TriggerPropertiesFactory?.Build();
    }

} // End Of Class

public static class InnerFlowTriggerConfigFactoryExtensions
{
    public static CombinedResult<InnerFlowTriggerConfigFactory, InnerFlowScheduledTriggerPropertiesFactory> WithTriggerProperties(this InnerFlowTriggerConfigFactory parentFactory, Action<Humidifier.AppFlow.FlowTypes.ScheduledTriggerProperties> subFactoryAction = null)
    {
        parentFactory.TriggerPropertiesFactory = new InnerFlowScheduledTriggerPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TriggerPropertiesFactory);
    }

    public static CombinedResult<InnerFlowTriggerConfigFactory, T1, InnerFlowScheduledTriggerPropertiesFactory> WithTriggerProperties<T1>(this CombinedResult<InnerFlowTriggerConfigFactory, T1> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithTriggerProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowTriggerConfigFactory, InnerFlowScheduledTriggerPropertiesFactory> WithTriggerProperties<T1>(this CombinedResult<T1, InnerFlowTriggerConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithTriggerProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowTriggerConfigFactory, T1, T2, InnerFlowScheduledTriggerPropertiesFactory> WithTriggerProperties<T1, T2>(this CombinedResult<InnerFlowTriggerConfigFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTriggerProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowTriggerConfigFactory, T2, InnerFlowScheduledTriggerPropertiesFactory> WithTriggerProperties<T1, T2>(this CombinedResult<T1, InnerFlowTriggerConfigFactory, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTriggerProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowTriggerConfigFactory, InnerFlowScheduledTriggerPropertiesFactory> WithTriggerProperties<T1, T2>(this CombinedResult<T1, T2, InnerFlowTriggerConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTriggerProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowTriggerConfigFactory, T1, T2, T3, InnerFlowScheduledTriggerPropertiesFactory> WithTriggerProperties<T1, T2, T3>(this CombinedResult<InnerFlowTriggerConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowTriggerConfigFactory, T2, T3, InnerFlowScheduledTriggerPropertiesFactory> WithTriggerProperties<T1, T2, T3>(this CombinedResult<T1, InnerFlowTriggerConfigFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowTriggerConfigFactory, T3, InnerFlowScheduledTriggerPropertiesFactory> WithTriggerProperties<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowTriggerConfigFactory, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowTriggerConfigFactory, InnerFlowScheduledTriggerPropertiesFactory> WithTriggerProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowTriggerConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowTriggerConfigFactory, T1, T2, T3, T4, InnerFlowScheduledTriggerPropertiesFactory> WithTriggerProperties<T1, T2, T3, T4>(this CombinedResult<InnerFlowTriggerConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowTriggerConfigFactory, T2, T3, T4, InnerFlowScheduledTriggerPropertiesFactory> WithTriggerProperties<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowTriggerConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowTriggerConfigFactory, T3, T4, InnerFlowScheduledTriggerPropertiesFactory> WithTriggerProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowTriggerConfigFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowTriggerConfigFactory, T4, InnerFlowScheduledTriggerPropertiesFactory> WithTriggerProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowTriggerConfigFactory, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowTriggerConfigFactory, InnerFlowScheduledTriggerPropertiesFactory> WithTriggerProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowTriggerConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerProperties(combinedResult.T5, subFactoryAction));
}
