// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpsWorks;

public class VolumeFactory(string resourceName = null, Action<Humidifier.OpsWorks.Volume> factoryAction = null) : ResourceFactory<Humidifier.OpsWorks.Volume>(resourceName)
{

    protected override Humidifier.OpsWorks.Volume Create()
    {
        var volumeResult = CreateVolume();
        factoryAction?.Invoke(volumeResult);

        return volumeResult;
    }

    private Humidifier.OpsWorks.Volume CreateVolume()
    {
        var volumeResult = new Humidifier.OpsWorks.Volume
        {
            GivenName = InputResourceName,
        };

        return volumeResult;
    }

} // End Of Class

public static class VolumeFactoryExtensions
{
}
