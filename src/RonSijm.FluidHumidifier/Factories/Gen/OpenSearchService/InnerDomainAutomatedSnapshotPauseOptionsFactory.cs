// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerDomainAutomatedSnapshotPauseOptionsFactory(Action<Humidifier.OpenSearchService.DomainTypes.AutomatedSnapshotPauseOptions> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.DomainTypes.AutomatedSnapshotPauseOptions>
{

    protected override Humidifier.OpenSearchService.DomainTypes.AutomatedSnapshotPauseOptions Create()
    {
        var automatedSnapshotPauseOptionsResult = CreateAutomatedSnapshotPauseOptions();
        factoryAction?.Invoke(automatedSnapshotPauseOptionsResult);

        return automatedSnapshotPauseOptionsResult;
    }

    private Humidifier.OpenSearchService.DomainTypes.AutomatedSnapshotPauseOptions CreateAutomatedSnapshotPauseOptions()
    {
        var automatedSnapshotPauseOptionsResult = new Humidifier.OpenSearchService.DomainTypes.AutomatedSnapshotPauseOptions();

        return automatedSnapshotPauseOptionsResult;
    }

} // End Of Class

public static class InnerDomainAutomatedSnapshotPauseOptionsFactoryExtensions
{
}
