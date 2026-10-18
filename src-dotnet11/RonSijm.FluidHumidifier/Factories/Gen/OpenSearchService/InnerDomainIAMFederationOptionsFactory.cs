// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerDomainIAMFederationOptionsFactory(Action<Humidifier.OpenSearchService.DomainTypes.IAMFederationOptions> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.DomainTypes.IAMFederationOptions>
{

    protected override Humidifier.OpenSearchService.DomainTypes.IAMFederationOptions Create()
    {
        var iAMFederationOptionsResult = CreateIAMFederationOptions();
        factoryAction?.Invoke(iAMFederationOptionsResult);

        return iAMFederationOptionsResult;
    }

    private Humidifier.OpenSearchService.DomainTypes.IAMFederationOptions CreateIAMFederationOptions()
    {
        var iAMFederationOptionsResult = new Humidifier.OpenSearchService.DomainTypes.IAMFederationOptions();

        return iAMFederationOptionsResult;
    }

} // End Of Class

public static class InnerDomainIAMFederationOptionsFactoryExtensions
{
}
