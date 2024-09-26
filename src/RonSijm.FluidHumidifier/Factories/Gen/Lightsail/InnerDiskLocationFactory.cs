// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InnerDiskLocationFactory(Action<Humidifier.Lightsail.DiskTypes.Location> factoryAction = null) : SubResourceFactory<Humidifier.Lightsail.DiskTypes.Location>
{

    protected override Humidifier.Lightsail.DiskTypes.Location Create()
    {
        var locationResult = CreateLocation();
        factoryAction?.Invoke(locationResult);

        return locationResult;
    }

    private Humidifier.Lightsail.DiskTypes.Location CreateLocation()
    {
        var locationResult = new Humidifier.Lightsail.DiskTypes.Location();

        return locationResult;
    }

} // End Of Class

public static class InnerDiskLocationFactoryExtensions
{
}
