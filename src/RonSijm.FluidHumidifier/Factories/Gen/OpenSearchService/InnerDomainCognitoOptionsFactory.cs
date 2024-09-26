// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerDomainCognitoOptionsFactory(Action<Humidifier.OpenSearchService.DomainTypes.CognitoOptions> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.DomainTypes.CognitoOptions>
{

    protected override Humidifier.OpenSearchService.DomainTypes.CognitoOptions Create()
    {
        var cognitoOptionsResult = CreateCognitoOptions();
        factoryAction?.Invoke(cognitoOptionsResult);

        return cognitoOptionsResult;
    }

    private Humidifier.OpenSearchService.DomainTypes.CognitoOptions CreateCognitoOptions()
    {
        var cognitoOptionsResult = new Humidifier.OpenSearchService.DomainTypes.CognitoOptions();

        return cognitoOptionsResult;
    }

} // End Of Class

public static class InnerDomainCognitoOptionsFactoryExtensions
{
}
