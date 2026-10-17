// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class IPv4PoolFactory(string resourceName = null, Action<Humidifier.EC2.IPv4Pool> factoryAction = null) : ResourceFactory<Humidifier.EC2.IPv4Pool>(resourceName)
{

    protected override Humidifier.EC2.IPv4Pool Create()
    {
        var iPv4PoolResult = CreateIPv4Pool();
        factoryAction?.Invoke(iPv4PoolResult);

        return iPv4PoolResult;
    }

    private Humidifier.EC2.IPv4Pool CreateIPv4Pool()
    {
        var iPv4PoolResult = new Humidifier.EC2.IPv4Pool
        {
            GivenName = InputResourceName,
        };

        return iPv4PoolResult;
    }

} // End Of Class

public static class IPv4PoolFactoryExtensions
{
}
