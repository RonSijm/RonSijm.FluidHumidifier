// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Athena;

public class InnerWorkGroupManagedQueryResultsConfigurationFactory(Action<Humidifier.Athena.WorkGroupTypes.ManagedQueryResultsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Athena.WorkGroupTypes.ManagedQueryResultsConfiguration>
{

    internal InnerWorkGroupManagedStorageEncryptionConfigurationFactory EncryptionConfigurationFactory { get; set; }

    protected override Humidifier.Athena.WorkGroupTypes.ManagedQueryResultsConfiguration Create()
    {
        var managedQueryResultsConfigurationResult = CreateManagedQueryResultsConfiguration();
        factoryAction?.Invoke(managedQueryResultsConfigurationResult);

        return managedQueryResultsConfigurationResult;
    }

    private Humidifier.Athena.WorkGroupTypes.ManagedQueryResultsConfiguration CreateManagedQueryResultsConfiguration()
    {
        var managedQueryResultsConfigurationResult = new Humidifier.Athena.WorkGroupTypes.ManagedQueryResultsConfiguration();

        return managedQueryResultsConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Athena.WorkGroupTypes.ManagedQueryResultsConfiguration result)
    {
        base.CreateChildren(result);

        result.EncryptionConfiguration ??= EncryptionConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerWorkGroupManagedQueryResultsConfigurationFactoryExtensions
{
    public static CombinedResult<InnerWorkGroupManagedQueryResultsConfigurationFactory, InnerWorkGroupManagedStorageEncryptionConfigurationFactory> WithEncryptionConfiguration(this InnerWorkGroupManagedQueryResultsConfigurationFactory parentFactory, Action<Humidifier.Athena.WorkGroupTypes.ManagedStorageEncryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionConfigurationFactory = new InnerWorkGroupManagedStorageEncryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionConfigurationFactory);
    }

    public static CombinedResult<InnerWorkGroupManagedQueryResultsConfigurationFactory, T1, InnerWorkGroupManagedStorageEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<InnerWorkGroupManagedQueryResultsConfigurationFactory, T1> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.ManagedStorageEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkGroupManagedQueryResultsConfigurationFactory, InnerWorkGroupManagedStorageEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<T1, InnerWorkGroupManagedQueryResultsConfigurationFactory> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.ManagedStorageEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerWorkGroupManagedQueryResultsConfigurationFactory, T1, T2, InnerWorkGroupManagedStorageEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<InnerWorkGroupManagedQueryResultsConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.ManagedStorageEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkGroupManagedQueryResultsConfigurationFactory, T2, InnerWorkGroupManagedStorageEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, InnerWorkGroupManagedQueryResultsConfigurationFactory, T2> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.ManagedStorageEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkGroupManagedQueryResultsConfigurationFactory, InnerWorkGroupManagedStorageEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerWorkGroupManagedQueryResultsConfigurationFactory> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.ManagedStorageEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerWorkGroupManagedQueryResultsConfigurationFactory, T1, T2, T3, InnerWorkGroupManagedStorageEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<InnerWorkGroupManagedQueryResultsConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.ManagedStorageEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkGroupManagedQueryResultsConfigurationFactory, T2, T3, InnerWorkGroupManagedStorageEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerWorkGroupManagedQueryResultsConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.ManagedStorageEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkGroupManagedQueryResultsConfigurationFactory, T3, InnerWorkGroupManagedStorageEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerWorkGroupManagedQueryResultsConfigurationFactory, T3> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.ManagedStorageEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWorkGroupManagedQueryResultsConfigurationFactory, InnerWorkGroupManagedStorageEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWorkGroupManagedQueryResultsConfigurationFactory> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.ManagedStorageEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerWorkGroupManagedQueryResultsConfigurationFactory, T1, T2, T3, T4, InnerWorkGroupManagedStorageEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerWorkGroupManagedQueryResultsConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.ManagedStorageEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkGroupManagedQueryResultsConfigurationFactory, T2, T3, T4, InnerWorkGroupManagedStorageEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerWorkGroupManagedQueryResultsConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.ManagedStorageEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkGroupManagedQueryResultsConfigurationFactory, T3, T4, InnerWorkGroupManagedStorageEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWorkGroupManagedQueryResultsConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.ManagedStorageEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWorkGroupManagedQueryResultsConfigurationFactory, T4, InnerWorkGroupManagedStorageEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWorkGroupManagedQueryResultsConfigurationFactory, T4> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.ManagedStorageEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerWorkGroupManagedQueryResultsConfigurationFactory, InnerWorkGroupManagedStorageEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWorkGroupManagedQueryResultsConfigurationFactory> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.ManagedStorageEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T5, subFactoryAction).T2);
}
