// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class HostFactory(string resourceName = null, Action<Humidifier.EC2.Host> factoryAction = null) : ResourceFactory<Humidifier.EC2.Host>(resourceName)
{

    protected override Humidifier.EC2.Host Create()
    {
        var hostResult = CreateHost();
        factoryAction?.Invoke(hostResult);

        return hostResult;
    }

    private Humidifier.EC2.Host CreateHost()
    {
        var hostResult = new Humidifier.EC2.Host
        {
            GivenName = InputResourceName,
        };

        return hostResult;
    }

} // End Of Class

public static class HostFactoryExtensions
{
}
