// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkspacesInstances;

public class VolumeFactory(string resourceName = null, Action<Humidifier.WorkspacesInstances.Volume> factoryAction = null) : ResourceFactory<Humidifier.WorkspacesInstances.Volume>(resourceName)
{

    internal List<InnerVolumeTagSpecificationFactory> TagSpecificationsFactories { get; set; } = [];

    protected override Humidifier.WorkspacesInstances.Volume Create()
    {
        var volumeResult = CreateVolume();
        factoryAction?.Invoke(volumeResult);

        return volumeResult;
    }

    private Humidifier.WorkspacesInstances.Volume CreateVolume()
    {
        var volumeResult = new Humidifier.WorkspacesInstances.Volume
        {
            GivenName = InputResourceName,
        };

        return volumeResult;
    }
    public override void CreateChildren(Humidifier.WorkspacesInstances.Volume result)
    {
        base.CreateChildren(result);

        result.TagSpecifications = TagSpecificationsFactories.Any() ? TagSpecificationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class VolumeFactoryExtensions
{
    public static CombinedResult<VolumeFactory, InnerVolumeTagSpecificationFactory> WithTagSpecifications(this VolumeFactory parentFactory, Action<Humidifier.WorkspacesInstances.VolumeTypes.TagSpecification> subFactoryAction = null)
    {
        var factory = new InnerVolumeTagSpecificationFactory(subFactoryAction);
        parentFactory.TagSpecificationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<VolumeFactory, T1, InnerVolumeTagSpecificationFactory> WithTagSpecifications<T1>(this CombinedResult<VolumeFactory, T1> combinedResult, Action<Humidifier.WorkspacesInstances.VolumeTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithTagSpecifications(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VolumeFactory, InnerVolumeTagSpecificationFactory> WithTagSpecifications<T1>(this CombinedResult<T1, VolumeFactory> combinedResult, Action<Humidifier.WorkspacesInstances.VolumeTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithTagSpecifications(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<VolumeFactory, T1, T2, InnerVolumeTagSpecificationFactory> WithTagSpecifications<T1, T2>(this CombinedResult<VolumeFactory, T1, T2> combinedResult, Action<Humidifier.WorkspacesInstances.VolumeTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VolumeFactory, T2, InnerVolumeTagSpecificationFactory> WithTagSpecifications<T1, T2>(this CombinedResult<T1, VolumeFactory, T2> combinedResult, Action<Humidifier.WorkspacesInstances.VolumeTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VolumeFactory, InnerVolumeTagSpecificationFactory> WithTagSpecifications<T1, T2>(this CombinedResult<T1, T2, VolumeFactory> combinedResult, Action<Humidifier.WorkspacesInstances.VolumeTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<VolumeFactory, T1, T2, T3, InnerVolumeTagSpecificationFactory> WithTagSpecifications<T1, T2, T3>(this CombinedResult<VolumeFactory, T1, T2, T3> combinedResult, Action<Humidifier.WorkspacesInstances.VolumeTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VolumeFactory, T2, T3, InnerVolumeTagSpecificationFactory> WithTagSpecifications<T1, T2, T3>(this CombinedResult<T1, VolumeFactory, T2, T3> combinedResult, Action<Humidifier.WorkspacesInstances.VolumeTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VolumeFactory, T3, InnerVolumeTagSpecificationFactory> WithTagSpecifications<T1, T2, T3>(this CombinedResult<T1, T2, VolumeFactory, T3> combinedResult, Action<Humidifier.WorkspacesInstances.VolumeTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, VolumeFactory, InnerVolumeTagSpecificationFactory> WithTagSpecifications<T1, T2, T3>(this CombinedResult<T1, T2, T3, VolumeFactory> combinedResult, Action<Humidifier.WorkspacesInstances.VolumeTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<VolumeFactory, T1, T2, T3, T4, InnerVolumeTagSpecificationFactory> WithTagSpecifications<T1, T2, T3, T4>(this CombinedResult<VolumeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WorkspacesInstances.VolumeTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VolumeFactory, T2, T3, T4, InnerVolumeTagSpecificationFactory> WithTagSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, VolumeFactory, T2, T3, T4> combinedResult, Action<Humidifier.WorkspacesInstances.VolumeTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VolumeFactory, T3, T4, InnerVolumeTagSpecificationFactory> WithTagSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, VolumeFactory, T3, T4> combinedResult, Action<Humidifier.WorkspacesInstances.VolumeTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, VolumeFactory, T4, InnerVolumeTagSpecificationFactory> WithTagSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VolumeFactory, T4> combinedResult, Action<Humidifier.WorkspacesInstances.VolumeTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, VolumeFactory, InnerVolumeTagSpecificationFactory> WithTagSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VolumeFactory> combinedResult, Action<Humidifier.WorkspacesInstances.VolumeTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T5, subFactoryAction).T2);
}
