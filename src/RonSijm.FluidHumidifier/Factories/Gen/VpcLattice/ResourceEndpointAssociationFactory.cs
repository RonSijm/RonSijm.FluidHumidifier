// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class ResourceEndpointAssociationFactory(string resourceName = null, Action<Humidifier.VpcLattice.ResourceEndpointAssociation> factoryAction = null) : ResourceFactory<Humidifier.VpcLattice.ResourceEndpointAssociation>(resourceName)
{

    protected override Humidifier.VpcLattice.ResourceEndpointAssociation Create()
    {
        var resourceEndpointAssociationResult = CreateResourceEndpointAssociation();
        factoryAction?.Invoke(resourceEndpointAssociationResult);

        return resourceEndpointAssociationResult;
    }

    private Humidifier.VpcLattice.ResourceEndpointAssociation CreateResourceEndpointAssociation()
    {
        var resourceEndpointAssociationResult = new Humidifier.VpcLattice.ResourceEndpointAssociation
        {
            GivenName = InputResourceName,
        };

        return resourceEndpointAssociationResult;
    }

} // End Of Class

public static class ResourceEndpointAssociationFactoryExtensions
{
}
