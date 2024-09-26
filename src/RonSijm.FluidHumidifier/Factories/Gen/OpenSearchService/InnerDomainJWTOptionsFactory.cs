// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerDomainJWTOptionsFactory(Action<Humidifier.OpenSearchService.DomainTypes.JWTOptions> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.DomainTypes.JWTOptions>
{

    protected override Humidifier.OpenSearchService.DomainTypes.JWTOptions Create()
    {
        var jWTOptionsResult = CreateJWTOptions();
        factoryAction?.Invoke(jWTOptionsResult);

        return jWTOptionsResult;
    }

    private Humidifier.OpenSearchService.DomainTypes.JWTOptions CreateJWTOptions()
    {
        var jWTOptionsResult = new Humidifier.OpenSearchService.DomainTypes.JWTOptions();

        return jWTOptionsResult;
    }

} // End Of Class

public static class InnerDomainJWTOptionsFactoryExtensions
{
}
