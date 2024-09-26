// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class LinkAssociationFactory(string resourceName = null, Action<Humidifier.NetworkManager.LinkAssociation> factoryAction = null) : ResourceFactory<Humidifier.NetworkManager.LinkAssociation>(resourceName)
{

    protected override Humidifier.NetworkManager.LinkAssociation Create()
    {
        var linkAssociationResult = CreateLinkAssociation();
        factoryAction?.Invoke(linkAssociationResult);

        return linkAssociationResult;
    }

    private Humidifier.NetworkManager.LinkAssociation CreateLinkAssociation()
    {
        var linkAssociationResult = new Humidifier.NetworkManager.LinkAssociation
        {
            GivenName = InputResourceName,
        };

        return linkAssociationResult;
    }

} // End Of Class

public static class LinkAssociationFactoryExtensions
{
}
