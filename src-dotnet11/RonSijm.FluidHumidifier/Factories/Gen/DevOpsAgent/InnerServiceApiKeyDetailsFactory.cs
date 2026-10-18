// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerServiceApiKeyDetailsFactory(Action<Humidifier.DevOpsAgent.ServiceTypes.ApiKeyDetails> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.ServiceTypes.ApiKeyDetails>
{

    protected override Humidifier.DevOpsAgent.ServiceTypes.ApiKeyDetails Create()
    {
        var apiKeyDetailsResult = CreateApiKeyDetails();
        factoryAction?.Invoke(apiKeyDetailsResult);

        return apiKeyDetailsResult;
    }

    private Humidifier.DevOpsAgent.ServiceTypes.ApiKeyDetails CreateApiKeyDetails()
    {
        var apiKeyDetailsResult = new Humidifier.DevOpsAgent.ServiceTypes.ApiKeyDetails();

        return apiKeyDetailsResult;
    }

} // End Of Class

public static class InnerServiceApiKeyDetailsFactoryExtensions
{
}
