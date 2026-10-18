// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VolumeFactory(string resourceName = null, Action<Humidifier.EC2.Volume> factoryAction = null) : ResourceFactory<Humidifier.EC2.Volume>(resourceName)
{

    protected override Humidifier.EC2.Volume Create()
    {
        var volumeResult = CreateVolume();
        factoryAction?.Invoke(volumeResult);

        return volumeResult;
    }

    private Humidifier.EC2.Volume CreateVolume()
    {
        var volumeResult = new Humidifier.EC2.Volume
        {
            GivenName = InputResourceName,
        };

        return volumeResult;
    }

} // End Of Class

public static class VolumeFactoryExtensions
{
}
