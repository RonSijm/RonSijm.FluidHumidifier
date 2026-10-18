// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerConnectionApiKeyAuthParametersFactory(Action<Humidifier.Events.ConnectionTypes.ApiKeyAuthParameters> factoryAction = null) : SubResourceFactory<Humidifier.Events.ConnectionTypes.ApiKeyAuthParameters>
{

    protected override Humidifier.Events.ConnectionTypes.ApiKeyAuthParameters Create()
    {
        var apiKeyAuthParametersResult = CreateApiKeyAuthParameters();
        factoryAction?.Invoke(apiKeyAuthParametersResult);

        return apiKeyAuthParametersResult;
    }

    private Humidifier.Events.ConnectionTypes.ApiKeyAuthParameters CreateApiKeyAuthParameters()
    {
        var apiKeyAuthParametersResult = new Humidifier.Events.ConnectionTypes.ApiKeyAuthParameters();

        return apiKeyAuthParametersResult;
    }

} // End Of Class

public static class InnerConnectionApiKeyAuthParametersFactoryExtensions
{
}
