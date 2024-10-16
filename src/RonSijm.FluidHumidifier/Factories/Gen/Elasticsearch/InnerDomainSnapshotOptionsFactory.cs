// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Elasticsearch;

public class InnerDomainSnapshotOptionsFactory(Action<Humidifier.Elasticsearch.DomainTypes.SnapshotOptions> factoryAction = null) : SubResourceFactory<Humidifier.Elasticsearch.DomainTypes.SnapshotOptions>
{

    protected override Humidifier.Elasticsearch.DomainTypes.SnapshotOptions Create()
    {
        var snapshotOptionsResult = CreateSnapshotOptions();
        factoryAction?.Invoke(snapshotOptionsResult);

        return snapshotOptionsResult;
    }

    private Humidifier.Elasticsearch.DomainTypes.SnapshotOptions CreateSnapshotOptions()
    {
        var snapshotOptionsResult = new Humidifier.Elasticsearch.DomainTypes.SnapshotOptions();

        return snapshotOptionsResult;
    }

} // End Of Class

public static class InnerDomainSnapshotOptionsFactoryExtensions
{
}
