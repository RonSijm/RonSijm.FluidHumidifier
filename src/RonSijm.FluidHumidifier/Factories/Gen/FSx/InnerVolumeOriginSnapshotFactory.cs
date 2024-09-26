// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerVolumeOriginSnapshotFactory(Action<Humidifier.FSx.VolumeTypes.OriginSnapshot> factoryAction = null) : SubResourceFactory<Humidifier.FSx.VolumeTypes.OriginSnapshot>
{

    protected override Humidifier.FSx.VolumeTypes.OriginSnapshot Create()
    {
        var originSnapshotResult = CreateOriginSnapshot();
        factoryAction?.Invoke(originSnapshotResult);

        return originSnapshotResult;
    }

    private Humidifier.FSx.VolumeTypes.OriginSnapshot CreateOriginSnapshot()
    {
        var originSnapshotResult = new Humidifier.FSx.VolumeTypes.OriginSnapshot();

        return originSnapshotResult;
    }

} // End Of Class

public static class InnerVolumeOriginSnapshotFactoryExtensions
{
}
