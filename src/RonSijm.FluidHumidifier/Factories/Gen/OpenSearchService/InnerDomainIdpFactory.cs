// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerDomainIdpFactory(Action<Humidifier.OpenSearchService.DomainTypes.Idp> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.DomainTypes.Idp>
{

    protected override Humidifier.OpenSearchService.DomainTypes.Idp Create()
    {
        var idpResult = CreateIdp();
        factoryAction?.Invoke(idpResult);

        return idpResult;
    }

    private Humidifier.OpenSearchService.DomainTypes.Idp CreateIdp()
    {
        var idpResult = new Humidifier.OpenSearchService.DomainTypes.Idp();

        return idpResult;
    }

} // End Of Class

public static class InnerDomainIdpFactoryExtensions
{
}
