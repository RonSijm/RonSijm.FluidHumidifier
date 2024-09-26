// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Elasticsearch;

public class InnerDomainEBSOptionsFactory(Action<Humidifier.Elasticsearch.DomainTypes.EBSOptions> factoryAction = null) : SubResourceFactory<Humidifier.Elasticsearch.DomainTypes.EBSOptions>
{

    protected override Humidifier.Elasticsearch.DomainTypes.EBSOptions Create()
    {
        var eBSOptionsResult = CreateEBSOptions();
        factoryAction?.Invoke(eBSOptionsResult);

        return eBSOptionsResult;
    }

    private Humidifier.Elasticsearch.DomainTypes.EBSOptions CreateEBSOptions()
    {
        var eBSOptionsResult = new Humidifier.Elasticsearch.DomainTypes.EBSOptions();

        return eBSOptionsResult;
    }

} // End Of Class

public static class InnerDomainEBSOptionsFactoryExtensions
{
}
