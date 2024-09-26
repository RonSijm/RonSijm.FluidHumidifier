// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerDomainMasterUserOptionsFactory(Action<Humidifier.OpenSearchService.DomainTypes.MasterUserOptions> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.DomainTypes.MasterUserOptions>
{

    protected override Humidifier.OpenSearchService.DomainTypes.MasterUserOptions Create()
    {
        var masterUserOptionsResult = CreateMasterUserOptions();
        factoryAction?.Invoke(masterUserOptionsResult);

        return masterUserOptionsResult;
    }

    private Humidifier.OpenSearchService.DomainTypes.MasterUserOptions CreateMasterUserOptions()
    {
        var masterUserOptionsResult = new Humidifier.OpenSearchService.DomainTypes.MasterUserOptions();

        return masterUserOptionsResult;
    }

} // End Of Class

public static class InnerDomainMasterUserOptionsFactoryExtensions
{
}
