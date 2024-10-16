// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EntityResolution;

public class InnerIdMappingWorkflowProviderPropertiesFactory(Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.ProviderProperties> factoryAction = null) : SubResourceFactory<Humidifier.EntityResolution.IdMappingWorkflowTypes.ProviderProperties>
{

    internal InnerIdMappingWorkflowIntermediateSourceConfigurationFactory IntermediateSourceConfigurationFactory { get; set; }

    protected override Humidifier.EntityResolution.IdMappingWorkflowTypes.ProviderProperties Create()
    {
        var providerPropertiesResult = CreateProviderProperties();
        factoryAction?.Invoke(providerPropertiesResult);

        return providerPropertiesResult;
    }

    private Humidifier.EntityResolution.IdMappingWorkflowTypes.ProviderProperties CreateProviderProperties()
    {
        var providerPropertiesResult = new Humidifier.EntityResolution.IdMappingWorkflowTypes.ProviderProperties();

        return providerPropertiesResult;
    }
    public override void CreateChildren(Humidifier.EntityResolution.IdMappingWorkflowTypes.ProviderProperties result)
    {
        base.CreateChildren(result);

        result.IntermediateSourceConfiguration ??= IntermediateSourceConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerIdMappingWorkflowProviderPropertiesFactoryExtensions
{
    public static CombinedResult<InnerIdMappingWorkflowProviderPropertiesFactory, InnerIdMappingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration(this InnerIdMappingWorkflowProviderPropertiesFactory parentFactory, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null)
    {
        parentFactory.IntermediateSourceConfigurationFactory = new InnerIdMappingWorkflowIntermediateSourceConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IntermediateSourceConfigurationFactory);
    }

    public static CombinedResult<InnerIdMappingWorkflowProviderPropertiesFactory, T1, InnerIdMappingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1>(this CombinedResult<InnerIdMappingWorkflowProviderPropertiesFactory, T1> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIdMappingWorkflowProviderPropertiesFactory, InnerIdMappingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1>(this CombinedResult<T1, InnerIdMappingWorkflowProviderPropertiesFactory> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerIdMappingWorkflowProviderPropertiesFactory, T1, T2, InnerIdMappingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1, T2>(this CombinedResult<InnerIdMappingWorkflowProviderPropertiesFactory, T1, T2> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIdMappingWorkflowProviderPropertiesFactory, T2, InnerIdMappingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1, T2>(this CombinedResult<T1, InnerIdMappingWorkflowProviderPropertiesFactory, T2> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIdMappingWorkflowProviderPropertiesFactory, InnerIdMappingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerIdMappingWorkflowProviderPropertiesFactory> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerIdMappingWorkflowProviderPropertiesFactory, T1, T2, T3, InnerIdMappingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1, T2, T3>(this CombinedResult<InnerIdMappingWorkflowProviderPropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIdMappingWorkflowProviderPropertiesFactory, T2, T3, InnerIdMappingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerIdMappingWorkflowProviderPropertiesFactory, T2, T3> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIdMappingWorkflowProviderPropertiesFactory, T3, InnerIdMappingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerIdMappingWorkflowProviderPropertiesFactory, T3> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerIdMappingWorkflowProviderPropertiesFactory, InnerIdMappingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerIdMappingWorkflowProviderPropertiesFactory> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerIdMappingWorkflowProviderPropertiesFactory, T1, T2, T3, T4, InnerIdMappingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerIdMappingWorkflowProviderPropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIdMappingWorkflowProviderPropertiesFactory, T2, T3, T4, InnerIdMappingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerIdMappingWorkflowProviderPropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIdMappingWorkflowProviderPropertiesFactory, T3, T4, InnerIdMappingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerIdMappingWorkflowProviderPropertiesFactory, T3, T4> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerIdMappingWorkflowProviderPropertiesFactory, T4, InnerIdMappingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerIdMappingWorkflowProviderPropertiesFactory, T4> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerIdMappingWorkflowProviderPropertiesFactory, InnerIdMappingWorkflowIntermediateSourceConfigurationFactory> WithIntermediateSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerIdMappingWorkflowProviderPropertiesFactory> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IntermediateSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateSourceConfiguration(combinedResult.T5, subFactoryAction));
}
