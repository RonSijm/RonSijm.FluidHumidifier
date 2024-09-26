// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Elasticsearch;

public class InnerDomainVPCOptionsFactory(Action<Humidifier.Elasticsearch.DomainTypes.VPCOptions> factoryAction = null) : SubResourceFactory<Humidifier.Elasticsearch.DomainTypes.VPCOptions>
{

    protected override Humidifier.Elasticsearch.DomainTypes.VPCOptions Create()
    {
        var vPCOptionsResult = CreateVPCOptions();
        factoryAction?.Invoke(vPCOptionsResult);

        return vPCOptionsResult;
    }

    private Humidifier.Elasticsearch.DomainTypes.VPCOptions CreateVPCOptions()
    {
        var vPCOptionsResult = new Humidifier.Elasticsearch.DomainTypes.VPCOptions();

        return vPCOptionsResult;
    }

} // End Of Class

public static class InnerDomainVPCOptionsFactoryExtensions
{
}
