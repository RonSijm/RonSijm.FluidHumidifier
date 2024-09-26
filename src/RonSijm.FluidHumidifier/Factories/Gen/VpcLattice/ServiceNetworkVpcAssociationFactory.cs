// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class ServiceNetworkVpcAssociationFactory(string resourceName = null, Action<Humidifier.VpcLattice.ServiceNetworkVpcAssociation> factoryAction = null) : ResourceFactory<Humidifier.VpcLattice.ServiceNetworkVpcAssociation>(resourceName)
{

    protected override Humidifier.VpcLattice.ServiceNetworkVpcAssociation Create()
    {
        var serviceNetworkVpcAssociationResult = CreateServiceNetworkVpcAssociation();
        factoryAction?.Invoke(serviceNetworkVpcAssociationResult);

        return serviceNetworkVpcAssociationResult;
    }

    private Humidifier.VpcLattice.ServiceNetworkVpcAssociation CreateServiceNetworkVpcAssociation()
    {
        var serviceNetworkVpcAssociationResult = new Humidifier.VpcLattice.ServiceNetworkVpcAssociation
        {
            GivenName = InputResourceName,
        };

        return serviceNetworkVpcAssociationResult;
    }

} // End Of Class

public static class ServiceNetworkVpcAssociationFactoryExtensions
{
}
