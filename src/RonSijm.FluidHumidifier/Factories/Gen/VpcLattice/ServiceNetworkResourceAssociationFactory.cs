// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class ServiceNetworkResourceAssociationFactory(string resourceName = null, Action<Humidifier.VpcLattice.ServiceNetworkResourceAssociation> factoryAction = null) : ResourceFactory<Humidifier.VpcLattice.ServiceNetworkResourceAssociation>(resourceName)
{

    protected override Humidifier.VpcLattice.ServiceNetworkResourceAssociation Create()
    {
        var serviceNetworkResourceAssociationResult = CreateServiceNetworkResourceAssociation();
        factoryAction?.Invoke(serviceNetworkResourceAssociationResult);

        return serviceNetworkResourceAssociationResult;
    }

    private Humidifier.VpcLattice.ServiceNetworkResourceAssociation CreateServiceNetworkResourceAssociation()
    {
        var serviceNetworkResourceAssociationResult = new Humidifier.VpcLattice.ServiceNetworkResourceAssociation
        {
            GivenName = InputResourceName,
        };

        return serviceNetworkResourceAssociationResult;
    }

} // End Of Class

public static class ServiceNetworkResourceAssociationFactoryExtensions
{
}
