// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerIntegrationTriggerPropertiesFactory(Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerProperties> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.IntegrationTypes.TriggerProperties>
{

    internal InnerIntegrationScheduledTriggerPropertiesFactory ScheduledFactory { get; set; }

    protected override Humidifier.CustomerProfiles.IntegrationTypes.TriggerProperties Create()
    {
        var triggerPropertiesResult = CreateTriggerProperties();
        factoryAction?.Invoke(triggerPropertiesResult);

        return triggerPropertiesResult;
    }

    private Humidifier.CustomerProfiles.IntegrationTypes.TriggerProperties CreateTriggerProperties()
    {
        var triggerPropertiesResult = new Humidifier.CustomerProfiles.IntegrationTypes.TriggerProperties();

        return triggerPropertiesResult;
    }
    public override void CreateChildren(Humidifier.CustomerProfiles.IntegrationTypes.TriggerProperties result)
    {
        base.CreateChildren(result);

        result.Scheduled ??= ScheduledFactory?.Build();
    }

} // End Of Class

public static class InnerIntegrationTriggerPropertiesFactoryExtensions
{
    public static CombinedResult<InnerIntegrationTriggerPropertiesFactory, InnerIntegrationScheduledTriggerPropertiesFactory> WithScheduled(this InnerIntegrationTriggerPropertiesFactory parentFactory, Action<Humidifier.CustomerProfiles.IntegrationTypes.ScheduledTriggerProperties> subFactoryAction = null)
    {
        parentFactory.ScheduledFactory = new InnerIntegrationScheduledTriggerPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScheduledFactory);
    }

    public static CombinedResult<InnerIntegrationTriggerPropertiesFactory, T1, InnerIntegrationScheduledTriggerPropertiesFactory> WithScheduled<T1>(this CombinedResult<InnerIntegrationTriggerPropertiesFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithScheduled(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIntegrationTriggerPropertiesFactory, InnerIntegrationScheduledTriggerPropertiesFactory> WithScheduled<T1>(this CombinedResult<T1, InnerIntegrationTriggerPropertiesFactory> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithScheduled(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerIntegrationTriggerPropertiesFactory, T1, T2, InnerIntegrationScheduledTriggerPropertiesFactory> WithScheduled<T1, T2>(this CombinedResult<InnerIntegrationTriggerPropertiesFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduled(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIntegrationTriggerPropertiesFactory, T2, InnerIntegrationScheduledTriggerPropertiesFactory> WithScheduled<T1, T2>(this CombinedResult<T1, InnerIntegrationTriggerPropertiesFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduled(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIntegrationTriggerPropertiesFactory, InnerIntegrationScheduledTriggerPropertiesFactory> WithScheduled<T1, T2>(this CombinedResult<T1, T2, InnerIntegrationTriggerPropertiesFactory> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduled(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerIntegrationTriggerPropertiesFactory, T1, T2, T3, InnerIntegrationScheduledTriggerPropertiesFactory> WithScheduled<T1, T2, T3>(this CombinedResult<InnerIntegrationTriggerPropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduled(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIntegrationTriggerPropertiesFactory, T2, T3, InnerIntegrationScheduledTriggerPropertiesFactory> WithScheduled<T1, T2, T3>(this CombinedResult<T1, InnerIntegrationTriggerPropertiesFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduled(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIntegrationTriggerPropertiesFactory, T3, InnerIntegrationScheduledTriggerPropertiesFactory> WithScheduled<T1, T2, T3>(this CombinedResult<T1, T2, InnerIntegrationTriggerPropertiesFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduled(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerIntegrationTriggerPropertiesFactory, InnerIntegrationScheduledTriggerPropertiesFactory> WithScheduled<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerIntegrationTriggerPropertiesFactory> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduled(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerIntegrationTriggerPropertiesFactory, T1, T2, T3, T4, InnerIntegrationScheduledTriggerPropertiesFactory> WithScheduled<T1, T2, T3, T4>(this CombinedResult<InnerIntegrationTriggerPropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduled(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIntegrationTriggerPropertiesFactory, T2, T3, T4, InnerIntegrationScheduledTriggerPropertiesFactory> WithScheduled<T1, T2, T3, T4>(this CombinedResult<T1, InnerIntegrationTriggerPropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduled(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIntegrationTriggerPropertiesFactory, T3, T4, InnerIntegrationScheduledTriggerPropertiesFactory> WithScheduled<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerIntegrationTriggerPropertiesFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduled(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerIntegrationTriggerPropertiesFactory, T4, InnerIntegrationScheduledTriggerPropertiesFactory> WithScheduled<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerIntegrationTriggerPropertiesFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduled(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerIntegrationTriggerPropertiesFactory, InnerIntegrationScheduledTriggerPropertiesFactory> WithScheduled<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerIntegrationTriggerPropertiesFactory> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ScheduledTriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduled(combinedResult.T5, subFactoryAction));
}
