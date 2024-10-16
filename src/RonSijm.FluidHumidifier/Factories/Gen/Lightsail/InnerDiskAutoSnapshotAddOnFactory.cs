// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InnerDiskAutoSnapshotAddOnFactory(Action<Humidifier.Lightsail.DiskTypes.AutoSnapshotAddOn> factoryAction = null) : SubResourceFactory<Humidifier.Lightsail.DiskTypes.AutoSnapshotAddOn>
{

    protected override Humidifier.Lightsail.DiskTypes.AutoSnapshotAddOn Create()
    {
        var autoSnapshotAddOnResult = CreateAutoSnapshotAddOn();
        factoryAction?.Invoke(autoSnapshotAddOnResult);

        return autoSnapshotAddOnResult;
    }

    private Humidifier.Lightsail.DiskTypes.AutoSnapshotAddOn CreateAutoSnapshotAddOn()
    {
        var autoSnapshotAddOnResult = new Humidifier.Lightsail.DiskTypes.AutoSnapshotAddOn();

        return autoSnapshotAddOnResult;
    }

} // End Of Class

public static class InnerDiskAutoSnapshotAddOnFactoryExtensions
{
}
