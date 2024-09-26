// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class ServiceNetworkFactory(string resourceName = null, Action<Humidifier.VpcLattice.ServiceNetwork> factoryAction = null) : ResourceFactory<Humidifier.VpcLattice.ServiceNetwork>(resourceName)
{

    protected override Humidifier.VpcLattice.ServiceNetwork Create()
    {
        var serviceNetworkResult = CreateServiceNetwork();
        factoryAction?.Invoke(serviceNetworkResult);

        return serviceNetworkResult;
    }

    private Humidifier.VpcLattice.ServiceNetwork CreateServiceNetwork()
    {
        var serviceNetworkResult = new Humidifier.VpcLattice.ServiceNetwork
        {
            GivenName = InputResourceName,
        };

        return serviceNetworkResult;
    }

} // End Of Class

public static class ServiceNetworkFactoryExtensions
{
}
