// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class StorageVirtualMachineFactory(string resourceName = null, Action<Humidifier.FSx.StorageVirtualMachine> factoryAction = null) : ResourceFactory<Humidifier.FSx.StorageVirtualMachine>(resourceName)
{

    internal InnerStorageVirtualMachineActiveDirectoryConfigurationFactory ActiveDirectoryConfigurationFactory { get; set; }

    protected override Humidifier.FSx.StorageVirtualMachine Create()
    {
        var storageVirtualMachineResult = CreateStorageVirtualMachine();
        factoryAction?.Invoke(storageVirtualMachineResult);

        return storageVirtualMachineResult;
    }

    private Humidifier.FSx.StorageVirtualMachine CreateStorageVirtualMachine()
    {
        var storageVirtualMachineResult = new Humidifier.FSx.StorageVirtualMachine
        {
            GivenName = InputResourceName,
        };

        return storageVirtualMachineResult;
    }
    public override void CreateChildren(Humidifier.FSx.StorageVirtualMachine result)
    {
        base.CreateChildren(result);

        result.ActiveDirectoryConfiguration ??= ActiveDirectoryConfigurationFactory?.Build();
    }

} // End Of Class

public static class StorageVirtualMachineFactoryExtensions
{
    public static CombinedResult<StorageVirtualMachineFactory, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory> WithActiveDirectoryConfiguration(this StorageVirtualMachineFactory parentFactory, Action<Humidifier.FSx.StorageVirtualMachineTypes.ActiveDirectoryConfiguration> subFactoryAction = null)
    {
        parentFactory.ActiveDirectoryConfigurationFactory = new InnerStorageVirtualMachineActiveDirectoryConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ActiveDirectoryConfigurationFactory);
    }

    public static CombinedResult<StorageVirtualMachineFactory, T1, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory> WithActiveDirectoryConfiguration<T1>(this CombinedResult<StorageVirtualMachineFactory, T1> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.ActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithActiveDirectoryConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageVirtualMachineFactory, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory> WithActiveDirectoryConfiguration<T1>(this CombinedResult<T1, StorageVirtualMachineFactory> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.ActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithActiveDirectoryConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<StorageVirtualMachineFactory, T1, T2, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory> WithActiveDirectoryConfiguration<T1, T2>(this CombinedResult<StorageVirtualMachineFactory, T1, T2> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.ActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActiveDirectoryConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageVirtualMachineFactory, T2, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory> WithActiveDirectoryConfiguration<T1, T2>(this CombinedResult<T1, StorageVirtualMachineFactory, T2> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.ActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActiveDirectoryConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StorageVirtualMachineFactory, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory> WithActiveDirectoryConfiguration<T1, T2>(this CombinedResult<T1, T2, StorageVirtualMachineFactory> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.ActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActiveDirectoryConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<StorageVirtualMachineFactory, T1, T2, T3, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory> WithActiveDirectoryConfiguration<T1, T2, T3>(this CombinedResult<StorageVirtualMachineFactory, T1, T2, T3> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.ActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActiveDirectoryConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageVirtualMachineFactory, T2, T3, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory> WithActiveDirectoryConfiguration<T1, T2, T3>(this CombinedResult<T1, StorageVirtualMachineFactory, T2, T3> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.ActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActiveDirectoryConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StorageVirtualMachineFactory, T3, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory> WithActiveDirectoryConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, StorageVirtualMachineFactory, T3> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.ActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActiveDirectoryConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StorageVirtualMachineFactory, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory> WithActiveDirectoryConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, StorageVirtualMachineFactory> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.ActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActiveDirectoryConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<StorageVirtualMachineFactory, T1, T2, T3, T4, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory> WithActiveDirectoryConfiguration<T1, T2, T3, T4>(this CombinedResult<StorageVirtualMachineFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.ActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActiveDirectoryConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageVirtualMachineFactory, T2, T3, T4, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory> WithActiveDirectoryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, StorageVirtualMachineFactory, T2, T3, T4> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.ActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActiveDirectoryConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StorageVirtualMachineFactory, T3, T4, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory> WithActiveDirectoryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, StorageVirtualMachineFactory, T3, T4> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.ActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActiveDirectoryConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StorageVirtualMachineFactory, T4, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory> WithActiveDirectoryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, StorageVirtualMachineFactory, T4> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.ActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActiveDirectoryConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, StorageVirtualMachineFactory, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory> WithActiveDirectoryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, StorageVirtualMachineFactory> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.ActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActiveDirectoryConfiguration(combinedResult.T5, subFactoryAction));
}
