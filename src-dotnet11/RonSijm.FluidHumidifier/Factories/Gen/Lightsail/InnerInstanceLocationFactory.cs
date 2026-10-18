// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InnerInstanceLocationFactory(Action<Humidifier.Lightsail.InstanceTypes.Location> factoryAction = null) : SubResourceFactory<Humidifier.Lightsail.InstanceTypes.Location>
{

    protected override Humidifier.Lightsail.InstanceTypes.Location Create()
    {
        var locationResult = CreateLocation();
        factoryAction?.Invoke(locationResult);

        return locationResult;
    }

    private Humidifier.Lightsail.InstanceTypes.Location CreateLocation()
    {
        var locationResult = new Humidifier.Lightsail.InstanceTypes.Location();

        return locationResult;
    }

} // End Of Class

public static class InnerInstanceLocationFactoryExtensions
{
}
