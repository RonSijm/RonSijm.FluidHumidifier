// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerDomainDomainEndpointOptionsFactory(Action<Humidifier.OpenSearchService.DomainTypes.DomainEndpointOptions> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.DomainTypes.DomainEndpointOptions>
{

    protected override Humidifier.OpenSearchService.DomainTypes.DomainEndpointOptions Create()
    {
        var domainEndpointOptionsResult = CreateDomainEndpointOptions();
        factoryAction?.Invoke(domainEndpointOptionsResult);

        return domainEndpointOptionsResult;
    }

    private Humidifier.OpenSearchService.DomainTypes.DomainEndpointOptions CreateDomainEndpointOptions()
    {
        var domainEndpointOptionsResult = new Humidifier.OpenSearchService.DomainTypes.DomainEndpointOptions();

        return domainEndpointOptionsResult;
    }

} // End Of Class

public static class InnerDomainDomainEndpointOptionsFactoryExtensions
{
}
