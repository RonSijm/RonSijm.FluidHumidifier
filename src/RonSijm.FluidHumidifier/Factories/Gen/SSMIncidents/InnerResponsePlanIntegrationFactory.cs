// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSMIncidents;

public class InnerResponsePlanIntegrationFactory(Action<Humidifier.SSMIncidents.ResponsePlanTypes.Integration> factoryAction = null) : SubResourceFactory<Humidifier.SSMIncidents.ResponsePlanTypes.Integration>
{

    internal InnerResponsePlanPagerDutyConfigurationFactory PagerDutyConfigurationFactory { get; set; }

    protected override Humidifier.SSMIncidents.ResponsePlanTypes.Integration Create()
    {
        var integrationResult = CreateIntegration();
        factoryAction?.Invoke(integrationResult);

        return integrationResult;
    }

    private Humidifier.SSMIncidents.ResponsePlanTypes.Integration CreateIntegration()
    {
        var integrationResult = new Humidifier.SSMIncidents.ResponsePlanTypes.Integration();

        return integrationResult;
    }
    public override void CreateChildren(Humidifier.SSMIncidents.ResponsePlanTypes.Integration result)
    {
        base.CreateChildren(result);

        result.PagerDutyConfiguration ??= PagerDutyConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerResponsePlanIntegrationFactoryExtensions
{
    public static CombinedResult<InnerResponsePlanIntegrationFactory, InnerResponsePlanPagerDutyConfigurationFactory> WithPagerDutyConfiguration(this InnerResponsePlanIntegrationFactory parentFactory, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyConfiguration> subFactoryAction = null)
    {
        parentFactory.PagerDutyConfigurationFactory = new InnerResponsePlanPagerDutyConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PagerDutyConfigurationFactory);
    }

    public static CombinedResult<InnerResponsePlanIntegrationFactory, T1, InnerResponsePlanPagerDutyConfigurationFactory> WithPagerDutyConfiguration<T1>(this CombinedResult<InnerResponsePlanIntegrationFactory, T1> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPagerDutyConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResponsePlanIntegrationFactory, InnerResponsePlanPagerDutyConfigurationFactory> WithPagerDutyConfiguration<T1>(this CombinedResult<T1, InnerResponsePlanIntegrationFactory> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPagerDutyConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerResponsePlanIntegrationFactory, T1, T2, InnerResponsePlanPagerDutyConfigurationFactory> WithPagerDutyConfiguration<T1, T2>(this CombinedResult<InnerResponsePlanIntegrationFactory, T1, T2> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPagerDutyConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResponsePlanIntegrationFactory, T2, InnerResponsePlanPagerDutyConfigurationFactory> WithPagerDutyConfiguration<T1, T2>(this CombinedResult<T1, InnerResponsePlanIntegrationFactory, T2> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPagerDutyConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResponsePlanIntegrationFactory, InnerResponsePlanPagerDutyConfigurationFactory> WithPagerDutyConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerResponsePlanIntegrationFactory> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPagerDutyConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerResponsePlanIntegrationFactory, T1, T2, T3, InnerResponsePlanPagerDutyConfigurationFactory> WithPagerDutyConfiguration<T1, T2, T3>(this CombinedResult<InnerResponsePlanIntegrationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPagerDutyConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResponsePlanIntegrationFactory, T2, T3, InnerResponsePlanPagerDutyConfigurationFactory> WithPagerDutyConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerResponsePlanIntegrationFactory, T2, T3> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPagerDutyConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResponsePlanIntegrationFactory, T3, InnerResponsePlanPagerDutyConfigurationFactory> WithPagerDutyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerResponsePlanIntegrationFactory, T3> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPagerDutyConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResponsePlanIntegrationFactory, InnerResponsePlanPagerDutyConfigurationFactory> WithPagerDutyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerResponsePlanIntegrationFactory> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPagerDutyConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerResponsePlanIntegrationFactory, T1, T2, T3, T4, InnerResponsePlanPagerDutyConfigurationFactory> WithPagerDutyConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerResponsePlanIntegrationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPagerDutyConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResponsePlanIntegrationFactory, T2, T3, T4, InnerResponsePlanPagerDutyConfigurationFactory> WithPagerDutyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerResponsePlanIntegrationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPagerDutyConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResponsePlanIntegrationFactory, T3, T4, InnerResponsePlanPagerDutyConfigurationFactory> WithPagerDutyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerResponsePlanIntegrationFactory, T3, T4> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPagerDutyConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResponsePlanIntegrationFactory, T4, InnerResponsePlanPagerDutyConfigurationFactory> WithPagerDutyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerResponsePlanIntegrationFactory, T4> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPagerDutyConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerResponsePlanIntegrationFactory, InnerResponsePlanPagerDutyConfigurationFactory> WithPagerDutyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerResponsePlanIntegrationFactory> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPagerDutyConfiguration(combinedResult.T5, subFactoryAction));
}
