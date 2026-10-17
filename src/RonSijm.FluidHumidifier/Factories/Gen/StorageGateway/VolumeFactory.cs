// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.StorageGateway;

public class VolumeFactory(string resourceName = null, Action<Humidifier.StorageGateway.Volume> factoryAction = null) : ResourceFactory<Humidifier.StorageGateway.Volume>(resourceName)
{

    protected override Humidifier.StorageGateway.Volume Create()
    {
        var volumeResult = CreateVolume();
        factoryAction?.Invoke(volumeResult);

        return volumeResult;
    }

    private Humidifier.StorageGateway.Volume CreateVolume()
    {
        var volumeResult = new Humidifier.StorageGateway.Volume
        {
            GivenName = InputResourceName,
        };

        return volumeResult;
    }

} // End Of Class

public static class VolumeFactoryExtensions
{
}
