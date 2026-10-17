// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerDomainIdentityCenterOptionsFactory(Action<Humidifier.OpenSearchService.DomainTypes.IdentityCenterOptions> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.DomainTypes.IdentityCenterOptions>
{

    protected override Humidifier.OpenSearchService.DomainTypes.IdentityCenterOptions Create()
    {
        var identityCenterOptionsResult = CreateIdentityCenterOptions();
        factoryAction?.Invoke(identityCenterOptionsResult);

        return identityCenterOptionsResult;
    }

    private Humidifier.OpenSearchService.DomainTypes.IdentityCenterOptions CreateIdentityCenterOptions()
    {
        var identityCenterOptionsResult = new Humidifier.OpenSearchService.DomainTypes.IdentityCenterOptions();

        return identityCenterOptionsResult;
    }

} // End Of Class

public static class InnerDomainIdentityCenterOptionsFactoryExtensions
{
}
