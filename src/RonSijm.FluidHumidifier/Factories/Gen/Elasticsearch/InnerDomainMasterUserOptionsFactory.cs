// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Elasticsearch;

public class InnerDomainMasterUserOptionsFactory(Action<Humidifier.Elasticsearch.DomainTypes.MasterUserOptions> factoryAction = null) : SubResourceFactory<Humidifier.Elasticsearch.DomainTypes.MasterUserOptions>
{

    protected override Humidifier.Elasticsearch.DomainTypes.MasterUserOptions Create()
    {
        var masterUserOptionsResult = CreateMasterUserOptions();
        factoryAction?.Invoke(masterUserOptionsResult);

        return masterUserOptionsResult;
    }

    private Humidifier.Elasticsearch.DomainTypes.MasterUserOptions CreateMasterUserOptions()
    {
        var masterUserOptionsResult = new Humidifier.Elasticsearch.DomainTypes.MasterUserOptions();

        return masterUserOptionsResult;
    }

} // End Of Class

public static class InnerDomainMasterUserOptionsFactoryExtensions
{
}
