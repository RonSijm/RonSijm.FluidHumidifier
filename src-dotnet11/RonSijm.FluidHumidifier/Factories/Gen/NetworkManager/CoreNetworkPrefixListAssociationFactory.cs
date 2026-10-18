// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class CoreNetworkPrefixListAssociationFactory(string resourceName = null, Action<Humidifier.NetworkManager.CoreNetworkPrefixListAssociation> factoryAction = null) : ResourceFactory<Humidifier.NetworkManager.CoreNetworkPrefixListAssociation>(resourceName)
{

    protected override Humidifier.NetworkManager.CoreNetworkPrefixListAssociation Create()
    {
        var coreNetworkPrefixListAssociationResult = CreateCoreNetworkPrefixListAssociation();
        factoryAction?.Invoke(coreNetworkPrefixListAssociationResult);

        return coreNetworkPrefixListAssociationResult;
    }

    private Humidifier.NetworkManager.CoreNetworkPrefixListAssociation CreateCoreNetworkPrefixListAssociation()
    {
        var coreNetworkPrefixListAssociationResult = new Humidifier.NetworkManager.CoreNetworkPrefixListAssociation
        {
            GivenName = InputResourceName,
        };

        return coreNetworkPrefixListAssociationResult;
    }

} // End Of Class

public static class CoreNetworkPrefixListAssociationFactoryExtensions
{
}
