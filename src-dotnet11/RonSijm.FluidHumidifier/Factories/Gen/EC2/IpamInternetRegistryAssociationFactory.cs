// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class IpamInternetRegistryAssociationFactory(string resourceName = null, Action<Humidifier.EC2.IpamInternetRegistryAssociation> factoryAction = null) : ResourceFactory<Humidifier.EC2.IpamInternetRegistryAssociation>(resourceName)
{

    protected override Humidifier.EC2.IpamInternetRegistryAssociation Create()
    {
        var ipamInternetRegistryAssociationResult = CreateIpamInternetRegistryAssociation();
        factoryAction?.Invoke(ipamInternetRegistryAssociationResult);

        return ipamInternetRegistryAssociationResult;
    }

    private Humidifier.EC2.IpamInternetRegistryAssociation CreateIpamInternetRegistryAssociation()
    {
        var ipamInternetRegistryAssociationResult = new Humidifier.EC2.IpamInternetRegistryAssociation
        {
            GivenName = InputResourceName,
        };

        return ipamInternetRegistryAssociationResult;
    }

} // End Of Class

public static class IpamInternetRegistryAssociationFactoryExtensions
{
}
