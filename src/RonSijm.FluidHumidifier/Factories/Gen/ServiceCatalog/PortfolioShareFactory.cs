// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalog;

public class PortfolioShareFactory(string resourceName = null, Action<Humidifier.ServiceCatalog.PortfolioShare> factoryAction = null) : ResourceFactory<Humidifier.ServiceCatalog.PortfolioShare>(resourceName)
{

    protected override Humidifier.ServiceCatalog.PortfolioShare Create()
    {
        var portfolioShareResult = CreatePortfolioShare();
        factoryAction?.Invoke(portfolioShareResult);

        return portfolioShareResult;
    }

    private Humidifier.ServiceCatalog.PortfolioShare CreatePortfolioShare()
    {
        var portfolioShareResult = new Humidifier.ServiceCatalog.PortfolioShare
        {
            GivenName = InputResourceName,
        };

        return portfolioShareResult;
    }

} // End Of Class

public static class PortfolioShareFactoryExtensions
{
}
