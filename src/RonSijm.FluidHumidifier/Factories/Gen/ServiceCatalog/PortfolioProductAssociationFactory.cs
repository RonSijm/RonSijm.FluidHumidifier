// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalog;

public class PortfolioProductAssociationFactory(string resourceName = null, Action<Humidifier.ServiceCatalog.PortfolioProductAssociation> factoryAction = null) : ResourceFactory<Humidifier.ServiceCatalog.PortfolioProductAssociation>(resourceName)
{

    protected override Humidifier.ServiceCatalog.PortfolioProductAssociation Create()
    {
        var portfolioProductAssociationResult = CreatePortfolioProductAssociation();
        factoryAction?.Invoke(portfolioProductAssociationResult);

        return portfolioProductAssociationResult;
    }

    private Humidifier.ServiceCatalog.PortfolioProductAssociation CreatePortfolioProductAssociation()
    {
        var portfolioProductAssociationResult = new Humidifier.ServiceCatalog.PortfolioProductAssociation
        {
            GivenName = InputResourceName,
        };

        return portfolioProductAssociationResult;
    }

} // End Of Class

public static class PortfolioProductAssociationFactoryExtensions
{
}
