// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AgentRegistry;

public class RegistryRecordFactory(string resourceName = null, Action<Humidifier.AgentRegistry.RegistryRecord> factoryAction = null) : ResourceFactory<Humidifier.AgentRegistry.RegistryRecord>(resourceName)
{

    internal InnerRegistryRecordDescriptorsFactory DescriptorsFactory { get; set; }

    protected override Humidifier.AgentRegistry.RegistryRecord Create()
    {
        var registryRecordResult = CreateRegistryRecord();
        factoryAction?.Invoke(registryRecordResult);

        return registryRecordResult;
    }

    private Humidifier.AgentRegistry.RegistryRecord CreateRegistryRecord()
    {
        var registryRecordResult = new Humidifier.AgentRegistry.RegistryRecord
        {
            GivenName = InputResourceName,
        };

        return registryRecordResult;
    }
    public override void CreateChildren(Humidifier.AgentRegistry.RegistryRecord result)
    {
        base.CreateChildren(result);

        result.Descriptors ??= DescriptorsFactory?.Build();
    }

} // End Of Class

public static class RegistryRecordFactoryExtensions
{
    public static CombinedResult<RegistryRecordFactory, InnerRegistryRecordDescriptorsFactory> WithDescriptors(this RegistryRecordFactory parentFactory, Action<Humidifier.AgentRegistry.RegistryRecordTypes.Descriptors> subFactoryAction = null)
    {
        parentFactory.DescriptorsFactory = new InnerRegistryRecordDescriptorsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DescriptorsFactory);
    }

    public static CombinedResult<RegistryRecordFactory, T1, InnerRegistryRecordDescriptorsFactory> WithDescriptors<T1>(this CombinedResult<RegistryRecordFactory, T1> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.Descriptors> subFactoryAction = null) => new (combinedResult, combinedResult, WithDescriptors(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RegistryRecordFactory, InnerRegistryRecordDescriptorsFactory> WithDescriptors<T1>(this CombinedResult<T1, RegistryRecordFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.Descriptors> subFactoryAction = null) => new (combinedResult, combinedResult, WithDescriptors(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<RegistryRecordFactory, T1, T2, InnerRegistryRecordDescriptorsFactory> WithDescriptors<T1, T2>(this CombinedResult<RegistryRecordFactory, T1, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.Descriptors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDescriptors(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RegistryRecordFactory, T2, InnerRegistryRecordDescriptorsFactory> WithDescriptors<T1, T2>(this CombinedResult<T1, RegistryRecordFactory, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.Descriptors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDescriptors(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RegistryRecordFactory, InnerRegistryRecordDescriptorsFactory> WithDescriptors<T1, T2>(this CombinedResult<T1, T2, RegistryRecordFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.Descriptors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDescriptors(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<RegistryRecordFactory, T1, T2, T3, InnerRegistryRecordDescriptorsFactory> WithDescriptors<T1, T2, T3>(this CombinedResult<RegistryRecordFactory, T1, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.Descriptors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDescriptors(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RegistryRecordFactory, T2, T3, InnerRegistryRecordDescriptorsFactory> WithDescriptors<T1, T2, T3>(this CombinedResult<T1, RegistryRecordFactory, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.Descriptors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDescriptors(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RegistryRecordFactory, T3, InnerRegistryRecordDescriptorsFactory> WithDescriptors<T1, T2, T3>(this CombinedResult<T1, T2, RegistryRecordFactory, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.Descriptors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDescriptors(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RegistryRecordFactory, InnerRegistryRecordDescriptorsFactory> WithDescriptors<T1, T2, T3>(this CombinedResult<T1, T2, T3, RegistryRecordFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.Descriptors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDescriptors(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<RegistryRecordFactory, T1, T2, T3, T4, InnerRegistryRecordDescriptorsFactory> WithDescriptors<T1, T2, T3, T4>(this CombinedResult<RegistryRecordFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.Descriptors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDescriptors(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RegistryRecordFactory, T2, T3, T4, InnerRegistryRecordDescriptorsFactory> WithDescriptors<T1, T2, T3, T4>(this CombinedResult<T1, RegistryRecordFactory, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.Descriptors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDescriptors(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RegistryRecordFactory, T3, T4, InnerRegistryRecordDescriptorsFactory> WithDescriptors<T1, T2, T3, T4>(this CombinedResult<T1, T2, RegistryRecordFactory, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.Descriptors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDescriptors(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RegistryRecordFactory, T4, InnerRegistryRecordDescriptorsFactory> WithDescriptors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RegistryRecordFactory, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.Descriptors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDescriptors(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, RegistryRecordFactory, InnerRegistryRecordDescriptorsFactory> WithDescriptors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RegistryRecordFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.Descriptors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDescriptors(combinedResult.T5, subFactoryAction).T2);
}
