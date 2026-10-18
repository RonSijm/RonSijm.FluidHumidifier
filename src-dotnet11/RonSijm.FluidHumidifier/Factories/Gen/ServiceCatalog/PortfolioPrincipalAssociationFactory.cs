// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalog;

public class PortfolioPrincipalAssociationFactory(string resourceName = null, Action<Humidifier.ServiceCatalog.PortfolioPrincipalAssociation> factoryAction = null) : ResourceFactory<Humidifier.ServiceCatalog.PortfolioPrincipalAssociation>(resourceName)
{

    protected override Humidifier.ServiceCatalog.PortfolioPrincipalAssociation Create()
    {
        var portfolioPrincipalAssociationResult = CreatePortfolioPrincipalAssociation();
        factoryAction?.Invoke(portfolioPrincipalAssociationResult);

        return portfolioPrincipalAssociationResult;
    }

    private Humidifier.ServiceCatalog.PortfolioPrincipalAssociation CreatePortfolioPrincipalAssociation()
    {
        var portfolioPrincipalAssociationResult = new Humidifier.ServiceCatalog.PortfolioPrincipalAssociation
        {
            GivenName = InputResourceName,
        };

        return portfolioPrincipalAssociationResult;
    }

} // End Of Class

public static class PortfolioPrincipalAssociationFactoryExtensions
{
}
