// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RAM;

public class ResourceAssociationFactory(string resourceName = null, Action<Humidifier.RAM.ResourceAssociation> factoryAction = null) : ResourceFactory<Humidifier.RAM.ResourceAssociation>(resourceName)
{

    protected override Humidifier.RAM.ResourceAssociation Create()
    {
        var resourceAssociationResult = CreateResourceAssociation();
        factoryAction?.Invoke(resourceAssociationResult);

        return resourceAssociationResult;
    }

    private Humidifier.RAM.ResourceAssociation CreateResourceAssociation()
    {
        var resourceAssociationResult = new Humidifier.RAM.ResourceAssociation
        {
            GivenName = InputResourceName,
        };

        return resourceAssociationResult;
    }

} // End Of Class

public static class ResourceAssociationFactoryExtensions
{
}
