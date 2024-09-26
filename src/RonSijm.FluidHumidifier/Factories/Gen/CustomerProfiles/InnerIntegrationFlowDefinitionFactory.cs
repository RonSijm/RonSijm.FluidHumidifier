// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerIntegrationFlowDefinitionFactory(Action<Humidifier.CustomerProfiles.IntegrationTypes.FlowDefinition> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.IntegrationTypes.FlowDefinition>
{

    internal InnerIntegrationTriggerConfigFactory TriggerConfigFactory { get; set; }

    internal InnerIntegrationSourceFlowConfigFactory SourceFlowConfigFactory { get; set; }

    protected override Humidifier.CustomerProfiles.IntegrationTypes.FlowDefinition Create()
    {
        var flowDefinitionResult = CreateFlowDefinition();
        factoryAction?.Invoke(flowDefinitionResult);

        return flowDefinitionResult;
    }

    private Humidifier.CustomerProfiles.IntegrationTypes.FlowDefinition CreateFlowDefinition()
    {
        var flowDefinitionResult = new Humidifier.CustomerProfiles.IntegrationTypes.FlowDefinition();

        return flowDefinitionResult;
    }
    public override void CreateChildren(Humidifier.CustomerProfiles.IntegrationTypes.FlowDefinition result)
    {
        base.CreateChildren(result);

        result.TriggerConfig ??= TriggerConfigFactory?.Build();
        result.SourceFlowConfig ??= SourceFlowConfigFactory?.Build();
    }

} // End Of Class

