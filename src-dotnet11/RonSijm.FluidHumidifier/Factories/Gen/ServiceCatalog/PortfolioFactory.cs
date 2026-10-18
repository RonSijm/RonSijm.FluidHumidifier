// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalog;

public class PortfolioFactory(string resourceName = null, Action<Humidifier.ServiceCatalog.Portfolio> factoryAction = null) : ResourceFactory<Humidifier.ServiceCatalog.Portfolio>(resourceName)
{

    protected override Humidifier.ServiceCatalog.Portfolio Create()
    {
        var portfolioResult = CreatePortfolio();
        factoryAction?.Invoke(portfolioResult);

        return portfolioResult;
    }

    private Humidifier.ServiceCatalog.Portfolio CreatePortfolio()
    {
        var portfolioResult = new Humidifier.ServiceCatalog.Portfolio
        {
            GivenName = InputResourceName,
        };

        return portfolioResult;
    }

} // End Of Class

public static class PortfolioFactoryExtensions
{
}
