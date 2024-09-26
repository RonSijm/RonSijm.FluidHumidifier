// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerIntegrationTriggerConfigFactory(Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerConfig> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.IntegrationTypes.TriggerConfig>
{

    internal InnerIntegrationTriggerPropertiesFactory TriggerPropertiesFactory { get; set; }

    protected override Humidifier.CustomerProfiles.IntegrationTypes.TriggerConfig Create()
    {
        var triggerConfigResult = CreateTriggerConfig();
        factoryAction?.Invoke(triggerConfigResult);

        return triggerConfigResult;
    }

    private Humidifier.CustomerProfiles.IntegrationTypes.TriggerConfig CreateTriggerConfig()
    {
        var triggerConfigResult = new Humidifier.CustomerProfiles.IntegrationTypes.TriggerConfig();

        return triggerConfigResult;
    }
    public override void CreateChildren(Humidifier.CustomerProfiles.IntegrationTypes.TriggerConfig result)
    {
        base.CreateChildren(result);

        result.TriggerProperties ??= TriggerPropertiesFactory?.Build();
    }

} // End Of Class

public static class InnerIntegrationTriggerConfigFactoryExtensions
{
    public static CombinedResult<InnerIntegrationTriggerConfigFactory, InnerIntegrationTriggerPropertiesFactory> WithTriggerProperties(this InnerIntegrationTriggerConfigFactory parentFactory, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerProperties> subFactoryAction = null)
    {
        parentFactory.TriggerPropertiesFactory = new InnerIntegrationTriggerPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TriggerPropertiesFactory);
    }

    public static CombinedResult<InnerIntegrationTriggerConfigFactory, T1, InnerIntegrationTriggerPropertiesFactory> WithTriggerProperties<T1>(this CombinedResult<InnerIntegrationTriggerConfigFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithTriggerProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIntegrationTriggerConfigFactory, InnerIntegrationTriggerPropertiesFactory> WithTriggerProperties<T1>(this CombinedResult<T1, InnerIntegrationTriggerConfigFactory> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithTriggerProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerIntegrationTriggerConfigFactory, T1, T2, InnerIntegrationTriggerPropertiesFactory> WithTriggerProperties<T1, T2>(this CombinedResult<InnerIntegrationTriggerConfigFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTriggerProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIntegrationTriggerConfigFactory, T2, InnerIntegrationTriggerPropertiesFactory> WithTriggerProperties<T1, T2>(this CombinedResult<T1, InnerIntegrationTriggerConfigFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTriggerProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIntegrationTriggerConfigFactory, InnerIntegrationTriggerPropertiesFactory> WithTriggerProperties<T1, T2>(this CombinedResult<T1, T2, InnerIntegrationTriggerConfigFactory> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTriggerProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerIntegrationTriggerConfigFactory, T1, T2, T3, InnerIntegrationTriggerPropertiesFactory> WithTriggerProperties<T1, T2, T3>(this CombinedResult<InnerIntegrationTriggerConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIntegrationTriggerConfigFactory, T2, T3, InnerIntegrationTriggerPropertiesFactory> WithTriggerProperties<T1, T2, T3>(this CombinedResult<T1, InnerIntegrationTriggerConfigFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIntegrationTriggerConfigFactory, T3, InnerIntegrationTriggerPropertiesFactory> WithTriggerProperties<T1, T2, T3>(this CombinedResult<T1, T2, InnerIntegrationTriggerConfigFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerIntegrationTriggerConfigFactory, InnerIntegrationTriggerPropertiesFactory> WithTriggerProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerIntegrationTriggerConfigFactory> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerIntegrationTriggerConfigFactory, T1, T2, T3, T4, InnerIntegrationTriggerPropertiesFactory> WithTriggerProperties<T1, T2, T3, T4>(this CombinedResult<InnerIntegrationTriggerConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIntegrationTriggerConfigFactory, T2, T3, T4, InnerIntegrationTriggerPropertiesFactory> WithTriggerProperties<T1, T2, T3, T4>(this CombinedResult<T1, InnerIntegrationTriggerConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIntegrationTriggerConfigFactory, T3, T4, InnerIntegrationTriggerPropertiesFactory> WithTriggerProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerIntegrationTriggerConfigFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerIntegrationTriggerConfigFactory, T4, InnerIntegrationTriggerPropertiesFactory> WithTriggerProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerIntegrationTriggerConfigFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerIntegrationTriggerConfigFactory, InnerIntegrationTriggerPropertiesFactory> WithTriggerProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerIntegrationTriggerConfigFactory> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerProperties(combinedResult.T5, subFactoryAction));
}
