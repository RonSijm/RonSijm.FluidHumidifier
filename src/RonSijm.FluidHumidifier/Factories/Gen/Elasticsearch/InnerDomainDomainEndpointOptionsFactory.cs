// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Elasticsearch;

public class InnerDomainDomainEndpointOptionsFactory(Action<Humidifier.Elasticsearch.DomainTypes.DomainEndpointOptions> factoryAction = null) : SubResourceFactory<Humidifier.Elasticsearch.DomainTypes.DomainEndpointOptions>
{

    protected override Humidifier.Elasticsearch.DomainTypes.DomainEndpointOptions Create()
    {
        var domainEndpointOptionsResult = CreateDomainEndpointOptions();
        factoryAction?.Invoke(domainEndpointOptionsResult);

        return domainEndpointOptionsResult;
    }

    private Humidifier.Elasticsearch.DomainTypes.DomainEndpointOptions CreateDomainEndpointOptions()
    {
        var domainEndpointOptionsResult = new Humidifier.Elasticsearch.DomainTypes.DomainEndpointOptions();

        return domainEndpointOptionsResult;
    }

} // End Of Class

public static class InnerDomainDomainEndpointOptionsFactoryExtensions
{
}
