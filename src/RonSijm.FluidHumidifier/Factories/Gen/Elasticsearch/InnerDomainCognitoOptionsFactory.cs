// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Elasticsearch;

public class InnerDomainCognitoOptionsFactory(Action<Humidifier.Elasticsearch.DomainTypes.CognitoOptions> factoryAction = null) : SubResourceFactory<Humidifier.Elasticsearch.DomainTypes.CognitoOptions>
{

    protected override Humidifier.Elasticsearch.DomainTypes.CognitoOptions Create()
    {
        var cognitoOptionsResult = CreateCognitoOptions();
        factoryAction?.Invoke(cognitoOptionsResult);

        return cognitoOptionsResult;
    }

    private Humidifier.Elasticsearch.DomainTypes.CognitoOptions CreateCognitoOptions()
    {
        var cognitoOptionsResult = new Humidifier.Elasticsearch.DomainTypes.CognitoOptions();

        return cognitoOptionsResult;
    }

} // End Of Class

public static class InnerDomainCognitoOptionsFactoryExtensions
{
}
