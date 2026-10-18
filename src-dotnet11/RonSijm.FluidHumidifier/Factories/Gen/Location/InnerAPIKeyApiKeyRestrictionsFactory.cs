// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Location;

public class InnerAPIKeyApiKeyRestrictionsFactory(Action<Humidifier.Location.APIKeyTypes.ApiKeyRestrictions> factoryAction = null) : SubResourceFactory<Humidifier.Location.APIKeyTypes.ApiKeyRestrictions>
{

    protected override Humidifier.Location.APIKeyTypes.ApiKeyRestrictions Create()
    {
        var apiKeyRestrictionsResult = CreateApiKeyRestrictions();
        factoryAction?.Invoke(apiKeyRestrictionsResult);

        return apiKeyRestrictionsResult;
    }

    private Humidifier.Location.APIKeyTypes.ApiKeyRestrictions CreateApiKeyRestrictions()
    {
        var apiKeyRestrictionsResult = new Humidifier.Location.APIKeyTypes.ApiKeyRestrictions();

        return apiKeyRestrictionsResult;
    }

} // End Of Class

public static class InnerAPIKeyApiKeyRestrictionsFactoryExtensions
{
}
