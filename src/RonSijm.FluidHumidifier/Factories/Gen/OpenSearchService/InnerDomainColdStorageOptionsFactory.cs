// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerDomainColdStorageOptionsFactory(Action<Humidifier.OpenSearchService.DomainTypes.ColdStorageOptions> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.DomainTypes.ColdStorageOptions>
{

    protected override Humidifier.OpenSearchService.DomainTypes.ColdStorageOptions Create()
    {
        var coldStorageOptionsResult = CreateColdStorageOptions();
        factoryAction?.Invoke(coldStorageOptionsResult);

        return coldStorageOptionsResult;
    }

    private Humidifier.OpenSearchService.DomainTypes.ColdStorageOptions CreateColdStorageOptions()
    {
        var coldStorageOptionsResult = new Humidifier.OpenSearchService.DomainTypes.ColdStorageOptions();

        return coldStorageOptionsResult;
    }

} // End Of Class

public static class InnerDomainColdStorageOptionsFactoryExtensions
{
}
