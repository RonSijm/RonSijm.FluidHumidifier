// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InnerInstanceAutoSnapshotAddOnFactory(Action<Humidifier.Lightsail.InstanceTypes.AutoSnapshotAddOn> factoryAction = null) : SubResourceFactory<Humidifier.Lightsail.InstanceTypes.AutoSnapshotAddOn>
{

    protected override Humidifier.Lightsail.InstanceTypes.AutoSnapshotAddOn Create()
    {
        var autoSnapshotAddOnResult = CreateAutoSnapshotAddOn();
        factoryAction?.Invoke(autoSnapshotAddOnResult);

        return autoSnapshotAddOnResult;
    }

    private Humidifier.Lightsail.InstanceTypes.AutoSnapshotAddOn CreateAutoSnapshotAddOn()
    {
        var autoSnapshotAddOnResult = new Humidifier.Lightsail.InstanceTypes.AutoSnapshotAddOn();

        return autoSnapshotAddOnResult;
    }

} // End Of Class

public static class InnerInstanceAutoSnapshotAddOnFactoryExtensions
{
}
