// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class VpcConnectionFactory(string resourceName = null, Action<Humidifier.MSK.VpcConnection> factoryAction = null) : ResourceFactory<Humidifier.MSK.VpcConnection>(resourceName)
{

    protected override Humidifier.MSK.VpcConnection Create()
    {
        var vpcConnectionResult = CreateVpcConnection();
        factoryAction?.Invoke(vpcConnectionResult);

        return vpcConnectionResult;
    }

    private Humidifier.MSK.VpcConnection CreateVpcConnection()
    {
        var vpcConnectionResult = new Humidifier.MSK.VpcConnection
        {
            GivenName = InputResourceName,
        };

        return vpcConnectionResult;
    }

} // End Of Class

public static class VpcConnectionFactoryExtensions
{
}
