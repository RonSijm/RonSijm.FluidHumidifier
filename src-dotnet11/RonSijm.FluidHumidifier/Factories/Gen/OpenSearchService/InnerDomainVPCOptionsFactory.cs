// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerDomainVPCOptionsFactory(Action<Humidifier.OpenSearchService.DomainTypes.VPCOptions> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.DomainTypes.VPCOptions>
{

    protected override Humidifier.OpenSearchService.DomainTypes.VPCOptions Create()
    {
        var vPCOptionsResult = CreateVPCOptions();
        factoryAction?.Invoke(vPCOptionsResult);

        return vPCOptionsResult;
    }

    private Humidifier.OpenSearchService.DomainTypes.VPCOptions CreateVPCOptions()
    {
        var vPCOptionsResult = new Humidifier.OpenSearchService.DomainTypes.VPCOptions();

        return vPCOptionsResult;
    }

} // End Of Class

public static class InnerDomainVPCOptionsFactoryExtensions
{
}
