// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Elasticsearch;

public class InnerDomainColdStorageOptionsFactory(Action<Humidifier.Elasticsearch.DomainTypes.ColdStorageOptions> factoryAction = null) : SubResourceFactory<Humidifier.Elasticsearch.DomainTypes.ColdStorageOptions>
{

    protected override Humidifier.Elasticsearch.DomainTypes.ColdStorageOptions Create()
    {
        var coldStorageOptionsResult = CreateColdStorageOptions();
        factoryAction?.Invoke(coldStorageOptionsResult);

        return coldStorageOptionsResult;
    }

    private Humidifier.Elasticsearch.DomainTypes.ColdStorageOptions CreateColdStorageOptions()
    {
        var coldStorageOptionsResult = new Humidifier.Elasticsearch.DomainTypes.ColdStorageOptions();

        return coldStorageOptionsResult;
    }

} // End Of Class

public static class InnerDomainColdStorageOptionsFactoryExtensions
{
}
