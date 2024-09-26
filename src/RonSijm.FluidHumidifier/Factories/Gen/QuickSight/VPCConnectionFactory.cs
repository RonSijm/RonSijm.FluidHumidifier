// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class VPCConnectionFactory(string resourceName = null, Action<Humidifier.QuickSight.VPCConnection> factoryAction = null) : ResourceFactory<Humidifier.QuickSight.VPCConnection>(resourceName)
{

    protected override Humidifier.QuickSight.VPCConnection Create()
    {
        var vPCConnectionResult = CreateVPCConnection();
        factoryAction?.Invoke(vPCConnectionResult);

        return vPCConnectionResult;
    }

    private Humidifier.QuickSight.VPCConnection CreateVPCConnection()
    {
        var vPCConnectionResult = new Humidifier.QuickSight.VPCConnection
        {
            GivenName = InputResourceName,
        };

        return vPCConnectionResult;
    }

} // End Of Class

public static class VPCConnectionFactoryExtensions
{
}
