// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerVolumeOpenZFSConfigurationFactory(Action<Humidifier.FSx.VolumeTypes.OpenZFSConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.FSx.VolumeTypes.OpenZFSConfiguration>
{

    internal InnerVolumeOriginSnapshotFactory OriginSnapshotFactory { get; set; }

    protected override Humidifier.FSx.VolumeTypes.OpenZFSConfiguration Create()
    {
        var openZFSConfigurationResult = CreateOpenZFSConfiguration();
        factoryAction?.Invoke(openZFSConfigurationResult);

        return openZFSConfigurationResult;
    }

    private Humidifier.FSx.VolumeTypes.OpenZFSConfiguration CreateOpenZFSConfiguration()
    {
        var openZFSConfigurationResult = new Humidifier.FSx.VolumeTypes.OpenZFSConfiguration();

        return openZFSConfigurationResult;
    }
    public override void CreateChildren(Humidifier.FSx.VolumeTypes.OpenZFSConfiguration result)
    {
        base.CreateChildren(result);

        result.OriginSnapshot ??= OriginSnapshotFactory?.Build();
    }

} // End Of Class

public static class InnerVolumeOpenZFSConfigurationFactoryExtensions
{
    public static CombinedResult<InnerVolumeOpenZFSConfigurationFactory, InnerVolumeOriginSnapshotFactory> WithOriginSnapshot(this InnerVolumeOpenZFSConfigurationFactory parentFactory, Action<Humidifier.FSx.VolumeTypes.OriginSnapshot> subFactoryAction = null)
    {
        parentFactory.OriginSnapshotFactory = new InnerVolumeOriginSnapshotFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OriginSnapshotFactory);
    }

    public static CombinedResult<InnerVolumeOpenZFSConfigurationFactory, T1, InnerVolumeOriginSnapshotFactory> WithOriginSnapshot<T1>(this CombinedResult<InnerVolumeOpenZFSConfigurationFactory, T1> combinedResult, Action<Humidifier.FSx.VolumeTypes.OriginSnapshot> subFactoryAction = null) => new (combinedResult, combinedResult, WithOriginSnapshot(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVolumeOpenZFSConfigurationFactory, InnerVolumeOriginSnapshotFactory> WithOriginSnapshot<T1>(this CombinedResult<T1, InnerVolumeOpenZFSConfigurationFactory> combinedResult, Action<Humidifier.FSx.VolumeTypes.OriginSnapshot> subFactoryAction = null) => new (combinedResult, combinedResult, WithOriginSnapshot(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVolumeOpenZFSConfigurationFactory, T1, T2, InnerVolumeOriginSnapshotFactory> WithOriginSnapshot<T1, T2>(this CombinedResult<InnerVolumeOpenZFSConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.FSx.VolumeTypes.OriginSnapshot> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOriginSnapshot(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVolumeOpenZFSConfigurationFactory, T2, InnerVolumeOriginSnapshotFactory> WithOriginSnapshot<T1, T2>(this CombinedResult<T1, InnerVolumeOpenZFSConfigurationFactory, T2> combinedResult, Action<Humidifier.FSx.VolumeTypes.OriginSnapshot> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOriginSnapshot(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVolumeOpenZFSConfigurationFactory, InnerVolumeOriginSnapshotFactory> WithOriginSnapshot<T1, T2>(this CombinedResult<T1, T2, InnerVolumeOpenZFSConfigurationFactory> combinedResult, Action<Humidifier.FSx.VolumeTypes.OriginSnapshot> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOriginSnapshot(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVolumeOpenZFSConfigurationFactory, T1, T2, T3, InnerVolumeOriginSnapshotFactory> WithOriginSnapshot<T1, T2, T3>(this CombinedResult<InnerVolumeOpenZFSConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.FSx.VolumeTypes.OriginSnapshot> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOriginSnapshot(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVolumeOpenZFSConfigurationFactory, T2, T3, InnerVolumeOriginSnapshotFactory> WithOriginSnapshot<T1, T2, T3>(this CombinedResult<T1, InnerVolumeOpenZFSConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.FSx.VolumeTypes.OriginSnapshot> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOriginSnapshot(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVolumeOpenZFSConfigurationFactory, T3, InnerVolumeOriginSnapshotFactory> WithOriginSnapshot<T1, T2, T3>(this CombinedResult<T1, T2, InnerVolumeOpenZFSConfigurationFactory, T3> combinedResult, Action<Humidifier.FSx.VolumeTypes.OriginSnapshot> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOriginSnapshot(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVolumeOpenZFSConfigurationFactory, InnerVolumeOriginSnapshotFactory> WithOriginSnapshot<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVolumeOpenZFSConfigurationFactory> combinedResult, Action<Humidifier.FSx.VolumeTypes.OriginSnapshot> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOriginSnapshot(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVolumeOpenZFSConfigurationFactory, T1, T2, T3, T4, InnerVolumeOriginSnapshotFactory> WithOriginSnapshot<T1, T2, T3, T4>(this CombinedResult<InnerVolumeOpenZFSConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FSx.VolumeTypes.OriginSnapshot> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOriginSnapshot(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVolumeOpenZFSConfigurationFactory, T2, T3, T4, InnerVolumeOriginSnapshotFactory> WithOriginSnapshot<T1, T2, T3, T4>(this CombinedResult<T1, InnerVolumeOpenZFSConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.FSx.VolumeTypes.OriginSnapshot> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOriginSnapshot(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVolumeOpenZFSConfigurationFactory, T3, T4, InnerVolumeOriginSnapshotFactory> WithOriginSnapshot<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVolumeOpenZFSConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.FSx.VolumeTypes.OriginSnapshot> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOriginSnapshot(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVolumeOpenZFSConfigurationFactory, T4, InnerVolumeOriginSnapshotFactory> WithOriginSnapshot<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVolumeOpenZFSConfigurationFactory, T4> combinedResult, Action<Humidifier.FSx.VolumeTypes.OriginSnapshot> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOriginSnapshot(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVolumeOpenZFSConfigurationFactory, InnerVolumeOriginSnapshotFactory> WithOriginSnapshot<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVolumeOpenZFSConfigurationFactory> combinedResult, Action<Humidifier.FSx.VolumeTypes.OriginSnapshot> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOriginSnapshot(combinedResult.T5, subFactoryAction));
}
