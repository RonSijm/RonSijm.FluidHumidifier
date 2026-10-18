// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerDomainEBSOptionsFactory(Action<Humidifier.OpenSearchService.DomainTypes.EBSOptions> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.DomainTypes.EBSOptions>
{

    protected override Humidifier.OpenSearchService.DomainTypes.EBSOptions Create()
    {
        var eBSOptionsResult = CreateEBSOptions();
        factoryAction?.Invoke(eBSOptionsResult);

        return eBSOptionsResult;
    }

    private Humidifier.OpenSearchService.DomainTypes.EBSOptions CreateEBSOptions()
    {
        var eBSOptionsResult = new Humidifier.OpenSearchService.DomainTypes.EBSOptions();

        return eBSOptionsResult;
    }

} // End Of Class

public static class InnerDomainEBSOptionsFactoryExtensions
{
}
