// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerInstanceVolumeFactory(Action<Humidifier.EC2.InstanceTypes.Volume> factoryAction = null) : SubResourceFactory<Humidifier.EC2.InstanceTypes.Volume>
{

    protected override Humidifier.EC2.InstanceTypes.Volume Create()
    {
        var volumeResult = CreateVolume();
        factoryAction?.Invoke(volumeResult);

        return volumeResult;
    }

    private Humidifier.EC2.InstanceTypes.Volume CreateVolume()
    {
        var volumeResult = new Humidifier.EC2.InstanceTypes.Volume();

        return volumeResult;
    }

} // End Of Class

public static class InnerInstanceVolumeFactoryExtensions
{
}
