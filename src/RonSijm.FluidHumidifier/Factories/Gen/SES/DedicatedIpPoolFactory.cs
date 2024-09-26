// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class DedicatedIpPoolFactory(string resourceName = null, Action<Humidifier.SES.DedicatedIpPool> factoryAction = null) : ResourceFactory<Humidifier.SES.DedicatedIpPool>(resourceName)
{

    protected override Humidifier.SES.DedicatedIpPool Create()
    {
        var dedicatedIpPoolResult = CreateDedicatedIpPool();
        factoryAction?.Invoke(dedicatedIpPoolResult);

        return dedicatedIpPoolResult;
    }

    private Humidifier.SES.DedicatedIpPool CreateDedicatedIpPool()
    {
        var dedicatedIpPoolResult = new Humidifier.SES.DedicatedIpPool
        {
            GivenName = InputResourceName,
        };

        return dedicatedIpPoolResult;
    }

} // End Of Class

public static class DedicatedIpPoolFactoryExtensions
{
}
