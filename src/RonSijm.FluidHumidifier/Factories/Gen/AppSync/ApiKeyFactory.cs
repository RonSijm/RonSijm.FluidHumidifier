// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class ApiKeyFactory(string resourceName = null, Action<Humidifier.AppSync.ApiKey> factoryAction = null) : ResourceFactory<Humidifier.AppSync.ApiKey>(resourceName)
{

    protected override Humidifier.AppSync.ApiKey Create()
    {
        var apiKeyResult = CreateApiKey();
        factoryAction?.Invoke(apiKeyResult);

        return apiKeyResult;
    }

    private Humidifier.AppSync.ApiKey CreateApiKey()
    {
        var apiKeyResult = new Humidifier.AppSync.ApiKey
        {
            GivenName = InputResourceName,
        };

        return apiKeyResult;
    }

} // End Of Class

public static class ApiKeyFactoryExtensions
{
}
