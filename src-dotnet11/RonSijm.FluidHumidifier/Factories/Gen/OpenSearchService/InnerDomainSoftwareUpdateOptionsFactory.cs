// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerDomainSoftwareUpdateOptionsFactory(Action<Humidifier.OpenSearchService.DomainTypes.SoftwareUpdateOptions> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.DomainTypes.SoftwareUpdateOptions>
{

    protected override Humidifier.OpenSearchService.DomainTypes.SoftwareUpdateOptions Create()
    {
        var softwareUpdateOptionsResult = CreateSoftwareUpdateOptions();
        factoryAction?.Invoke(softwareUpdateOptionsResult);

        return softwareUpdateOptionsResult;
    }

    private Humidifier.OpenSearchService.DomainTypes.SoftwareUpdateOptions CreateSoftwareUpdateOptions()
    {
        var softwareUpdateOptionsResult = new Humidifier.OpenSearchService.DomainTypes.SoftwareUpdateOptions();

        return softwareUpdateOptionsResult;
    }

} // End Of Class

public static class InnerDomainSoftwareUpdateOptionsFactoryExtensions
{
}
