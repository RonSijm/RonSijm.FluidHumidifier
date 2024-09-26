// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpsWorks;

public class InnerInstanceEbsBlockDeviceFactory(Action<Humidifier.OpsWorks.InstanceTypes.EbsBlockDevice> factoryAction = null) : SubResourceFactory<Humidifier.OpsWorks.InstanceTypes.EbsBlockDevice>
{

    protected override Humidifier.OpsWorks.InstanceTypes.EbsBlockDevice Create()
    {
        var ebsBlockDeviceResult = CreateEbsBlockDevice();
        factoryAction?.Invoke(ebsBlockDeviceResult);

        return ebsBlockDeviceResult;
    }

    private Humidifier.OpsWorks.InstanceTypes.EbsBlockDevice CreateEbsBlockDevice()
    {
        var ebsBlockDeviceResult = new Humidifier.OpsWorks.InstanceTypes.EbsBlockDevice();

        return ebsBlockDeviceResult;
    }

} // End Of Class

public static class InnerInstanceEbsBlockDeviceFactoryExtensions
{
}
