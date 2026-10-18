// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceDiscovery;

public class InstanceFactory(string resourceName = null, Action<Humidifier.ServiceDiscovery.Instance> factoryAction = null) : ResourceFactory<Humidifier.ServiceDiscovery.Instance>(resourceName)
{

    protected override Humidifier.ServiceDiscovery.Instance Create()
    {
        var instanceResult = CreateInstance();
        factoryAction?.Invoke(instanceResult);

        return instanceResult;
    }

    private Humidifier.ServiceDiscovery.Instance CreateInstance()
    {
        var instanceResult = new Humidifier.ServiceDiscovery.Instance
        {
            GivenName = InputResourceName,
        };

        return instanceResult;
    }

} // End Of Class

public static class InstanceFactoryExtensions
{
}
