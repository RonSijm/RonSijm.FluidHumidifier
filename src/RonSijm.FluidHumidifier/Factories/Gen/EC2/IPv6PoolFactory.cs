// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class IPv6PoolFactory(string resourceName = null, Action<Humidifier.EC2.IPv6Pool> factoryAction = null) : ResourceFactory<Humidifier.EC2.IPv6Pool>(resourceName)
{

    protected override Humidifier.EC2.IPv6Pool Create()
    {
        var iPv6PoolResult = CreateIPv6Pool();
        factoryAction?.Invoke(iPv6PoolResult);

        return iPv6PoolResult;
    }

    private Humidifier.EC2.IPv6Pool CreateIPv6Pool()
    {
        var iPv6PoolResult = new Humidifier.EC2.IPv6Pool
        {
            GivenName = InputResourceName,
        };

        return iPv6PoolResult;
    }

} // End Of Class

public static class IPv6PoolFactoryExtensions
{
}
