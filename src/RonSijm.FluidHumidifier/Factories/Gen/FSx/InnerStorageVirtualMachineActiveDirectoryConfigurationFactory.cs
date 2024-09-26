// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerStorageVirtualMachineActiveDirectoryConfigurationFactory(Action<Humidifier.FSx.StorageVirtualMachineTypes.ActiveDirectoryConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.FSx.StorageVirtualMachineTypes.ActiveDirectoryConfiguration>
{

    internal InnerStorageVirtualMachineSelfManagedActiveDirectoryConfigurationFactory SelfManagedActiveDirectoryConfigurationFactory { get; set; }

    protected override Humidifier.FSx.StorageVirtualMachineTypes.ActiveDirectoryConfiguration Create()
    {
        var activeDirectoryConfigurationResult = CreateActiveDirectoryConfiguration();
        factoryAction?.Invoke(activeDirectoryConfigurationResult);

        return activeDirectoryConfigurationResult;
    }

    private Humidifier.FSx.StorageVirtualMachineTypes.ActiveDirectoryConfiguration CreateActiveDirectoryConfiguration()
    {
        var activeDirectoryConfigurationResult = new Humidifier.FSx.StorageVirtualMachineTypes.ActiveDirectoryConfiguration();

        return activeDirectoryConfigurationResult;
    }
    public override void CreateChildren(Humidifier.FSx.StorageVirtualMachineTypes.ActiveDirectoryConfiguration result)
    {
        base.CreateChildren(result);

        result.SelfManagedActiveDirectoryConfiguration ??= SelfManagedActiveDirectoryConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerStorageVirtualMachineActiveDirectoryConfigurationFactoryExtensions
{
    public static CombinedResult<InnerStorageVirtualMachineActiveDirectoryConfigurationFactory, InnerStorageVirtualMachineSelfManagedActiveDirectoryConfigurationFactory> WithSelfManagedActiveDirectoryConfiguration(this InnerStorageVirtualMachineActiveDirectoryConfigurationFactory parentFactory, Action<Humidifier.FSx.StorageVirtualMachineTypes.SelfManagedActiveDirectoryConfiguration> subFactoryAction = null)
    {
        parentFactory.SelfManagedActiveDirectoryConfigurationFactory = new InnerStorageVirtualMachineSelfManagedActiveDirectoryConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SelfManagedActiveDirectoryConfigurationFactory);
    }

    public static CombinedResult<InnerStorageVirtualMachineActiveDirectoryConfigurationFactory, T1, InnerStorageVirtualMachineSelfManagedActiveDirectoryConfigurationFactory> WithSelfManagedActiveDirectoryConfiguration<T1>(this CombinedResult<InnerStorageVirtualMachineActiveDirectoryConfigurationFactory, T1> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.SelfManagedActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSelfManagedActiveDirectoryConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory, InnerStorageVirtualMachineSelfManagedActiveDirectoryConfigurationFactory> WithSelfManagedActiveDirectoryConfiguration<T1>(this CombinedResult<T1, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.SelfManagedActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSelfManagedActiveDirectoryConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerStorageVirtualMachineActiveDirectoryConfigurationFactory, T1, T2, InnerStorageVirtualMachineSelfManagedActiveDirectoryConfigurationFactory> WithSelfManagedActiveDirectoryConfiguration<T1, T2>(this CombinedResult<InnerStorageVirtualMachineActiveDirectoryConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.SelfManagedActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSelfManagedActiveDirectoryConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory, T2, InnerStorageVirtualMachineSelfManagedActiveDirectoryConfigurationFactory> WithSelfManagedActiveDirectoryConfiguration<T1, T2>(this CombinedResult<T1, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory, T2> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.SelfManagedActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSelfManagedActiveDirectoryConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory, InnerStorageVirtualMachineSelfManagedActiveDirectoryConfigurationFactory> WithSelfManagedActiveDirectoryConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.SelfManagedActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSelfManagedActiveDirectoryConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerStorageVirtualMachineActiveDirectoryConfigurationFactory, T1, T2, T3, InnerStorageVirtualMachineSelfManagedActiveDirectoryConfigurationFactory> WithSelfManagedActiveDirectoryConfiguration<T1, T2, T3>(this CombinedResult<InnerStorageVirtualMachineActiveDirectoryConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.SelfManagedActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelfManagedActiveDirectoryConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory, T2, T3, InnerStorageVirtualMachineSelfManagedActiveDirectoryConfigurationFactory> WithSelfManagedActiveDirectoryConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.SelfManagedActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelfManagedActiveDirectoryConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory, T3, InnerStorageVirtualMachineSelfManagedActiveDirectoryConfigurationFactory> WithSelfManagedActiveDirectoryConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory, T3> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.SelfManagedActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelfManagedActiveDirectoryConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory, InnerStorageVirtualMachineSelfManagedActiveDirectoryConfigurationFactory> WithSelfManagedActiveDirectoryConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.SelfManagedActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelfManagedActiveDirectoryConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerStorageVirtualMachineActiveDirectoryConfigurationFactory, T1, T2, T3, T4, InnerStorageVirtualMachineSelfManagedActiveDirectoryConfigurationFactory> WithSelfManagedActiveDirectoryConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerStorageVirtualMachineActiveDirectoryConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.SelfManagedActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelfManagedActiveDirectoryConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory, T2, T3, T4, InnerStorageVirtualMachineSelfManagedActiveDirectoryConfigurationFactory> WithSelfManagedActiveDirectoryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.SelfManagedActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelfManagedActiveDirectoryConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory, T3, T4, InnerStorageVirtualMachineSelfManagedActiveDirectoryConfigurationFactory> WithSelfManagedActiveDirectoryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.SelfManagedActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelfManagedActiveDirectoryConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory, T4, InnerStorageVirtualMachineSelfManagedActiveDirectoryConfigurationFactory> WithSelfManagedActiveDirectoryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory, T4> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.SelfManagedActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelfManagedActiveDirectoryConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory, InnerStorageVirtualMachineSelfManagedActiveDirectoryConfigurationFactory> WithSelfManagedActiveDirectoryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerStorageVirtualMachineActiveDirectoryConfigurationFactory> combinedResult, Action<Humidifier.FSx.StorageVirtualMachineTypes.SelfManagedActiveDirectoryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelfManagedActiveDirectoryConfiguration(combinedResult.T5, subFactoryAction));
}
