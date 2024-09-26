// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerKnowledgeBaseSourceConfigurationFactory(Action<Humidifier.Wisdom.KnowledgeBaseTypes.SourceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.KnowledgeBaseTypes.SourceConfiguration>
{

    internal InnerKnowledgeBaseAppIntegrationsConfigurationFactory AppIntegrationsFactory { get; set; }

    protected override Humidifier.Wisdom.KnowledgeBaseTypes.SourceConfiguration Create()
    {
        var sourceConfigurationResult = CreateSourceConfiguration();
        factoryAction?.Invoke(sourceConfigurationResult);

        return sourceConfigurationResult;
    }

    private Humidifier.Wisdom.KnowledgeBaseTypes.SourceConfiguration CreateSourceConfiguration()
    {
        var sourceConfigurationResult = new Humidifier.Wisdom.KnowledgeBaseTypes.SourceConfiguration();

        return sourceConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Wisdom.KnowledgeBaseTypes.SourceConfiguration result)
    {
        base.CreateChildren(result);

        result.AppIntegrations ??= AppIntegrationsFactory?.Build();
    }

} // End Of Class

public static class InnerKnowledgeBaseSourceConfigurationFactoryExtensions
{
    public static CombinedResult<InnerKnowledgeBaseSourceConfigurationFactory, InnerKnowledgeBaseAppIntegrationsConfigurationFactory> WithAppIntegrations(this InnerKnowledgeBaseSourceConfigurationFactory parentFactory, Action<Humidifier.Wisdom.KnowledgeBaseTypes.AppIntegrationsConfiguration> subFactoryAction = null)
    {
        parentFactory.AppIntegrationsFactory = new InnerKnowledgeBaseAppIntegrationsConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AppIntegrationsFactory);
    }

    public static CombinedResult<InnerKnowledgeBaseSourceConfigurationFactory, T1, InnerKnowledgeBaseAppIntegrationsConfigurationFactory> WithAppIntegrations<T1>(this CombinedResult<InnerKnowledgeBaseSourceConfigurationFactory, T1> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.AppIntegrationsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAppIntegrations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseSourceConfigurationFactory, InnerKnowledgeBaseAppIntegrationsConfigurationFactory> WithAppIntegrations<T1>(this CombinedResult<T1, InnerKnowledgeBaseSourceConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.AppIntegrationsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAppIntegrations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseSourceConfigurationFactory, T1, T2, InnerKnowledgeBaseAppIntegrationsConfigurationFactory> WithAppIntegrations<T1, T2>(this CombinedResult<InnerKnowledgeBaseSourceConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.AppIntegrationsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppIntegrations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseSourceConfigurationFactory, T2, InnerKnowledgeBaseAppIntegrationsConfigurationFactory> WithAppIntegrations<T1, T2>(this CombinedResult<T1, InnerKnowledgeBaseSourceConfigurationFactory, T2> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.AppIntegrationsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppIntegrations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseSourceConfigurationFactory, InnerKnowledgeBaseAppIntegrationsConfigurationFactory> WithAppIntegrations<T1, T2>(this CombinedResult<T1, T2, InnerKnowledgeBaseSourceConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.AppIntegrationsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppIntegrations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseSourceConfigurationFactory, T1, T2, T3, InnerKnowledgeBaseAppIntegrationsConfigurationFactory> WithAppIntegrations<T1, T2, T3>(this CombinedResult<InnerKnowledgeBaseSourceConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.AppIntegrationsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppIntegrations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseSourceConfigurationFactory, T2, T3, InnerKnowledgeBaseAppIntegrationsConfigurationFactory> WithAppIntegrations<T1, T2, T3>(this CombinedResult<T1, InnerKnowledgeBaseSourceConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.AppIntegrationsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppIntegrations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseSourceConfigurationFactory, T3, InnerKnowledgeBaseAppIntegrationsConfigurationFactory> WithAppIntegrations<T1, T2, T3>(this CombinedResult<T1, T2, InnerKnowledgeBaseSourceConfigurationFactory, T3> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.AppIntegrationsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppIntegrations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseSourceConfigurationFactory, InnerKnowledgeBaseAppIntegrationsConfigurationFactory> WithAppIntegrations<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseSourceConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.AppIntegrationsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppIntegrations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseSourceConfigurationFactory, T1, T2, T3, T4, InnerKnowledgeBaseAppIntegrationsConfigurationFactory> WithAppIntegrations<T1, T2, T3, T4>(this CombinedResult<InnerKnowledgeBaseSourceConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.AppIntegrationsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppIntegrations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseSourceConfigurationFactory, T2, T3, T4, InnerKnowledgeBaseAppIntegrationsConfigurationFactory> WithAppIntegrations<T1, T2, T3, T4>(this CombinedResult<T1, InnerKnowledgeBaseSourceConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.AppIntegrationsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppIntegrations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseSourceConfigurationFactory, T3, T4, InnerKnowledgeBaseAppIntegrationsConfigurationFactory> WithAppIntegrations<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerKnowledgeBaseSourceConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.AppIntegrationsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppIntegrations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseSourceConfigurationFactory, T4, InnerKnowledgeBaseAppIntegrationsConfigurationFactory> WithAppIntegrations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseSourceConfigurationFactory, T4> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.AppIntegrationsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppIntegrations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseSourceConfigurationFactory, InnerKnowledgeBaseAppIntegrationsConfigurationFactory> WithAppIntegrations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseSourceConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.AppIntegrationsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppIntegrations(combinedResult.T5, subFactoryAction));
}
