// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EntityResolution;

public class InnerMatchingWorkflowProviderPropertiesFactory(Action<Humidifier.EntityResolution.MatchingWorkflowTypes.ProviderProperties> factoryAction = null) : SubResourceFactory<Humidifier.EntityResolution.MatchingWorkflowTypes.ProviderProperties>
{

    internal InnerMatchingWorkflowIntermediateSourceConfigurationFactory IntermediateSourceConfigurationFactory { get; set; }

    protected override Humidifier.EntityResolution.MatchingWorkflowTypes.ProviderProperties Create()
    {
        var providerPropertiesResult = CreateProviderProperties();
        factoryAction?.Invoke(providerPropertiesResult);

        return providerPropertiesResult;
    }

    private Humidifier.EntityResolution.MatchingWorkflowTypes.ProviderProperties CreateProviderProperties()
    {
        var providerPropertiesResult = new Humidifier.EntityResolution.MatchingWorkflowTypes.ProviderProperties();

        return providerPropertiesResult;
    }
    public override void CreateChildren(Humidifier.EntityResolution.MatchingWorkflowTypes.ProviderProperties result)
    {
        base.CreateChildren(result);

        result.IntermediateSourceConfiguration ??= IntermediateSourceConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerMatchingWorkflowProviderPropertiesFactoryExtensions
{
    public static CombinedResult<InnerMatchingWorkflowProviderPropertiesFactory, InnerMatchingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration(this InnerMatchingWorkflowProviderPropertiesFactory parentFactory, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null)
    {
        parentFactory.IntermediateSourceConfigurationFactory = new InnerMatchingWorkflowIntermediateSourceConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IntermediateSourceConfigurationFactory);
    }

    public static CombinedResult<InnerMatchingWorkflowProviderPropertiesFactory, T1, InnerMatchingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1>(this CombinedResult<InnerMatchingWorkflowProviderPropertiesFactory, T1> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMatchingWorkflowProviderPropertiesFactory, InnerMatchingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1>(this CombinedResult<T1, InnerMatchingWorkflowProviderPropertiesFactory> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerMatchingWorkflowProviderPropertiesFactory, T1, T2, InnerMatchingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1, T2>(this CombinedResult<InnerMatchingWorkflowProviderPropertiesFactory, T1, T2> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMatchingWorkflowProviderPropertiesFactory, T2, InnerMatchingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1, T2>(this CombinedResult<T1, InnerMatchingWorkflowProviderPropertiesFactory, T2> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMatchingWorkflowProviderPropertiesFactory, InnerMatchingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerMatchingWorkflowProviderPropertiesFactory> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerMatchingWorkflowProviderPropertiesFactory, T1, T2, T3, InnerMatchingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1, T2, T3>(this CombinedResult<InnerMatchingWorkflowProviderPropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMatchingWorkflowProviderPropertiesFactory, T2, T3, InnerMatchingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerMatchingWorkflowProviderPropertiesFactory, T2, T3> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMatchingWorkflowProviderPropertiesFactory, T3, InnerMatchingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerMatchingWorkflowProviderPropertiesFactory, T3> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMatchingWorkflowProviderPropertiesFactory, InnerMatchingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMatchingWorkflowProviderPropertiesFactory> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerMatchingWorkflowProviderPropertiesFactory, T1, T2, T3, T4, InnerMatchingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerMatchingWorkflowProviderPropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMatchingWorkflowProviderPropertiesFactory, T2, T3, T4, InnerMatchingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerMatchingWorkflowProviderPropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMatchingWorkflowProviderPropertiesFactory, T3, T4, InnerMatchingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMatchingWorkflowProviderPropertiesFactory, T3, T4> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMatchingWorkflowProviderPropertiesFactory, T4, InnerMatchingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMatchingWorkflowProviderPropertiesFactory, T4> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerMatchingWorkflowProviderPropertiesFactory, InnerMatchingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMatchingWorkflowProviderPropertiesFactory> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T5, subFactoryAction));
}
