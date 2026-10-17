// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class HostKeyFactory(string resourceName = null, Action<Humidifier.Transfer.HostKey> factoryAction = null) : ResourceFactory<Humidifier.Transfer.HostKey>(resourceName)
{

    protected override Humidifier.Transfer.HostKey Create()
    {
        var hostKeyResult = CreateHostKey();
        factoryAction?.Invoke(hostKeyResult);

        return hostKeyResult;
    }

    private Humidifier.Transfer.HostKey CreateHostKey()
    {
        var hostKeyResult = new Humidifier.Transfer.HostKey
        {
            GivenName = InputResourceName,
        };

        return hostKeyResult;
    }

} // End Of Class

public static class HostKeyFactoryExtensions
{
}
