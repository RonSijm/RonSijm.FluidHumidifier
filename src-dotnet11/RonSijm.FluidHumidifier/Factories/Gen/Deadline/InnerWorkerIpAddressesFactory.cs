// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerWorkerIpAddressesFactory(Action<Humidifier.Deadline.WorkerTypes.IpAddresses> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.WorkerTypes.IpAddresses>
{

    protected override Humidifier.Deadline.WorkerTypes.IpAddresses Create()
    {
        var ipAddressesResult = CreateIpAddresses();
        factoryAction?.Invoke(ipAddressesResult);

        return ipAddressesResult;
    }

    private Humidifier.Deadline.WorkerTypes.IpAddresses CreateIpAddresses()
    {
        var ipAddressesResult = new Humidifier.Deadline.WorkerTypes.IpAddresses();

        return ipAddressesResult;
    }

} // End Of Class

public static class InnerWorkerIpAddressesFactoryExtensions
{
}