public static class InnerIntegrationFlowDefinitionFactoryExtensions
{
    public static CombinedResult<InnerIntegrationFlowDefinitionFactory, InnerIntegrationTriggerConfigFactory> WithTriggerConfig(this InnerIntegrationFlowDefinitionFactory parentFactory, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerConfig> subFactoryAction = null)
    {
        parentFactory.TriggerConfigFactory = new InnerIntegrationTriggerConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TriggerConfigFactory);
    }

    public static CombinedResult<InnerIntegrationFlowDefinitionFactory, InnerIntegrationSourceFlowConfigFactory> WithSourceFlowConfig(this InnerIntegrationFlowDefinitionFactory parentFactory, Action<Humidifier.CustomerProfiles.IntegrationTypes.SourceFlowConfig> subFactoryAction = null)
    {
        parentFactory.SourceFlowConfigFactory = new InnerIntegrationSourceFlowConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceFlowConfigFactory);
    }

    public static CombinedResult<InnerIntegrationFlowDefinitionFactory, T1, InnerIntegrationTriggerConfigFactory> WithTriggerConfig<T1>(this CombinedResult<InnerIntegrationFlowDefinitionFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTriggerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIntegrationFlowDefinitionFactory, InnerIntegrationTriggerConfigFactory> WithTriggerConfig<T1>(this CombinedResult<T1, InnerIntegrationFlowDefinitionFactory> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTriggerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerIntegrationFlowDefinitionFactory, T1, T2, InnerIntegrationTriggerConfigFactory> WithTriggerConfig<T1, T2>(this CombinedResult<InnerIntegrationFlowDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTriggerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIntegrationFlowDefinitionFactory, T2, InnerIntegrationTriggerConfigFactory> WithTriggerConfig<T1, T2>(this CombinedResult<T1, InnerIntegrationFlowDefinitionFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTriggerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIntegrationFlowDefinitionFactory, InnerIntegrationTriggerConfigFactory> WithTriggerConfig<T1, T2>(this CombinedResult<T1, T2, InnerIntegrationFlowDefinitionFactory> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTriggerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerIntegrationFlowDefinitionFactory, T1, T2, T3, InnerIntegrationTriggerConfigFactory> WithTriggerConfig<T1, T2, T3>(this CombinedResult<InnerIntegrationFlowDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIntegrationFlowDefinitionFactory, T2, T3, InnerIntegrationTriggerConfigFactory> WithTriggerConfig<T1, T2, T3>(this CombinedResult<T1, InnerIntegrationFlowDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIntegrationFlowDefinitionFactory, T3, InnerIntegrationTriggerConfigFactory> WithTriggerConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerIntegrationFlowDefinitionFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerIntegrationFlowDefinitionFactory, InnerIntegrationTriggerConfigFactory> WithTriggerConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerIntegrationFlowDefinitionFactory> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerIntegrationFlowDefinitionFactory, T1, T2, T3, T4, InnerIntegrationTriggerConfigFactory> WithTriggerConfig<T1, T2, T3, T4>(this CombinedResult<InnerIntegrationFlowDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIntegrationFlowDefinitionFactory, T2, T3, T4, InnerIntegrationTriggerConfigFactory> WithTriggerConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerIntegrationFlowDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIntegrationFlowDefinitionFactory, T3, T4, InnerIntegrationTriggerConfigFactory> WithTriggerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerIntegrationFlowDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerIntegrationFlowDefinitionFactory, T4, InnerIntegrationTriggerConfigFactory> WithTriggerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerIntegrationFlowDefinitionFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerIntegrationFlowDefinitionFactory, InnerIntegrationTriggerConfigFactory> WithTriggerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerIntegrationFlowDefinitionFactory> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.TriggerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerIntegrationFlowDefinitionFactory, T1, InnerIntegrationSourceFlowConfigFactory> WithSourceFlowConfig<T1>(this CombinedResult<InnerIntegrationFlowDefinitionFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.SourceFlowConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceFlowConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIntegrationFlowDefinitionFactory, InnerIntegrationSourceFlowConfigFactory> WithSourceFlowConfig<T1>(this CombinedResult<T1, InnerIntegrationFlowDefinitionFactory> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.SourceFlowConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceFlowConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerIntegrationFlowDefinitionFactory, T1, T2, InnerIntegrationSourceFlowConfigFactory> WithSourceFlowConfig<T1, T2>(this CombinedResult<InnerIntegrationFlowDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.SourceFlowConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceFlowConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIntegrationFlowDefinitionFactory, T2, InnerIntegrationSourceFlowConfigFactory> WithSourceFlowConfig<T1, T2>(this CombinedResult<T1, InnerIntegrationFlowDefinitionFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.SourceFlowConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceFlowConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIntegrationFlowDefinitionFactory, InnerIntegrationSourceFlowConfigFactory> WithSourceFlowConfig<T1, T2>(this CombinedResult<T1, T2, InnerIntegrationFlowDefinitionFactory> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.SourceFlowConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceFlowConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerIntegrationFlowDefinitionFactory, T1, T2, T3, InnerIntegrationSourceFlowConfigFactory> WithSourceFlowConfig<T1, T2, T3>(this CombinedResult<InnerIntegrationFlowDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.SourceFlowConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceFlowConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIntegrationFlowDefinitionFactory, T2, T3, InnerIntegrationSourceFlowConfigFactory> WithSourceFlowConfig<T1, T2, T3>(this CombinedResult<T1, InnerIntegrationFlowDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.SourceFlowConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceFlowConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIntegrationFlowDefinitionFactory, T3, InnerIntegrationSourceFlowConfigFactory> WithSourceFlowConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerIntegrationFlowDefinitionFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.SourceFlowConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceFlowConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerIntegrationFlowDefinitionFactory, InnerIntegrationSourceFlowConfigFactory> WithSourceFlowConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerIntegrationFlowDefinitionFactory> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.SourceFlowConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceFlowConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerIntegrationFlowDefinitionFactory, T1, T2, T3, T4, InnerIntegrationSourceFlowConfigFactory> WithSourceFlowConfig<T1, T2, T3, T4>(this CombinedResult<InnerIntegrationFlowDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.SourceFlowConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceFlowConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIntegrationFlowDefinitionFactory, T2, T3, T4, InnerIntegrationSourceFlowConfigFactory> WithSourceFlowConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerIntegrationFlowDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.SourceFlowConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceFlowConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIntegrationFlowDefinitionFactory, T3, T4, InnerIntegrationSourceFlowConfigFactory> WithSourceFlowConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerIntegrationFlowDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.SourceFlowConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceFlowConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerIntegrationFlowDefinitionFactory, T4, InnerIntegrationSourceFlowConfigFactory> WithSourceFlowConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerIntegrationFlowDefinitionFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.SourceFlowConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceFlowConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerIntegrationFlowDefinitionFactory, InnerIntegrationSourceFlowConfigFactory> WithSourceFlowConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerIntegrationFlowDefinitionFactory> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.SourceFlowConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceFlowConfig(combinedResult.T5, subFactoryAction));
}
