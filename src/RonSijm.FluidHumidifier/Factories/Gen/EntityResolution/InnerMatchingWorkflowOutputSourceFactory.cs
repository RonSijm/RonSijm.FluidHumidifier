// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EntityResolution;

public class InnerMatchingWorkflowOutputSourceFactory(Action<Humidifier.EntityResolution.MatchingWorkflowTypes.OutputSource> factoryAction = null) : SubResourceFactory<Humidifier.EntityResolution.MatchingWorkflowTypes.OutputSource>
{

    internal InnerMatchingWorkflowCustomerProfilesIntegrationConfigFactory CustomerProfilesIntegrationConfigFactory { get; set; }

    protected override Humidifier.EntityResolution.MatchingWorkflowTypes.OutputSource Create()
    {
        var outputSourceResult = CreateOutputSource();
        factoryAction?.Invoke(outputSourceResult);

        return outputSourceResult;
    }

    private Humidifier.EntityResolution.MatchingWorkflowTypes.OutputSource CreateOutputSource()
    {
        var outputSourceResult = new Humidifier.EntityResolution.MatchingWorkflowTypes.OutputSource();

        return outputSourceResult;
    }
    public override void CreateChildren(Humidifier.EntityResolution.MatchingWorkflowTypes.OutputSource result)
    {
        base.CreateChildren(result);

        result.CustomerProfilesIntegrationConfig ??= CustomerProfilesIntegrationConfigFactory?.Build();
    }

} // End Of Class

public static class InnerMatchingWorkflowOutputSourceFactoryExtensions
{
    public static CombinedResult<InnerMatchingWorkflowOutputSourceFactory, InnerMatchingWorkflowCustomerProfilesIntegrationConfigFactory> WithCustomerProfilesIntegrationConfig(this InnerMatchingWorkflowOutputSourceFactory parentFactory, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.CustomerProfilesIntegrationConfig> subFactoryAction = null)
    {
        parentFactory.CustomerProfilesIntegrationConfigFactory = new InnerMatchingWorkflowCustomerProfilesIntegrationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomerProfilesIntegrationConfigFactory);
    }

    public static CombinedResult<InnerMatchingWorkflowOutputSourceFactory, T1, InnerMatchingWorkflowCustomerProfilesIntegrationConfigFactory> WithCustomerProfilesIntegrationConfig<T1>(this CombinedResult<InnerMatchingWorkflowOutputSourceFactory, T1> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.CustomerProfilesIntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomerProfilesIntegrationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMatchingWorkflowOutputSourceFactory, InnerMatchingWorkflowCustomerProfilesIntegrationConfigFactory> WithCustomerProfilesIntegrationConfig<T1>(this CombinedResult<T1, InnerMatchingWorkflowOutputSourceFactory> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.CustomerProfilesIntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomerProfilesIntegrationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMatchingWorkflowOutputSourceFactory, T1, T2, InnerMatchingWorkflowCustomerProfilesIntegrationConfigFactory> WithCustomerProfilesIntegrationConfig<T1, T2>(this CombinedResult<InnerMatchingWorkflowOutputSourceFactory, T1, T2> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.CustomerProfilesIntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomerProfilesIntegrationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMatchingWorkflowOutputSourceFactory, T2, InnerMatchingWorkflowCustomerProfilesIntegrationConfigFactory> WithCustomerProfilesIntegrationConfig<T1, T2>(this CombinedResult<T1, InnerMatchingWorkflowOutputSourceFactory, T2> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.CustomerProfilesIntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomerProfilesIntegrationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMatchingWorkflowOutputSourceFactory, InnerMatchingWorkflowCustomerProfilesIntegrationConfigFactory> WithCustomerProfilesIntegrationConfig<T1, T2>(this CombinedResult<T1, T2, InnerMatchingWorkflowOutputSourceFactory> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.CustomerProfilesIntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomerProfilesIntegrationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMatchingWorkflowOutputSourceFactory, T1, T2, T3, InnerMatchingWorkflowCustomerProfilesIntegrationConfigFactory> WithCustomerProfilesIntegrationConfig<T1, T2, T3>(this CombinedResult<InnerMatchingWorkflowOutputSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.CustomerProfilesIntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerProfilesIntegrationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMatchingWorkflowOutputSourceFactory, T2, T3, InnerMatchingWorkflowCustomerProfilesIntegrationConfigFactory> WithCustomerProfilesIntegrationConfig<T1, T2, T3>(this CombinedResult<T1, InnerMatchingWorkflowOutputSourceFactory, T2, T3> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.CustomerProfilesIntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerProfilesIntegrationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMatchingWorkflowOutputSourceFactory, T3, InnerMatchingWorkflowCustomerProfilesIntegrationConfigFactory> WithCustomerProfilesIntegrationConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerMatchingWorkflowOutputSourceFactory, T3> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.CustomerProfilesIntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerProfilesIntegrationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMatchingWorkflowOutputSourceFactory, InnerMatchingWorkflowCustomerProfilesIntegrationConfigFactory> WithCustomerProfilesIntegrationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMatchingWorkflowOutputSourceFactory> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.CustomerProfilesIntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerProfilesIntegrationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMatchingWorkflowOutputSourceFactory, T1, T2, T3, T4, InnerMatchingWorkflowCustomerProfilesIntegrationConfigFactory> WithCustomerProfilesIntegrationConfig<T1, T2, T3, T4>(this CombinedResult<InnerMatchingWorkflowOutputSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.CustomerProfilesIntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerProfilesIntegrationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMatchingWorkflowOutputSourceFactory, T2, T3, T4, InnerMatchingWorkflowCustomerProfilesIntegrationConfigFactory> WithCustomerProfilesIntegrationConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerMatchingWorkflowOutputSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.CustomerProfilesIntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerProfilesIntegrationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMatchingWorkflowOutputSourceFactory, T3, T4, InnerMatchingWorkflowCustomerProfilesIntegrationConfigFactory> WithCustomerProfilesIntegrationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMatchingWorkflowOutputSourceFactory, T3, T4> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.CustomerProfilesIntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerProfilesIntegrationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMatchingWorkflowOutputSourceFactory, T4, InnerMatchingWorkflowCustomerProfilesIntegrationConfigFactory> WithCustomerProfilesIntegrationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMatchingWorkflowOutputSourceFactory, T4> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.CustomerProfilesIntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerProfilesIntegrationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMatchingWorkflowOutputSourceFactory, InnerMatchingWorkflowCustomerProfilesIntegrationConfigFactory> WithCustomerProfilesIntegrationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMatchingWorkflowOutputSourceFactory> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.CustomerProfilesIntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerProfilesIntegrationConfig(combinedResult.T5, subFactoryAction).T2);
}
