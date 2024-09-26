// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalog;

public class AcceptedPortfolioShareFactory(string resourceName = null, Action<Humidifier.ServiceCatalog.AcceptedPortfolioShare> factoryAction = null) : ResourceFactory<Humidifier.ServiceCatalog.AcceptedPortfolioShare>(resourceName)
{

    protected override Humidifier.ServiceCatalog.AcceptedPortfolioShare Create()
    {
        var acceptedPortfolioShareResult = CreateAcceptedPortfolioShare();
        factoryAction?.Invoke(acceptedPortfolioShareResult);

        return acceptedPortfolioShareResult;
    }

    private Humidifier.ServiceCatalog.AcceptedPortfolioShare CreateAcceptedPortfolioShare()
    {
        var acceptedPortfolioShareResult = new Humidifier.ServiceCatalog.AcceptedPortfolioShare
        {
            GivenName = InputResourceName,
        };

        return acceptedPortfolioShareResult;
    }

} // End Of Class

public static class AcceptedPortfolioShareFactoryExtensions
{
}
