// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerDomainSnapshotOptionsFactory(Action<Humidifier.OpenSearchService.DomainTypes.SnapshotOptions> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.DomainTypes.SnapshotOptions>
{

    protected override Humidifier.OpenSearchService.DomainTypes.SnapshotOptions Create()
    {
        var snapshotOptionsResult = CreateSnapshotOptions();
        factoryAction?.Invoke(snapshotOptionsResult);

        return snapshotOptionsResult;
    }

    private Humidifier.OpenSearchService.DomainTypes.SnapshotOptions CreateSnapshotOptions()
    {
        var snapshotOptionsResult = new Humidifier.OpenSearchService.DomainTypes.SnapshotOptions();

        return snapshotOptionsResult;
    }

} // End Of Class

public static class InnerDomainSnapshotOptionsFactoryExtensions
{
}
