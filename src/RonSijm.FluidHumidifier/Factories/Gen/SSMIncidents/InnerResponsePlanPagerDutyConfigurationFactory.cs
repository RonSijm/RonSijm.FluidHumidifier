// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSMIncidents;

public class InnerResponsePlanPagerDutyConfigurationFactory(Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyConfiguration>
{

    internal InnerResponsePlanPagerDutyIncidentConfigurationFactory PagerDutyIncidentConfigurationFactory { get; set; }

    protected override Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyConfiguration Create()
    {
        var pagerDutyConfigurationResult = CreatePagerDutyConfiguration();
        factoryAction?.Invoke(pagerDutyConfigurationResult);

        return pagerDutyConfigurationResult;
    }

    private Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyConfiguration CreatePagerDutyConfiguration()
    {
        var pagerDutyConfigurationResult = new Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyConfiguration();

        return pagerDutyConfigurationResult;
    }
    public override void CreateChildren(Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyConfiguration result)
    {
        base.CreateChildren(result);

        result.PagerDutyIncidentConfiguration ??= PagerDutyIncidentConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerResponsePlanPagerDutyConfigurationFactoryExtensions
{
    public static CombinedResult<InnerResponsePlanPagerDutyConfigurationFactory, InnerResponsePlanPagerDutyIncidentConfigurationFactory> WithPagerDutyIncidentConfiguration(this InnerResponsePlanPagerDutyConfigurationFactory parentFactory, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyIncidentConfiguration> subFactoryAction = null)
    {
        parentFactory.PagerDutyIncidentConfigurationFactory = new InnerResponsePlanPagerDutyIncidentConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PagerDutyIncidentConfigurationFactory);
    }

    public static CombinedResult<InnerResponsePlanPagerDutyConfigurationFactory, T1, InnerResponsePlanPagerDutyIncidentConfigurationFactory> WithPagerDutyIncidentConfiguration<T1>(this CombinedResult<InnerResponsePlanPagerDutyConfigurationFactory, T1> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyIncidentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPagerDutyIncidentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResponsePlanPagerDutyConfigurationFactory, InnerResponsePlanPagerDutyIncidentConfigurationFactory> WithPagerDutyIncidentConfiguration<T1>(this CombinedResult<T1, InnerResponsePlanPagerDutyConfigurationFactory> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyIncidentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPagerDutyIncidentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerResponsePlanPagerDutyConfigurationFactory, T1, T2, InnerResponsePlanPagerDutyIncidentConfigurationFactory> WithPagerDutyIncidentConfiguration<T1, T2>(this CombinedResult<InnerResponsePlanPagerDutyConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyIncidentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPagerDutyIncidentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResponsePlanPagerDutyConfigurationFactory, T2, InnerResponsePlanPagerDutyIncidentConfigurationFactory> WithPagerDutyIncidentConfiguration<T1, T2>(this CombinedResult<T1, InnerResponsePlanPagerDutyConfigurationFactory, T2> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyIncidentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPagerDutyIncidentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResponsePlanPagerDutyConfigurationFactory, InnerResponsePlanPagerDutyIncidentConfigurationFactory> WithPagerDutyIncidentConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerResponsePlanPagerDutyConfigurationFactory> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyIncidentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPagerDutyIncidentConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerResponsePlanPagerDutyConfigurationFactory, T1, T2, T3, InnerResponsePlanPagerDutyIncidentConfigurationFactory> WithPagerDutyIncidentConfiguration<T1, T2, T3>(this CombinedResult<InnerResponsePlanPagerDutyConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyIncidentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPagerDutyIncidentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResponsePlanPagerDutyConfigurationFactory, T2, T3, InnerResponsePlanPagerDutyIncidentConfigurationFactory> WithPagerDutyIncidentConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerResponsePlanPagerDutyConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyIncidentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPagerDutyIncidentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResponsePlanPagerDutyConfigurationFactory, T3, InnerResponsePlanPagerDutyIncidentConfigurationFactory> WithPagerDutyIncidentConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerResponsePlanPagerDutyConfigurationFactory, T3> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyIncidentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPagerDutyIncidentConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResponsePlanPagerDutyConfigurationFactory, InnerResponsePlanPagerDutyIncidentConfigurationFactory> WithPagerDutyIncidentConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerResponsePlanPagerDutyConfigurationFactory> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyIncidentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPagerDutyIncidentConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerResponsePlanPagerDutyConfigurationFactory, T1, T2, T3, T4, InnerResponsePlanPagerDutyIncidentConfigurationFactory> WithPagerDutyIncidentConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerResponsePlanPagerDutyConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyIncidentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPagerDutyIncidentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResponsePlanPagerDutyConfigurationFactory, T2, T3, T4, InnerResponsePlanPagerDutyIncidentConfigurationFactory> WithPagerDutyIncidentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerResponsePlanPagerDutyConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyIncidentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPagerDutyIncidentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResponsePlanPagerDutyConfigurationFactory, T3, T4, InnerResponsePlanPagerDutyIncidentConfigurationFactory> WithPagerDutyIncidentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerResponsePlanPagerDutyConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyIncidentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPagerDutyIncidentConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResponsePlanPagerDutyConfigurationFactory, T4, InnerResponsePlanPagerDutyIncidentConfigurationFactory> WithPagerDutyIncidentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerResponsePlanPagerDutyConfigurationFactory, T4> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyIncidentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPagerDutyIncidentConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerResponsePlanPagerDutyConfigurationFactory, InnerResponsePlanPagerDutyIncidentConfigurationFactory> WithPagerDutyIncidentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerResponsePlanPagerDutyConfigurationFactory> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyIncidentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPagerDutyIncidentConfiguration(combinedResult.T5, subFactoryAction));
}
